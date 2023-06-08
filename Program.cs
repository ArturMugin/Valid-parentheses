class Program
{
    static void Main()
    {
        string one = "()";
        string two = "{}";
        string three = "[]";

        string s = "{}(({[]}))}";
        while (s.Length > 0)
        {
            if (s.Contains(one))
            {
                s = s.Replace(one, "");
            }
            else if (s.Contains(two))
            {
                s = s.Replace(two, "");
            }
            else if (s.Contains(three))
            {
                s = s.Replace(three, "");
            }
            else
            {
                break;
            }
        }
        if (s.Length > 0)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("True");
        }
    }
}