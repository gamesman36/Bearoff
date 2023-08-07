namespace Bearoff
{
    internal class Program
    {
        static readonly Random random = new Random();
        static void Main(string[] args)
        {
            var die1 = new Die();
            var die2 = new Die();
            var checkerCounts = new List<int>();
            checkerCounts = CreateBoard(checkerCounts);
            ShowRolledDice(die1, die2);
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

        static List<int> CreateBoard(List<int> checkerCounts)
        {
            int checkersToDistribute = 15;

            for (int i = 0; i < 6; i++)
            {
                if (checkersToDistribute > 0)
                {
                    int maxCheckers = Math.Min(checkersToDistribute, 5);
                    int numberOfCheckers = random.Next(1, maxCheckers + 1);
                    int remainder = checkersToDistribute - numberOfCheckers;
                    checkerCounts.Add(numberOfCheckers);
                    checkersToDistribute = remainder;
                }

                else
                {
                    checkerCounts.Add(0);
                }
            }
            return checkerCounts;
        }
    }
}