using Akka.Actor;
using static Akka.Pattern.BackoffSupervisor;

namespace AkkApi.Models
{
    public class ProgramActor : ReceiveActor
    {
        public ProgramActor()
        {
            Receive<MessageAppointment>(message => Console.WriteLine($"Tu cita se agendo para el día: {message.AppointmentDay} a las: {message.AppointmentTime} "));
        }
        protected override void PreStart() => Console.WriteLine("Se ha inicializado la API");
    }
}
