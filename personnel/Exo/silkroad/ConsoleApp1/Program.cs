const int BoardSize = 9;
const int SilkyNumber = 20;
Random rnd = new Random();
bool[,] silkyWay = new bool[BoardSize, BoardSize];
int[,] testedWay = new int[BoardSize, BoardSize];

// testedWay :
// 0 = not tested
// 1 = tested
// 2 = good way
// 3 = detected silk (obstacle)

for (int i = 0; i < SilkyNumber; i++)
{
    int y = rnd.Next(BoardSize);
    int x = rnd.Next(BoardSize);
    if ((x != BoardSize - 1) || (y != 0))
    {
        if (!silkyWay[x, y])
        {
            silkyWay[x, y] = true;
        }
        else
        {
            i--;
        }
    }
    else
    {
        i--;
    }
}

for (int i = 0; i < BoardSize; i++)
{
    for (int j = 0; j < BoardSize; j++)
    {
        testedWay[i, j] = silkyWay[i, j] ? 3 : 0;
    }
}

void DrawBoard(bool[,] board)
{
    Console.Write("  ");
    for (int i = 0; i < BoardSize; i++)
    {
        Console.Write(i + 1);
    }
    Console.Write("\n ┌");
    for (int i = 0; i < BoardSize; i++)
    {
        Console.Write("─");
    }
    Console.WriteLine("┐");

    for (int i = 0; i < BoardSize; i++)
    {
        Console.Write($"{(char)(i + 65)}│");
        for (int j = 0; j < BoardSize; j++)
        {
            if (board[i, j])
            {
                Console.Write("█"); 
            }
            else
            {
                Console.Write(" "); 
            }
        }
        Console.WriteLine("│");
    }
    Console.Write(" └");
    for (int i = 0; i < BoardSize; i++)
    {
        Console.Write("─");
    }
    Console.WriteLine("┘");
}

bool FindPath(int[,] testedBoard, int x, int y)
{
    if (x == 0 && y == BoardSize-1)
    {
        testedBoard[x, y] = 2;
        Console.WriteLine("Chemin trouvé !");
        return true;
    }

    if (x < 0 || y < 0 || x >= BoardSize || y >= BoardSize)
    {
        return false;
    }

    if (testedBoard[x, y] != 0)
    {
        return false;
    }

    testedBoard[x, y] = 1;

    if (FindPath(testedBoard, x - 1, y))
    {
        testedBoard[x, y] = 2; 
        return true;
    }

    if (FindPath(testedBoard, x, y - 1))
    {
        testedBoard[x, y] = 2; 
        return true;
    }

    if (FindPath(testedBoard, x + 1, y))
    {
        testedBoard[x, y] = 2;
        return true;
    }

    if (FindPath(testedBoard, x, y + 1))
    {
        testedBoard[x, y] = 2;
        return true;
    }

    return false;
}

DrawBoard(silkyWay);

if (FindPath(testedWay, BoardSize - 1, 0))
{
    Console.WriteLine("Voici le chemin trouvé :");
}
else
{
    Console.WriteLine("Aucun chemin trouvé.");
}

void DrawPath(int[,] board)
{
    Console.WriteLine("\nChemin :");
    for (int i = 0; i < BoardSize; i++)
    {
        for (int j = 0; j < BoardSize; j++)
        {
            if (board[i, j] == 2) Console.Write("O"); 
            else if (board[i, j] == 3) Console.Write("█"); 
            else Console.Write("."); 
        }
        Console.WriteLine();
    }
}

DrawPath(testedWay);

Console.ReadLine();
