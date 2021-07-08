using System;
using System.Collections.Generic;
using System.Text;

namespace Certifique_se
{
    public class Certificado:Empresa
    {
        public Certificado()
        {
           this.Key = Guid.NewGuid().ToString();            
            
        }
        public override void DadosdaEmpresa()
        {
            Console.WriteLine(base.RazaoSocial);
            Console.WriteLine(base.RazaoSocial);
        }

        public string Key { get; set; }
        public int Curso { get; set; }

        public string Instrutor { get; set; }

        public string Cargo { get; set; }

        public DateTime DatadoCurso { get; set; }

        public string RG { get; set; }

        public string NomedoAluno { get; set; }

        public string Escolhido { get; set; }
    }
}
