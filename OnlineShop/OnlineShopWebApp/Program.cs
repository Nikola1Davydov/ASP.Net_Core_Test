var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// https://localhost:5001/start/hello
// По текущему времени выведите Доброе утро, Добрый день, Добрый вечер или Доброй ночи. 
//Ночь - 0:00 до 05:59
//Утро - 06:00 до 11:59
//День - 12:00 до 17:59
//Вечер - 18:00 до 23:59

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=calc}/{action=index}");


app.Run();
