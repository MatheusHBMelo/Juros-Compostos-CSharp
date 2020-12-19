// Código desenvolvido para atividade - Juros compostos em C# - Matheus Henrique
using System;
class ProgramaAulaCSharp {
  static void Main() {
    decimal valor, juros, taxa, jurostot, v1; // Escopo das variaveis
    int prazo, contador;

Console.Write("Digite o capital inicial: ");   // Entrada do capital
valor = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o prazo a ser calculado(meses): "); // Entrada dos meses
prazo = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a taxa de juros ao mês: "); // Entrada dos juros ao mês
taxa = Convert.ToDecimal(Console.ReadLine());

v1 = valor;
contador = 0; 
do      // Inicio de repetição do contador de acordo com o prazo                        
{ // Inicio da formula
  juros = valor * taxa / 100;
  juros = Math.Round(juros, 2);
  valor = valor + juros;
  contador = contador + 1;
  Console.WriteLine("Mes " + contador + " - Valor = R$ " + valor + " - O juros mensal foi de: R$" + juros);
} while (contador < prazo);
jurostot = valor - v1;
Console.WriteLine("\nMontante final: R$" + valor + " - O juros total foi de: R$" + jurostot);
Console.ReadKey();    
  }
}