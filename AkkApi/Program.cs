using Akka.Actor;
using AkkApi.Models;
using static Akka.Pattern.BackoffSupervisor;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

ActorSystem system = ActorSystem.Create("MiPrimerSistemaAkka");
var messageAppointment = system.ActorOf<ProgramActor>("messageAppointment");


app.MapGet("/", (string dayP, string timeP) =>
{
    var NewAppointment = new MessageAppointment(dayP, timeP);
    messageAppointment.Tell(NewAppointment);
    return Results.Ok(NewAppointment.ToString());
});
    
app.Run();
