using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;

namespace RpgApi.Controllers
{

    [ApiController]
    [Route("[controller]")] //definido a rota para o controller

    public class PersonagensController : ControllerBase //Classe da controler referente aos personagens
    {
        private readonly DataContext _context; //Declaração de atributos

        public PersonagensController(DataContext context)
        {
            //Inicialização do atributo a partir de um parâmetro
            _context = context;
        }

        [HttpGet("{id}")] //buscar pelo id
        public async Task<IActionResult> GetSingle(int id)
        {
            try //tenta executar essa função
            {
                //Busca um objeto dentro da classe personagem que o número do seu id seja igual ao id pesquisado
                Personagem p = await _context.TB_PERSONAGENS.FirstOrDefaultAsync(pBusca => pBusca.Id == id);
                return Ok(p); //Retorna uma mensagem de sucesso exibindo informações do objeto
            }
            catch(System.Exception ex) //Caso dê errado, o sistema tratará a excessão aqui
            {
                return BadRequest(ex.Message); //Retorna uma mensagem de erro pré-definida
            }
        }

        [HttpGet("GetAll")] //Buscar todos

        public async Task<IActionResult> Get()
        {
            try //tenta executar essa função
            {
                List<Personagem> lista = await _context.TB_PERSONAGENS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex) //Caso dê errado, o sistema tratará a excessão aqui
            {
                return BadRequest(ex.Message); //Retorna uma mensagem de erro pré-definida
            }
        }
        
        [HttpPost] //Postagem, adicionando personagem novo

        public async Task<IActionResult> Add(Personagem novoPersonagem)
        {
            try //tenta executar essa função
            {
                if(novoPersonagem.PontosVida > 100)
                {
                    throw new Exception("Pontos de vida não pode ser maior que 100");
                }
                await _context.TB_PERSONAGENS.AddAsync(novoPersonagem);
                await _context.SaveChangesAsync();

                return Ok(novoPersonagem.Id);
            }
            catch(System.Exception ex) //Caso dê errado, o sistema tratará a excessão aqui
            {
                return BadRequest(ex.Message); //Retorna uma mensagem de erro pré-definida
            }
        }

        [HttpPut]

        public async Task<IActionResult> Update(Personagem novoPersonagem)
        {
            try //tenta executar essa função
            {
                if(novoPersonagem.PontosVida >100)
                {
                    throw new System.Exception("Pontos de vida não pode ser maior que 100");
                }

                _context.TB_PERSONAGENS.Update(novoPersonagem);
                int linhasAfetadas = await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex) //Caso dê errado, o sistema tratará a excessão aqui
            {
                return BadRequest(ex.Message); //Retorna uma mensagem de erro pré-definida
            }
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            try //tenta executar essa função
            {
                Personagem pRemover = await _context.TB_PERSONAGENS.FirstOrDefaultAsync(p => p.Id == id);

                _context.TB_PERSONAGENS.Remove(pRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);
            }
            catch(System.Exception ex) //Caso dê errado, o sistema tratará a excessão aqui
            {
                return BadRequest(ex.Message); //Retorna uma mensagem de erro pré-definida
            }
        }


    }   //Fim da classe do tipo Controller
}