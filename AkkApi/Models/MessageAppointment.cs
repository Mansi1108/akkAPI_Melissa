namespace AkkApi.Models
{
    public class MessageAppointment
    {
        public string AppointmentDay { get; private set; }
        public string AppointmentTime { get; private set; }

        public MessageAppointment(string appointmentDay, string appointmentTime)
        {
            AppointmentDay = appointmentDay;
            AppointmentTime = appointmentTime;
        }

        public override string ToString()
        {
            return $"Se ha agregado tu cita con éxito \n Tu cita se agendo para el día: {AppointmentDay} a las: {AppointmentTime}";
        }
    }
}
