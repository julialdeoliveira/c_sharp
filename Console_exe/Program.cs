using Console_exe.exercicios;
using Console_exe.TipoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TipoNumerico tipo1 = new TipoNumerico();
            tipo1.Executar();
            BemVindo.Salutar();
            TipoNumerico2.Executa();
            Cadastro.Cadastrar();
        }
    }
}
