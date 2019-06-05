using System;

namespace DesafiosTecnicos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Minimum Packs: " + Program.MinimumPacks(16, 2, 10));
            Console.WriteLine("Right Characters: " + Program.RightCharacters("abbcbb"));
        }
        static public int MinimumPacks(int items, int largeBox, int smallBox)
        {
            var lgBox = items / (largeBox * 5) > 0 ? largeBox : pegarMenorValor(items, largeBox);
            var smBox = items % (lgBox * 5);
            return lgBox + smBox;

            int pegarMenorValor(int it, int lgB)
            {
                do
                {
                    lgB--;
                } while (items / (lgB * 5) == 0);

                return lgB;
            }
        }

        static public string RightCharacters(string text)
        {
            var chars = "";
            for(int i = 0; i < text.Length - 1; i++)
            {
                if(!(text[i] == text[i + 1]))
                {
                    chars += text[i];
                }
            }
            Console.WriteLine(chars);
            Console.ReadKey();
            return chars;
        }
    }
}