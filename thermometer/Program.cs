namespace thermometer;

class Program
{
    static void Main(string[] args)
    {
        Random rd = new Random();
        int temparature = rd.Next(-100, 100);
        if (temparature > 0 && temparature <= 30){
            Console.Write("It's not Freezing with a Temparature of " + temparature + "°C");
        }
        else if (temparature > 30) {
            Console.Write("It's boiling hot with a temparature of " + temparature + "°C");
        }
        else if (temparature < 0) {
            Console.Write("It's Freezing with a Temparature of " + temparature + "°C");
        }
        else if (temparature == 0) {
            Console.Write("It's " + temparature + " Degrees");
        }
    }
}