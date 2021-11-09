using AumentoSalarial.Models;
using System;
using System.Collections.Generic;

namespace AumentoSalarial
{
    class Program
    {
        static List<Funcionario> funcionario;
        static void Main(string[] args)
        {
            funcionario = new List<Funcionario>();
            Console.WriteLine("Quandos funcionários você deseja Cadastrar?");
            int quantidadeDeFuncionarios = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeDeFuncionarios; i++)
            {
                Console.WriteLine(i + 1 + "º Funcionário:\n");
                Console.WriteLine("Digite o nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o salario:");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o cargo:");
                string cargo = Console.ReadLine();
                double aumento = RetornaAumento(salario);
                funcionario.Add(new Funcionario(nome, salario, cargo, aumento));
                Console.Clear();
            }
            foreach(Funcionario item in funcionario)
            {
                Console.WriteLine("Nome do Funcionário:"+item.nome);
                Console.WriteLine("Salario do Funcionário:" + item.salario);
                Console.WriteLine("Cargo do Funcionário:" + item.cargo);
                Console.WriteLine("AUMENTO do Funcionário:" + item.aumentoSalario+"\n");
                
            }
        }
        public static double RetornaAumento(double salario)
        {
            double aumento = 0;
            if (salario >= 2000)
            {
                aumento = salario * 1;
            }
            else
            {
                aumento = salario * 0.8;
            }
            
            return aumento;
        }
    }
}
