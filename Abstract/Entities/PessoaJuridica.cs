using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int NumFuncionarios { get; set; }

        public PessoaJuridica(int numFuncionarios, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double CalculoImposto()
        {
           if( NumFuncionarios > 10) 
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
