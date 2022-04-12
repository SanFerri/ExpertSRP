using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// El codigo no cumple con el principio SRP, ya que hay mas de 1 razon para cambiar la clase
    /// la primera es que se podria tener que agregar nuevos valores del paciente como su edad, y
    /// tambien es posible que en un futuro se precise conocer la especialidad del doctor, ademas de
    /// que es necesario verificar todos estos datos asi que minimo hay unas 4 razones de cambio.
    /// 
    /// Para cumplir con SRP primero crearia 3 clases nuevas, una que sea paciente, una
    /// appointment y la otra doctor.
    /// </summary>
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }


    }
}
