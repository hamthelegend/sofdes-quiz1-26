// See https://aka.ms/new-console-template for more information

using SofdesQuiz1_26;

Console.WriteLine("What integers do you want to multiply?");
var a = Extensions.ForceReadIntegerLine("a");
var b = Extensions.ForceReadIntegerLine("b");
var aluMachine = new AluMachine(a, b);
aluMachine.PrintResult();