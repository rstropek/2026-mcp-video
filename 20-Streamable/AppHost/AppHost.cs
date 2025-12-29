var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects._10_DemoServer>("demo-server");

builder.Build().Run();
