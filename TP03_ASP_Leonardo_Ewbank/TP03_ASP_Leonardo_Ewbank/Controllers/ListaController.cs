using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TP03_ASP_Leonardo_Ewbank.Models;

namespace TP03_ASP_Leonardo_Ewbank.Controllers
{

    public class ListaController : Controller
    {
        public static List<Aniversariantes> AniverCadastrados { get; set; } = new List<Aniversariantes>();

        public IActionResult Index(string? message)
        {
            ViewBag.Message = message;

            

            return View(AniverCadastrados);
        }
        public IActionResult Novo()
        {
            return View();
        }


        public IActionResult Cadastrar(Aniversariantes model)
        {
            if (ModelState.IsValid == false)
            {
                return View();
            }

            model.Id = Guid.NewGuid();

            AniverCadastrados.Add(model);
            return RedirectToAction("Index", "Lista", new{message = "Cadastrado com sucesso"});
        }

        public IActionResult Detalhes([FromQuery]Guid id)
        {
            var aniver = AniverCadastrados.Where(x => x.Id == id).FirstOrDefault();


            return View(aniver);
        }
        public IActionResult Editar([FromQuery]Guid Id)
        {
            var aniver = AniverCadastrados.Where(x => x.Id == Id).FirstOrDefault();

            return View(aniver);
        }


        public IActionResult Modificar(Guid Id, Aniversariantes model)
        {
            if (ModelState.IsValid == false)
            {
                return View();
            }

            var aniverEdit = AniverCadastrados.Where(x => x.Id == Id).FirstOrDefault();

            aniverEdit.nome = model.nome;
            aniverEdit.sobrenome = model.sobrenome;
            aniverEdit.DataNascimento = model.DataNascimento;

            AniverCadastrados.Remove(aniverEdit);
            AniverCadastrados.Add(aniverEdit);
            return RedirectToAction("Index", "Lista", new { message = "Editado com sucesso" });
        }


        public IActionResult Excluir([FromQuery] Guid Id)
        {
            var aniver = AniverCadastrados.Where(x => x.Id == Id).FirstOrDefault();
            return View(aniver);
        }

        public IActionResult Remover (Guid Id)
        {
            if(ModelState.IsValid == false)
            {
                return View();
            }
            var aniver = AniverCadastrados.Where(x => x.Id == Id).FirstOrDefault();
            AniverCadastrados.Remove(aniver);
            return RedirectToAction("Index", "Lista", new { message = "Removido com Sucesso" });
        }
        
    }
}