using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using RegistroEstudiantes.Data;
using RegistroEstudiantes.Model;

namespace RegistroEstudiantes.Pages.Materias
{
    public class RegistroMateriasModel : PageModel
    {
        private IConfiguration config;
        public IMateriaService MateriaService;

        public string Mensaje { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Texto { get; set; }

        public IList<Materia> Materias;

        public RegistroMateriasModel(IConfiguration config, IMateriaService materiaService)
        {
            this.config = config;
            MateriaService = materiaService;
        }

        public void OnGet()
        {
            this.Mensaje = config["Mensaje"];
            this.Materias = MateriaService.GetMateriasPorNombre(Texto);
        }
    }
}