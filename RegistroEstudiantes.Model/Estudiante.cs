using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroEstudiantes.Model
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Edad { get; set; }
        public Sexo Sexo { get; set; }
        public string Estatus { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

    }
}

