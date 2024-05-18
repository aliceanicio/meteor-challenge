using System;
using System.Drawing;
using System.Collections.Generic;


class Program3
{
    static void Main()
    {
        string imagePath = @"../meteor_challenge_01.png";
        Color targetColor = Color.FromArgb(255, 255, 0, 0); // Vermelho
        Color referenceColor = Color.FromArgb(255, 0, 0, 255); // Azul
        int count = CountPixelsInBlueColumns(imagePath, targetColor, referenceColor);
        Console.WriteLine($"Número de Meteoros que cairão sobre a água: {count}");
    }


    static int CountPixelsInBlueColumns(string imagePath, Color targetColor, Color referenceColor)
    {
        int count = 0;
        HashSet<int> blueColumns = new HashSet<int>();


        using (Bitmap bitmap = new Bitmap(imagePath))
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    if (bitmap.GetPixel(x, y).ToArgb() == referenceColor.ToArgb())
                    {
                        blueColumns.Add(x);
                    }
                }
            }


            foreach (int x in blueColumns)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    if (bitmap.GetPixel(x, y).ToArgb() == targetColor.ToArgb())
                    {
                        count++;
                    }
                }
            }
        }


        return count;
    }
}
