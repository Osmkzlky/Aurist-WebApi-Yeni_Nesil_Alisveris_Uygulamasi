
using ecommerce_app.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ecommerce_app.Models;

namespace ecommerce_app.Data;


public class DataContext : IdentityDbContext<AppUser>
{
  public DataContext(DbContextOptions<DataContext> options) : base(options) { }
  public DbSet<Product> Products { get; set; }
  public DbSet<Category> Categories { get; set; }
  public DbSet<Slider> Sliders { get; set; }
  public DbSet<ProductImage> ProductImages { get; set; }
  public DbSet<ProductColor> ProductColors { get; set; }
  public DbSet<Review> Reviews { get; set; }
  public DbSet<Order> Orders { get; set; }
  public DbSet<Address> Addresses { get; set; }
  public DbSet<CartItem> CartItems { get; set; }
  public DbSet<Promo> Promos { get; set; }



  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    List<IdentityRole> roles = new List<IdentityRole>
    {
      new IdentityRole {
        Name = "Admin",
        NormalizedName = "ADMIN"
      },
      new IdentityRole {
        Name = "User",
        NormalizedName = "USER"
      }
    };
    modelBuilder.Entity<IdentityRole>().HasData(roles);

    modelBuilder.Entity<Promo>().HasData(new List<Promo>
    {
      new Promo {
        Id = 1,
        PromoImage = "https://ik.imagekit.io/osdata/Promo1.png?updatedAt=1755362698992",
        PromoTitle = "%10 İndirim",
        PromoDescription = "agustos10",
        PromoExpirationDate = DateTime.Parse("2025-08-20 16:04:08.950101"),
        PromoProcess = "% 10"
      },
      new Promo {
        Id = 2,
        PromoImage = "https://ik.imagekit.io/osdata/Promo3.png?updatedAt=1755362698992",
        PromoTitle = "Efsane Yaz İndirimi",
        PromoDescription = "efsaneindirim15",
        PromoExpirationDate = DateTime.Parse("2025-08-30 16:04:08.950101"),
        PromoProcess = "% 15"
      },
      new Promo {
        Id = 3,
        PromoImage = "https://ik.imagekit.io/osdata/Promo4.png?updatedAt=1755362698992",
        PromoTitle = "Sezon İndirimi",
        PromoDescription = "sezonindirim22",
       PromoExpirationDate = DateTime.Parse("2025-08-22 16:04:08.950101"),
        PromoProcess = "% 22"
      },
      new Promo {
        Id = 4,
        PromoImage = "https://ik.imagekit.io/osdata/Promo2.png?updatedAt=1755362698992",
        PromoTitle = "%15 İndirim",
        PromoDescription = "agustos15",
        PromoExpirationDate = DateTime.Parse("2025-08-27 16:04:08.950101"),
        PromoProcess = "% 15"

      }
    });

    modelBuilder.Entity<Slider>().HasData(new List<Slider>
        {
             new Slider
    {
        Id = 1,
        slider_image = "https://ik.imagekit.io/osdata/clothes/slider_1.png?updatedAt=1753124783871",
        slider_detail = "Slider 1 Açıklama",
        slider_index = 0,
        slider_isActive = true,
        slider_title = "Başlık"
    },
           new Slider
    {
        Id = 2,
        slider_image = "https://ik.imagekit.io/osdata/clothes/slider_2.png?updatedAt=1753124784575",
        slider_detail = "Slider 2 Açıklama",
        slider_index = 1,
        slider_isActive = true,
        slider_title = "Başlık"
    },
    new Slider
    {
        Id = 3,
        slider_image = "https://ik.imagekit.io/osdata/clothes/slider_3.png?updatedAt=1753124785298",
        slider_detail = "Slider 3 Açıklama",
        slider_index = 2,
        slider_isActive = true,
        slider_title = "Başlık"
    }

        });


