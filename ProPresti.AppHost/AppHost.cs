var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ProPresti>("propresti");

builder.Build().Run();
