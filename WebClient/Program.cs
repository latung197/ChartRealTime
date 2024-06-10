var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var builderRazor = builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    builderRazor.AddRazorRuntimeCompilation();
  
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}    

app.UseHttpsRedirection();

var timeOutCacheStaticFile = 60 * 60; // cài đặt cho phép máy người dùng lưu cache 1 tiếng đồng hồ.(Đơn vị tính bằng S)
app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = cg =>
    {
        cg.Context.Response.Headers.Append("Cache-Control", $"public, max-age={timeOutCacheStaticFile}");
    }//,RequestPath="StaticFiles/User"// cho phép trình duyệt lưu cache 1 tiếng 

    //    OnPrepareResponse = cg =>
    //    {
    //        cg.Context.Response.Headers.Append("Cache-Control", $"public, max-age={timeOutCacheStaticFile}");
    //    },
    //RequestPath = "StaticFiles/User" -- RequestPath Định nghĩa lại đường dẫn vật lý của tài nguyên
});// Cho phép đường dẫn để ~ sẽ truy cập vào thư mục wwwrot và lấy các file CSS, JS .....

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
