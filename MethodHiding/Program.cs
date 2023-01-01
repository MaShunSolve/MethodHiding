using MethodHiding;
internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog = new Dog();
        string dogSay = dog.Say();
        Console.WriteLine(dogSay);
        //-------------------------------------//
        Animal fish1 = new Fish();//共變
        string fishSay = fish1.Say();//預期結果為:我是某種動物
        Console.WriteLine(fishSay);

        Fish fish2 = new Fish();//預期結果為:啵啵啵
        string fishMsg = fish2.Say();
        Console.WriteLine(fishMsg);

    }
}