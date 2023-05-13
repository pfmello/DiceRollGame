global using DiceRollGame.Game;
global using DiceRollGame.UserCommunication;
// Utilizando Single-Responsibility-Principle, o primeiro dos princípios SOLID

var random = new Random();
var dice = new Dice(random);
var game = new Game(dice);

GameResult result = game.PlayGame();

Game.PrintResult(result);

Console.ReadKey();


