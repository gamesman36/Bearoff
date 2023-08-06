namespace Bearoff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var die1 = new Die();
            var die2 = new Die();
            ShowRolledDice(die1, die2);
            var checkerCounts = new List<int>() { 0, 0, 0, 3, 5, 7 };
            var board = new Homeboard(checkerCounts);
        }

        static void ShowRolledDice(Die die1, Die die2)
        {
            var roll1 = die1.ShowRoll();
            var roll2 = die2.ShowRoll();

            var rollString = roll1 >= roll2
                ? $"{roll1}-{roll2}"
                : $"{roll2}-{roll1}";

            Console.WriteLine($"The roll is {rollString}.");
        }
    }
}