using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegistroEstudiantes.Data;
using RegistroEstudiantes.Model;

namespace RegistroEstudiantes.Pages.Estudiantes
{
    public class DetalleEstudianteModel : PageModel
    {
        private readonly IEstudianteService service;
        public Estudiante Estudiante { get; set; }
        public DetalleEstudianteModel(IEstudianteService service)
        {
            this.service = service;
        }
        public IActionResult OnGet(int Id)
        {
            Estudiante = service.GetEstudianteporId(Id);

            if (Estudiante == null)
            {
                return RedirectToPage("EstudianteNoEncontrado");
            }
            else
            {
                return Page();
            }
        }
    }
}