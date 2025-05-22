using System;
using CompuertasLogicas.Library;

namespace CompuertasLogicas.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //aca vemos las AND 
            Console.WriteLine("Pruebas and:");
            AndGate andGate1 = new AndGate(false, false);
            Console.WriteLine($"entran dos bool false y sale: {andGate1.Output()}");
            AndGate andGate2 = new AndGate(false, true);
            Console.WriteLine($"entra un bool false y otro true y sale: {andGate2.Output()}");
            AndGate andGate3 = new AndGate(true, false);
            Console.WriteLine($"entra un bool true y otro flase y sale: {andGate3.Output()}");
            AndGate andGate4 = new AndGate(true, true);
            Console.WriteLine($"entran dos true y sale : {andGate4.Output()}");

            //aca vemos las or
            Console.WriteLine("Pruebas or");
            OrGate orGate1 = new OrGate(false, false);
            Console.WriteLine($"entran dos bool false y sale: {orGate1.Output()}");
            OrGate orGate2 = new OrGate(false, true);
            Console.WriteLine($"entra un bool false y otro true y sale : {orGate2.Output()}");
            OrGate orGate3 = new OrGate(true, false);
            Console.WriteLine($"entra un bool true y otro false y sale: {orGate3.Output()}");
            OrGate orGate4 = new OrGate(true, true);
            Console.WriteLine($"entran dos bool true y sale: {orGate4.Output()}");

            //aca vemos las not
            Console.WriteLine("Pruebas not");
            NotGate notGate1 = new NotGate(false);
            Console.WriteLine($"entra un bool false y  sale: {notGate1.Output()}");
            NotGate notGate2 = new NotGate(true);
            Console.WriteLine($"entra un bool true y sale: {notGate2.Output()}");
        }
    }
}