namespace Bearoff
{
    internal class Die
    {
        private Random _random = new Random();
        private int _valueShown;

        public Die()
        {
            Roll();
        }

        public void Roll()
        {
            _valueShown = _random.Next(1, 7);
        }

        public int ShowRoll()
        {
            return _valueShown;
        }
    }
}
