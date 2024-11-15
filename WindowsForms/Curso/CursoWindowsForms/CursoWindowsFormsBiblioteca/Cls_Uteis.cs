using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca
{
    public class Cls_Uteis
    {
        public static bool Valida(string cpf)
        {
            return cpf[cpf.Length - 1] != '0' ? true : false;
        }

        public class ChecaForcaSenha
        {
            private string forcaSenha;
            public ChecaForcaSenha(string forcaSenha)
            {
                this.forcaSenha = forcaSenha;
            }

            public string GetForcaSenha()
            {
                if (forcaSenha.Length == 0)
                {
                    return "";
                }
                else if (forcaSenha.Length >= 1 && forcaSenha.Length <= 2)
                {
                    return "Inaceitável";
                }
                else if (forcaSenha.Length >= 3 && forcaSenha.Length <= 4)
                {
                    return "Fraca";
                }
                else if (forcaSenha.Length >= 5 && forcaSenha.Length <= 6)
                {
                    return "Aceitável";
                }
                else if (forcaSenha.Length >= 7 && forcaSenha.Length <= 8)
                {
                    return "Forte";
                }
                else
                {
                    return "Segura";
                }
            }

        }

    }
}
