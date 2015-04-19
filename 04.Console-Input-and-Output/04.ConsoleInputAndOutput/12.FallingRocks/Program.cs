//  * Implement the "Falling Rocks" game in the text console. 
// A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). 
// A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.

//  Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. 
// The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).

//  Implement collision detection and scoring system.



// I couldnt make the dwarf with the given symbol so I made it with #. I wanted to make all the rocks look the same and to be gray color
// to be "realistic". 
// The symbol ↓ (yellow) gives you 300 points and slows the speed by 10.
// The symbol ♥ (pink) gives you 500 points and 1 to life.
// The game speed increases every second.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallingRocks
{
    struct Object
    {
        public int x;
        public int y;
        public char c;
        public ConsoleColor color;
    }

    class FallingRocks
    {
        static void PrintPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        static void PrintStringPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Red)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main()
        {
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 50;

            int scoreIncrease = 1;
            double score = 0;
            double speed = 100.0;
            double acceleration = 0.5;
            int playfieldWidth = 20;
            int livesCount = 5;
            Object Dwarf = new Object();
            Dwarf.x = 10;
            Dwarf.y = Console.WindowHeight - 1;
            Dwarf.c = '#';
            Dwarf.color = ConsoleColor.Cyan;
            Random randomGenerator = new Random();
            List<Object> objects = new List<Object>();
            while (true)
            {
                scoreIncrease++;
                score += scoreIncrease;
                speed += acceleration;
                if (speed > 400)
                {
                    speed = 400;
                }
                bool hitten = false;
                // Generate rocks
                {
                    int chance = randomGenerator.Next(0, 100);
                    if (chance < 1)
                    {
                        Object newObject = new Object();
                        newObject.color = ConsoleColor.Magenta;
                        newObject.c = '♥';
                        newObject.x = randomGenerator.Next(0, playfieldWidth);
                        newObject.y = 0;
                        objects.Add(newObject);
                    }
                    if (chance < 5)
                    {
                        Object newObject = new Object();
                        newObject.color = ConsoleColor.Yellow;
                        newObject.c = '↓';
                        newObject.x = randomGenerator.Next(0, playfieldWidth);
                        newObject.y = 0;
                        objects.Add(newObject);
                    }
                    else
                    {
                        Object newObject = new Object();
                        newObject.x = randomGenerator.Next(0, playfieldWidth);
                        newObject.y = 0;
                        newObject.c = '@';
                        newObject.color = ConsoleColor.White;
                        objects.Add(newObject);
                    }
                }

                // Move the dwarf (ReadKey)
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (Dwarf.x - 1 >= 0)
                        {
                            Dwarf.x = Dwarf.x - 1;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (Dwarf.x + 1 < playfieldWidth)
                        {
                            Dwarf.x = Dwarf.x + 1;
                        }
                    }
                }
                // Move rocks (objects)
                List<Object> newList = new List<Object>();
                for (int i = 0; i < objects.Count; i++)
                {
                    Object oldRocks = objects[i];
                    Object newObject = new Object();
                    newObject.x = oldRocks.x;
                    newObject.y = oldRocks.y + 1;
                    newObject.c = oldRocks.c;
                    newObject.color = oldRocks.color;
                    // Check if rocks are hitting us
                    if (newObject.c == '♥' && newObject.x == Dwarf.x && newObject.y == Dwarf.y)
                    {
                        livesCount++;
                        score += (5 * speed);
                    }
                    if (newObject.c == '↓' && newObject.x == Dwarf.x && newObject.y == Dwarf.y)
                    {
                        speed -= 10.0;
                        score += (3 * speed);
                    }
                    if (newObject.c == '@' && newObject.x == Dwarf.x && newObject.y == Dwarf.y)
                    {
                        speed -= 30;
                        hitten = true;
                        livesCount--;
                        if (livesCount <= 0)
                        {
                            PrintStringPosition(22, 14, "GAME OVER!!!", ConsoleColor.Red);
                            PrintStringPosition(22, 16, "Your score: " + score, ConsoleColor.Red);
                            PrintStringPosition(22, 18, "Press [Enter] to continue...", ConsoleColor.Red);

                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        else
                        {
                            objects.Clear();
                        }
                    }
                    if (newObject.y < Console.WindowHeight)
                    {
                        newList.Add(newObject);
                    }
                }
                objects = newList;
                // Clear the console
                Console.Clear();
                // Redraw playfield

                foreach (Object rock in objects)
                {
                    PrintPosition(rock.x, rock.y, rock.c, rock.color);
                }
                if (hitten)
                {
                    PrintPosition(Dwarf.x, Dwarf.y, 'X', ConsoleColor.Red);
                }
                else
                {
                    PrintPosition(Dwarf.x, Dwarf.y, Dwarf.c, Dwarf.color);
                }
                // Draw info
                PrintStringPosition(22, 5, "Lives count: " + livesCount, ConsoleColor.Green);
                PrintStringPosition(22, 6, "Speed: " + speed, ConsoleColor.Green);
                PrintStringPosition(22, 7, "Score: " + score, ConsoleColor.Green);
                // Slow down the program
                Thread.Sleep((int)(600 - speed));
            }
        }
    }
}