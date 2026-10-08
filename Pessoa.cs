using System;
using System.Collections.Generic;
using System.Text;

namespace POOFundamentos
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public void Apresentar()
        {
            Console.WriteLine("Olá! eu sou " + Nome);
        }

        public string ApresentarNovo()
        {
            return "Olá! eu sou " + Nome;
        }
    }
}
