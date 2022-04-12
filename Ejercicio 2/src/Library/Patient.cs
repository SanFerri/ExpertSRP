namespace Library
{
    /// <summary>
    /// ¿Quien debe conocer toda informacion valiosa para un paciente?
    /// (edad, nombre, y telefono)
    /// Por expert deberia ser Patient, quien crea al paciente.
    /// </summary>
    public class Patient
    {
        //t(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string 
        public int Age {get; private set;}
        public string Name {get; private set;}
        public string Phone {get; private set;}
        public bool IsValid {get; private set;}

        public Patient(int age, string name, string phone)
        {
            this.IsValid = Validator.Validate(new string[]{name, phone});
            this.Age = age;
            this.Name = name;
            this.Phone = phone;
        }

          public override string ToString()
        {
            return this.IsValid ? 
            $"Patient, name: {this.Name}, Age: {this.Age}, Phone: {this.Phone}." 
            : "Invalid Patient.";
        }
        
    }
}