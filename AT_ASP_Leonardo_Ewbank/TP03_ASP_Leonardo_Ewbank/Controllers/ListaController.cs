using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TP03_ASP_Leonardo_Ewbank.Models;
using TP03_ASP_Leonardo_Ewbank.Repository;

namespace TP03_ASP_Leonardo_Ewbank.Controllers
{

    public class ListaController : Controller
    {
        private AniversarianteRepository AniversarianteRepository { get; set; }
        public ListaController(AniversarianteRepository aniversarianteRepository)
        {
            this.AniversarianteRepository = aniversarianteRepository; 
        }

        public IActionResult Index(string? message, string? searchName)
        {
            ViewBag.Message = message;

            if (!String.IsNullOrEmpty(searchName))
            {
                var Encontrados = AniversarianteRepository.BuscarPorNome(searchName);
                return View(Encontrados);
            }

            return View(AniversarianteRepository.ListarTodos());
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

            AniversarianteRepository.Salvar(model);
            
            return RedirectToAction("Index", "Lista", new{message = "Cadastrado com sucesso"});
        }

        public IActionResult Detalhes([FromQuery]Guid id)
        {
            var aniver = AniversarianteRepository.BuscarPorId(id);


            return View(aniver);
        }
        public IActionResult Editar([FromQuery]Guid Id)
        {
            var aniver = AniversarianteRepository.BuscarPorId(Id);

            return View(aniver);
        }

        public IActionResult Modificar(Guid Id, Aniversariantes model)
        {
            if (ModelState.IsValid == false)
            {
                return View();
            }

            var aniverEdit = AniversarianteRepository.BuscarPorId(Id);
            

            aniverEdit.nome = model.nome;
            aniverEdit.sobrenome = model.sobrenome;
            aniverEdit.DataNascimento = model.DataNascimento;

            AniversarianteRepository.Editar(aniverEdit);
            return RedirectToAction("Index", "Lista", new { message = "Editado com sucesso" });
        }

        public IActionResult Excluir([FromQuery] Guid Id)
        {
            var aniver = AniversarianteRepository.BuscarPorId(Id);
            return View(aniver);
        }

        public IActionResult Remover (Guid Id)
        {
            if(ModelState.IsValid == false)
            {
                return View();
            }
            var aniver = AniversarianteRepository.BuscarPorId(Id);
            AniversarianteRepository.Deletar(Id);
            return RedirectToAction("Index", "Lista", new { message = "Removido com Sucesso" });
        }
        
    }
}