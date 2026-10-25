using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            string  imeraz= "3.e";//unosimo ime razreda
            string unos = Console.ReadLine();//tražimo od korisnika vrijednosti varijable
            int brojucenika = int.Parse(unos);


            string unos2 = Console.ReadLine();
            int brojpredmeta = int.Parse(unos2);



            string unos3 = Console.ReadLine();
            double prosjek = double.Parse(unos3);

            
            Console.WriteLine("ime razreda:{0}\nbroj ucenika:{1}\nbroj predmeta:{2}\nprosijek:{3} ",imeraz,brojucenika,brojpredmeta,prosjek);//ispisujemo sve varijable koje imamo
           
            
            Console.ReadLine();//ispisujemo vrijednosti
            //mijenjamo vrijednosti varijabla
            imeraz = "4.e";
            brojucenika = brojucenika + 3;
            brojpredmeta = brojpredmeta - 1;
            prosjek = prosjek + 0.05;

            Console.WriteLine("ime razreda:{0}\nnovi broj ucenika:{1}\nnovi broj predmeta:{2}\npoboljšani prosjek:{3} ",imeraz, brojucenika, brojpredmeta, prosjek);//ispsujemo nove varijable
            Console.ReadLine();
          
        }
    }
}
