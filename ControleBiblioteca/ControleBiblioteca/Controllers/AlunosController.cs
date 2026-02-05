using Microsoft.AspNetCore.Mvc;
using ControleBiblioteca.Models;

namespace ControleBiblioteca.Controllers
{
    public class AlunosController : Controller
    {
        // Lista simulada (apenas para teste)
        private static List<Aluno> alunos = new List<Aluno>();

        public IActionResult Index()
        {
            return View(alunos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            alunos.Add(aluno);
            return RedirectToAction("Index");
        }
    }
}