﻿int[,,] GetArray3D(int row, int col, int depth)
{
    int[,,] result = new int[depth, row, col];
    for (int i = 0; i < depth; i++)
    {
        for (int j = 0; j < row; j++)
        {
            for (int k = 0; k < col; k++)
            {
                int temp;
                bool tempInResult = true;
                while (tempInResult)
                {
                    tempInResult = false;
                    temp = new Random().Next(10, 100);
                    for (int i2 = 0; i2 < depth; i2++)
                    {
                        for (int j2 = 0; j2 < row; j2++)
                        {
                            for (int k2 = 0; k2 < col; k2++)
                            {
                                if (temp == result[i2, j2, k2]) 
                                {   
                                    tempInResult = true;
                                    break;
                                }
                            }
                        }
                    }
                    result[i, j, k] = temp;
                }
            }
        }
    }
    return result;
}

void PrintArray3D(int[,,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(2); k++)
            {
                Console.Write($"{mas[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}


int[,,] Array3D = GetArray3D(2, 2, 2);
PrintArray3D(Array3D);