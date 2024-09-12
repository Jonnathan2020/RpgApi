using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Controllers
{
    [Route("[controller]")]
    public class PersonagensExercicioController : Controller
    {
        private static List<Personagem> personagens = new List<Personagem>()
        {
            new Personagem(){ Id = 1, Nome= "Frodo", PontosVida = 100, Forca = 17, Defesa = 23, Inteligencia = 33, Classe = Models.Enuns.ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=Models.Enuns.ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=Models.Enuns.ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=Models.Enuns.ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=Models.Enuns.ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=Models.Enuns.ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=Models.Enuns.ClasseEnum.Mago }
        };

        //Métodos Solicitados

        //a
        [HttpGet("{GetByName}")]
        public IActionResult GetByName(string GetByName)
        {
            List<Personagem> buscaNome = personagens.FindAll(p => p.Nome.Contains(GetByName));
            if(GetByName != null)
            {
                return Ok("Os personagens encontrados foram: " + buscaNome);
            }
            return NotFound();
        }


        //b
        [HttpGet("{GetClerigoMago}")]

        public IActionResult GetClerigoMago()
        {
            List<Personagem> listaBusca = personagens.FindAll(p => p.Classe != ClasseEnum.Cavaleiro).OrderByDescending(pp => pp.PontosVida).ToList();
            return Ok(listaBusca);
        }

        //c
        [HttpGet("GetContagem")]

        public IActionResult GetQuantidade()
        {
            return Ok("Quantidade de personagens é: " + personagens.Count);
            return Ok($"O somatório de inteligencia dos personagens é: {personagens.Sum(p => p.Inteligencia)}");
        }

        //d
        [HttpPost]
        public IActionResult AddPersonagem(Personagem novoPersonagem)
        {
            if(novoPersonagem.Defesa <10 || novoPersonagem.Inteligencia >30)
            {
                return BadRequest("O valor de defesa é menor que 10 ou inteligência é maior que 30. Portanto, não é possível adicionar o personagem");
            }
            else
            {
                return Ok("Personagem incluído com sucesso");
            }
        }

        //e
        [HttpPost]

        public IActionResult AddPersonagemMago(Personagem novoPersonagem)
        {
            if(novoPersonagem.Classe == ClasseEnum.Mago)
            {
                if(novoPersonagem.Inteligencia > 35)
                {
                    return Ok("Personagem incluído com sucesso");
                }
                else
                {
                    return BadRequest("O valor de inteligência não foi suficiente. Portanto não foi possível add personagem");
                }
            }
            else
            {
                if(novoPersonagem.Defesa <10 || novoPersonagem.Inteligencia >30)
                {
                    return BadRequest("O valor de defesa é menor que 10 ou inteligência é maior que 30. Portanto, não é possível adicionar o personagem");
                }
                else
                {
                    return Ok("Personagem incluído com sucesso");
                }
            }
        }

        //f
        [HttpGet("GetByClasse/{Classe}")]
        public IActionResult Get(ClasseEnum Classe)
        {
            List<Personagem> listaBusca = personagens.FindAll(p => p.Classe == Classe);

            return Ok(listaBusca);
        }
    }
}