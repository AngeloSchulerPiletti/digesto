using Digesto.Application;
using Digesto.Application.Interfaces;
using Digesto.Infra.Interfaces;
using Digesto.Infra;
using Digesto.Application.Services.Interfaces;
using Digesto.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<IPaginationService, PaginationService>();

builder.Services.AddScoped<ICustomerBusiness, CustomerBusiness>();
builder.Services.AddScoped<IBrokerBusiness, BrokerBusiness>();
builder.Services.AddScoped<IEmailBusiness, EmailBusiness>();
builder.Services.AddScoped<IInsuranceQuoteRequestBusiness, InsuranceQuoteRequestBusiness>();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IBrokerRepository, BrokerRepository>();
builder.Services.AddScoped<IEmailRepository, EmailRepository>();
builder.Services.AddScoped<IInsuranceQuoteRequestRepository, InsuranceQuoteRequestRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
