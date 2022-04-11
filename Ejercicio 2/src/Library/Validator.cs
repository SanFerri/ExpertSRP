namespace Library
{
    public class Validator
    {
        public static bool Validate(string[] data)
        {
            foreach(string d in data)
            {
                if(string.IsNullOrEmpty(d)) return false;
            }
            return true;
        }
    }
}