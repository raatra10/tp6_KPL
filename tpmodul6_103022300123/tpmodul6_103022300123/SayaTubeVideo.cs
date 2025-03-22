using System;

namespace tpmodul6_103022300123
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            // Validasi judul tidak null dan panjang <= 100 karakter
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("Judul tidak boleh kosong!");
            if (title.Length > 100)
                throw new ArgumentException("Judul tidak boleh lebih dari 100 karakter!");

            // Generate ID secara random (5 digit)
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count <= 0)
                throw new ArgumentException("Jumlah play count harus lebih dari 0!");
            if (count > 10000000)
                throw new ArgumentException("Play count tidak boleh lebih dari 10 juta!");

            // Cek apakah playCount akan melebihi batas maksimum integer
            if ((long)this.playCount + count > int.MaxValue)
                throw new OverflowException("Play count tidak boleh melebihi batas integer!");

            // Mencegah overflow dengan checked
            checked
            {
                this.playCount += count;
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video       : " + this.id);
            Console.WriteLine("Judul Video    : " + this.title);
            Console.WriteLine("Jumlah Play    : " + this.playCount + "\n");
        }
    }
}
