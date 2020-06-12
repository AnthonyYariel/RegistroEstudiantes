using RegistroEstudiantes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroEstudiantes.Data
{
    public interface IMateriaService
    {
        IList<Materia> GetMateriasPorNombre(string texto);
        public Materia GetMateriaporId(int Id);
    }
    public class InMemoryMateriasService : IMateriaService
    {
        IList<Materia> materias;

        public InMemoryMateriasService()
        {
            this.materias = new List<Materia>()
            {
                new Materia {Id = 1, Codigo="01", Nombre="Programación Orientada a Objeto",  Area=Area.Tecnología, Disponible=true, Descripcion="Esta materia es para aprender a programar", Objetivos="Este es el objetivo de esta materia"},
                new Materia {Id = 2, Codigo="02", Nombre="Base de Datos SQL Server 2017", Area=Area.Tecnología, Disponible=true, Descripcion="Esta materia es para aprender a programar", Objetivos="Este es el objetivo de esta materia"},
                new Materia {Id = 3, Codigo="03", Nombre="Algoritmos",    Area=Area.Tecnología, Disponible=true, Descripcion="Esta materia es para aprender a programar", Objetivos="Este es el objetivo de esta materia"},
            };
        }

        public Materia GetMateriaporId(int Id)
        {
            return this.materias.SingleOrDefault(d => d.Id == Id);
        }

        public IList<Materia> GetMateriasPorNombre(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                texto = texto.ToLower();
            }
            return materias.Where(m => string.IsNullOrEmpty(texto) || m.Nombre.ToLower().Contains(texto)).OrderBy(m => m.Nombre).ToList();
        }
    }
}
