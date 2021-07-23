using System;

namespace POO_Back_End_Rec3.Models
{
    public class Participante : Usuário
    {
        public string ConfirmarChegada(){
            
            return "Confirmado em todos os dias";
        }

        public string ConfimadoNaData(string nome){
            return $"Confimado no dia {nome}";
        }
        
        
        
    }
}