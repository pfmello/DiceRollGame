namespace DiceRollGame.UserCommunication;
public static class ConsoleReader
{
    public static int ReadNumber(string message)
    {
        int output;

        do
        {
            Console.WriteLine(message)
                ;
        } while (!int.TryParse(Console.ReadLine(), out output));

        return output;
    }

    public static int AskHowManyTurns()
    {
        Console.WriteLine("How many turns do you want ?");
        int numberOfTurns = int.Parse(Console.ReadLine());
        return numberOfTurns;
    }
}
