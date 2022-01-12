using System;
using System.Collections.Generic;
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

            //Rep1(); <-- Kartojimas
            //Rep2();
            //Rep3();
            //Rep4();
            //Rep5();
            //Rep6();
            //Rep7();
            //Rep8();
            //Rep9();
            //Rep10();
            //Rep11();
            //Rep12();
            //Rep13();
            //Rep14();

            //Problem1(); // <-- Metodų uždaviniai
            //Problem2();
            //Problem3();
            //Problem4();
            //Problem5();
            //Problem5();
            //Problem6();
            //Problem7();
            //Problem8(0, 3, true); // <-- Perkrauta funkcija, int, int; perkrauname su bool
            //Problem9();
            Problem10();
            //Problem11();
            //Problem12();
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

            int[] numbersReverse = numbers.Select(x => Convert.ToInt32(x)).Reverse().ToArray();

            //string numbersReverseText = string.Join(' ', numbers.Reverse());

            //int[] numbersReverse = new int[numbers.Length];
            //int index = 0;

            //for (int i = numbers.Length - 1; i >= 0 ; i--)
            //{
            //    numbersReverse[index] = int.Parse(numbers[i]);
            //    index++;
            //}
            //foreach (var item in numbersReverse)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
        }

        public static void Rep9()
        {
            // Vartotojas įveda 5 skaičius
            // Programa išveda jų sumą

            int[] numbers = { 1, 2, 3, 4, 5 };
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                counter += numbers[i];
            }
            Console.WriteLine(counter);
        }

        public static void Rep10()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] newNumbers = new int[numbers.Length];

            for (int i = 0; i < newNumbers.Length; i++)
            {
                newNumbers[i] = numbers[i];
            }
            foreach (var item in newNumbers)
            {
                Console.Write(item);
            }
            Console.WriteLine(); //<-- cukrus
        }

        public static void Rep11()
        {
            // Dictionary
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Programming", "Defined algorithms that PC follows");
            dictionary.TryGetValue("Programming", out string value);

            Console.WriteLine(value);
        }

        public static void Rep12()
        {
            // Upildyti masyvą atsitiktiniais skaičiais
            // Surasti ir parodyti didžiausią ir mažiaučią elementą

            Random random = new Random(); // <-- kodėl žalia spalva?
            int[] randomNumbers = new int[10];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 100);
            }

            int smallsestNumber = randomNumbers[0];

            foreach (var number in randomNumbers)
            {
                if (number < smallsestNumber)
                {
                    smallsestNumber = number;
                }
            }

            int bigestNumber = randomNumbers[0];

            foreach (var number in randomNumbers)
            {
                if (number > bigestNumber)
                {
                    bigestNumber = number;
                }
            }
            Console.WriteLine("List is: ");
            foreach (var item in randomNumbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(); // <-- cukrus eilutei
            Console.WriteLine($"Smallest number: {smallsestNumber}");
            Console.WriteLine($"Biggest number: {bigestNumber}");

            //alternatyviai:
            Console.WriteLine(randomNumbers.Min());
            Console.WriteLine(randomNumbers.Max());
        }

        public static void Rep13()
        {
            Random random = new Random();
            int[] firstRandomNumbers = new int[5];
            int[] secondRandomNumbers = new int[5];
            for (int i = 0; i < firstRandomNumbers.Length; i++)
            {
                firstRandomNumbers[i] = random.Next(1, 100);
                secondRandomNumbers[i] = random.Next(1, 100);
            }

            int[] appendedArrays = new int[firstRandomNumbers.Length + secondRandomNumbers.Length];

            firstRandomNumbers.CopyTo(appendedArrays, 0);
            secondRandomNumbers.CopyTo(appendedArrays, firstRandomNumbers.Length);
        }

        public static void Rep14()
        {
            //
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

        public static void Problem9()
        {
            // Palindromas - (gr.palindromos - bėgantis atgal, grįžtantis):
            // 1.žodis, eilėraštis arba frazė, skaitomi iš kairės į dešinę ir
            // iš dešinės į kairę, išlaikantys tą pačia prasmę
            // pvz., lietuvių k. žodis: „Savas“, sakinys „Abu gaišo po šia guba“

            // O tai uždavinys koks...? Spėju, kad išvesti string'ą atvirkščiai
            Console.WriteLine("Vartotojau, įvesk sakinį, kuris bus atspausdintas atbulai: ");
            string palindrome = Console.ReadLine();

            palindrome.ToCharArray();

            for (int i = palindrome.Length - 1; i >= 0; i--)
            {
                Console.Write(palindrome[i]);
            }
            Console.WriteLine();
        }

        public static void Problem10()
        {
            // Padaryti funkciją, kuri parodo X Fibonačio skaičių. Seka prasideda
            // šiais skaičiais 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233…
            // kiekvienas šios sekos skaičius lygus dviejų prieš jį einančių skaičių sumai

            Console.WriteLine("Fibonaci sequence");
            // Iš esmės reikia susikurti generatorių cikle
            // ir targetinti tam tikrą max index'ą cikle


        }

        public static void Problem11()
        {
            // Parašyti funkciją, kuri suskaičiuoja atskirų
            // bet kokio skaičiaus skaitmenų sumą
            Console.WriteLine("Programa apskaičiuos atskirų įvesto skaitmens skaitmenų sumą");
            Console.WriteLine("Vartotojau įvesk skaičių: ");
            if(!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("(!) Netinkama įvestis.");
                Environment.Exit(1);
            }
            char[] tempCharArray = num.ToString().ToCharArray();


            List<char> splitNum = new List<char>();
            for (int i = 0; i < tempCharArray.Length; i++)
            {
                splitNum.Add(tempCharArray[i]);
            }

            int sum = 0;
            Console.WriteLine($"Skaičiaus: {num}, pavienių skaičių: ");
            foreach (var item in splitNum)
            {
                sum += int.Parse(item.ToString());
                Console.Write($"{item} ");
            }
            Console.WriteLine($"suma yra {sum} ");
            Console.WriteLine();

            // 100% yra normalesnis sprendimas;
        }

        public static void Problem12()
        {
            // Parašyti rekursinę funkciją faktorialo skaičiavimui.
            // Faktorialas – natūrinių skaičių sandauga
            // nuo 1 iki natūrinio skaičiaus (imtinai).
            // Žymima šauktuko (!) ženklu. Pvz: 5! = 1*2*3*4*5=120;

            // Nematau skirtumo nuo 8 užduoties, '+' į '*' pakeiti ir viskas:
            Console.WriteLine("Vartotojau įvesk 2 integerius: ");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int count = firstNum;
            
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i != 1)
                {
                    Console.WriteLine($"{count} * {i} = {count * i}");
                    count *= i;
                }
            }
            Console.WriteLine(count);
        }
    }
}

