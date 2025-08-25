using ecommerce_app.Services;
using ecommerce_app.DTOs.Account;
using ecommerce_app.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ecommerce_app.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Google.Apis.Auth;


namespace ecommerce_app.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenService;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IEmailService _emailService;

        public AccountController(UserManager<AppUser> userManager, ITokenService tokenService, SignInManager<AppUser> signInManager, IEmailService emailService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _signInManager = signInManager;
            _emailService = emailService;
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userManager.Users
                .FirstOrDefaultAsync(u => u.Email.ToLower() == loginDto.Email.ToLower());

            if (user == null)
            {
                return Unauthorized(new { message = "Geçersiz e-posta veya parola." });
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

            if (!result.Succeeded)
            {
                return Unauthorized(new { message = "Geçersiz e-posta veya parola." });
            }

            var userDto = new NewUserDto
            {
                UserId = user.Id,
                UserName = user.UserName ?? user.Email!,
                Email = user.Email!,
                FullName = $"{user.Name} {user.Surname}",
                Token = _tokenService.CreateToken(user)
            };

            return Ok(userDto);
        }

        [Authorize]
        [HttpGet("validate")]
        public IActionResult ValidateToken()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;


            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { message = "Geçersiz token." });
            }

            return Ok(new
            {
                message = "Token geçerli",
                userId = userId
            });
        }


        [HttpGet("google-login")]
        public IActionResult GoogleLogin()
        {
            var redirectUrl = Url.Action("GoogleResponse", "Account");
            var properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return Challenge(properties, "Google");
        }

        [HttpGet("google-response")]
        public async Task<IActionResult> GoogleResponse()
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                return Redirect("/login-failed");

            var signInResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false);
            AppUser user;

            if (!signInResult.Succeeded)
            {

                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                user = new AppUser
                {
                    UserName = email,
                    Email = email
                };

                var result = await _userManager.CreateAsync(user);
                if (!result.Succeeded)
                    return BadRequest(result.Errors);

                await _userManager.AddLoginAsync(user, info);
                await _userManager.AddToRoleAsync(user, "User");
            }
            else
            {
                user = await _userManager.FindByLoginAsync(info.LoginProvider, info.ProviderKey);
            }


            return Ok(new NewUserDto
            {
                UserId = user.Id,
                UserName = user.UserName ?? user.Email!,
                Email = user.Email!,
                FullName = $"{user.Name} {user.Surname}",
                Token = _tokenService.CreateToken(user)
            });
        }

        [HttpPost("google-token-login")]
        public async Task<IActionResult> GoogleTokenLogin([FromBody] GoogleTokenDto tokenDto)
        {
            var payload = await GoogleJsonWebSignature.ValidateAsync(tokenDto.IdToken);

            var user = await _userManager.FindByEmailAsync(payload.Email);
            if (user == null)
            {
                user = new AppUser
                {
                    Email = payload.Email,
                    UserName = payload.Email
                };
                var result = await _userManager.CreateAsync(user);
                if (!result.Succeeded)
                    return BadRequest(result.Errors);
                await _userManager.AddToRoleAsync(user, "User");
            }

            return Ok(new NewUserDto
            {
                UserId = user.Id,
                UserName = user.UserName ?? user.Email!,
                Email = user.Email!,
                FullName = $"{user.Name} {user.Surname}",
                Token = _tokenService.CreateToken(user)
            });
        }





        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var appUser = new AppUser
                {
                    UserName = registerDto.Email,
                    Email = registerDto.Email,
                    Name = registerDto.Name,
                    Surname = registerDto.Surname,
                    PhoneNumber = registerDto.Phone
                };

                var createUser = await _userManager.CreateAsync(appUser, registerDto.Password);

                if (createUser.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(appUser, "User");

                    if (roleResult.Succeeded)
                    {
                        return Ok(new NewUserDto
                        {
                            UserName = appUser.UserName,
                            Email = appUser.Email,
                            Token = _tokenService.CreateToken(appUser)
                        });
                    }
                    else
                    {

                        var roleErrors = roleResult.Errors.Select(e => e.Description).ToList();
                        return StatusCode(500, new { errors = roleErrors });
                    }
                }
                else
                {

                    var createErrors = createUser.Errors.Select(e => e.Description).ToList();
                    return BadRequest(new { errors = createErrors });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { errors = new List<string> { ex.Message } });
            }
        }


        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                // Güvenlik amacıyla kullanıcı varmış gibi davranılır
                return Ok(new { message = "Eğer bu e-posta bir kullanıcıya aitse, şifre sıfırlama bağlantısı gönderildi." });
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            try
            {

                var encodedToken = System.Web.HttpUtility.UrlEncode(token);
                var encodedEmail = System.Web.HttpUtility.UrlEncode(user.Email);

                // Tarayıcıda açılacak HTTPS link (uygulamaya yönlendiren bir sayfa olacak)
                var redirectLink = $"http://localhost:4200/api/account/redirect/reset-password?email={encodedEmail}&token={encodedToken}";

                string subject = "Şifre Sıfırlama Bağlantısı";
                string body = $@"
            <h2>Şifre Sıfırlama</h2>
            <p>Şifrenizi sıfırlamak için aşağıdaki bağlantıya tıklayın:</p>
            <p><a href='{redirectLink}'>Şifreyi Sıfırla</a></p>
            <p>Bu bağlantı sınırlı bir süre için geçerlidir.</p>
        ";

                await _emailService.SendEmailAsync(user.Email, subject, body);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Mail gönderilemedi",
                    error = ex.Message,
                    stackTrace = ex.StackTrace
                });
            }

            return Ok(new { message = "Şifre sıfırlama bağlantısı gönderildi.", email = user.Email, token = token });
        }


        [HttpGet("redirect/reset-password")]
        public IActionResult RedirectToApp([FromQuery] string email, [FromQuery] string token)
        {
            var deepLink = $"myapp://reset-password?email={email}&token={token}";
            var html = $@"
        <html>
        <head>
            <meta http-equiv='refresh' content='0;url={deepLink}' />
        </head>
        <body>
            <p>Yönlendiriliyorsunuz...</p>
            <a href='{deepLink}'>Eğer otomatik yönlendirme olmazsa buraya tıklayın.</a>
        </body>
        </html>
    ";

            return Content(html, "text/html");
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return BadRequest(new { message = "Kullanıcı bulunamadı." });

            var decodedToken = System.Web.HttpUtility.UrlDecode(model.Token);
            var result = await _userManager.ResetPasswordAsync(user, decodedToken, model.NewPassword);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok(new { message = "Şifre başarıyla sıfırlandı." });
        }

        [Authorize]
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return Unauthorized(new { message = "Kullanıcı bulunamadı." });

            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description).ToList();

                if (errors.Any(e => e.Contains("incorrect", StringComparison.OrdinalIgnoreCase)))
                {
                    return BadRequest(new { message = "Eski şifre yanlış." });
                }

                return BadRequest(new { errors });
            }

            return Ok(new { message = "Şifreniz başarıyla güncellendi." });
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("change-password-by-id")]
        public async Task<IActionResult> ChangePasswordById([FromBody] AdminChangePasswordDto model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
                return NotFound(new { message = "Kullanıcı bulunamadı." });

            var removeResult = await _userManager.RemovePasswordAsync(user);
            if (!removeResult.Succeeded)
            {
                var errors = removeResult.Errors.Select(e => e.Description).ToList();
                return BadRequest(new { message = "Mevcut şifre silinemedi.", errors });
            }

            var addResult = await _userManager.AddPasswordAsync(user, model.NewPassword);
            if (!addResult.Succeeded)
            {
                var errors = addResult.Errors.Select(e => e.Description).ToList();
                return BadRequest(new { message = "Yeni şifre eklenemedi.", errors });
            }

            return Ok(new { message = "Şifre başarıyla değiştirildi." });
        }


        [Authorize]
        [HttpGet("me")]
        public async Task<IActionResult> GetCurrentUser()
        {
            var email = User.FindFirstValue(ClaimTypes.Email);

            if (email == null)
                return Unauthorized(new { message = "Geçersiz token." });

            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
                return NotFound(new { message = "Kullanıcı bulunamadı." });


            var userDto = new NewUserDto
            {
                UserId = user.Id,
                UserName = user.UserName ?? user.Email!,
                Email = user.Email!,
                FullName = $"{user.Name} {user.Surname}"
            };

            return Ok(userDto);
        }

        [Authorize]
        [HttpGet("myInformation")]
        public async Task<IActionResult> GetUserInformation()
        {
            var email = User.FindFirstValue(ClaimTypes.Email);

            if (email == null)
                return Unauthorized(new { message = "Geçersiz token." });

            var user = await _userManager.Users.Where(e => e.Email == email).FirstOrDefaultAsync();


            if (user == null)
                return NotFound(new { message = "Kullanıcı bulunamadı." });


            var userDto = new MyInformationDto
            {
                Name = user.Name,
                Surname = user.Surname,
                Phone = user.PhoneNumber ?? "",
                Email = user.Email

            };

            return Ok(userDto);
        }

        [Authorize]
        [HttpPut("myInformation")]
        public async Task<IActionResult> ChangeMyInformation([FromBody] ChangeMyInformationDto model)
        {
            var email = User.FindFirstValue(ClaimTypes.Email);

            if (string.IsNullOrEmpty(email))
                return Unauthorized(new { message = "Geçersiz token." });

            var user = await _userManager.Users
                .Where(e => e.Email == email)
                .FirstOrDefaultAsync();

            if (user == null)
                return NotFound(new { message = "Kullanıcı bulunamadı." });

            user.Name = model.Name;
            user.Surname = model.Surname;
            user.PhoneNumber = model.PhoneNumber;

            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
                return BadRequest(new { message = "Bilgiler güncellenemedi.", errors = result.Errors });

            return Ok(new { message = "Bilgiler başarıyla güncellendi." });
        }

    }







}