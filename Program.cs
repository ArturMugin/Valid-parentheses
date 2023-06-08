class Program
{
    static void Main()
    {
        string mainStr = "{([";
        string secondStr = "})]";
        string s = "{(}))";

        for (int i = 0; i <= s.Length; i++)
        {
            if (mainStr.Contains(s[0]) && s.Contains(secondStr[mainStr.IndexOf(s[0])]))
            {
                s = s.Remove(s.IndexOf(secondStr[mainStr.IndexOf(s[0])]), 1);
                s = s.Remove(0, 1);
            }
        }
        bool result = s.Length == 0 ? true : false;
        Console.WriteLine(result);
        //return result;
    }
}