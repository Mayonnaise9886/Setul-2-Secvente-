using System;
using System.Collections.Specialized;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {


            string DN = "DA";
            while (DN == "DA")
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Introduceti numarul problemei: \n");
                Console.ForegroundColor = ConsoleColor.White;


                int nrpb = Convert.ToInt32(Console.ReadLine());
                switch (nrpb)
                {
                    case 1:

                        //Se da o secventa de n numere.Sa se determine cate din ele sunt pare. 

                        Console.WriteLine("Cerinta este : se da o secventa de n numere. Sa se determine cate din ele sunt pare\r\nIntroduceti numarul de valori din secventa\n");

                        int n = Convert.ToInt32(Console.ReadLine());
                        int nr = 0;
                        Console.WriteLine("Introduceti valorile din secventa");
                        while (n > 0)
                        {
                            int x = Convert.ToInt32(Console.ReadLine());
                            n -= 1;
                            if (x % 2 == 0)
                                nr++;

                        }

                        Console.WriteLine("sunt " + nr + " numere pare in secventa\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 2:

                        //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 

                        Console.WriteLine("Cerinta este: Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.\nIntroduceti numarul de valori din secventa: \n");

                        int n1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduceti secventa de numere: ");
                        int nrm = 0, nre = 0, nrp = 0;
                        while (n1 > 0)
                        {
                            int x1 = Convert.ToInt32(Console.ReadLine());
                            if (x1 < 0)
                                nrm++;
                            if (x1 == 0)
                                nre++;
                            if (x1 > 0)
                                nrp++;
                            n1 -= 1;

                        }

                        Console.WriteLine("Sunt " + nrm + " numere negative, " + nre + " numere egale cu 0, si " + nrp + " numere pozitive");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 3:


                        //Calculati suma si produsul numerelor de la 1 la n.

                        Console.WriteLine("Cerinta este: Calculati suma si produsul numerelor de la 1 la n.\nIntroduceti numarul n:\n");

                        int n3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Suma de la 1 la n este: " + (n3 * (n3 + 1) / 2));

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 4:

                        //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 

                        Console.WriteLine("Cerinta este: Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a \r\nIntroduceti numarul de valori din secventa");

                        int n4 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduceti numarul a:\n");

                        int a = Convert.ToInt32(Console.ReadLine());
                        int nr1 = -1;
                        int poz = -2;

                        Console.WriteLine("Introduceti valorile din secventa\n");

                        while (n4 > 0)
                        {
                            int x100 = Convert.ToInt32(Console.ReadLine());
                            n4 -= 1;
                            nr1++;
                            if (a == x100)
                            {
                                poz = nr1;
                            }

                        }

                        if (poz != -2)
                            Console.WriteLine("Pozitia lui a este: " + poz);
                        else
                            Console.WriteLine("a nu exista in secventa data. Raspuns : -1");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 5:
                        //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 

                        Console.WriteLine("Cerinta este: Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa\nIntroduceti numarul de valori din secventa\n");

                        int n5 = Convert.ToInt32(Console.ReadLine());

                        int poz2 = -1;
                        int nr3 = 0;

                        Console.WriteLine("Introduceti numerele din secventa\n");

                        while (n5 > 0)
                        {
                            int x4 = Convert.ToInt32(Console.ReadLine());
                            poz2++;
                            n5 -= 1;
                            if (x4 == poz2)
                                nr3++;
                        }
                        Console.WriteLine(nr3 + " numere din secventa sunt egale cu pozitiile pe care apar\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 6:

                        //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 

                        Console.WriteLine("Cerinta este: Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.\r\nIntroduceti numarul de valori din secventa\n");

                        int n6 = Convert.ToInt32(Console.ReadLine());

                        int x7 = -999;

                        bool notok = false;

                        Console.WriteLine("Introduceti numerele din secventa:\n");

                        while (n6 > 0)
                        {
                            int x6 = Convert.ToInt32(Console.ReadLine());
                            if (x6 <= x7)
                                notok = true;

                            x7 = x6;

                            n6 -= 1;

                        }

                        if (notok == false)
                            Console.WriteLine("Numerele din secventa se afla in ordine crescatoare\n");
                        else
                            Console.WriteLine("Numerele din secventa nu se afla in ordine crescatoare\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();


                        break;

                    case 7:

                        //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa

                        Console.WriteLine("Cerinta este: Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa\r\nIntroduceti numarul de valori din secventa\n");

                        int n7 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduceti valorile din secventa\n");

                        int max = -9999;

                        int min = 9999;


                        while (n7 > 0)
                        {
                            int x8 = Convert.ToInt32(Console.ReadLine());
                            if (x8 > max)
                                max = x8;
                            if (x8 < min)
                                min = x8;

                            n7 -= 1;

                        }

                        Console.WriteLine("Cea mai mare valoare din secventa este: " + max + " iar cea mai mica este " + min);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 8:

                        //Determinati al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...

                        Console.WriteLine("Determianti al n-lea numar din sirul lui Fibonacci\r\nIntroduceti al n-lea numar pe care doriti sa il determin\n");

                        int n8 = Convert.ToInt32(Console.ReadLine());

                        int nmrdet = n8;

                        int nmr1 = 1, nmr2 = 1, nmr3 = 0;

                        if (n8 == 1)
                            Console.WriteLine("Primul numar din sirul lui Fibonacci este 1");
                        if (n8 == 2)
                            Console.WriteLine("Al doilea numar din sirul lui Fibonacci este 1");

                        while (n8 > 0)
                        {
                            nmr3 = nmr1 + nmr2;

                            nmr2 = nmr1;

                            nmr1 = nmr3;

                            n8 -= 1;
                        }

                        Console.WriteLine("Al " + nmrdet + " numar din sirul lui Fibonacci este: " + nmr3);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 9:

                        //Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 

                        Console.WriteLine("Cerinta este: Sa se determine daca o secventa de n numere este monotona\r\nIntroduceti numarul de elemente din secventa:\n");

                        int n10 = Convert.ToInt32(Console.ReadLine());

                        bool okc = true, okd = true, okegal = true;

                        Console.WriteLine("Introduceti secventa de numere:\n");

                        int x2 = Convert.ToInt32(Console.ReadLine());

                        while (n10 > 1)
                        {

                            int y = Convert.ToInt32(Console.ReadLine());

                            if (x2 > y)
                                okc = false;
                            else if (x2 < y)
                                okd = false;

                            if (x2 == y)
                                okegal = false;

                            n10 -= 1;

                            x2 = y;

                        }

                        if (okc == true && okegal == true)
                            Console.WriteLine("Sirul este monoton strict crescator\n");
                        else if (okc == true && okegal == false)
                            Console.WriteLine("Sirul este monoton crescator\n");

                        if (okd == true && okegal == true)
                            Console.WriteLine("Sirul este monoton strict descrescator\n");
                        else if (okd == true && okegal == false)
                            Console.WriteLine("Sirul este monoton descrescator\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 10:

                        //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 

                        Console.WriteLine("Cerinta este: Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.\r\nIntroduceti numarul de valori din secventa");

                        int n11 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduceti valorile din secventa:\n");

                        int x3 = Convert.ToInt32(Console.ReadLine());

                        int max1 = 1, max2 = 0;

                        while (n11 > 1)
                        {
                            int y2 = Convert.ToInt32(Console.ReadLine());

                            {
                                if (x3 == y2)
                                    max1++;
                                else if (max1 > max2)
                                {
                                    max2 = max1;
                                    max1 = 1;
                                }

                                n11 -= 1;
                                x3 = y2;
                            }
                        }

                        Console.WriteLine("Cea mai mare secventa de valori consecutive egale este de: " + max2 + " numere\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 11:

                        //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 


                        Console.WriteLine("Cerinta este: Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.\r\nIntroduceti numarul de valori din secventa");

                        int n12 = Convert.ToInt32(Console.ReadLine());

                        int sum3 = 0;

                        int ogl = 0;

                        Console.WriteLine("Introduceti valorile din secventa:\n");

                        while (n12 > 0)
                        {
                            int x13 = Convert.ToInt32(Console.ReadLine());

                            while (x13 != 0)
                            {
                                ogl = ogl * 10 + x13 % 10;
                                x13 = x13 / 10;
                            }

                            sum3 = sum3 + ogl;

                            ogl = 0;

                            n12 -= 1;

                        }

                        Console.WriteLine("Suma inverselor din secventa este: " + sum3);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 12:

                        //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 


                        Console.WriteLine("Cerinta este: Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere\r\nIntroduceti numarul de valori din secventa:\n");

                        int n14 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduceti valorile din secventa: \n");

                        bool okgrup = false;

                        int x14 = Convert.ToInt32(Console.ReadLine());

                        int nrgrup = 0, x15 = 0;

                        while (n14 > 1)
                        {
                            x15 = Convert.ToInt32(Console.ReadLine());

                            if (n14 == 2 && x15 != 0)
                                nrgrup++;

                            if (x14 != 0 && x15 == 0)
                                nrgrup++;

                            x14 = x15;

                            n14 -= 1;
                        }

                        if (nrgrup == 1)
                            Console.WriteLine("Exista un grup de numere consecutive diferite de 0 in secventa\n");
                        else
                            Console.WriteLine("Exista " + nrgrup + " grupuri de numere consecutive diferite de 0 in secventa\n");


                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 13:

                        //O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 

                        Console.WriteLine("Cerinta este: Determinati daca o secventa de n numere este o secventa crescatoare rotita\r\nIntroduceti numarul de valori din secventa\n");

                        int n16 = Convert.ToInt32(Console.ReadLine());

                        int x18 = 0;

                        Console.WriteLine("Introduceti valorile din secventa:\n");

                        int primulnr = Convert.ToInt32(Console.ReadLine());

                        int x17 = Convert.ToInt32(Console.ReadLine());

                        bool rotita = false, crc = false;

                        while (n16 > 2 && rotita == false)
                        {
                            x18 = Convert.ToInt32(Console.ReadLine());
                            if (x17 < x18)
                                crc = true;
                            else
                                crc = false;

                            x17 = x18;

                            n16 -= 1;

                            if (n16 == 2)
                                if (primulnr > x18 && crc == true)
                                    rotita = true;
                        }

                        if (rotita == true || crc == true)
                            Console.WriteLine("Secventa data este rotita crescatoare\n");
                        else
                            Console.WriteLine("Secventa data nu este rotita crescatoare");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 17:

                        //Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 

                        Console.WriteLine("Cerinta este: Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor\r\nIntroduceti numarul de valori din secventa:\n ");

                        int x19 = Convert.ToInt32(Console.ReadLine());

                        int nrde0 = 0, nrde1 = 0, nivincb = 0;

                        Console.WriteLine("Introduceti valorile din secventa: \n");

                        int x20 = Convert.ToInt32(Console.ReadLine());

                        bool ok = false;

                        if (x20 == 0)
                        {
                            ok = true;
                            nrde0++;
                        }
                        int x21, x22;

                        int nrdeschis = 0, nrinchis = 0, maxincub = 0;

                        while (x19 > 1 && ok == true)
                        {
                            x21 = Convert.ToInt32(Console.ReadLine());
                            if (x21 == 0)
                                nrde0++;
                            else
                                nrde1++;

                            if (nrde0 == nrde1 && maxincub <= nrde0)
                            {
                                maxincub = nrde0;
                                nrde1 = nrde0 = 0;
                            }
                            else if (nrde1 > nrde0)
                                ok = false;
                            x19--;

                        }
                        if (nrde1 != nrde0)
                            ok = false;

                        if (ok == true)
                            Console.WriteLine("Secventa este una parantezata corect si nivelul de incubare maxim este: " + maxincub);
                        else
                            Console.WriteLine("Secventa data nu este una parantezata corect\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();


                        break;

                    case 16:
                        //O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 

                        Console.WriteLine("Cerinta este: sa se determine daca este o secventa bitonica rotita.\r\nIntroduceti numarul de valori din secventa:\n");
                        
                        int n30 = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Introduceti valorile din secventa: \n");

                        int prim = 0, st, nr30, dr = 0, k = 0, s1 = 3, s2 = 3, s3 = 3, i = 0;

                        prim = Convert.ToInt32(Console.ReadLine());

                        st = prim;

                        nr30 = Convert.ToInt32(Console.ReadLine());

                        for(i = 2; i <= n30; i++)
                        {
                            if(i < n30)
                               dr = Convert.ToInt32(Console.ReadLine());
                            if (st < nr30 && k == 0)
                                s1 = 1;
                            if (st > nr30 && k == 0)
                                s1 = 0;
                            if (st < nr30 && k == 1)
                                s2 = 1;
                            if (st > nr30 && k == 1)
                                s2 = 0;
                            if (st < nr30 && k == 2)
                                s3 = 1;
                            if (st > nr30 && k == 2)
                                s3 = 0;

                            if(i < n30)
                            {
                                if (st < nr30 && dr < nr30)
                                    ++k;
                                if (st > nr30 && dr > nr30)
                                    ++k;
                                st = nr30;
                                nr30 = dr;
                            }
                        }
                        if (s1 == 1 && prim < nr30)
                            s1 = s2;
                        if (k <= 2 && s1 != s2)
                        {
                            if(s3!=3 && s3 == s1)
                                Console.WriteLine("Sirul este bitonic \n");
                            if(s3 == 3)
                                Console.WriteLine("Sirul este bitonic\n");
                        }
                        else
                            Console.WriteLine("Sirul nu este bitonic\n");
                               

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 15:

                        //O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 

                        Console.WriteLine("Cerinta este: Determinati daca o secventa este bitonica\r\nIntroduceti numarul de valori din secventa\n");

                        int n40 = Convert.ToInt32 (Console.ReadLine());

                        Console.WriteLine("Introduceti valorile din secventa: \n");

                        bool ok1 = false, ok3 = false;

                        int x40 = Convert.ToInt32(Console.ReadLine()), i5 = 0, l = 0;

                        while(n40 > 1)
                        {
                            if (i5 >= 1 && l >= x40 && ok1 == true)
                            {
                                ok1 = false;
                                ok3 = true;
                            }
                            else if(i5 >= 1 && ok3 == false && l<= x40)
                            {
                                ok1 = true;
                            }
                            n40--;
                            i5++;
                            l = x40;
                            x40 = Convert.ToInt32(Console.ReadLine());
                        }

                        if (ok3) 
                            Console.WriteLine("Secventa este bitonica");
                        else 
                            Console.WriteLine("Secventa nu este bitonica");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 14:

                        Console.WriteLine("Cerinta este: Determinati daca o secventa de n numere este o secventa monotona rotita.\r\nIntroduceti numarul de valori din secventa");

                        int x50, i50 = 0, l50 = 0, max51 = int.MinValue, min51, max52, min52 = int.MaxValue;

                        bool ok11 = true, ok12 = true, ok13 = true, ok14 = true;

                        int n50 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduceti valorile din secventa\n");

                        x50 = Convert.ToInt32(Console.ReadLine());

                        min51 = max52 = x50;

                        while (n50 > 1)
                        {
                            if (i50 >= 1 && l50 > x50 && ok11 == true)
                            {
                                ok1 = false;
                                max51 = l50; min51 = x50;
                            }
                            else if (ok11 == false && (x50 > max51 || x50 < min51))
                            {
                                ok12 = false;
                            }

                            if (i50 >= 1 && l50 < x50 && ok13 == true)
                            {
                                ok13 = false;
                                min52 = l50; 
                                max52 = x50;
                            }
                            else if (ok13 == false && (x50 < min52 || x50 > max52))
                            {
                                ok14 = false;
                            }

                            i50++;
                            l50 = x50;
                            x50 = Convert.ToInt32(Console.ReadLine());
                            n50--;
                        }
                        if (ok12) Console.WriteLine("Secventa rotita este crescatoare");
                        else if (ok14) Console.WriteLine("Secventa rotita este descrescatoare");
                        else Console.WriteLine("Secventa rotita nu este monotona");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;
                }
            }
        }
    }
}
