namespace Pong
{
    class Ball
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }
    
        public Ball()
        {
            X = 0;
            Y = 0;
            SpeedX = 1;
            SpeedY = 1;
        }
    
        public void Update()
        {
            X += SpeedX;
            Y += SpeedY;
        }
    }
}
