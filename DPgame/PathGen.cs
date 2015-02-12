using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPgame
{
    class PathGen
    {
        private Room entrance;
        int x;
        int y;
        private Room[,] grid;
        int tempRooms;
        int goalRooms;

        public PathGen()
        {
            this.entrance = null;
            setEasy();
        }

        public void setEasy()
        {
            Random rand = new Random();
            this.x = 5;
            this.y = 5;
            this.grid = new Room[x, y];
            int floor = (x * y) / 4;
            int ceil = floor * 2;
            this.goalRooms = rand.Next(floor, ceil);

        }

        public void setMedium()
        {
            Random rand = new Random();
            this.x = 8;
            this.y = 8;
            this.grid = new Room[x, y];
            int floor = (x * y) / 4;
            int ceil = floor * 2;
            this.goalRooms = rand.Next(floor, ceil);

        }

        public void setHard()
        {
            Random rand = new Random();
            this.x = 12;
            this.y = 12;
            this.grid = new Room[x, y];
            int floor = (x * y) / 4;
            int ceil = floor * 2;
            this.goalRooms = rand.Next(floor, ceil);

        }

        public Room getPath()
        {
            this.tempRooms = 0;
            this.entrance = new Room();
            this.entrance.Entrance = true;
            this.grid[0, 0] = this.entrance;
            
            while (this.tempRooms < this.goalRooms)
            {
                buildPath(this.entrance, 0, 0);
            }

            return this.entrance;
        }

        private void buildPath(Room cur, int i, int j)
        {

            if (tempRooms < goalRooms)
            {
                Random rand = new Random();

                int r = rand.Next(3);
                try
                {
                    if (this.grid[i + 1, j] == null && r == 0)
                    {
                        cur.North = new Room();
                        this.grid[i + 1, j] = cur.North;
                        this.tempRooms++;
                        cur.North.South = cur;
                        buildPath(cur.North, i + 1, j);
                    }
                    else if (!cur.hasNorth() && r == 0)
                    {
                        cur.North = this.grid[i + 1, j];
                        cur.North.South = cur;
                        buildPath(cur.North, i + 1, j);
                    }
                }
                    catch (IndexOutOfRangeException)
                    {
                        
                    }

                    try
                    {
                        if (tempRooms < goalRooms)
                        {
                            r = rand.Next(3);
                            if (this.grid[i - 1, j] == null && r == 0)
                            {
                                cur.South = new Room();
                                this.grid[i + 1, j] = cur.South;
                                this.tempRooms++;
                                cur.South.North = cur;
                                buildPath(cur.South, i - 1, j);
                            }
                            else if (!cur.hasSouth() && r == 0)
                            {
                                cur.South = this.grid[i - 1, j];
                                cur.South.North = cur;
                                buildPath(cur.South, i - 1, j);
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        
                    }

                    try
                    {
                        if (tempRooms < goalRooms)
                        {
                            r = rand.Next(3);
                            if (this.grid[i, j + 1] == null && r == 0)
                            {
                                cur.East = new Room();
                                this.grid[i, j + 1] = cur.East;
                                this.tempRooms++;
                                cur.East.West = cur;
                                buildPath(cur.East, i, j + 1);
                            }
                            else if (!cur.hasEast() && r == 0)
                            {
                                cur.East = this.grid[i, j + 1];
                                cur.East.West = cur;
                                buildPath(cur.East, i, j + 1);
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                       
                    }

                    try
                    {
                        if (tempRooms < goalRooms)
                        {
                            r = rand.Next(3);
                            if (this.grid[i, j - 1] == null && r == 0)
                            {
                                cur.West = new Room();
                                this.grid[i, j - 1] = cur.West;
                                this.tempRooms++;
                                cur.West.East = cur;
                                buildPath(cur.West, i, j - 1);
                            }
                            else if (!cur.hasWest() && r == 0)
                            {
                                cur.West = this.grid[i, j - 1];
                                cur.West.East = cur;
                                buildPath(cur.West, i, j - 1);
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        
                    }
                
            }
            else
            {
                cur.Exit = true;
            }
        }

        public void printPath()
        {
            for (int i = 0; i < this.x; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < this.y; j++)
                {
                    if (this.grid[i, j] != null)
                    {
                        if (this.grid[i, j].Entrance)
                            Console.Write("E ");
                        else if (this.grid[i, j].Exit)
                            Console.Write("X ");
                        else
                            Console.Write("0 ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine("|");
            }
        }

    }
}
