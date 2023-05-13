namespace DiceRollGame.Game;

class Game
{
    private readonly Dice _dice;
    private readonly int InitialTries;
    public Game(Dice dice)
    {
        _dice = dice;
        InitialTries = ConsoleReader.AskHowManyTurns();
    }

    public GameResult PlayGame()
    {
        var randomNumber = _dice.Roll();

        Console.WriteLine($"O Dado será rodado {InitialTries} vezes !");

        for (int i = 0; i < InitialTries; i++)
        {
            var guessNumber = ConsoleReader.ReadNumber("What is your guess ?");

            if (guessNumber == randomNumber)
            {
                return GameResult.Victory;
            }
            Console.WriteLine("ERROU !");
        }
        return GameResult.Defeat;
    }

    public static void PrintResult(GameResult result)
    {
        var output = (result == GameResult.Victory) ? "Venceu" : "Perdeu";
        Console.WriteLine(output);
    }
}
