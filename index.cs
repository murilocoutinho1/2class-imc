using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace App2
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string nome = "";
            float peso, altura, imc;
            WriteLine("Escreva o nome do(a) da pessoa:");
            nome = ReadLine();
            WriteLine("Digite o peso:");
            peso = float.Parse(ReadLine());
            WriteLine("Digite a altura:");
            altura = float.Parse(ReadLine());
            imc = peso / (altura * altura);
            WriteLine($"O IMC do(a) {nome} resultou em: {imc}");
            ReadKey();
        }
    }
}