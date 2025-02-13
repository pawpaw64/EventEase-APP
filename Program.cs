using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using EventEaseApp;
using EventEaseApp.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents()
    .AddInteractiveComponents();
builder.Services.AddSingleton<EventModel>();

var app = builder.Build();
app.MapRazorComponents();
app.Run();
