using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;


namespace ByteBank.SistemaAgencia
{
    class TimeHumanizer
    {

        static void main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2018, 6, 30);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(40);  //dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca) + ".";

            Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
