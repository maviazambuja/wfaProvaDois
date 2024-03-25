using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProvaDois
{
    class Onibus : Veiculo
    {
        private int assentos;
        public Onibus(string Placa, int Ano, int Assentos) : base(Placa, Ano)
        {
            this.assentos = Assentos;

        }

        public int Assentos { get => assentos; set => assentos = value; }

        public override double CalculoAluguel()
        {
            double diaria;
            diaria = (30 * Assentos) - (2024 - Ano) * 70;
            return diaria;
        }
    }
}
