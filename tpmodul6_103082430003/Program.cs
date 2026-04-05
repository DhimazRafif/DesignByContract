using tpmodul6_103082430003;

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo film1 = new SayaTubeVideo("Tutorial Design By Contract - Dhimaz Rafif Hanafi");

        film1.PrintVideoDetails();
        film1.IncreasePlayCount(12);
        film1.PrintVideoDetails();
    }
}
