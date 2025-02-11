using System;

class Program
{
    static void Main()
    {
        const int Dimensiune = 9;
        int[,] sudoku = new int[Dimensiune, Dimensiune];
        int row = 0;

        while (row < Dimensiune)
        {
            string input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input))
            {
                continue;
            }

            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int col = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == "")
                {
                    continue;
                }

                sudoku[row, col] = int.Parse(numbers[i]);
                col++;
            }

            row++;
        }

        Console.WriteLine(VerificaSudoku(sudoku) ? "True" : "False");
    }
    static bool VerificaSudoku(int[,] sudoku)
    {
        return VerificaLinie(sudoku) && VerificaColoane(sudoku) && VerificaMatrici(sudoku);
    }

    static bool VerificaLinie(int[,] sudoku)
    {
        const int Dimensiune = 9;
        for (int i = 0; i < Dimensiune; i++)
        {
            bool[] linie = new bool[Dimensiune];
            for (int j = 0; j < Dimensiune; j++)
            {
                int numar = sudoku[i, j];
                if (numar < 1 || numar > Dimensiune)
                {
                    return false;
                }
                if (linie[numar])
                {
                    return false;
                }

                linie[numar] = true;
            }
        }

        return true;
    }

    static bool VerificaColoane(int[,] sudoku)
    {
        const int Dimensiune = 9;
        for (int j = 0; j < Dimensiune; j++)
        {
            bool[] coloana = new bool[Dimensiune];
            for (int i = 0; i < Dimensiune; i++)
            {
                int numar = sudoku[i, j];
                if (numar < 1 || numar > Dimensiune)
                {
                    return false;
                }

                coloana[numar] = true;
            }
        }

        return true;
    }

    static bool VerificaMatrici(int[,] sudoku)
    {
        const int Dimensiune = 9;
        const int Matrice = 3;

        for (int orizontal = 0; orizontal < Dimensiune; orizontal += Matrice)
        {
            for (int vertical = 0; vertical < Dimensiune; vertical += Matrice)
            {
                if (!VerificaMatrici2(sudoku, orizontal, vertical))
                {
                    return false;
                }
            }
        }

        return true;
    }

    static bool VerificaSubmatrici(int[,] sudoku, int orizontal2, int vertical2)
    {
        const int Dimensiune = 9;
        const int Matrice = 3;
        bool[] matrice = new bool[10];

        for (int i = 0; i < Matrice; i++)
        {
            for (int j = 0; j < Matrice; j++)
            {
                int numar = sudoku[orizontal2 + i, vertical2 + j];

                if (numar < 1 || numar > Dimensiune || matrice[numar])
                {
                    return false;
                }

                matrice[numar] = true;
            }
        }

        return true;
    }
}