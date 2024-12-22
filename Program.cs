namespace Set3Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vector: ");
            string input = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(" "),int.Parse);

            Console.WriteLine("vector inainte de sortare: ");
            Print(v);

            MutareZeroLaFinal(v);

            Console.WriteLine("Vector dupa sortare: ");
            Print(v);



        }
        static void MutareZeroLaFinal(int[] v)
        {
            int indexNrNenul = 0;

            for(int i  = 0; i < v.Length; i++)
            {
                if (v[i] != 0)
                {
                    int temp = v[i];
                    v[i] = v[indexNrNenul];
                    v[indexNrNenul] = temp;

                    indexNrNenul++;

                }
            }
        }

        static void Print(int[] v)
        {
            Console.WriteLine(String.Join(" ",v));
        }
    }
}
