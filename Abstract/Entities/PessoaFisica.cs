using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(double gastosSaude, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }
       
        public override double CalculoImposto()
        {
            double abatimento = GastosSaude * 0.50;
            if (RendaAnual < 20000)
            {
                return (RendaAnual * 0.15) - abatimento;
            }
            else
            {
                return (RendaAnual * 0.25) - abatimento;
            }
        }
    }
}
