namespace Pong
{
    class Paddle
    {
        public int Position { get; set; }
        public int Score { get; set; }
        private int maxPosition;
        private int minPosition;

        public Paddle(int minPos, int maxPos)
        {
            Position = 0;
            Score = 0;
            minPosition = minPos;
            maxPosition = maxPos;
        }

        public void MoveUp()
        {
            if (Position > minPosition)
                Position--;
        }

        public void MoveDown()
        {
            if (Position < maxPosition)
                Position++;
        }
    }
}
