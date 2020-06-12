using System;

namespace Aula15
{
    public class Permissao
    {
        public Permissao()
        {
        }

        public Permissao(bool permitir) 
        {
            this.Permitir = permitir;
               
        }
                public bool Permitir {get; set;}

        public void Autorizar(){

            Console.WriteLine("Deseja permitir acesso? Digite true ou false");
            
            try{
                Permitir = Boolean.Parse(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Erro na aplicação! Dados inválidos!");
            }

        }
    }
}