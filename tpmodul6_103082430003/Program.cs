using tpmodul6_103082430003;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            //benar
            SayaTubeVideo film1 = new SayaTubeVideo("DesignByContract - Dhimaz Rafif Hanafi");
            //salah
            SayaTubeVideo film2 = new SayaTubeVideo(new string('-',101));

            film1.PrintVideoDetails();
            //benar
            film1.IncreasePlayCount(12);

            //salah
            film1.IncreasePlayCount(12000000);

            film1.PrintVideoDetails();

        }
        catch (Exception ex) 
        { 
            Console.WriteLine(ex.ToString());
        }

    }
}
