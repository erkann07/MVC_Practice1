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

// Controller -> Kullan�c�dan gelen iste�i yapar ve i� mant��� burdad�r.

// Action -> Controller i�inde bulunan ve kullan�c�dan gelen iste�e g�re �al��an metotlard�r.

// Model -> Veriyi temsil eder. Veri taban�ndaki verileri tutar ve i� mant���na g�re �ekillendirir.

// View -> Kullan�c�ya g�sterilecek olan sayfad�r.

// Razor -> HTML ve C# kodlar�n� birle�tiren bir �ablon motorudur. Razor, C# kodunu HTML i�inde kullanmam�z� sa�lar.

// Razorview ->  Razor kullan�larak yaz�lm�� .cshtml uzant�l� sayfalard�r. View klas�r�nde yer al�r.

// builder.Build(); -> Yap�land�r�lan servisleri ve uygulamay� birle�tirip �al��maya haz�r hale getirir.

// app.Run(); -> Uygulamay� ba�lat�r ve istekleri dinlemeye ba�lar.
