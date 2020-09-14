using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratos2.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(int funcionarios, string nome, double rendaAnual) :base(nome, rendaAnual)
        {
            Funcionarios = funcionarios;
        }

        public override double Imposto()
        {
            if (Funcionarios < 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }
    }
}