    modelBuilder.Entity<Category>().HasData(
       new List<Category>
       {
        new Category ()
        { Id=1,category_name="Tümünü Gör",category_url="view-all",category_image="https://ik.imagekit.io/osdata/clothes/womenList.heic?updatedAt=1755084524577",category_isHome=true,category_kind="Women",category_campaign="Mega İndirim Günleri!",category_campaignColor="FFD700"},

        new Category ()
        {Id=2,category_name="Tişört/Bluz",category_url="tshirt-blouses",category_image="https://ik.imagekit.io/osdata/clothes/Women/bluz1_on_jack&jones.heic?updatedAt=1753264404211",category_isHome=true,category_kind="Women"},

         new Category ()
        { Id=3,category_name="Elbiseler",category_url="dresses",category_image="https://ik.imagekit.io/osdata/clothes/Women/elbise1_on_jack&jones.heic?updatedAt=1753264410116",category_isHome=true,category_kind="Women"},

         new Category ()
        { Id=4,category_name="Gömlekler",category_url="shirts",category_image="https://ik.imagekit.io/osdata/clothes/Women/gomlek1_on_jack&jones.heic?updatedAt=1753264400669",category_isHome=true,category_kind="Women"},

        new Category ()
        { Id=5,category_name="Etekler",category_url="skirts",category_image="https://ik.imagekit.io/osdata/clothes/Women/etek1_on_jack&jones.heic?updatedAt=1753267522055",category_isHome=true,category_kind="Women"},

         new Category ()
       { Id=6,category_name="Pantolon",category_url="trousers",category_image="https://ik.imagekit.io/osdata/clothes/Women/pantolon1_on_jack&jones.heic?updatedAt=1753264378490",category_isHome=true,category_kind="Women"},

         new Category ()
        { Id=7,category_name="Şortlar",category_url="shorts",category_image="https://ik.imagekit.io/osdata/clothes/Women/sort1_on_jack&jones.heic?updatedAt=1753264384700",category_isHome=true,category_kind="Women"},

        new Category ()
        { Id=8,category_name="Jeans",category_url="jeans",category_image="https://ik.imagekit.io/osdata/clothes/Women/jean1_on_jack&jones.heic?updatedAt=1753264387431",category_isHome=true,category_kind="Women"},

        new Category ()
        { Id=9,category_name="Sweatshirts",category_url="sweatshirts",category_image="https://ik.imagekit.io/osdata/clothes/Women/sweatshirt1_on_jack&jones.heic?updatedAt=1753264382676",category_isHome=true,category_kind="Women"},

        new Category ()
        { Id=10,category_name="Ceketler/Montlar",category_url="jackets-coats",category_image="https://ik.imagekit.io/osdata/clothes/Women/mont1_on_jack&jones.heic?updatedAt=1753264383272",category_isHome=true,category_kind="Women"},

        new Category ()
        { Id=11,category_name="Kazak/Hırka",category_url="knitwears",category_image="https://ik.imagekit.io/osdata/clothes/Women/kazak1_on_jack&jones.heic?updatedAt=1753264382849",category_isHome=true,category_kind="Women"},

        new Category ()
        { Id=12,category_name="Tailoring",category_url="tailoring",category_image="https://ik.imagekit.io/osdata/clothes/Women/tailoring1_on_jack&jones.heic?updatedAt=1753264383334",category_isHome=true,category_kind="Women"},

         new Category ()
         { Id=13,category_name="Aksesuarlar",category_url="accessories",category_image="https://ik.imagekit.io/osdata/clothes/Women/canta1_jack&jones.heic?updatedAt=1753264409942",category_isHome=true,category_kind="Women"},





         new Category ()
          { Id=14,category_name="Tümünü Gör",category_url="view-all",category_image="https://ik.imagekit.io/osdata/clothes/MenList.heic?updatedAt=1755084524691",category_isHome=true,category_kind="Men",category_campaign="Hafta Sonuna Özel Kaçırılmaz Fiyatlar!",category_campaignColor="b74646"},

          new Category ()
          { Id=15,category_name="Spor",category_url="sports",category_image="https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray1_on.heic?updatedAt=1753264188000",category_isHome=true,category_kind="Men",category_campaign="Sezon Hazır Mısın? Yemyeşil İndirimler",category_campaignColor="3ab21d"},

          new Category ()
          { Id=16,category_name="Tişört",category_url="t-shirts",category_image="https://ik.imagekit.io/osdata/clothes/Men/tshirt5_on_zara.heic?updatedAt=1753264086292",category_isHome=true,category_kind="Men"},

          new Category ()
          { Id=17,category_name="Pantolon",category_url="trousers",category_image="https://ik.imagekit.io/osdata/clothes/Men/pantolon1_on_zara.heic?updatedAt=1753264046736",category_isHome=true,category_kind="Men"},

          new Category ()
          { Id=18,category_name="Şortlar",category_url="shorts",category_image="https://ik.imagekit.io/osdata/clothes/Men/sort1_on_zara.heic?updatedAt=1753264048405",category_isHome=true,category_kind="Men"},

          new Category ()
          { Id=19,category_name="Gömlekler",category_url="shirts",category_image="https://ik.imagekit.io/osdata/clothes/Men/gomlek1_on_zara.heic?updatedAt=1753264040447",category_isHome=true,category_kind="Men"},

          new Category ()
          { Id=20,category_name="Jeans",category_url="jeans",category_image="https://ik.imagekit.io/osdata/clothes/Men/jean2_on_zara.heic?updatedAt=1753264043367",category_isHome=true,category_kind="Men"},

          new Category ()
          { Id=21,category_name="Ceketler/Montlar",category_url="jackets-coats",category_image="https://ik.imagekit.io/osdata/clothes/Men/mont1_jack&jones.heic?updatedAt=1753264045216",category_isHome=true,category_kind="Men"},

          new Category ()
          { Id=22,category_name="Sweatshirtler",category_url="sweatshirts",category_image="https://ik.imagekit.io/osdata/clothes/Men/swetshirt1_jack&jones.heic?updatedAt=1753264082051",category_isHome=true,category_kind="Men"},

          new Category ()
          { Id=23,category_name="Takım Elbiseler",category_url="tailoring",category_image="https://ik.imagekit.io/osdata/clothes/Men/takimelbise1_jack&jones.heic?updatedAt=1753267118640",category_isHome=true,category_kind="Men"},

          new Category ()
          { Id=24,category_name="Ayakkabılar",category_url="shoes",category_image="https://ik.imagekit.io/osdata/clothes/Men/ayakkab%C4%B11_jack&jones.heic?updatedAt=1753264039411",category_isHome=true,category_kind="Men"},

          new Category ()
          { Id=25,category_name="Aksesuarlar",category_url="accessories",category_image="https://ik.imagekit.io/osdata/clothes/Men/corap1_jack&jones.heic?updatedAt=1753264041706",category_isHome=true,category_kind="Men"},




         new Category ()
          { Id=26,category_name="Tümünü Gör",category_url="view-all",category_image="https://ik.imagekit.io/osdata/clothes/kidList.heic?updatedAt=1755084709328",category_isHome=true,category_kind="Kids"},

          new Category ()
          { Id=27,category_name="Jeans",category_url="jeans",category_image="https://ik.imagekit.io/osdata/clothes/Kids/jean1_on_jack&jones.heic?updatedAt=1753264472717",category_isHome=true,category_kind="Kids"},

          new Category ()
          { Id=28,category_name="Tişörtler",category_url="t-shirts",category_image="https://ik.imagekit.io/osdata/clothes/Kids/tisort_jack&jones.heic?updatedAt=1753264472788",category_isHome=true,category_kind="Kids"},

          new Category ()
          { Id=29,category_name="Eşofmanlar",category_url="tracksuits",category_image="https://ik.imagekit.io/osdata/clothes/Kids/esofman1_arka_jack&jones.heic?updatedAt=1753264472795",category_isHome=true,category_kind="Kids"},

          new Category ()
          { Id=30,category_name="Şortlar",category_url="shorts",category_image="https://ik.imagekit.io/osdata/clothes/Kids/sort1_on_jack&jones.heic?updatedAt=1753264475488",category_isHome=true,category_kind="Kids"},

          new Category ()
          { Id=31,category_name="Gömlekler",category_url="shirts",category_image="https://ik.imagekit.io/osdata/clothes/Kids/gomlek1_on_jack&jones.heic?updatedAt=1753264472764",category_isHome=true,category_kind="Kids"},

          new Category ()
          { Id=32,category_name="Aksesuarlar",category_url="accessories",category_image="https://ik.imagekit.io/osdata/clothes/Kids/corap1_jack&jones.heic?updatedAt=1753264475251",category_isHome=true,category_kind="Kids"},


       }
   );

