using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

var fileProvider = new PhysicalFileProvider(
       Path.Combine(builder.Environment.ContentRootPath, "public"));

app.UseDefaultFiles(new DefaultFilesOptions {
    FileProvider = fileProvider
});

app.UseStaticFiles(new StaticFileOptions {
    FileProvider = fileProvider
});

app.Run();
