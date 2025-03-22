using System;
using tpmodul6_103022300123;

class Program
{
    static void Main()
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – RAFI ATHALLAH RAMADHAN");
            video.PrintVideoDetails();

            // Tambahkan playCount
            video.IncreasePlayCount(10000000);
            video.PrintVideoDetails();

            // menguji batas maksimal integer dengan loop
            for (int i = 0; i < 250; i++)
            {
                video.IncreasePlayCount(10000000); // Akan menyebabkan overflow
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        Console.ReadLine();
    }
}
