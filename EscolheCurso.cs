using System;
using System.Collections.Generic;
using System.Text;

namespace Certifique_se
{
    public class EscolheCurso
    {
        public string CursoEscolhido(int curso)
        {
            string  retorno = "";

            if (curso == 1)
            {
                retorno = "NR 6 - Equipamento de proteção Individual - EPI";
            }
            

            else if (curso == 2 )
            {
                retorno = "NR 33 - Segurança e Saúde nos trabalhos em Espaço Confinados";
            }

            else if (curso ==3 )
            {
                retorno = "NR 35 - Segurança e Saúde no trabalhos em Altura";
            }

            else
            {
                retorno = "Escolha um dos Cursos, conforme lista acima";
            }
            return retorno;

        }
    }
}
