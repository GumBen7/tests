namespace Tests {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Fibo(int.Parse(Console.ReadLine())));
        }
        static int Fibo(int c) {
            if (c < 1) {
                return 1;
            }
            if (c < 3) {
                return c;
            }
            int a1 = 1, a2 = 1, a3 = 2, t;
            while (c > a3) {
                 t = a3;
                 a3 = a2 + a3;
                 a1 = a2;
                 a2 = t;
            }
            if (a3 - c < c - a2) {
                return a3;
            }
            return a2;
        }
    }
}