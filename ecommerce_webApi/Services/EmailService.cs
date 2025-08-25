using System.Net;
using System.Net.Mail;
using ecommerce_app.Interfaces;

public class EmailService : IEmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SendEmailAsync(string toEmail, string subject, string body)
    {
        var smtpServer = _configuration["EmailSettings:SmtpServer"];
        var port = int.Parse(_configuration["EmailSettings:Port"]);
        var fromEmail = _configuration["EmailSettings:SenderEmail"];
        var password = _configuration["EmailSettings:SenderPassword"];

        var client = new SmtpClient(smtpServer)
        {
            Port = port,
            Credentials = new NetworkCredential(fromEmail, password),
            EnableSsl = true
        };

        var message = new MailMessage(fromEmail, toEmail, subject, body)
        {
            IsBodyHtml = true
        };

        await client.SendMailAsync(message);
    }
}