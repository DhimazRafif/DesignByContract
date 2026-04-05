using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //prekondisi
            if(title == null || title.Length > 100)
            {
                throw new ArgumentException("Judul tidak boleh kosong dan maksimal panjang judul 100 karakter");

            }
            //Debug.Assert(title != null&&title.Length<100,"Judul tidak boleh kosong dan maksimal panjang judul 100 karakter");
            this.title = title;
            this.playCount = 0;

            Random random = new Random();
            int generateId = random.Next(00000, 99999);
            this.id = generateId;
        }

        public void IncreasePlayCount(int plusCount)
        {
            //prekondisi
            if (plusCount > 10000000)
                throw new ArgumentOutOfRangeException("Maksimal nominal penambahan adalah 10.000.000");
            //Debug.Assert(plusCount<10000000,"Maksimal nominal penambahan adalah 10.000.000");

            try
            {
                checked
                {
                    this.playCount += plusCount;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error : error overflow penambahan melebihi batas integer");
            }
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
