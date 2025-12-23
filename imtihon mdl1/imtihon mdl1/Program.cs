namespace imtihon_mdl1;

internal class Program
{ static void Main(string[] args)
    {
        ////6 
        //List<int> list = new List<int>() { 1, 7, 5, 0, 8, 3 };
        //Console.WriteLine(FirstTwo(list));


        ////5
        //string example = "shubs G13 abdusamad HH))**090";
        //Console.WriteLine(checker(example));


        ////4
        //string example = "Pfdzhewevhgv y77y&^";
        //Console.WriteLine(CheckerPDP(example));


        //3
        //string example = "njkdnkjf jv fjnkjjjken940380439";
        //Console.WriteLine(FirstThree(example));


        //2
        //List<string> elemento = new List<string>() { "abdusamad" };
        //Console.WriteLine(uzunlik(elemento));


        //1
        //List<int> list = new List<int>() { 1, 6, 4, 7, 8};
        //Console.WriteLine(JuftSon(list));
    }

    static int FirstTwo(List<int> num)
    {
        var sum = 0;
        for (int i = 0; i < 2; i++)
        {
            sum = sum + num[i];
        }
        return sum;
    }


    static bool checker(string text)
    {

        if (text.Contains("G13"))
        {
            return true;
        }

        return false;
    }


    static bool CheckerPDP(string exm)
    {
        var res = exm.Substring(0, 3);
        return res == "PDP";
    }


    static string FirstThree(string input)
    {
        var result = input.Substring(0, 3);
        return result;
    }


    static bool uzunlik(List<string> element)
    {
        var counter1 = 0;
        var counter2 = 0;
        foreach (var str in element)
        {
            if (str.Length > 5)
            {
                counter1++;
            }
            else
            {
                counter2++;
            }
            return counter1 == 0;
        }
        return counter2 == 0;
    }


    static int JuftSon(List<int> elements)
    {
        var summOfNumbers = 0;
        foreach (var i in elements)
        {
            if (i % 2 == 0)
            {
                summOfNumbers++;
            }
        }
        return summOfNumbers;
    }
}

