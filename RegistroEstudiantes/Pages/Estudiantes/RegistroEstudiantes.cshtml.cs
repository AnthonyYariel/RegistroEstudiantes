using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using RegistroEstudiantes.Data;
using RegistroEstudiantes.Model;

namespace RegistroEstudiantes.Pages.Estudiantes
{
    public class RegistroEstudiantesModel : PageModel
    {
        private IConfiguration config;
        public IEstudianteService EstudianteService;

    
        public string Mensaje { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Texto { get; set; }

        public IList<Estudiante> Estudiantes;

        public RegistroEstudiantesModel(IConfiguration config, IEstudianteService estudianteService)
        {
            this.config = config;
            EstudianteService = estudianteService;
        }

        public void OnGet()
        {
            this.Mensaje = config["Mensaje"];
            this.Estudiantes = EstudianteService.GetEstudiantePorNombre(Texto);
        }
        
    }
}