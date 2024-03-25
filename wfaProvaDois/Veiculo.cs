using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProvaDois
{
    public abstract class Veiculo
    {
        protected string Placa;
        protected int Ano;
        protected Veiculo(string placa, int ano)
        {
            this.Placa = placa;
            this.Ano = ano;

        }

        public string Placa1 { get => Placa; set => Placa = value; }
        public int Ano1 { get => Ano; set => Ano = value; }

        public abstract double Alugar();
        
    }
}
