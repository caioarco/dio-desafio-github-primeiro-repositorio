 class Program
    {
        static void Main()
        {
            double n, nota, quociente, resto;

            Console.WriteLine("Digite o valor a ser pago");
            n = double.Parse(Console.ReadLine());
            
            resto = n;
            if (resto > 100)
            {
                nota = 100;
                quociente = resto / 100;
                Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
                resto = resto % 100;
            }
            if (resto > 50){
                nota = 50;
                quociente = resto/50;
                Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
                resto = resto % 50;
            }
            if (resto > 20)
            {
                nota = 20;
                quociente = resto/20;
                Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
                resto = resto % 20;
            }
            if (resto > 10)
            {
                nota = 10;
                quociente = resto/10;
                Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
                resto = resto % 10;
            }
                nota = 5;
                quociente = resto/5;
                Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
                resto = resto % 5;
                nota = 2;
                quociente = resto/2;
                Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
                nota = 1;
                quociente = resto/1;
                Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
                resto = resto % 1;
                nota = 0.50;
                Console.WriteLine($"{quociente} moeda(s) de R$ 50 centavos");
            }

    }
            
            