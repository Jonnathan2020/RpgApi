using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgApi.Models
{
    public class Arma //Classe chamada ARMA
    {
        public int Id {get;set;} //Atributo da classe Id = identificador
        public string Nome {get;set;} = ""; //Atributo da classe Nome = nome do objeto
        public int Dano {get;set; } //Atributo da classe que é considerado um dano que será causado dentro do game
        public Personagem? Personagem { get; set; }
        public int PersonagemId { get; set; }
    }
}