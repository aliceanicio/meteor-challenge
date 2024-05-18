using System;
using System.Drawing;


class Program2
{
    static void Main()
    {
        string imagePath = @"../meteor_challenge_01.png";
        Color targetColor = Color.FromArgb(255, 255, 0, 0);
        int count = CountPixels(imagePath, targetColor);
        Console.WriteLine($"Número de pixels da cor Vermelha: {count}");
    }


    static int CountPixels(string imagePath, Color targetColor)
    {
        int count = 0;


        using (Bitmap bitmap = new Bitmap(imagePath))
        {
            for (int x = 0; x < bitmap.Width; x++)
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
