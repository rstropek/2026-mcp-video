var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects._10_DemoServer>("demo-server");
builder.AddProject<Projects._20_McpStreamableServer>("mcp-streamable-server");

builder.Build().Run();
