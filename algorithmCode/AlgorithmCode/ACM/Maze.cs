using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.ACM
{
    public class Maze
    {

        static int N = 10;

        static int M = 10;

        static  int INF = 1000000000;

        static char[,] MAZE = {
            { '#', 's', '#', '#', '#', '#', '#', '#', '.', '#' },
            { '.', '.', '.', '.', '.', '.', '#', '.', '.', '#' },
            { '.', '#', '.', '#', '#', '.', '#', '#', '.', '#' },
            { '.', '#', '.', '.', '.', '.', '.', '.', '.', '.' },
            { '#', '#', '.', '#', '#', '.', '#', '#', '#', '#' },
            { '.', '.', '.', '.', '#', '.', '.', '.', '.', '#' },
            { '.', '#', '#', '#', '#', '#', '#', '#', '.', '#' },
            { '.', '.', '.', '.', '#', '.', '.', '.', '.', '.' },
            { '.', '#', '#', '#', '#', '.', '#', '#', '#', '.' },
            { '.', '.', '.', '.', '#', '.', '.', '.', 'G', '#' }
        };

        static int[,] D = new int[10, 10];

        static int sx = 1, sy = 0, gx = 8, gy = 9;

        static int[] dx = { 1, 0, -1, 0 };
        static int[] dy = { 0, 1, 0, -1 };



        public Maze()
        {
        }

        public static int BFS()
        {
            Queue<Point> que = new Queue<Point>();

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    D[i, j] = INF;

            que.Enqueue(new Point(sx, sy));

            D[sx, sy] = 0;

            while (que.Count > 0)
            {
                Point p = que.Dequeue();

                if (p.x == gx && p.y == gy)
                    break;

                for (int i = 0; i < 4; i++)
                {
                    int nx = p.x + dx[i];
                    int ny = p.y + dy[i];

                    if (0 <= nx && nx < N && 0 <= ny && ny < M && MAZE[nx, ny] != '#' && D[nx, ny] == INF)
                    {
                        que.Enqueue(new Point(nx, ny));
                        D[nx, ny] = D[p.x, p.y] + 1;
                    }
                }
            }

            return D[gx, gy];
        }

        public static int Solve() {
           return BFS();
        }
    }

    struct Point
    {
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x;
        public int y;
    }
}
