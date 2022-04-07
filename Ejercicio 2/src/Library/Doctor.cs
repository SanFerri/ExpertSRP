namespace Library
{
    public class Doctor
    {
        public string Name {get; private set;}
        public string Specialization {get; private set;}
        public bool IsValid {get; private set;}

        public Doctor(string name, string specialization)
        {
            this.IsValid = Validator.Validate(new string[]{name, specialization});
            this.Name = name;
            this.Specialization = specialization;
        }

        
          public override string ToString()
        {
            return this.IsValid ? 
            $"Doctor, name: {this.Name}, Specialization: {this.Specialization}." 
            : "Invalid Doctor.";
        }
    }
}