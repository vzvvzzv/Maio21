using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 = ? //cvp 30 (stack, deger /  int, dec, flo, double, bool)

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = ? //cvp 999, heap (referans / array, class, interface)

            // sayilar1 stack bellekte 101 adresinde tutuluyor karsiligi da heap'te 101 adresinde ise
            //sayilar2 stack bellekte 102 adresinde tutuluyor karsiligi da heap'te 102 adresinde ise
            //stack1'in 101'i artik 102'dir, bu durumda da heap'teki 102'yi isaret eder

            //deger tiplerde deger ataniyor, referans tiplerde adresi ataniyor, pointer
        }
    }
}
