var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.CrewinDemo_ApiService>("apiservice");

builder.AddProject<Projects.CrewinDemo_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
