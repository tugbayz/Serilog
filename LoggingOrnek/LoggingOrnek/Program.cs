//, rollingInterval: RollingInterval.Day
using Serilog;

Log.Logger = new LoggerConfiguration()
          .MinimumLevel.Debug() 
          .WriteTo.Console()
          .WriteTo.File("logs/myapp.txt")
          .CreateLogger();

Log.Information("Uygulama başlatıldı");
Log.Warning("Bu bir uyarı mesajıdır");
Log.Error("Bu bir hata mesajıdır");

try
{
    var result = 10 / int.Parse("0"); // bilerek hata
}
catch (Exception ex)
{
    Log.Fatal(ex, "Beklenmeyen bir hata oluştu!");
}
finally
{
    Log.CloseAndFlush();
}