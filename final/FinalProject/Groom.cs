public class Groom : Couple
{
    /*Class Constructor*/
    public Groom(string name, int age, string phone) : base(name, age, phone)
    {
    }

    /*Class methods*/
    public override void WriteVow()
    {
        string vow;
        Console.WriteLine("Write your vows to your future wife:");
        vow = Console.ReadLine();

        SetVow(vow);
    }
}