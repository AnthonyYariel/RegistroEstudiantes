using System;

namespace RegistroEstudiantes.Model
{
    public class CalcularEdad 
    {
        public string Edad (DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Month > fechaActual.Month)
            {
                --edad;
            }

            return edad.ToString();

            

            
        }
    }
}

