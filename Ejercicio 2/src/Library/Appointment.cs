using System;

namespace Library
{
    public class Appointment
    {
        public string Identifier {get; private set;}
        public DateTime Date {get; private set;}
        public string Place {get; private set;}
        public Patient Patient {get; private set;}
        public Doctor Doctor {get; private set;}
        public bool IsValid {get; private set;}

        public Appointment(string identifier, DateTime date, string place, Patient patient, Doctor doctor)
        {
            this.IsValid = Validator.Validate(new string[]{identifier, place}) && patient.IsValid && doctor.IsValid;
            this.Identifier = identifier;
            this.Date = date;
            this.Place = place;
            this.Patient = patient;
            this.Doctor = doctor;
        }


        public override string ToString()
        {
            return this.IsValid ? 
            $"Appointment taking place at {this.Place} on {this.Date.ToString()}. Patient: ({this.Patient}), Doctor: ({this.Doctor})." 
            : "Invalid appointment.";
        }
        
    }
}