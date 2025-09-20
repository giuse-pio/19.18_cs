namespace _19._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            string input;
            do
            {
                Console.Write("inserisci un numero nella lista A (o premi invio per uscire): ");
                input = Console.ReadLine();
                int n;
                if (input == "")
                    break;
                else
                {
                    int.TryParse(input, out n);
                    a.Add(n);
                }

            } while (input != "");
            do
            {
                Console.Write("inserisci un numero nella lista B (o premi invio per uscire): ");
                input = Console.ReadLine();
                int n;
                if (input == "")
                    break;
                else
                {
                    int.TryParse(input, out n);
                    b.Add(n);
                }
            } while (true);

            if (CollectionsUguali(a, b))
            {
                Console.WriteLine("le liste sono uguali");
            }
            else
            {
                Console.WriteLine("le liste non sono uguali");
            }
        }

        static bool CollectionsUguali(List<int> a, List<int> b)
        {
            if (a.Count != b.Count)
                return false;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }
    }
}
