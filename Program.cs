using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Load();
        }

        private static void Question()
        {
            Console.WriteLine();
            Console.Write("Doriti sa incercati o alta problema (DA/NU): ");
            string answer = Console.ReadLine();
            if (answer.Equals("Da", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.Clear(); Load();
            }
            else
            {
                if (answer.Equals("Nu", StringComparison.CurrentCultureIgnoreCase))
                    return;
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Input invalid. Incercati din nou.");
                    Question();
                }
            }
        }

        private static void Load()
        {
            Console.WriteLine("Probleme - setul 1");
            Console.WriteLine();
            Console.Write("Introduce-ti numarul problemei dorite (1-21) sau cifra '0' pentru a inchide consola: ");
            string nrprob = Console.ReadLine();
            Console.WriteLine();
            switch (nrprob)
            {
                case "0": return;
                case "1": Prob1(); break;
                case "2": Prob2(); break;
                case "3": Prob3(); break;
                case "4": Prob4(); break;
                case "5": Prob5(); break;
                case "6": Prob6(); break;
                case "7": Prob7(); break;
                case "8": Prob8(); break;
                case "9": Prob9(); break;
                case "10": Prob10(); break;
                case "11": Prob11(); break;
                case "12": Prob12(); break;
                case "13": Prob13(); break;
                case "14": Prob14(); break;
                case "15": Prob15(); break;
                case "16": Prob16(); break;
                case "17": Prob17(); break;
                case "18": Prob18(); break;
                case "19": Prob19(); break;
                case "20": Prob20(); break;
                case "21": Prob21(); break;
                default: Console.WriteLine("Input invalid. Incercati din nou."); Console.WriteLine(); Load(); break;
            }
        }

        private static void Prob1()
        {
            Console.WriteLine("Problema 1: Ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'a': ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'b': ");
            float b = float.Parse(Console.ReadLine());
            float x = -b / a;
            Console.WriteLine($"Solutia: x = {x}");
            Question();
        }

        private static void Prob2()
        {
            Console.WriteLine("Problema 2: Ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'a': ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'b': ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'c': ");
            float c = float.Parse(Console.ReadLine());
            float d, x1, x2;

            if (a == 0 && b == 0 & c == 0)
            {
                Console.WriteLine("Exista o infinitate de solutii.");
            }
            else
            {
                if (a == 0 && b == 0)
                    Console.WriteLine("Nu exista solutii.");
                else
                {
                    if (a == 0)
                    {
                        if (c != 0)
                        {
                            x1 = -c / b;
                            Console.WriteLine($"Solutia: x = {x1}");
                        }
                        else Console.WriteLine($"Solutia: x = 0");
                    }
                    else
                    {
                        if (b == 0)
                        {
                            if (c != 0 && (-c / a) >= 0)
                            {
                                x1 = (float)Math.Sqrt(-c / a);
                                Console.WriteLine($"Solutia: x = {x1}");
                            }
                            else
                            {
                                if (c == 0) Console.WriteLine($"Solutia: x = 0");
                                else Console.WriteLine("Nu exista solutii.");
                            }
                        }
                    }
                }
            }

            if (a != 0 && b != 0)
            {
                d = b * b - 4 * a * c;

                if (d < 0)
                    Console.WriteLine("Nu exista solutie in multimea R.");
                else
                {
                    if (d >= 0)
                    {
                        x1 = (-b + (float)Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - (float)Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine($"Solutiile: x1 = {x1}, x2 = {x2}");
                    }
                }
            }
            Question();
        }

        private static void Prob3()
        {
            Console.WriteLine("Problema 3: Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            float n = float.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'k': ");
            float k = float.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("Numarul n se divide cu k.");
            else Console.WriteLine("Numarul n nu se divide cu k.");
            Question();
        }

        private static void Prob4()
        {
            Console.WriteLine("Problema 4: Determinati daca un an y este an bisect.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'y': ");
            int y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                Console.WriteLine($"Anul {y} este bisect.");
            else Console.WriteLine($"Anul {y} nu este bisect.");
            Question();
        }

        private static void Prob5()
        {
            Console.WriteLine("Problema 5: Extrageti si afisati a k-a cifra de la sfarsitul unui numar.");
            Console.WriteLine();
            Console.Write("Introduce-ti numarul: ");
            int numar = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'k': ");
            int k = int.Parse(Console.ReadLine());
            int auxnum = numar, auxk = k;
            if (auxk == 1)
            {
                Console.WriteLine($"Prima cifra de la sfarsitul numarului {numar} este {numar % 10}.");
            }
            else
            {
                while (auxk > 1)
                {
                    auxk--;
                    auxnum /= 10;
                }
                Console.WriteLine($"A {k}-a cifra de la sfarsitul numarului {numar} este {auxnum % 10}.");
            }
            Question();
        }

        private static void Prob6()
        {
            Console.WriteLine("Problema 6: Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'b': ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'c': ");
            int c = int.Parse(Console.ReadLine());

            if ((a < b + c) && (b < a + c) && (c < a + b))
                Console.WriteLine("Da");
            else Console.WriteLine("Nu");
            Question();
        }

        private static void Prob7()
        {
            Console.WriteLine("Problema 7: Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'b': ");
            int b = int.Parse(Console.ReadLine());

            int aux = a;
            a = b;
            b = aux;

            Console.WriteLine($"a = {a}, b = {b}");
            Question();
        }

        private static void Prob8()
        {
            Console.WriteLine("Problema 8: Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'b': ");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a = {a}, b = {b}");
            Question();
        }

        private static void Prob9()
        {
            Console.WriteLine("Problema 9: Afisati toti divizorii numarului n.");
            Console.WriteLine();
            Console.Write("Introduce-ti numarul 'n': ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Divizorii numarului {n} sunt: 1 ");
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) Console.Write(i + " ");
            Console.WriteLine(n);
            Question();
        }

        private static bool Prim(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n != 2 && n % 2 == 0) return false;
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private static void Prob10()
        {
            Console.WriteLine("Problema 10: Determinati daca un numar n este prim.");
            Console.WriteLine();
            Console.Write("Introduce-ti numarul 'n': ");
            int n = int.Parse(Console.ReadLine());
            if (Prim(n)) Console.WriteLine($"Numarul {n} este prim.");
            else Console.WriteLine($"Numarul {n} nu este prim.");
            Question();
        }

        private static void Prob11()
        {
            Console.WriteLine("Problema 11: Afisati in ordine inversa cifrele unui numar n.");
            Console.WriteLine();
            Console.Write("Introduce-ti numarul 'n': ");
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                Console.Write(n % 10 + " ");
                n /= 10;
            }
            Question();
        }

        private static void Prob12()
        {
            Console.WriteLine("Problema 12: Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b].");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'n': ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'b': ");
            int b = int.Parse(Console.ReadLine());
            int contor = 0;
            bool ok = false;

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    contor++; ok = true;
                }
            }

            if (ok)
            {
                if (contor == 1)
                    Console.WriteLine($"In intervalul [{a}, {b}] exista un numar divizibil cu {n}.");
                else Console.WriteLine($"In intervalul [{a}, {b}] exista {contor} numere divizibile cu {n}.");
            }
            else Console.WriteLine($"In intervalul [{a}, {b}] nu exista numere divizibile cu {n}.");
            Question();
        }

        private static void Prob13()
        {
            Console.WriteLine("Problema 13: Determianti cati ani bisecti sunt intre anii y1 si y2.");
            Console.WriteLine();
            Console.Write("Introduce-ti variabila 'y1': ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti variabila 'y2': ");
            int y2 = int.Parse(Console.ReadLine());
            int contor = 0;
            bool ok = false;

            for (int y = y1; y <= y2; y++)
                if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                {
                    contor++; ok = true;
                }

            if (ok)
            {
                if (contor == 1)
                    Console.WriteLine($"Intre anii {y1} si {y2} exista un an bisect.");
                else Console.WriteLine($"Intre anii {y1} si {y2} exista {contor} ani bisecti.");
            }
            else Console.WriteLine($"Intre anii {y1} si {y2} nu exista ani bisecti.");
            Question();
        }

        private static void Prob14()
        {
            Console.WriteLine("Problema 14: Determinati daca un numar n este palindrom.");
            Console.WriteLine();
            Console.Write("Introduce-ti numarul 'n': ");
            int n = int.Parse(Console.ReadLine());
            int aux = n, invers = 0;

            while(aux!=0)
            {
                invers = invers * 10 + aux % 10;
                aux /= 10;
            }

            if (invers == n) Console.WriteLine($"Numarul {n} este palindrom.");
            else Console.WriteLine($"Numarul {n} nu este palindrom.");
            Question();
        }

        private static void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        private static void Prob15()
        {
            Console.WriteLine("Problema 15: Se dau 3 numere. Sa se afiseze in ordine crescatoare.");
            Console.WriteLine();
            Console.Write("Introduce-ti primul numar: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti al doilea numar: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti al treilea numar: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b) Swap(ref a, ref b);
            if (a > c) Swap(ref a, ref c);
            if (b > c) Swap(ref b, ref c);

            Console.WriteLine($"Numerele in ordine crescatoare sunt: {a} {b} {c}");
            Question();
        }

        private static void Prob16()
        {
            Console.WriteLine("Problema 16: Se dau 5 numere. Sa se afiseze in ordine crescatoare.");
            Console.WriteLine();
            Console.Write("Introduce-ti primul numar: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti al doilea numar: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti al treilea numar: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti al patrulea numar: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti al cincilea numar: ");
            int e = int.Parse(Console.ReadLine());

            if (a > b) Swap(ref a, ref b);
            if (a > c) Swap(ref a, ref c);
            if (a > d) Swap(ref a, ref d);
            if (a > e) Swap(ref a, ref e);
            if (b > c) Swap(ref b, ref c);
            if (b > d) Swap(ref b, ref d);
            if (b > e) Swap(ref b, ref e);
            if (c > d) Swap(ref c, ref d);
            if (c > e) Swap(ref c, ref e);
            if (d > e) Swap(ref d, ref e);

            Console.WriteLine($"Numerele in ordine crescatoare sunt: {a} {b} {c} {d} {e}");
            Question();
        }

        private static void Prob17()
        {
            Console.WriteLine("Problema 17: Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere folosind algoritmul lui Euclid.");
            Console.WriteLine();
            Console.Write("Introduce-ti primul numar: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti al doilea numar: ");
            int b = int.Parse(Console.ReadLine());

            int aux1 = a, aux2 = b;
            while(aux1!=aux2)
            {
                if (aux1 < aux2)
                    aux2 -= aux1;
                else
                    aux1 -= aux2;
            }

            Console.WriteLine($"Cmmdc si cmmmc al numerelor {a} si {b} sunt numerele {aux1}, respectiv {(a*b)/aux1}.");
            Question();
        }

        private static void Prob18()
        {
            Console.WriteLine("Problema 18: Afisati descompunerea in factori primi ai unui numar n.");
            Console.WriteLine();
            Console.Write("Introduce-ti numarul 'n': ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write(n + " = ");

            bool ok = false;
            int contor = 0, factor = 3;
            if (n % 2 == 0)
            {
                while (n % 2 == 0)
                {
                    n /= 2; contor++; ok = true;
                }
                Console.Write($"2^{contor}");
            }

            while(n!=1)
            {
                contor = 0;
                if ((n % factor != 0) || !Prim(factor))
                    factor += 2;
                else
                {
                    while (n % factor == 0)
                    {
                        n /= factor; contor++;
                    }
                    if (ok)
                        Console.Write(" x ");
                    Console.Write($"{factor}^{contor}");
                    ok = true;
                    factor += 2;
                }
            }
            Console.WriteLine();
            Question();
        }

        private static void Prob19()
        {
            Console.WriteLine("Problema 19: Determinati daca un numar e format doar cu 2 cifre care se pot repeta.");
            Console.WriteLine();
            Console.Write("Introduce-ti numarul: ");
            int n = int.Parse(Console.ReadLine());
            int aux = n;

            var v = new bool[10];
            while(aux!=0)
            {
                v[aux % 10] = true;
                aux /= 10;
            }
            int contor = 0;
            for(int i=0; i<10; i++)
            {
                if (v[i]) contor++;
            }
            if (contor == 1)
                Console.WriteLine("Nu, numarul este format dintr-o singura cifra care se repeta.");
            else
            {
                if (contor == 2) Console.WriteLine("Da, numarul este format din doua cifre care se repeta.");
                else Console.WriteLine("Nu, numarul este format din mai mult de doua cifre.");
            }
            Question();
        }

        private static void Prob20()
        {
            Console.WriteLine("Afisati fractia m/n in format zecimal, cu perioada intre paranteze daca e cazul.");
            Console.WriteLine();
            Console.Write("Introduce-ti numarul 'm': ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Introduce-ti numarul 'n': ");
            int n = int.Parse(Console.ReadLine());

            int parteInt = m / n;
            int parteFrac = m % n;

            Console.WriteLine();
            Console.Write($"Fractia {m}/{n} in format zecimal este: {parteInt},");

            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFrac);
            bool periodic = false;

            do
            {
                cifra = parteFrac * 10 / n;
                cifre.Add(cifra);
                rest = parteFrac * 10 % n;
                if (!resturi.Contains(rest))
                    resturi.Add(rest);
                else
                {
                    periodic = true;
                    break;
                }
                parteFrac = rest;
            } while (rest != 0);

            if(!periodic)
            {
                foreach (var item in cifre)
                    Console.Write(item);
            }
            else
            {
                for(int i = 0; i < resturi.Count; i++)
                {
                    if(resturi[i] == rest)
                        Console.Write("(");
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
            Console.WriteLine();
            Question();
        }

        static Random rnd = new Random();

        private static void Prob21()
        {
            Console.WriteLine("Problema 21: Ghiciti un numar intre 1 si 1024 prin intrebari de forma numarul este mai mare sau egal decat x?");
            int x = rnd.Next(0, 1024), n, i=0;
            bool ok = false, ok2 = false;
            while (!ok)
            {
                Console.WriteLine();
                Console.WriteLine("Intrebari:");
                Console.WriteLine("1. x mai mare decat n?");
                Console.WriteLine("2. x mai mic decat n?");
                Console.WriteLine("3. x divizibil cu n?");
                Console.WriteLine("4. este x numar prim?");
                Console.WriteLine("5. este x egal cu n?");
                Console.WriteLine("6. Afisati numarul (optiunea asta v-a inchide secventa).");
                Console.Write("Introduce-ti numarul intrebarii dorite: ");
                i = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (i == 1)
                {
                    Console.Write("Introduce-ti numarul 'n': ");
                    n = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (x > n)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Da, x este mai mare de {n}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Nu, x nu este mai mare de {n}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }


                if (i == 2)
                {
                    Console.Write("Introduce-ti numarul 'n': ");
                    n = int.Parse(Console.ReadLine());

                    if (x < n)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Da, x este mai mic de {n}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Nu, x nu este mai mic de {n}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (i == 3)
                {
                    Console.Write("Introduce-ti numarul 'n': ");
                    n = int.Parse(Console.ReadLine());

                    if (x % n == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Da, x este divizibil cu {n}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Nu, x nu este divizibil cu {n}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (i == 4)
                {
                    if (Prim(x))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Da, x este prim");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nu, x nu este prim");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (i == 5)
                {
                    Console.Write("Introduce-ti numarul 'n': ");
                    n = int.Parse(Console.ReadLine());

                    if (x == n)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Da, este egal {n}");
                        ok = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Nu, nu este egal cu {n}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (i == 6)
                {
                    Console.WriteLine(x);
                    ok = true;
                    ok2 = true;
                }
            }
            if (!ok2) Console.WriteLine("Felicitari! Ai ghicit numarul.");
            Question();
        }
    }

}
