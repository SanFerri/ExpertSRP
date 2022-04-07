using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            // Console.WriteLine(appointmentResult);
            Doctor doctor = new Doctor("Armand", "Huesologo");
            Patient patient = new Patient(23, "Steven Jhonson", "5555-555-555");
            Appointment appointment = new Appointment("986782342", DateTime.Now, "Wall Street", patient, doctor);
            Console.WriteLine(appointment.IsValid ? "Appointment scheduled" : "Something went wrong");
            Console.WriteLine(appointment);


            Console.WriteLine();

            // string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            // Console.WriteLine(appointmentResult2);
            Doctor doctor2 = new Doctor("Armand", "Curandero");
            Patient patient2 = new Patient(23, "Ralf Manson", "5555-555-555");
            Appointment appointment2 = new Appointment("", DateTime.Now, "Queen Street", patient2, doctor2);
            Console.WriteLine(appointment2.IsValid ? "Appointment scheduled" : "Something went wrong");
            Console.WriteLine(appointment2);
        }
    }
}
