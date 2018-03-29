using Alura.DesignPatterns2.Cap1;
using Alura.DesignPatterns2.Cap2;
using Alura.DesignPatterns2.Cap3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Capitulo3();
        }

        static void Capitulo3()
        {
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Victor", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            Console.WriteLine(contrato.Tipo);

            Console.WriteLine(historico.Pega(2).Contrato.Tipo);
        }

        static void Capitulo1()
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela";
        }

        static void Capitulo2()
        {
            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>()
            {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa")
            };
            Piano piano = new Piano();
            piano.Toca(musica);
        }
    }
}
