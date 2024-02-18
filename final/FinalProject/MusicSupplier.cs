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
    public override float CalculateFee()
    {
        return 1000;
    }

    public void AddMusic(string food)
    {

    }
    
    public string GetMusicList()
    {
        return "menu";
    }
}