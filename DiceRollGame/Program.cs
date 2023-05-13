global using DiceRollGame.Game;
global using DiceRollGame.UserCommunication;

var random = new Random();
var dice = new Dice(random);
var game = new Game(dice);

GameResult result = game.PlayGame();

Game.PrintResult(result);

Console.ReadKey();


