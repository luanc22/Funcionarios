using System;

namespace Funcionarios.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime agora = new System.DateTime();
            agora = DateTime.Now;
            int horaAgora = agora.Hour;

            Funcionario funcionario1 = new Funcionario();
            DataDeEntrada data1 = new DataDeEntrada();

            funcionario1.id = 1;
            funcionario1.nome = "Luan";
            funcionario1.dataDeEntrada = data1;
            funcionario1.rg = "39.149.402-8";
            funcionario1.departamento = "Dev Jr.";
            funcionario1.salario = 2500;
            data1.dia = 11;
            data1.mes = 3;
            data1.ano = 2022;

            if(horaAgora >= 13 && horaAgora <= 19)
            {
                funcionario1.estaNaEmpresa = true;
            }
            else
            {
                funcionario1.estaNaEmpresa = false;
            }

            funcionario1.Mostra();
            Console.ReadLine();
        }
    }
}
