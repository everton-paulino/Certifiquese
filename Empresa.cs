using System;
using System.Collections.Generic;
using System.Text;

namespace Certifique_se
{
    public class Empresa
    {
        public string RazaoSocial { get; set; }

        public string Cnpj { get; set; }

        public virtual void DadosdaEmpresa()
        {
            Console.WriteLine("Razão Social:"+ RazaoSocial);
            Console.WriteLine("CNPJ:" + Cnpj);
        }
    }
}
