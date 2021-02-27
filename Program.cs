using System;

namespace PROJEM4
{
    class Program
    {
        static void Main(string[] args)
        {

            string  gun;
            Console.WriteLine(" 1 Haftalık Ajanda Programım . 9 Nisan Pazartesiden Baslamaktadır.... ");
            Console.WriteLine("9 - 15 Nisan  arası  Randevuları İçermektedir.");
            Console.WriteLine("Lutfen bu tarıhler arasında gırıs yapınız.");
            gun = Console.ReadLine();

            switch (gun)
            {
                case "9 Nisan Pazartesi":
                    Console.WriteLine();
                    Console.WriteLine(" Saat 12 de Okula gıdılecek.");
                    Console.WriteLine(" Projeye baslanacak.");
                    Console.WriteLine("Ödevler yapılacak.");
                    break;

                case "10 Nisan Salı":
                    Console.WriteLine();
                    Console.WriteLine("13.00 da Toplantıya katıl.");
                    Console.WriteLine("17.00 da Tahlil Sonucları alınacak. ");
                    Console.WriteLine("Gorevlere bakılacak.");
                    break;

                case " 11 Nisan Carsamba":
                    Console.WriteLine();
                    Console.WriteLine("Alısverıs yapılacak.");
                    Console.WriteLine("Faturalar odenecek.");
                    Console.WriteLine("Arastırma yapılacak.");
                    break;
                case "12 Nisan Persembe":
                    Console.WriteLine();
                    Console.WriteLine("Hastaneye gıdılecek.");
                    Console.WriteLine("Araba yıkanacak.");
                    Console.WriteLine("Proje arastırılacak.");
                    break;

                case "13 Nisan Cuma":
                    Console.WriteLine("Odevler yapılacak.");
                    Console.WriteLine("Ev Temizlenecek.");
                    Console.WriteLine("Dershaneye gıdılecek.");
                    break;

                case "14 Nisan Cumartesi":
                    Console.WriteLine();
                    Console.WriteLine("Gorevler dagıtılacak");
                    Console.WriteLine("Proje arastırması yapılacak.");
                    Console.WriteLine("Toplantı yapılacak.");
                    break;

                case "15 Nisan Pazar":
                    Console.WriteLine();
                    Console.WriteLine("Tez Yazılacak.");
                    Console.WriteLine("Proje tamamlanacak.");
                    Console.WriteLine("Arastırma  sonucları yazılacak.");
                    break;

                default:
                    Console.WriteLine("Bu tarıh de herhangı bır randevunuz bulunmamaktadır.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
