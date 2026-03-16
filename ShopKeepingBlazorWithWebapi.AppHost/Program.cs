var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.ShopKeepingBlazorWithWebapi_ApiService>("apiservice");

builder.AddProject<Projects.ShopKeepingBlazorWithWebapi_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
