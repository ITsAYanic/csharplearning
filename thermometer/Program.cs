namespace thermometer;

class Program
{
    static void Main(string[] args)
    {
        Random rd = new Random();
        int temperature = rd.Next(-100, 100);
        if (temperature > 0 && temperature < 31){
            Console.Write("It's not Freezing with a Temparature of " + temperature + "°C");
        }
        else if (temperature > 30) {
            Console.Write("It's boiling hot with a temparature of " + temperature + "°C");
        }
        else if (temperature < 0) {
            Console.Write("It's Freezing with a Temparature of " + temperature + "°C");
        }
        else if (temperature == 0) {
            Console.Write("It's " + temperature + " Degrees");
        }
        else
        {
            Console.Write("Wait, I didn't intend for it to show this message? This is the Value where it went wrong:" + temperature);
        }
    }
}