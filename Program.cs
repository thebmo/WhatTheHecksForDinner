using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WhatTheHecksForDinner.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<WhatTheHecksForDinnerContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("WhatTheHecksForDinnerContext")));
}
else
{
    builder.Services.AddDbContext<WhatTheHecksForDinnerContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionMovieContext")));
}
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
