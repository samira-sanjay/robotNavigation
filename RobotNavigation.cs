using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codec_Techical
{
    public enum Directions
    {
        North = 1,
        South = 2,
        East = 3,
        West = 4
    }
    public class CurrentPosition : ICurrentPosition
       {

      

            public int X;
            public int Y;
            public Directions Direction;

            public CurrentPosition()
            {
                X = Y = 1;
                this.Direction = Directions.North;
            }

            public  void NavigateRobot(char[] directions)
            {
                foreach (char item in directions)
                {
                    switch (item)
                    {
                        case 'F':
                            MoveForward();
                            break;
                        case 'L':
                            MoveLeft(); ;
                            break;
                        case 'R':
                            MoveRight();
                            break;
                        default:
                            Console.WriteLine($"Wrong command {item}");
                            break;
                    }
                }
            }

            void MoveRight()
            {
                switch (this.Direction)
                {
                    case  Directions.North:
                        this.Direction = Directions.East;
                        break;
                    case  Directions.South:
                        this.Direction = Directions.West;
                        break;
                    case Directions.East:
                    this.Direction = Directions.South;
                        break;
                    case Directions.West:
                    this.Direction = Directions.North;
                        break;

                    default:

                        break;
                }
            }

            void MoveLeft()
            {
                switch (this.Direction)
                {
                    case Directions.North:
                        this.Direction=Directions.West;
                        break;
                    case Directions.South:
                        this.Direction = Directions.East;
                        break;
                    case Directions.East:
                        this.Direction = Directions.North;
                        break;
                    case Directions.West:
                        this.Direction = Directions.South;
                        break;

                    default:

                        break;
                }
            }

            void MoveForward()
            {
                switch (this.Direction)
                {
                case Directions.North:
                    this.Y += 1;
                        break;
                case Directions.South:
                    this.Y -= 1;
                        break;
                case Directions.East:
                    this.X += 1;
                        break;
                case Directions.West:
                    this.X -= 1;
                        break;

                    default:
                        
                        break;
                }
            }

       
    }
    }

