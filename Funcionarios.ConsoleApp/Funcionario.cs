using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.ConsoleApp
{
    public class Funcionario
    {
        public int id;
        public string nome;
        public string departamento;
        public double salario;
        public DataDeEntrada dataDeEntrada;
        public string rg;
        public bool estaNaEmpresa;

        public double AumentaSalario(double aumento)
        {
            salario = salario + aumento;
            return salario;
        }

        public void Demite()
        {
            id = 0;
            nome = "";
            departamento = "";
            salario = 0;
            rg = "";
            estaNaEmpresa = false;
        }

        public void Mostra()
        {
            Console.WriteLine();
            Console.WriteLine("ID do funcionario: " + id);
            Console.WriteLine("Nome do funcionario: " + nome);
            Console.WriteLine("Departamento do funcionario: " + departamento);
            Console.WriteLine("Salario do funcionario: " + salario);
            Console.WriteLine("RG do Funcionario: " + rg);
            Console.WriteLine("Dia de entrada: " + dataDeEntrada.dia);
            Console.WriteLine("Mes de entrada: " + dataDeEntrada.mes);
            Console.WriteLine("Ano de entrada: " + dataDeEntrada.ano);

            if (estaNaEmpresa == true)
            {
                Console.WriteLine("Funcionario se encontra na empresa.");
            }
            else
            {
                Console.WriteLine("Funcionario nao se encontra na empresa.");
            }
        }
    }

    public class DataDeEntrada
    {
        public int dia;
        public int mes;
        public int ano;
    }
}
