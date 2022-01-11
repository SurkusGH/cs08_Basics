using System;
using System.Linq;

namespace cs08_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs08_PASKAITA!");
            #region TEORIJA - KARTOJIMAS 

            //

            #endregion

            //Kartojimas

            //Rep1();
            //Rep2();
            //Rep3();
            //Rep4();
            //Rep5();
            //Rep6();
            Rep7();
            Rep8();
            //Rep9();
            //Rep10();
            //Rep11();
            //Rep12();

            //Metodų uždaviniai
            //Problem1();
            //Problem2();
            //Problem3();
            //Problem4();
            //Problem5();
            //Problem5();
            //Problem6();
            //Problem7();
            //Problem8(0, 3, true); // <-- Perkrauta funkcija, int, int; perkrauname su bool
        }

        public static void Rep1()
        {
            // Paprašyti vartotojo įvesti bet kokį skaičių
            // Išvesti skaičių sumą nuo 1 iki įvesto skaičiaus
            int input = 10;
            for (int i = 1; i <= input; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
        }

        public static void Rep2()
        {
            // Vartotojas įveda sakinį, programa išveda visus
            // simbolius atvirkštine tvarka
            string input = "ABCDEFGH";
            for (int i = input.Length-1; i >= 0; i--) // <-- lenght - 1, nes atbulinė indeksacija nuo 6, ne nuo 7, nes pradžia nuo 0
            {
                Console.Write(input[i]);
            }
            Console.WriteLine("");
        }

        public static void Rep3()
        {
            // Paprašyti įvesti skaičių.Parodyti pasirinkto skaičiaus daugybos
            // lentelę. Paklausti ar tęsti ar ne ? (taip / ne)
            // Naudoti begalinį ciklą, ciklą cikle ir break;
            int num = 5;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
            //alternatyviai:
            int x = 1;
            while (true)
            {
                Console.WriteLine($"{num} * {x} = {num * x}");
                x++;
                if (x == 11)
                {
                    break;
                }
            }

            // alternatyviai:
            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("Enter a number for multiplication table: ");
                int input = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{input} * {x} = {input * x}");
                }
                Console.WriteLine("Continue? y/n");
                char decision = char.Parse(Console.ReadLine());
                if(decision == 'n')
                {
                    isAlive = false;
                }
            }
                
        }

        public static void Rep4()
        {
            int input = 1000000000;
            int sum = 0;

            int chunk = input / 100;

            for (int i = 1; i <= input; i++)
            {
                sum += i;
                if (i%chunk == 0)
                {
                    Console.Clear();
                    Console.Write($"{i/chunk}%");
                }
            }
            Console.WriteLine("");
        }

        public static void Rep5()
        {
            int rows = 3;

            for (int i = 0; i < rows; i++)
            {
                Console.Write(new String(' ', rows - 1));
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void Rep6()
        {
            //string text = "Word1 word22 word333"
        }

        public static void Rep7()
        {
            int[] array = new int[5];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write("Enter an integer: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(""); // <-- cukrus
            Console.WriteLine("Reversed array: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Rep8()
        {
            string numbersText = Console.ReadLine();
            string[] numbers = numbersText.Split(' ');
            string numbersReverseText = string.Join(' ', numbers.Reverse());

            int[] numbersReverse = new int[numbers.Length];

            for (int i = numbers.Length - 1; i >= 0 ; i--)
            {
                numbersReverse[i] = int.Parse(numbers[i]);
            }
            foreach (var item in numbersReverse)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static void Rep9()
        {

        }

        public static void Rep10()
        {

        }

        public static void Rep11()
        {

        }

        public static void Rep12()
        {

        }

        public static void Problem1()
        {
            // Parašyti funkciją, kuri išveda į konsolę Jūsų vardą
            Console.WriteLine("Koks tavo vardas?");
            string name = Console.ReadLine();
            Console.WriteLine($"Tavo vardas {name}.");
        }

        public static void Problem2()
        {
            // Parašyti funkciją, kuri išveda į konsolę vardą
            // tiek kartų kiek yra nurodoma
            Console.WriteLine("Koks tavo vardas?");
            string name = Console.ReadLine();
            Console.WriteLine("Kiek kartų atspausdinti tavo vardą?");
            bool repeatPrint = int.TryParse(Console.ReadLine(), out int index);

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"Print #{i}: {name}");
            }
        }

        public static void Problem3()
        {
            // Parašyti funkciją, kuri gauna string tipo parametrą.
            // Funkcija turi gražinti eilutę su tiek "#",
            // kiek simbolių yra gautame parametre
            Console.WriteLine("Įvesk string'ą?");
            string someString = Console.ReadLine();
            someString.ToCharArray();

            foreach (var item in someString)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }

        public static void Problem4()
        {
            // Parašti funkciją, kuri gražina KMI
            // Formulė KMI = Masė (Kg)/ūgis(m)²

            Console.WriteLine("Įveskite svorį (kg)");
            bool weight = float.TryParse(Console.ReadLine(), out float theWeight);
            Console.WriteLine("Įveskite ūgį (cm)");
            bool Height = float.TryParse(Console.ReadLine(), out float theHeight);
            Console.WriteLine($"Jūsų KMI yra: {theWeight/Math.Pow(theHeight/100, 2)}");
        }

        public static void Problem5()
        {
            // Parašyti funkciją, kuri suskaičiuoja ir gražina,
            // kiek tarpų yra įvestame stringe

            Console.WriteLine("Vartotojau įveskite sakinį: ");
            string someString = Console.ReadLine();
            int counter = 0;

            someString.ToCharArray();
            
            foreach (var item in someString)
            {
                if (item == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine($"Sakinyje yra {counter} tarpai.");
        }

        public static void Problem6()
        {
            // Parašyti funkciją, kuri paima int[] parametrą ir išveda elementų
            // sumą, bei kiek elementų yra in array
            
            Console.WriteLine("Vartotojau kokio dydžio masyvas? (int)");
            int arraySize = int.Parse(Console.ReadLine());
            int[] smallArray = new int[arraySize];
            for (int i = 0; i < smallArray.Length; i++)
            {
                Console.WriteLine($"Veskite int: ({i+1} iš {arraySize})");
                smallArray[i] = int.Parse(Console.ReadLine());
            }
            int sumArray = 0;
            for (int i = 0; i < smallArray.Length; i++)
            {
                sumArray += smallArray[i];
            }
            Console.WriteLine($"Masyvo elementų suma: {sumArray}, masyve yra {smallArray.Length} elementų");
        }

        public static void Problem7()
        {
            // Parašyt funkciją, kuri kelia
            // vieną skaičių į antrojo laipsnį
            // Pvz.: 2 ^ 3 = 8

            Console.WriteLine("Vartotojau, duokite 2 int: ");
            if (!int.TryParse(Console.ReadLine(), out int index1))
            {
                Console.WriteLine("Įvestas ne int");
                Environment.Exit(1);
            }

            if (!int.TryParse(Console.ReadLine(), out int index2))
            {
                Console.WriteLine("Įvestas ne int");
                Environment.Exit(1);
            }

            Console.WriteLine($"{index1} ^ {index2} = {Math.Pow(index1, index2)}");
        }

        public static void Problem8(int firstNum, int secondNum)
        {
            // Parašyti 2 perkrautas funkcijas:
            // 1. Išveda skaičių sumą nuo … iki;
            // 2. Gauna parametrus: int nuo, int iki, bool rodytiTarpineSuma.
            // Pvz.: nuo 1, iki 5;
            // 0+1=1, 1+2=3, 3+4=7, 7+5=12
            int count = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                count += i;
            }
            Console.WriteLine(count);
        }

        public static void Problem8(int firstNum, int secondNum, bool showMid)
        {
            int count = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine($"{count} + {i} = {count + i}");
                    count += i;
                }
            }
        }
    }
}