    modelBuilder.Entity<Product>().HasData(
        new List<Product> {
              new Product()
              {
                  Id = 1,
                  product_name ="Kadın Keten Gömlek",
                  product_price =  1790,
                  product_detail="Günlük kullanım için mükemmel, her döneme uygun, kaliteli bir gömlek ile günlük gardırobunuzu yükseltin.Poplin, benzersiz bir görünüm için güçlü bir kumaştır ve ışıldayan bir parlaklığa sahiptir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=4,
                  product_tag="İndirim",
                  product_tagColor="00bf63",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 2,
                  product_name ="Kadın Desenli Askılı Keten Bluz",
                  product_price =  1390,
                  product_detail="Taze, eğlenceli ve renkli bir görünüm sağlayan hafif plaj stiliyle yaza hazır olun. Açık uçlu kumaş; kuruluk hissi ve daha rustik bir görünüm verir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=2,
                  product_tag="Son Ürün",
                  product_tagColor="FF0000",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 3,
                  product_name ="Kadın Kapüşonlu Minimal Logo Baskılı Sweatshirt",
                  product_price =  1190,
                  product_detail="Günlük kullanım için kaliteli sweat. İç kısmı yumuşak dokunuşlu hafif fırçalanmış kuma",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=9,
                  product_tag="Turuncu İndirim",
                  product_tagColor="FFA500",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
               {
                  Id = 4,
                  product_name ="Kadın Kısa Kollu Kroşe Gömlek",
                  product_price =  1390,
                  product_detail="Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=4,
                  product_tag="Yeni Sezon",
                  product_tagColor="0000FF",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 5,
                  product_name ="Kadın Düz İşlemeli Elbise",
                  product_price =  1590,
                  product_detail="Taze, eğlenceli ve renkli bir görünüm sağlayan hafif plaj stiliyle yaza hazır olun. Pamuk, yumuşak ve nefes alabilen özellikleriyle bilinen doğal bir iplik türüdür.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=3,
                  product_tag="Harika Fiyat",
                  product_tagColor="FFC107",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 6,
                  product_name ="Kadın Askılı Denim Elbise",
                  product_price =  1990,
                  product_detail="Her duruma uygun şık bir görünüm yaratmayı kolaylaştıran hafif, havadar bir yazlık takım ile gardırobunuzu güzelleştirin. Denim kumaşı; birlikte dokunan boyalı çözgü ipliği ve atkı dokuma ipi ile öne çıkan, dayanıklı bir çapraz dokuma kumaştır.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=3,
                  product_tag="Efsane Ürün",
                  product_tagColor="E1AD01",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 7,
                  product_name ="Kadın Keten Şort",
                  product_price =  1090,
                  product_detail="Eşofman şortları, süper rahat olmalarını sağlayan büzme ipli ve elastik bel bandına sahiptir. Çeşitli kumaş ve bağlantı parçalarından oluşurlar. Dokuma kumaş; örgü kumaşlar gibi esnemeyen güçlü ve dayanıklı bir malzemedir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=7,
                  product_tag="Yeni Sezon",
                  product_tagColor="0000FF",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 8,
                  product_name ="Kadın Keten Kruvaze",
                  product_price =  2790,
                  product_detail="Kıyafet yönetmeliği şık bir kıyafet gerektirdiğinde, resmi kıyafetlerle bir üst seviyeye çıkın. Dimi; klasik bir görünüm yaratan V veya W deseniyle ünlü, dayanıklı, dokuma bir kumaştır.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=12,
                  product_tag="Efsane Fiyat",
                  product_tagColor="8B0000",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 9,
                  product_name ="Kadın Ayarlanabilir Askılı Canta",
                  product_price =  1790,
                  product_detail="İş, okul, seyahat ve açık hava etkinlikleri de dahil olmak üzere günlük kullanım için kaliteli bir çanta. Poliüretan deriye alternatif, dayanıklı, ve sentetik bir materyaldir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=13,
                  product_tag="Yeni Ürün",
                  product_tagColor="808000",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 10,
                  product_name ="Kadın Fermuar Detaylı Deri Ceket",
                  product_price =  2190,
                  product_detail="Deri görünümlü motorcu ceketi",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=10,
                  product_tag="En Çok Satılan",
                  product_tagColor="FFC107",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 11,
                  product_name ="Kadın Pileli Keten Pantolon",
                  product_price =  1790,
                  product_detail="Günlük kıyafetler rahattır ve günlük kullanım için uygundur. Dokuma kumaş; örgü kumaşlar gibi esnemeyen güçlü ve dayanıklı bir malzemedir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=6,
                  product_tag="Flaş Fiyat",
                  product_tagColor="FFD700",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 12,
                  product_name ="Kadın Cizgili Kazak",
                  product_price =  990,
                  product_detail="Bu sade örgü, gardırobunuzdaki her şeyle uyumludur. Düz örgü, konforu ve esnekliği ön plana çıkaran bir örgülü kumaştır..",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=11,
                  product_tag="Avantajlı Ürün",
                  product_tagColor="800080",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 13,
                  product_name ="Kadın Örgülü Etek",
                  product_price =  870,
                  product_detail="Ribana örgü, dikey çizgilere sahiptir ve rahat bir his için çok esnektir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=5,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 14,
                  product_name ="Kadın Örgülü Bluz",
                  product_price =  950,
                  product_detail="Bu haftasonu kot pantolonla giyebileceğiniz gibi, ofiste gömlek ve pantolonun üzerine de giyebileceğiniz rahat bir örgü türüdür. Yapısal örgü, özel bir görünüm için hafif bir doku ile üretilmiştir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=2,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 15,
                  product_name ="Kadın Kırmızı Bluz",
                  product_price =  990,
                  product_detail="Bu sade örgü, gardırobunuzdaki her şeyle uyumludur. Düz örgü, konforu ve esnekliği ön plana çıkaran bir örgülü kumaştır..",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=2,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["XS","S","M","L","XL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 16,
                  product_name ="GALATASARAY 25/26 Alternatif Forması",
                  product_price =  4499,
                  product_detail="Galatasaray 25/26 alternatif forması, Galatasaray’ın 120 yıllık kültürünün sembollerinden biri olan klasik parçalı tasarımıyla kulübün DNA‘sına saygı duruşunda bulunuyor. Formanın ense kısmında yer alan “İlklerin ve Enlerin Takımı” yazısı, kulübün köklü tarihine gönderme yapıyor. Hem performans hem de gurur için tasarlanan bu forma, sahada ve saha dışında rahat etmeni sağlayacak son teknoloji kumaş teknolojisine sahip. Formanı giy, tarihi kucakla ve önümüzdeki sezon da takımının yanında ol.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=15,
                  product_tag="Yeni Sezon",
                  product_tagColor="00bf63",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Puma"
              },

              new Product()
              {
                  Id = 17,
                  product_name ="GALATASARAY 25/26 Erkek İç Saha Forması",
                  product_price =  4499,
                  product_detail="Galatasaray 25/26 İç Saha forması, Galatasaray’ın 120 yıllık kültürünün sembollerinden biri olan klasik parçalı tasarımıyla kulübün DNA‘sına saygı duruşunda bulunuyor. Formanın ense kısmında yer alan “İlklerin ve Enlerin Takımı” yazısı, kulübün köklü tarihine gönderme yapıyor. Hem performans hem de gurur için tasarlanan bu forma, sahada ve saha dışında rahat etmeni sağlayacak son teknoloji kumaş teknolojisine sahip. Formanı giy, tarihi kucakla ve önümüzdeki sezon da takımının yanında ol.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=15,
                  product_tag="Yeni Sezon",
                  product_tagColor="00bf63",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Puma"
              },

              new Product()
              {
                  Id = 18,
                  product_name ="GALATASARAY 25/26 Erkek Deplasman Forması",
                  product_price =  4499,
                  product_detail="Galatasaray 25/26 İç Saha forması, Galatasaray’ın 120 yıllık kültürünün sembollerinden biri olan klasik parçalı tasarımıyla kulübün DNA‘sına saygı duruşunda bulunuyor. Formanın ense kısmında yer alan “İlklerin ve Enlerin Takımı” yazısı, kulübün köklü tarihine gönderme yapıyor. Hem performans hem de gurur için tasarlanan bu forma, sahada ve saha dışında rahat etmeni sağlayacak son teknoloji kumaş teknolojisine sahip. Formanı giy, tarihi kucakla ve önümüzdeki sezon da takımının yanında ol.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=15,
                  product_tag="Yeni Sezon",
                  product_tagColor="00bf63",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Puma"
              },



              new Product()
              {
                  Id = 19,
                  product_name ="REAL MADRİD 25/26 Authentic İç Saha Forması",
                  product_price =  7999,
                  product_detail="Sağlam temeller üzerine kuruldu. Bu Real Madrid Authentic iç saha forması, yenilenen Bernabéu stadyumunun uzun ve köklü geçmişini yansıtan zarif şekiller, dokular ve renklerle tasarlandı. 25/26 sezonunda efsanevi stadyumda giyilmek üzere tasarlanan forma, hızlı futbol için performans odaklı bir yapıya ve eşsiz ilham için ısı transferli kulüp armasına sahiptir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=15,
                  product_tag="Yeni Sezon",
                  product_tagColor="00bf63",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Adidas"
              },

              new Product()
              {
                  Id = 20,
                  product_name ="REAL MADRİD 25/26 Deplasman Forması",
                  product_price =  5399,
                  product_detail="Sağlam temeller üzerine kuruldu. Bu Real Madrid Authentic iç saha forması, yenilenen Bernabéu stadyumunun uzun ve köklü geçmişini yansıtan zarif şekiller, dokular ve renklerle tasarlandı. 25/26 sezonunda efsanevi stadyumda giyilmek üzere tasarlanan forma, hızlı futbol için performans odaklı bir yapıya ve eşsiz ilham için ısı transferli kulüp armasına sahiptir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=15,
                  product_tag="Yeni Sezon",
                  product_tagColor="00bf63",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Adidas"
              },

              new Product()
              {
                  Id = 21,
                  product_name ="FC BAYERN 25/26 İç Saha Forması",
                  product_price =  5399,
                  product_detail="Bu forma, efsanevi stadyuma selam duruyor. Takım ruhunu yeniden canlandırıyor. Bu adidas FC Bayern formasında kulübün ikonik renklerinde büyük bir M harfi yer alıyor. Münih'in kısaltması olan bu harf, ışıltılı tasarımla öne çıkıyor. Taraftarların takımlarına duyduğu sevgiyi gösteren bu konforlu tişört, nemi uzaklaştıran AEROREADY teknolojisine ve nakış kulüp armasına sahiptir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=15,
                  product_tag="Yeni Sezon",
                  product_tagColor="00bf63",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Adidas"
              },

              new Product()
              {
                  Id = 22,
                  product_name ="GALATASARAY 25/26 Erkek Kaleci Forması",
                  product_price =  4499,
                  product_detail="Galatasaray 25/26 İç Saha forması, Galatasaray’ın 120 yıllık kültürünün sembollerinden biri olan klasik parçalı tasarımıyla kulübün DNA‘sına saygı duruşunda bulunuyor. Formanın ense kısmında yer alan “İlklerin ve Enlerin Takımı” yazısı, kulübün köklü tarihine gönderme yapıyor. Hem performans hem de gurur için tasarlanan bu forma, sahada ve saha dışında rahat etmeni sağlayacak son teknoloji kumaş teknolojisine sahip. Formanı giy, tarihi kucakla ve önümüzdeki sezon da takımının yanında ol.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=15,
                  product_tag="Yeni Sezon",
                  product_tagColor="00bf63",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Puma"
              },

              new Product()
              {
                  Id = 23,
                  product_name ="GALATASARAY 25/26 Erkek Kaleci Forması",
                  product_price =  4499,
                  product_detail="Galatasaray 25/26 İç Saha forması, Galatasaray’ın 120 yıllık kültürünün sembollerinden biri olan klasik parçalı tasarımıyla kulübün DNA‘sına saygı duruşunda bulunuyor. Formanın ense kısmında yer alan “İlklerin ve Enlerin Takımı” yazısı, kulübün köklü tarihine gönderme yapıyor. Hem performans hem de gurur için tasarlanan bu forma, sahada ve saha dışında rahat etmeni sağlayacak son teknoloji kumaş teknolojisine sahip. Formanı giy, tarihi kucakla ve önümüzdeki sezon da takımının yanında ol.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=15,
                  product_tag="Yeni Sezon",
                  product_tagColor="00bf63",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Puma"
              },

              new Product()
              {
                  Id = 24,
                  product_name ="Nike Mercurial Vapor 16 Elite",
                  product_price =  13999,
                  product_detail="Hız takıntın mı var? Oyunun en büyük yıldızları da senin gibi. Bu yüzden bu Elite kramponu geliştirilmiş 3/4 boy Air Zoom birimiyle donattık. Bu stil, sana ve sporun en hızlı oyuncularına defansı aşmak için ihtiyaç duyulan itiş gücünü sunar. Hem kendinden hem ayakkabından mükemmel bir performans beklediğini biliyoruz. Bu nedenle, şimdiye kadarki en hızlı tepki veren Mercurial'ı tasarladık.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=15,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["EU 36","EU 37","EU 38","EU 39","EU 40","EU 41","EU 42","EU 43","EU 44","EU 45"],
                  product_brand="Nike"
              },

              new Product()
              {
                  Id = 25,
                  product_name ="Nike Phantom 6 Low Elite",
                  product_price =  13999,
                  product_detail="İsabete çok mu önem veriyorsun? Biz de öyle. Bu yüzden Phantom 6 Elite'i, isabet yeteneğine güç katan çığır açıcı Gripknit ile tasarladık. Yapışkan doku, ayağını topa yaklaştırır ve her fırsatı değerlendirebilmen için sana kontrol kazandırır. Bu kramponla şut kaçırmak diye bir şey yok. Ayrıca Cyclone 360 tutuş plakasıyla bir araya gelerek hızlı dönüşler yapmanı sağlar ve golleri sıralaman için sana rakip tanımayan avantaj sunar.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=15,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["EU 36","EU 37","EU 38","EU 39","EU 40","EU 41","EU 42","EU 43","EU 44","EU 45"],
                  product_brand="Nike"
              },

              new Product()
              {
                  Id = 26,
                  product_name ="Nike Mercurial Superfly 10 Academy LV8",
                  product_price =  5299,
                  product_detail="Hızına seviye atlatmak mı istiyorsun? Bu Academy kramponu geliştirilmiş bir Air Zoom topuk birimiyle ürettik. Bu birim, defansı aşmak için ihtiyaç duyduğun itiş gücünü sunar. Ortaya çıkan stil, maç boyu tempoyu belirleyebilmen için en hızlı tepki veren Mercurial modelidir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=15,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["EU 36","EU 37","EU 38","EU 39","EU 40","EU 41","EU 42","EU 43","EU 44","EU 45"],
                  product_brand="Nike"
              },

              new Product()
              {
                  Id = 27,
                  product_name ="Erkek Kol ve Yaka Detaylı Tişört",
                  product_price =  890,
                  product_detail="Bu klasik tişört; kot pantolon, şort ve pantolonlarla iyi uyum sağlayarak gardırobun vazgeçilmezi olacak. Penye jarse esnektir ve yumuşak bir hisse sahiptir. Günlük kullanım için mükemmeldir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=16,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Jack&Jones"
              },

              new Product()
              {
                  Id = 28,
                  product_name ="Erkek Kol ve Yaka Detaylı Tişört",
                  product_price =  890,
                  product_detail="Bu klasik tişört; kot pantolon, şort ve pantolonlarla iyi uyum sağlayarak gardırobun vazgeçilmezi olacak. Penye jarse esnektir ve yumuşak bir hisse sahiptir. Günlük kullanım için mükemmeldir.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=16,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Jack&Jones"
              },

              new Product ()
              {
                  Id=29,
                  product_name ="Pamuklu Keten Gömlek",
                  product_price =  1690,
                  product_detail="Keten ve pamuk karışımlı relaxed fit gömlek. Yakası düğmeli. Düğmeli manşetli uzun kollu. Göğsü yama cepli ve önü düğmeli.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=19,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Zara"
              },

              new Product()
              {
                  Id = 30,
                  product_name ="Relaxed Fit Pamuklu - Keten Pantolon",
                  product_price =  1690,
                  product_detail="%14 keten ve pamuk karışımlı kumaştan üretilmiş relaxed fit pantolon. Ayarlanabilir bağcıklı lastikli bel. Ön cepli ve biyeli arka cepli.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=17,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Zara"
              },

              new Product()
              {
                  Id = 31,
                  product_name ="Relaxed Fit Pamuklu - Keten Pantolon",
                  product_price =  1690,
                  product_detail="%14 keten ve pamuk karışımlı kumaştan üretilmiş relaxed fit pantolon. Ayarlanabilir bağcıklı lastikli bel. Ön cepli ve biyeli arka cepli.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=17,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Zara"
              },

               new Product()
              {
                  Id = 32,
                  product_name ="%100 Keten Bermuda Şort",
                  product_price =  1690,
                  product_detail="Keten kumaştan regular fit bermuda. Beli ayarlanabilir büzgü ipli elastik ve önde pileli. Ön cepli ve arkada yama cep detaylı.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=18,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Zara"

              },

               new Product()
              {
                  Id = 33,
                  product_name ="Seoul + Lisboa Edt 2 X 90 ML (3.4 FL. OZ)",
                  product_price =  990,
                  product_detail="İkili eau de toilette seti. Koku piramidinde fındık, biber ve kehribar (I) + limon, yeşil notalar ve misk (II) notaları yer alıyor.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=25,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Zara"
              },

               new Product()
              {
                  Id = 34,
                  product_name ="Dik Dokulu Polo Tişört",
                  product_price =  1320,
                  product_detail="Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.",
                  product_isActive=true,
                  product_isHome=true,
                  CategoryId=16,
                  product_tag="Yeni",
                  product_tagColor="3E6DD6",
                  product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                  product_brand="Zara"
              },

              new Product()
              {
                Id = 35,
                product_name ="Dik Dokulu Polo Tişört",
                product_price =  1320,
                product_detail="Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.",
                product_isActive=true,
                product_isHome=true,
                CategoryId=16,
                product_tag="Yeni",
                product_tagColor="3E6DD6",
                product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                product_brand="Zara"
              },

               new Product()
              {
                Id = 36,
                product_name ="Dik Dokulu Polo Tişört",
                product_price =  1320,
                product_detail="Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.",
                product_isActive=true,
                product_isHome=true,
                CategoryId=16,
                product_tag="Yeni",
                product_tagColor="3E6DD6",
                product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                product_brand="Zara"
              },

              new Product()
              {
                Id = 37,
                product_name ="Basic Kontrast Kumaşlı Tişört",
                product_price =  920,
                product_detail="Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.",
                product_isActive=true,
                product_isHome=true,
                CategoryId=16,
                product_tag="Yeni",
                product_tagColor="3E6DD6",
                product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                product_brand="Zara"
              },

              new Product()
              {
                Id = 38,
                product_name ="Basic Kontrast Kumaşlı Tişört",
                product_price =  920,
                product_detail="Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.",
                product_isActive=true,
                product_isHome=true,
                CategoryId=16,
                product_tag="Yeni",
                product_tagColor="3E6DD6",
                product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                product_brand="Zara"
              },

              new Product()
              {
                Id = 39,
                product_name ="Basic Kontrast Kumaşlı Tişört",
                product_price =  920,
                product_detail="Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.",
                product_isActive=true,
                product_isHome=true,
                CategoryId=16,
                product_tag="Yeni",
                product_tagColor="3E6DD6",
                product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                product_brand="Zara"
              },

              new Product()
              {
                Id = 40,
                product_name ="Basic Kontrast Kumaşlı Tişört",
                product_price =  920,
                product_detail="Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.",
                product_isActive=true,
                product_isHome=true,
                CategoryId=16,
                product_tag="Yeni",
                product_tagColor="3E6DD6",
                product_sizes = ["XS","S","M","L","XL","XXL","XXXL"],
                product_brand="Zara"
              },
               new Product()
              {
                Id = 41,
                product_name ="Desenli Halter Uzun Elbise",
                product_price =  2290,
                product_detail="Halter yakalı, bağcıklı ve V yakalı uzun elbise. İç astarı vardır. Sırtı açık, bağcıklı ve dikiş kısmında gizli fermuarlı kapamalıdır.",
                product_isActive=true,
                product_isHome=true,
                CategoryId=3,
                product_tag="Yeni",
                product_tagColor="3E6DD6",
                product_sizes = ["XS","S","M","L","XL"],
                product_brand="Zara"
              },
               new Product()
              {
                Id = 42,
                product_name ="Dokulu Çiçekli Kısa Elbise",
                product_price =  1490,
                product_detail="Dikiş kısmında gizli fermuarlı kapamalıdır.",
                product_isActive=true,
                product_isHome=true,
                CategoryId=3,
                product_tag="Sezon İndirimi",
                product_tagColor="b74646",
                product_sizes = ["XS","S","M","L","XL"],
                product_brand="Pull&Bear"
              },
               new Product()
              {
                Id = 43,
                product_name ="Uzun Kollu Kısa Elbise",
                product_price =  920,
                product_detail="Dikiş kısmında gizli fermuarlı kapamalıdır.",
                product_isActive=true,
                product_isHome=true,
                CategoryId=3,
                product_tag="Son Ürünler",
                product_tagColor="f7ecd5",
                product_sizes = ["XS","S","M","L","XL"],
                product_brand="Pull&Bear"
              },
               new Product()
              {
                Id = 44,
                product_name ="City Çanta",
                product_price =  1490,
                product_detail="City el çantası. Metal detaylı. Metal fermuarlı iç cep. Çıkarılabilir çapraz askılı. Çift kulplu metal fermuar kapamalı.",
                product_isActive=true,
                product_isHome=true,
                CategoryId=13,
                product_tag="Yeni",
                product_tagColor="3E6DD6",
                product_sizes = ["M"],
                product_brand="Zara"
              },
               new Product()
              {
                Id = 45,
                product_name ="Süet Fiyonklu Topuklu Sandalet",
                product_price =  2890,
                product_detail="Süet, topuklu sandalet ayakkabı. Ön tarafında fiyonk detayı. Ayarlanabilir elastik bantlı arka şerit. Yüksek topuklu.",
                product_isActive=true,
                product_isHome=true,
                CategoryId=13,
                product_tag="Yeni",
                product_tagColor="3E6DD6",
                product_sizes = ["35","36","37","38","39","40"],
                product_brand="Zara"
              },
        }
    );

    modelBuilder.Entity<ProductImage>().HasData(
              new ProductImage
              {
                Id = 1,
                ProductId = 1,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/gomlek1_on_jack&jones.heic?updatedAt=1753264400669"
              },

              new ProductImage
              {
                Id = 2,
                ProductId = 1,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/gomlek1_arka_jack&jones.heic?updatedAt=1753264399797"
              },

              new ProductImage
              {
                Id = 3,
                ProductId = 2,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/bluz1_on_jack&jones.heic?updatedAt=1753264404211"
              },

              new ProductImage
              {
                Id = 4,
                ProductId = 2,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/bluz1_arka_jack&jones.heic?updatedAt=1753264398224"
              },

              new ProductImage
              {
                Id = 5,
                ProductId = 3,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/sweatshirt1_on_jack&jones.heic?updatedAt=1753264382676"
              },

              new ProductImage
              {
                Id = 6,
                ProductId = 3,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/sweatshirt_arka_jack&jones.heic?updatedAt=1753264382292"
              },

              new ProductImage
              {
                Id = 7,
                ProductId = 4,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/gomlek2_on_jack&jones.heic?updatedAt=1753264410066"
              },

              new ProductImage
              {
                Id = 8,
                ProductId = 4,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/gomlek2_arka_jack&jones.heic?updatedAt=1753264410148"
              },

              new ProductImage
              {
                Id = 9,
                ProductId = 5,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/elbise1_on_jack&jones.heic?updatedAt=1753264410116"
              },

              new ProductImage
              {
                Id = 10,
                ProductId = 5,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/elbise1_arka_jack&jones.heic?updatedAt=1753264409983"
              },

              new ProductImage
              {
                Id = 11,
                ProductId = 6,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/elbise2_jack&jones.heic?updatedAt=1753264409957"
              },

              new ProductImage
              {
                Id = 12,
                ProductId = 7,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/sort1_on_jack&jones.heic?updatedAt=1753264384700"
              },

              new ProductImage
              {
                Id = 13,
                ProductId = 7,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/sort1_arka_jack&jones.heic?updatedAt=1753264384643"
              },

              new ProductImage
              {
                Id = 14,
                ProductId = 8,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/tailoring1_on_jack&jones.heic?updatedAt=1753264383334"
              },

              new ProductImage
              {
                Id = 15,
                ProductId = 8,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/tailoring1_arka_jack&jones.heic?updatedAt=1753264383008"
              },

              new ProductImage
              {
                Id = 16,
                ProductId = 9,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/canta1_jack&jones.heic?updatedAt=1753264409942"
              },

              new ProductImage
              {
                Id = 17,
                ProductId = 10,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/mont1_on_jack&jones.heic?updatedAt=1753264383272"
              },

              new ProductImage
              {
                Id = 18,
                ProductId = 10,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/mont1_arka_jack&jones.heic?updatedAt=1753264383212"
              },

              new ProductImage
              {
                Id = 19,
                ProductId = 11,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/pantolon1_on_jack&jones.heic?updatedAt=1753264378490"
              },

              new ProductImage
              {
                Id = 20,
                ProductId = 11,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/pantolon1_arka_jack&jones.heic?updatedAt=1753264377464"
              },

              new ProductImage
              {
                Id = 21,
                ProductId = 12,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/kazak1_on_jack&jones.heic?updatedAt=1753264382849"
              },

              new ProductImage
              {
                Id = 22,
                ProductId = 12,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/kazak1_arka_jack&jones.heic?updatedAt=1753264382530"
              },

              new ProductImage
              {
                Id = 23,
                ProductId = 13,
                image_url = "https://ik.imagekit.io/osdata/clothes/Women/etek1_on_jack&jones.heic?updatedAt=1753267522055"
              },

                 new ProductImage
                 {
                   Id = 24,
                   ProductId = 13,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/etek1_arka_jack&jones.heic?updatedAt=1753267522039"
                 },

                 new ProductImage
                 {
                   Id = 25,
                   ProductId = 14,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/bluz2_on_jack&jones.heic?updatedAt=1753264405034"
                 },

                 new ProductImage
                 {
                   Id = 26,
                   ProductId = 14,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/bluz2_arka_jack&jones.heic?updatedAt=1753264408207"
                 },

                 new ProductImage
                 {
                   Id = 27,
                   ProductId = 15,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/bluz3_on_jack&jones.heic?updatedAt=1753267007813"
                 },

                 new ProductImage
                 {
                   Id = 28,
                   ProductId = 15,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/bluz3_arka_jack&jones.heic?updatedAt=1753267007524"
                 },

                   new ProductImage
                   {
                     Id = 29,
                     ProductId = 16,
                     image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray5_on.heic?updatedAt=1755083587943"
                   },

                  new ProductImage
                  {
                    Id = 30,
                    ProductId = 16,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray5_arka.heic?updatedAt=1755083587546"
                  },


                  new ProductImage
                  {
                    Id = 31,
                    ProductId = 17,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray1_on.heic?updatedAt=1753264188000"
                  },

                  new ProductImage
                  {
                    Id = 32,
                    ProductId = 17,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray1_arka.heic?updatedAt=1753264187949"
                  },

                  new ProductImage
                  {
                    Id = 33,
                    ProductId = 18,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray2_on.heic?updatedAt=1753264187235"
                  },

                  new ProductImage
                  {
                    Id = 34,
                    ProductId = 18,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray2_arka.heic?updatedAt=1753264187779"
                  },



                  new ProductImage
                  {
                    Id = 35,
                    ProductId = 19,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_real1_on.heic?updatedAt=1753264191330"
                  },

                  new ProductImage
                  {
                    Id = 36,
                    ProductId = 19,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_real1_arka.heic?updatedAt=1753264192719"
                  },

                  new ProductImage
                  {
                    Id = 37,
                    ProductId = 20,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_real2_on.heic?updatedAt=1753264194483"
                  },

                  new ProductImage
                  {
                    Id = 38,
                    ProductId = 20,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_real2_arka.heic?updatedAt=1753264192017"
                  },

                  new ProductImage
                  {
                    Id = 39,
                    ProductId = 21,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_bayern1_on.heic?updatedAt=1753264189901"
                  },

                  new ProductImage
                  {
                    Id = 40,
                    ProductId = 21,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_bayern1_arka.heic?updatedAt=1753264189825"
                  },

                   new ProductImage
                   {
                     Id = 41,
                     ProductId = 22,
                     image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray4_on.heic?updatedAt=1753264190759"
                   },

                  new ProductImage
                  {
                    Id = 42,
                    ProductId = 22,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galataray4_arka.heic?updatedAt=1753264188871"
                  },

                  new ProductImage
                  {
                    Id = 43,
                    ProductId = 23,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray3.heic?updatedAt=1753264189497"
                  },

                  new ProductImage
                  {
                    Id = 44,
                    ProductId = 24,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike1_yan.heic?updatedAt=1753264198469"
                  },

                  new ProductImage
                  {
                    Id = 45,
                    ProductId = 24,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike1_ust.heic?updatedAt=1753264200245"
                  },

                  new ProductImage
                  {
                    Id = 46,
                    ProductId = 25,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike4_yan.heic?updatedAt=1753264200023"
                  },

                  new ProductImage
                  {
                    Id = 47,
                    ProductId = 25,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike4_ust.heic?updatedAt=1753264200325"
                  },

                  new ProductImage
                  {
                    Id = 48,
                    ProductId = 26,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike3_yan.heic?updatedAt=1753264198609"
                  },

                  new ProductImage
                  {
                    Id = 49,
                    ProductId = 26,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike3_ust.heic?updatedAt=1753264198765"
                  },

                  new ProductImage
                  {
                    Id = 50,
                    ProductId = 27,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt9_jack&jones.heic?updatedAt=1753264088651"
                  },

                  new ProductImage
                  {
                    Id = 51,
                    ProductId = 28,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt8_jack&jones.heic?updatedAt=1753264088412"
                  },

                  new ProductImage
                  {
                    Id = 52,
                    ProductId = 29,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/gomlek1_on_zara.heic?updatedAt=1753264040447"
                  },

                  new ProductImage
                  {
                    Id = 53,
                    ProductId = 29,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/gomlek1_arka_zara.heic?updatedAt=1753264041192"
                  },

                  new ProductImage
                  {
                    Id = 54,
                    ProductId = 30,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/pantolon1_on_zara.heic?updatedAt=1753264046736"
                  },

                  new ProductImage
                  {
                    Id = 55,
                    ProductId = 30,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/pantolon1_arka_zara.heic?updatedAt=1753264046340"
                  },

                  new ProductImage
                  {
                    Id = 56,
                    ProductId = 31,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/pantolon2_on_zara.heic?updatedAt=1753264046949"
                  },

                  new ProductImage
                  {
                    Id = 57,
                    ProductId = 32,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/sort1_on_zara.heic?updatedAt=1753264048405"
                  },

                  new ProductImage
                  {
                    Id = 58,
                    ProductId = 32,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/sort1_arka_zara.heic?updatedAt=1753264048239"
                  },

                  new ProductImage
                  {
                    Id = 59,
                    ProductId = 33,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/parfum1_zara.heic?updatedAt=1753264047132"
                  },



                  new ProductImage
                  {
                    Id = 60,
                    ProductId = 34,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt1_on_zara.heic?updatedAt=1753264083633"
                  },

                  new ProductImage
                  {
                    Id = 61,
                    ProductId = 34,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt1_arka_zara.heic?updatedAt=1753264083089"
                  },

                  new ProductImage
                  {
                    Id = 62,
                    ProductId = 35,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt2_on_zara.heic?updatedAt=1753264083894"
                  },

                  new ProductImage
                  {
                    Id = 63,
                    ProductId = 35,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt2_arka_zara.heic?updatedAt=1753264083912"
                  },

                  new ProductImage
                  {
                    Id = 64,
                    ProductId = 36,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt3_on_zara.heic?updatedAt=1753264083857"
                  },

                  new ProductImage
                  {
                    Id = 65,
                    ProductId = 36,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt3_arka_zara.heic?updatedAt=1753264083729"
                  },

                  new ProductImage
                  {
                    Id = 66,
                    ProductId = 37,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt4_on_zara.heic?updatedAt=1753264083117"
                  },

                  new ProductImage
                  {
                    Id = 67,
                    ProductId = 37,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt4_arka_zara.heic?updatedAt=1753264083080"
                  },

                 new ProductImage
                 {
                   Id = 68,
                   ProductId = 38,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt5_on_zara.heic?updatedAt=1753264086292"
                 },

                 new ProductImage
                 {
                   Id = 69,
                   ProductId = 38,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt5_arka_zara.heic?updatedAt=1753264083987"
                 },

                 new ProductImage
                 {
                   Id = 70,
                   ProductId = 39,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt6_on_zara.heic?updatedAt=1753264087944"
                 },

                 new ProductImage
                 {
                   Id = 71,
                   ProductId = 39,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt6_arka_zara.heic?updatedAt=1753264087191"
                 },

                 new ProductImage
                 {
                   Id = 72,
                   ProductId = 40,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt7_on_zara.heic?updatedAt=1753264087945"
                 },

                 new ProductImage
                 {
                   Id = 73,
                   ProductId = 40,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Men/tshirt7_arka_zara.heic?updatedAt=1753264087723"
                 },
                 new ProductImage
                 {
                   Id = 74,
                   ProductId = 41,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/elbise3_zara_on.heic?updatedAt=1755463778774"
                 },
                 new ProductImage
                 {
                   Id = 75,
                   ProductId = 41,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/elbise3_zara_arka.heic?updatedAt=1755463778920"
                 },
                 new ProductImage
                 {
                   Id = 76,
                   ProductId = 41,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/elbise3_zara_canli_on.heic?updatedAt=1755463778913"
                 },
                 new ProductImage
                 {
                   Id = 77,
                   ProductId = 41,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/elbise3_zara_canli_arka.heic?updatedAt=1755463779108"
                 },
                 new ProductImage
                 {
                   Id = 78,
                   ProductId = 41,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/elbise3_zara_canli_yan.heic?updatedAt=1755463779329"
                 },
                 new ProductImage
                 {
                   Id = 79,
                   ProductId = 42,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/elbise5_pull&bear.heic?updatedAt=1755463779457"
                 },
                 new ProductImage
                 {
                   Id = 80,
                   ProductId = 43,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/elbise4_pull&bear.heic?updatedAt=1755463779406"
                 },
                 new ProductImage
                 {
                   Id = 81,
                   ProductId = 44,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/canta2_zara.heic?updatedAt=1755463790358"
                 },
                 new ProductImage
                 {
                   Id = 82,
                   ProductId = 45,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/ayakkab%C4%B11_zara_yan.heic?updatedAt=1755463790454"
                 },
                 new ProductImage
                 {
                   Id = 83,
                   ProductId = 45,
                   image_url = "https://ik.imagekit.io/osdata/clothes/Women/ayakkab%C4%B11_zara_ust.heic?updatedAt=1755463790372"
                 },
                  new ProductImage
                  {
                    Id = 84,
                    ProductId = 45,
                    image_url = "https://ik.imagekit.io/osdata/clothes/Women/ayakkab%C4%B11_zara_arka.heic?updatedAt=1755463790215"
                  }
);
    modelBuilder.Entity<ProductColor>().HasData(
        new ProductColor { Id = 1, ProductId = 1, color_name = "Pembe", color_hex = "ff66c4" },
        new ProductColor { Id = 2, ProductId = 1, color_name = "Siyah", color_hex = "000000" },
        new ProductColor { Id = 3, ProductId = 1, color_name = "Beyaz", color_hex = "FFFFFF" },
        new ProductColor { Id = 4, ProductId = 2, color_name = "Pembe", color_hex = "F7B9D9" },
        new ProductColor { Id = 5, ProductId = 2, color_name = "Mor", color_hex = "9B30FF" },

        new ProductColor { Id = 6, ProductId = 3, color_name = "Kırmızı", color_hex = "FF0000" },
        new ProductColor { Id = 7, ProductId = 4, color_name = "Yeşil", color_hex = "00FF00" },
        new ProductColor { Id = 8, ProductId = 5, color_name = "Mavi", color_hex = "0000FF" },
        new ProductColor { Id = 9, ProductId = 6, color_name = "Sarı", color_hex = "FFFF00" },

        new ProductColor { Id = 10, ProductId = 7, color_name = "Turuncu", color_hex = "FFA500" },

        new ProductColor { Id = 11, ProductId = 24, color_name = "Pembe", color_hex = "ff66c4" },
         new ProductColor { Id = 12, ProductId = 24, color_name = "Siyah", color_hex = "000000" },
          new ProductColor { Id = 13, ProductId = 24, color_name = "Gri", color_hex = "808080" },
           new ProductColor { Id = 14, ProductId = 24, color_name = "Beyaz", color_hex = "FFFFFF" },
            new ProductColor { Id = 15, ProductId = 25, color_name = "Mor", color_hex = "808080" },
             new ProductColor { Id = 16, ProductId = 25, color_name = "Kırmızı", color_hex = "FF0000" },
               new ProductColor { Id = 17, ProductId = 41, color_name = "Lacivert", color_hex = "024697" }


    );
  }
}