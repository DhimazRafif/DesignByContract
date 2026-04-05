using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul6_103082430003
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.playCount = 0;

            Random random = new Random();
            int generateId = random.Next(00000, 99999);
            this.id = generateId;
        }

        public void IncreasePlayCount(int plusCount)
        {
            int hasil = playCount + plusCount;
            playCount = hasil;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"Id Film : {id}");
            Console.WriteLine($"Judul : {title}");
            Console.WriteLine($"Play Count : {playCount}");
        }
    }
}
