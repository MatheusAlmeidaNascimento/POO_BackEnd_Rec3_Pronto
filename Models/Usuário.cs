using System;
using System.Collections.Generic;
using System.IO;

namespace POO_Back_End_Rec3.Models
{
    public abstract class Usuário
    {
        public string Nome { get; set; } 
        public string Email { get; set; }
        protected string Senha { get; set; }

        public virtual void Logar(){
            
        }
        public List<string> ReadAllLinesCSV(string PATH){
            
            List<string> linhas = new List<string>();
            using(StreamReader file = new StreamReader(PATH))
            {
                string linha;
                while((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }
            return linhas;
        }
        
    }

}