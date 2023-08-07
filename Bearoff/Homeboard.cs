namespace Bearoff
{
    internal class Homeboard
    {
        private List<int> _checkerCounts;

        public Homeboard(List<int> checkerCounts)
        {
            _checkerCounts = checkerCounts;
            Console.Write("Current board: ");
            string spaced = string.Join(" ", _checkerCounts);
            Console.WriteLine(spaced);
        }
    }
}
