var builder = WebApplication.CreateBuilder(args);




builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
);


app.Run();

//                    ---------- MVC METOTLARI ----------

// Controller -> Kullanýcýdan gelen isteði yapar ve iþ mantýðý burdadýr.

// Action -> Controller içinde bulunan ve kullanýcýdan gelen isteðe göre çalýþan metotlardýr.

// Model -> Veriyi temsil eder. Veri tabanýndaki verileri tutar ve iþ mantýðýna göre þekillendirir.

// View -> Kullanýcýya gösterilecek olan sayfadýr.

// Razor -> HTML ve C# kodlarýný birleþtiren bir þablon motorudur. Razor, C# kodunu HTML içinde kullanmamýzý saðlar.

// Razorview ->  Razor kullanýlarak yazýlmýþ .cshtml uzantýlý sayfalardýr. View klasöründe yer alýr.

// builder.Build(); -> Yapýlandýrýlan servisleri ve uygulamayý birleþtirip çalýþmaya hazýr hale getirir.

// app.Run(); -> Uygulamayý baþlatýr ve istekleri dinlemeye baþlar.
