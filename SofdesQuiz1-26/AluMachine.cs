using System.Diagnostics.CodeAnalysis;

namespace SofdesQuiz1_26;

public record AluMachine(
    int A,
    int B
){

    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    public int Multiply() {
        return A * B;
    }

    public void PrintResult() {
        Console.WriteLine($"{A} * {B} = {Multiply()}");
    }
    
}