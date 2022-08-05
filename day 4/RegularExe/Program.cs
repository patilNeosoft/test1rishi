

using System.Text.RegularExpressions;

class Program {
    static void Main()
    {
        string mystr = "Pooja Patil\npayal Patil";
        Console.WriteLine(mystr);

        //case sensitive
        Match mymatch = Regex.Match(mystr, "Patil");
        Console.WriteLine(mymatch);

        //returns index of first occurance
        Console.WriteLine(mymatch.Index);


        //ignores case
        MatchCollection mymatch1 = Regex.Matches(mystr, "patil", RegexOptions.IgnoreCase);
        Console.WriteLine(mymatch1.Count);



    }
}
        



    
