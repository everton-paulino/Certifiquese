using System;
using System.Collections.Generic;

namespace Certifique_se
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();

            List<Certificado> ListadeCertificados = new List<Certificado>();

            Console.WriteLine("Razão Social");
            empresa.RazaoSocial = Convert.ToString(Console.ReadLine());

            Console.WriteLine("CNPJ");
            empresa.Cnpj = Convert.ToString(Console.ReadLine());

            
            Console.WriteLine("Para adicionar um aluno, Tecle S");
            string GeraCertificado = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite o número do Curso escolhido");
            Console.WriteLine("1. NR 6 - Equipamento de proteção Individual - EPI ");
            Console.WriteLine("2. NR 33 - Segurança e Saúde nos trabalhos em Espaço Confinados");
            Console.WriteLine("3. NR 35 - Segurança e Saúde no trabalhos em Altura");
            int EscolhidoCurso = Convert.ToInt32(Console.ReadLine());

            EscolheCurso escolhe = new EscolheCurso();
            string CursoSelecionado = escolhe.CursoEscolhido(EscolhidoCurso);

             

            Console.WriteLine("Data do Curso - DD/MM/AAAA");
            DateTime Cursodata = Convert.ToDateTime(Console.ReadLine());

            while (GeraCertificado == "S" || GeraCertificado == "s")
            {
                Certificado certificado = new Certificado();

                certificado.Key = Convert.ToString(Console.ReadLine());

                Console.ReadLine();
                
                certificado.DatadoCurso = Cursodata;
                Console.ReadLine();
                

                certificado.Escolhido = CursoSelecionado;
                Console.ReadLine();

                Console.WriteLine("Nome do Aluno");
                certificado.NomedoAluno = Convert.ToString(Console.ReadLine());

                Console.WriteLine("RG do Aluno");
                certificado.RG = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Cargo do Aluno");
                certificado.Cargo = Convert.ToString(Console.ReadLine());

                ListadeCertificados.Add(certificado);

                Console.WriteLine("Para adicionar mais um aluno, Tecle S");
                GeraCertificado = Convert.ToString(Console.ReadLine());
            }
                      
            foreach (var item in ListadeCertificados)
            {
                Console.WriteLine(" Certifico que " + item.Cargo + item.NomedoAluno +" Portador do RG: " + item.RG);
                Console.WriteLine(" pertecente a Empresa " + empresa.RazaoSocial + "CNPJ" + empresa.Cnpj);
                Console.WriteLine(", concluiu o Curso -" + item.Escolhido + " na data " + item.DatadoCurso);
                               
            }
            //Console.WriteLine("LISTA DE PRESENÇA");
            //Console.WriteLine(" Curso " + CursoSelecionado);
            //Console.WriteLine(" Data: " + Cursodata);
            //Console.WriteLine(" Empresa " + empresa.RazaoSocial + "- CPNJ :" +empresa.Cnpj);
            //Console.WriteLine("PARTICIPANTES");
            //Console.WriteLine("Nome" ); 




        }
    }
}
