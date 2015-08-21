using System;
class Program
{

    // The gravitational field of the Moon is approximately 17% of that on the Earth.
    // Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
    static void Main(string[] args)
    {
        double weightOnEarth = double.Parse(Console.ReadLine());

        // 17% of something = something * 17 / 100
        double weightOnMoon = (weightOnEarth * 17) / 100;
        Console.WriteLine("Weight on the moon will be : {0}", weightOnMoon);

    }
}
