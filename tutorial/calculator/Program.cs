// See https://aka.ms/new-console-template for more information
namespace calculator;

// Main read function
public class Calculator{
    // static make the function global and doesn't need to create "new" object for initialization
    static void Main(){
        Console.WriteLine("Calculadora");
        sum(10, 15);
        substract(10, 15);
        division(10, 15);
        multiplication(10, 15);
    }

    static void sum(int a, int b){
        double result;
        result = a + b;
        Console.WriteLine($"Resultado de la suma {a} + {b} = {result}");
    }

    static void substract(int a, int b){
        double result;
        result = a - b;
        Console.WriteLine($"Resultado de la resta {a} - {b} = {result}");
    }

    static void division(double a, double b){
        double result;
        result = a / b;
        Console.WriteLine($"Resultado de la division {a} / {b} = {result}");
    }

    static void multiplication(int a, int b){
        double result;
        result = a * b;
        Console.WriteLine($"Resultado de la multiplicación {a} * {b} = {result}");
    }

}
