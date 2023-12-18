namespace Dz5_Singletone
{
    public sealed class Singleton
    {

        private Singleton() { }

        private static Singleton MarkValue;


        public static Singleton GetInstance()
        {
            if (MarkValue == null)
            {
                MarkValue = new Singleton();
            }
            return MarkValue;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Все працюне");
            }
            else
            {
                Console.WriteLine("Не працює");
            }
        }
    }
}
