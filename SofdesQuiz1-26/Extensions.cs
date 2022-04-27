namespace SofdesQuiz1_26;

public static class Extensions{
    
    public static int ToInt(this string receiver) {
        return int.Parse(receiver);
    }
    
    public static int ForceReadIntegerLine(string label, int tabs = 1) {
        int integer;
        
        while (true) {
            Console.Write($"{label}: {new string('\t', tabs)}");

            try {
                integer = Console.ReadLine()?.ToInt() ?? 0;
                break;
            }
            catch (FormatException) {
                Console.WriteLine($"{label} must be an integer.");
            }
        }

        return integer;
    }
}