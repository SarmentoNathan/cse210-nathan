using System.ComponentModel;

public class MusicSupplier : Supplier
{
    /*Class attributes*/
    private List<string> _musicList = new List<string>();

    /*Class constructor*/
    public MusicSupplier(string name) : base(name)
    {

    }

    /*Class methods*/
    public override void CalculateFee()
    {
        float value;
        Console.Write("Enter the value of the music supplier chosen: ");
        value = float.Parse(Console.ReadLine());

        SetFee(value);
    }

    public void AddMusic(string music)
    {
        _musicList.Add(music);
    }
    
    public void PrintMusicList()
    {
        foreach(string music in _musicList)
        {
            Console.WriteLine(music);
        }
    }
}