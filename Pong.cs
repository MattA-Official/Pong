using System;
using System.Threading;

namespace Pong
{
    class Pong
    {
        private Paddle leftPaddle;
        private Paddle rightPaddle;
        private Ball ball;
        private GameState gameState;

        public void Start()
        {
            // Determine the height of the screen
            int minPos = Console.WindowTop;
            int maxPos = Console.WindowHeight - 1;
            leftPaddle = new Paddle(minPos, maxPos);
            rightPaddle = new Paddle(minPos, maxPos);

            ball = new Ball();

            gameState = GameState.Playing;

            while (true)
            {
                // Get correct game state
                if (gameState == GameState.Playing)
                {
                    // handle user input
                    HandleInput();

                    // update game state
                    Update();

                    // draw the game to the screen
                    Draw();
                }
                else if (gameState == GameState.Paused)
                {
                    // handle user input
                    HandlePauseMenuInput();

                    // draw the game to the screen
                    DrawPauseMenu();
                }
                else if (gameState == GameState.MainMenu)
                {
                    // handle user input
                    HandleMenuInput();

                    // draw the game to the screen
                    DrawMenu();
                }
                else if (gameState == GameState.GameOver)
                {
                    // handle user input
                    HandleGameOverInput();

                    // draw the game to the screen
                    DrawGameOver();
                }

                // wait for a short time to limit the frame rate
                Thread.Sleep(1000 / 60); // sleep for 1/60th of a second
            }
        }

        void HandleInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        leftPaddle.MoveUp();
                        break;
                    case ConsoleKey.S:
                        leftPaddle.MoveDown();
                        break;
                    case ConsoleKey.UpArrow:
                        rightPaddle.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        rightPaddle.MoveDown();
                        break;
                    case ConsoleKey.Escape:
                        gameState = GameState.Paused;
                        break;
                    default:
                        break;
                }
            }
        }

        void Update()
        {
            throw new NotImplementedException();
        }

        void Draw()
        {
            throw new NotImplementedException();
        }

        private void HandlePauseMenuInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.R:
                        gameState = GameState.Playing;
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private void DrawPauseMenu()
        {
            Console.Clear();
            Console.WriteLine("Game Paused");
            Console.WriteLine("Press 'R' to resume");
            Console.WriteLine("Press 'Q' to quit");
        }

        void HandleMenuInput()
        {
            throw new NotImplementedException();
        }

        void DrawMenu()
        {
            throw new NotImplementedException();
        }

        void HandleGameOverInput()
        {
            throw new NotImplementedException();
        }

        void DrawGameOver()
        {
            throw new NotImplementedException();
        }
    }
}
