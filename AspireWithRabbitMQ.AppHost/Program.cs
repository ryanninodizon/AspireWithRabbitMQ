var builder = DistributedApplication.CreateBuilder(args);

var rabbitMQ = builder.AddRabbitMQ("messaging").WithManagementPlugin();

builder.AddProject<Projects.AspireWithRabbitmQ_Sender>("sender")
.WithReference(rabbitMQ);

builder.AddProject<Projects.AspireWithRabbitmQ_Receiver>("receiver")
.WithReference(rabbitMQ);

builder.Build().Run();
