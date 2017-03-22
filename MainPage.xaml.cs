using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SnakeApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

                Console.SetBufferSize(80, 25);

                Walls walls = new Walls(80, 25);
                walls.Draw();

                Point p = new Point(4, 5, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Draw();

                Food food = new Food(80, 25, '$');
                Point ruoka = food.CreateFood();
                ruoka.Draw();

                while (true)
                {
                    if (walls.IsHit(snake) || snake.IsHitTail())
                    {
                        break;
                    }
                    if (snake.Eat(ruoka))
                    {
                        food = ruoka.Createruoka();
                        ruoka.Draw();
                    }
                    else
                    {
                        snake.Move();
                    }

                        Thread.Sleep(100);

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.HandleKey(key.Key);
                    }

                }
            }
        }
  }

