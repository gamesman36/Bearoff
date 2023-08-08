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
            var moveList = ShowMoveList(die1, die2);
            Console.Write("Numbers to move: ");
            string spaced = string.Join(" ", moveList);
            Console.WriteLine(spaced);
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

        static List<int> ShowMoveList(Die die1, Die die2)
        {
            var moveList = new List<int>();

            if (die1.ShowRoll() != die2.ShowRoll())
            {
                moveList.Add(die1.ShowRoll());
                moveList.Add(die2.ShowRoll());
            }

            else
            {
                for (int i = 0; i < 4; i++)
                {
                    moveList.Add(die1.ShowRoll());
                }
            }

            return moveList;
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