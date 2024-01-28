/* EXCEEDING THE REQUIREMENTS*/
// This class has 10 different Book of Mormon scriptures and sort one of them to the Reference Class
// and to the Scripture Class
public class BookOfMormonScriptures
{
    private List<string> _scriptures = new List<string>()
    {
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them",
        "Adam fell that men might be; and men are, that they might have joy",
        "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do",
        "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father",
        "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true",
        "O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God",
        "Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness",
        "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall",
        "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them",
        "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things"
    };
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    /*private List<string> _books = new List<string>()
    {

    }*/

    /* Class Constructor */
    public BookOfMormonScriptures()
    {

    }

    /*Class Methods*/
    public string GetRandomScripture()
    {
        int scripturesQuantity = _scriptures.Count;

        Random rnd = new Random();
        string chosenScripture = _scriptures[rnd.Next(scripturesQuantity)];

        return chosenScripture;
    }

    public void SetReference(string scripture)
    {
        if(scripture == "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them")
        {
            _book = "1 Nefi";
            _chapter = 3;
            _verse = 7;
            _endVerse = 0;
        }

        else if(scripture == "Adam fell that men might be; and men are, that they might have joy")
        {
            _book = "2 Nefi";
            _chapter = 2;
            _verse = 25;
            _endVerse = 0;
        }

        else if(scripture == "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do")
        {
            _book = "2 Nefi";
            _chapter = 32;
            _verse = 3;
            _endVerse = 0;
        }

        else if(scripture == "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father")
        {
            _book = "Mosiah";
            _chapter = 3;
            _verse = 19;
            _endVerse = 0;
        }

        else if(scripture == "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true")
        {
            _book = "Alma";
            _chapter = 32;
            _verse = 21;
            _endVerse = 0;
        }

        else if(scripture == "O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God")
        {
            _book = "Alma";
            _chapter = 37;
            _verse = 35;
            _endVerse = 0;
        }

        else if(scripture == "Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness")
        {
            _book = "Alma";
            _chapter = 41;
            _verse = 10;
            _endVerse = 0;
        }

        else if(scripture == "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall")
        {
            _book = "Helaman";
            _chapter = 5;
            _verse = 12;
            _endVerse = 0;
        }

        else if(scripture == "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them")
        {
            _book = "Ether";
            _chapter = 12;
            _verse = 27;
            _endVerse = 0;
        }

        else if(scripture == "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things")
        {
            _book = "Moroni";
            _chapter = 10;
            _verse = 4;
            _endVerse = 5;
        }
   }

   public string GetBook()
   {
        return _book;
   }

   public int GetChapter()
   {
        return _chapter;
   }

   public int GetVerse()
   {
    return _verse;
   } 

   public int GetEndVerse()
   {
        return _endVerse;
   }

}