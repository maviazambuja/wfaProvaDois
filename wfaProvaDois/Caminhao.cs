using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProvaDois
{
    class Caminhao: Veiculo
    {
        private int eixos;
        public Caminhao(string Placa, int Ano, int eixos) : base(Placa, Anoveiculo)
        {
            this.eixos = eixos;

        }

        public int Eixos { get => eixos; set => eixos = value; }

        public override double CalculoAluguel()
        {
            double diaria;
            diaria = (300 * eixos) - (2024 - Anoveiculo) * 50;
            return diaria;
        }
}
