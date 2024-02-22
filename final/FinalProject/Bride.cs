public class Bride : Couple
{
    /*Class Constructor*/
    public Bride(string name, int age, string phone) : base(name, age, phone)
    {
    }

    /*Class methods*/
    public override void WriteVow()
    {
        string vow;
        Console.WriteLine("Write your vows to your future husband:");
        vow = Console.ReadLine();

        SetVow(vow);
    }
}