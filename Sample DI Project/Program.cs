using Alor.OpenAPI.DI;
using Alor.OpenAPI.Extensions;
using Serilog;

// ����������� Serilog ��� �������
    Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Information()
        .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
        .CreateLogger();

    var builder = WebApplication.CreateBuilder(args);

// DI: 1. ���� ��������� ������ (������ �����������)
    var defaultOptions = new OpenApiClientOptions
    {
        Contour = "Prod",
        WsResponseMessageHandler = msg => Console.WriteLine($"[AlorDefault1] WS: {msg}")
    };
    builder.Services.AddOpenApiClient(defaultOptions);

// DI: 2. ��������� ����������� �������� (������ ����������� � ����������)
    var profileOptions1 = new OpenApiClientOptions
    {
        Contour = "Prod",
        WsResponseMessageHandler = msg => Console.WriteLine($"[ManualPF1] WS: {msg}")
    };
    builder.Services.AddOpenApiClient("ManualPF1", profileOptions1);

    var profileOptions2 = new OpenApiClientOptions
    {
        Contour = "Dev",
        WsResponseCommandMessageHandler = cmd => Console.WriteLine($"[ManualPF2] CMD: {cmd}")
    };
    builder.Services.AddOpenApiClient("ManualPF2", profileOptions2);

// DI: 3. ���� ������ ����� ������ (��������, ��� ������ Alor).
// �.�. ��� ������ AddOpenApiClient ��� �������� ����� ���������� ����������� SingleTone,
// �� ���������� ���������� �������, ������� �� ���������������� � ������ DI: 1.

// appsettings.json:
/*
"Alor": {
     "UseCustomConfig": true,
     "BaseUrl": "https://api.alor.ru",
     "WsUrl": "wss://api.alor.ru/ws",
     "CwsUrl": "wss://api.alor.ru/cws",
     "AuthUrl": "https://oauth.alor.ru/refresh?token="
   }
*/

builder.Services.AddOpenApiClient(builder.Configuration.GetSection("Alor"));

// DI: 4. ����� �������� ����� ������
// appsettings.json:
/*
"AlorClients": {
  "MultConfigProfile1": { "Contour": "Prod" },
  "MultConfigProfile2": { "Contour": "Dev" }
}
*/
    var section = builder.Configuration.GetSection("AlorClients");
    builder.Services.AddOpenApiClientsFromConfiguration(section);
// ������� "MultConfigProfile1" � "MultConfigProfile2" ����� �������� ����� IOpenApiClientProvider/Get("MultConfigProfile1")

    
    
    builder.Services.AddControllers();
    builder.Host.UseSerilog();

    var app = builder.Build();
    app.MapControllers();
    app.Run();