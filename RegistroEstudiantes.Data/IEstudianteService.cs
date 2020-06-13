using Microsoft.VisualBasic;
using RegistroEstudiantes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroEstudiantes.Data
{
    public interface IEstudianteService
    {
        IList<Estudiante> GetEstudiantePorNombre(string texto);
        public Estudiante GetEstudianteporId(int Id);
    }
    public class InMemoryestudiantesService : IEstudianteService
    {
        IList<Estudiante> estudiante;

        public InMemoryestudiantesService()
        {
            this.estudiante = new List<Estudiante>()
            {
                new Estudiante {Id = 1, Matricula="ARB09-2020", Apellido="Reynoso", Nombre="Anthony", Estatus="Activo",  Cedula="001-1907312-0", Correo="ing.anthonyreynoso@gmail.com", Telefono="829-638-0702", Sexo=Sexo.Masculino},
                new Estudiante {Id = 2, Matricula="YOE28-2018", Apellido="Ortiz",   Nombre="Yaritssa",Estatus="Activo",  Cedula="001-2352122-5", Correo="yaritssaOrtize2826@gmail.com", Telefono="809-621-1916", Sexo=Sexo.Femenino},
                new Estudiante {Id = 3, Matricula="ABM07-2015", Apellido="Bautista",Nombre="Alida",   Estatus="Activo",  Cedula="001-0355072-9", Correo="prof.alidabautista@gmail.com", Telefono="829-638-4884", Sexo=Sexo.Femenino},
                new Estudiante {Id = 4, Matricula="LRR14-2016", Apellido="Reynoso", Nombre="Luis",    Estatus="Inactivo",Cedula="001-0355400-2", Correo="luisrreynoso140910@gmail.com", Telefono="829-440-3239", Sexo=Sexo.Masculino},
                new Estudiante {Id = 5, Matricula="LOR09-2019", Apellido="Bautita", Nombre="Luciano", Estatus="Retirado",Cedula="001-1945611-9", Correo="lomarbautistag0928@gmail.com", Telefono="829-638-1612", Sexo=Sexo.Masculino},
            };
        }

        public Estudiante GetEstudianteporId(int Id)
        {
            return this.estudiante.SingleOrDefault(d => d.Id == Id);
        }

        public IList<Estudiante> GetEstudiantePorNombre(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                texto = texto.ToLower();
            }

            return estudiante.Where(m => string.IsNullOrEmpty(texto) || m.Nombre.ToLower().Contains(texto)).OrderBy(m => m.Nombre).ToList();
        }

    }
}
