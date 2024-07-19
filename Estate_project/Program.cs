using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Estate_project
{
    public class Estate
    {
        public double Amount;
        public int NumberOfEstate;
        public double SpaseOfEstate;
        public bool garden;
        public double SpaseOfgarden;
        public string TypeOfEstate;
        public string Location;
        public int NumOfBedrooms;
        public int NumOfBathroom;
        public int FloorNumber;
        public bool Furnish;
        public string TypeOfPay;
        public string brief;
        public DateTime Time;
        public string v;
        ArrayList EstateInfo;
        public Estate()
        {

        }

        public Estate(double amount,int numberOfEstate, double spaseOfEstate,bool Garden, double spaseOfgarden,string typeOfEstate,string location, int numOfBedrooms, int numOfBathroom,int floorNumber,bool furnish ,string typeOfPay, string Brief,DateTime time)
        {
                        
            Amount = amount;
            NumberOfEstate = numberOfEstate;
            SpaseOfEstate = spaseOfEstate;
            garden = Garden;
            SpaseOfgarden = spaseOfgarden;
            TypeOfEstate = typeOfEstate;
            Location = location;
            NumOfBedrooms = numOfBedrooms;
            NumOfBathroom = numOfBathroom;
            FloorNumber = floorNumber;
            Furnish = furnish;
            TypeOfPay = typeOfPay;
            brief =Brief;
            Time = time;
        }
        public void DisplayShort()//brief
        {
            Console.WriteLine($"Amount: {Amount} Negotiable.\nAbstract: {brief}\nLocation: {Location}\nTime: {Time}");
            if (garden)
            {
                Console.WriteLine($"It has garden.\nthe spased of garden is{SpaseOfgarden}");
            }
            else
            {
                Console.WriteLine("It has not garden.");
            }
        }
        public void DisplayAll()//ArrayList AllInfo
        {
            Console.WriteLine($"-The type of Estate: {TypeOfEstate}.\n\n-Location: {Location}.\n\n-The Amount: {Amount}.\n\n-The type of paying: {TypeOfPay}.\n\n-The apase of estate: {SpaseOfEstate}.\n\n-Bedrooms number: {NumOfBedrooms}.\n\n-Bathrooms number: {NumOfBathroom}.\n\n-Is furnished? : {Furnish}.");
            if (TypeOfEstate.ToUpper() == "PARTMENT")
            {
                Console.WriteLine($"\n-The floor: {FloorNumber}.\n");
            }
            Console.WriteLine("You want bay?");
            v = Console.ReadLine();
            if (v.ToUpper() == "TRUE" || v.ToUpper() == "YES")
            {
                Console.WriteLine("\n-Phone call?-\t-WhatsApp chat?-\t-Message?-\n\n");
                here:
                string shoose = Console.ReadLine();
                if (shoose.ToUpper() == "PHONE CALL")
                {
                    Console.WriteLine("Call us whis this number [777 888 999].\n\n");
                }
                else if (shoose.ToUpper() == "WHATSAPP CHAT")
                {
                    Console.WriteLine("connect us whis this number[777 888 999].\n\n");
                    
                }
                else if (shoose.ToUpper() == "MESSAGE")
                {
                    Console.WriteLine("write: ");
                    string m = Console.ReadLine();
                    Console.WriteLine("it will be answered as soon as the message arrives,The purchase has been completed\n\nThanks.\n\n");
                }
                else
                {
                    Console.WriteLine("\nPlese enter agean.\n\n");
                    goto here;
                }
            }
        }
        public static void UseItInMain(ArrayList EstateList,int a,int b)
        {
            Console.WriteLine("\nPlease, select your choise.\n\n");
            int l = int.Parse(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                if (l == i + 1)
                {
                    Estate E = (Estate)EstateList[i];
                    E.DisplayAll();
                    if (E.v.ToUpper() == "TRUE" || E.v.ToUpper() == "YES")
                    {
                        EstateList.Remove(E);
                    }
                    else
                    {
                        Console.WriteLine("\n\nThankyou for your time.\n");
                    }
                }
            }
        }

    }
    public class All_Estate : Estate
    {
        public All_Estate()
        {

        }
        public All_Estate(double amount, int numberOfEstate, double spaseOfEstate, bool Garden, double spaseOfgarden, string typeOfEstate, string location, int numOfBedrooms, int numOfBathroom, int floorNumber, bool furnish, string typeOfPay, string Brief, DateTime time): base( amount,  numberOfEstate,  spaseOfEstate,  Garden,  spaseOfgarden,  typeOfEstate,  location,  numOfBedrooms,  numOfBathroom,  floorNumber,  furnish,  typeOfPay,  Brief,  time)
        {

        }
        public virtual void Display_short_info(ArrayList ShortInfo)
        {
            int i = 0;
            foreach (Estate Es in ShortInfo)
            {
                Console.WriteLine($"[{i + 1}]");
                Es.DisplayShort();
                Console.WriteLine("--------------------------------------");
                i += 1;
            }
        }
        public void Display_All_info(ArrayList AllInfo)
        {
            int i = 0;
            foreach (Estate Es in AllInfo)
            {
                Console.WriteLine($"[{i + 1}]");
                Es.DisplayAll();
                Console.WriteLine("--------------------------------------");
                i += 1;
            }
        }
    }
    public class Ascending_Estate : All_Estate
    {
        public Ascending_Estate()
        {

        }
        public Ascending_Estate(double amount, int numberOfEstate, double spaseOfEstate, bool Garden, double spaseOfgarden, string typeOfEstate, string location, int numOfBedrooms, int numOfBathroom, int floorNumber, bool furnish, string typeOfPay, string Brief, DateTime time) : base(amount, numberOfEstate, spaseOfEstate, Garden, spaseOfgarden, typeOfEstate, location, numOfBedrooms, numOfBathroom, floorNumber, furnish, typeOfPay, Brief, time)

        {

        }
        public virtual ArrayList Display_short_info(ArrayList EstateOpj)
        {
            ArrayList newEstateList = new ArrayList();
            ArrayList AmountList = new ArrayList();
            foreach (Estate obj in EstateOpj)
            {
                AmountList.Add(obj.Amount);;
            }
          AmountList.Sort();
            int i = 0;
            foreach (double amount in AmountList)
            {
                foreach (Estate obj in EstateOpj)
                {
                    if (obj.Amount == amount)
                    {
                        Console.WriteLine($"[{i + 1}]");
                        obj.DisplayShort();
                        Console.WriteLine("--------------------------------------");
                        i += 1;
                    }
                }
            }
            return newEstateList;
        }
    }
    public class Descending_Estate : All_Estate
    {
        public Descending_Estate()
        {

        }
        public Descending_Estate(double amount, int numberOfEstate, double spaseOfEstate, bool Garden, double spaseOfgarden, string typeOfEstate, string location, int numOfBedrooms, int numOfBathroom, int floorNumber, bool furnish, string typeOfPay, string Brief, DateTime time) : base(amount, numberOfEstate, spaseOfEstate, Garden, spaseOfgarden, typeOfEstate, location, numOfBedrooms, numOfBathroom, floorNumber, furnish, typeOfPay, Brief, time)
        {

        }
        public virtual ArrayList Display_short_info(ArrayList EstateOpj)
        {
            ArrayList AmountList = new ArrayList();
            ArrayList newEstateList = new ArrayList();
            foreach (Estate obj in EstateOpj)
            {
                AmountList.Add(obj.Amount);
            }
            AmountList.Sort();
            AmountList.Reverse();
            int i = 0;
            foreach (double amount in AmountList)
            {
                foreach (Estate obj in EstateOpj)
                {
                    if (obj.Amount == amount)
                    {
                        Console.WriteLine($"[{i + 1}]");
                        obj.DisplayShort();
                        newEstateList.Add(obj);
                        Console.WriteLine("--------------------------------------");
                        i += 1;
                    }
                }
            }
            return newEstateList;
        }
    }
    public class NewListed : All_Estate
    {
        public NewListed()
        {

        }
        public NewListed(double amount, int numberOfEstate, double spaseOfEstate, bool Garden, double spaseOfgarden, string typeOfEstate, string location, int numOfBedrooms, int numOfBathroom, int floorNumber, bool furnish, string typeOfPay, string Brief, DateTime time) : base(amount, numberOfEstate, spaseOfEstate, Garden, spaseOfgarden, typeOfEstate, location, numOfBedrooms, numOfBathroom, floorNumber, furnish, typeOfPay, Brief, time)
        {

        }
        public virtual ArrayList Display_short_info(ArrayList EstateOpj)
        {
            ArrayList DateList = new ArrayList();
            ArrayList newEstateList = new ArrayList();
            foreach (Estate obj in EstateOpj)
            {
                DateList.Add(obj.Time);
            }
            DateList.Sort();
            DateList.Reverse();
            int i = 0;
            foreach (DateTime time in DateList)
            {
                foreach (Estate obj in EstateOpj)
                {
                    if (obj.Time == time)
                    {
                        Console.WriteLine($"[{i + 1}]");
                        obj.DisplayShort();
                        newEstateList.Add(obj);
                        Console.WriteLine("--------------------------------------");
                        i += 1;
                    }
                }
            }
            return newEstateList;
        }
    }
    public class BetwenAmount : All_Estate
    {
        public double LowAmount;
        public double LargeAmount;
        public BetwenAmount()
        {

        }
        public BetwenAmount(double amount, int numberOfEstate, double spaseOfEstate, bool Garden, double spaseOfgarden, string typeOfEstate, string location, int numOfBedrooms, int numOfBathroom, int floorNumber, bool furnish, string typeOfPay, string Brief, DateTime time) : base(amount, numberOfEstate, spaseOfEstate, Garden, spaseOfgarden, typeOfEstate, location, numOfBedrooms, numOfBathroom, floorNumber, furnish, typeOfPay, Brief, time)
        {

        }
        public virtual ArrayList Display_short_info(ArrayList EstateOpj)
        {
            Console.WriteLine("Enter the low Amount: ");
            LowAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the large Amount: ");
            LargeAmount = double.Parse(Console.ReadLine());
            ArrayList AmountList = new ArrayList();
            ArrayList newList = new ArrayList();
            foreach (Estate obj in EstateOpj)
            {
                AmountList.Add(obj.Amount);
            }
            int i = 0;
            foreach (Estate obj in EstateOpj)
            {
                if (obj.Amount >= LowAmount && obj.Amount <= LargeAmount)
                {
                    Console.WriteLine($"[{i + 1}]");
                    obj.DisplayShort();
                    newList.Add(obj);
                    Console.WriteLine("--------------------------------------");
                    i++;
                }
            }
            return newList;
        }
    }
    public class Estate_Sale : Estate
    {
        public Estate_Sale()
        {

        }
        public Estate GetInfo()
        {
            Estate E1 = new Estate();

            Console.WriteLine("\n\n\n-The Type of estate: ");
            E1.TypeOfEstate = Console.ReadLine();

            Console.WriteLine("\n\n\n-The location: ");
            E1.Location = Console.ReadLine();

            Console.WriteLine("\n\n\n-The Amount: ");
            E1.Amount = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\n\n-The Spase Of Estate: ");
            E1.SpaseOfEstate = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\n\n-It has gerden: ");
            string Bole = Console.ReadLine();
            if (Bole.ToUpper() == "YES" || Bole.ToUpper() == "TRUE")
            {
                E1.garden = true;
            }
            else
            {
                E1.garden = false;
            }
            if (E1.garden)
            {
                Console.WriteLine("\n\n\n-The Spase Of garden: ");
                E1.SpaseOfgarden = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n\n\n-The Number Of Bedrooms: ");
            E1.NumOfBedrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n\n-The Number Of Bathroom: ");
            E1.NumOfBathroom = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n\n-The number of Floor: ");
            E1.FloorNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n\n-It is Furnished: ");
            string Bol = Console.ReadLine();
            if (Bol.ToUpper() == "YES" || Bol.ToUpper() == "TRUE")
            {
                E1.Furnish = true;
            }
            else
            {
                E1.Furnish = false;
            }

            Console.WriteLine("\n\n\n-Gev us short brief for this estate: ");
            E1.brief = Console.ReadLine();
            Console.WriteLine("\n\n\n---------------------------------------Finish---------------------------------------");

            return E1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList EstateList = new ArrayList();
            Estate e1 = new Estate(27000000.0, 30, 734, false, 0, "detached villa", "Pyramids Walk", 8, 6, 1, false, "Cash or installments", "Villa for sale in Pyramids Walk Compound", DateTime.Now);
            EstateList.Add(e1);
            Estate e2 = new Estate(1899000.0, 34, 180, true, 30, "partment", "Muklla", 3, 3, 1, false, "Cash", "Apartment for sale in Al Dis area in Mukalla", new DateTime(2024, 7, 14));
            EstateList.Add(e2);
            Estate e3 = new Estate(1300000.0, 3, 150, false, 0, "partment", "Fifth Settlement/ New Cairo", 3, 2, 1, false, "Cash", "Front roof apartment, Gardenia shot 1", new DateTime(2024, 5, 31));
            EstateList.Add(e3);
            Estate e4 = new Estate(21000000.0, 80, 730, false, 0, "detached villa", "Pyramids Walk", 8, 6, 0, false, "Cash or installments ", "Villa for sale in Pyramids Walk Compound in October", new DateTime(2024, 1, 12));
            EstateList.Add(e4);
            Estate e5 = new Estate(29000000.0, 1, 756, false, 0, "detached villa", "Palm Valley Sheikh Zayed", 7, 6, 0, false, "Cash", "Independent villa for sale in Palm Valley / Palm Hills / Sheikh Zayed", new DateTime(2023, 2, 13));
            EstateList.Add(e5);
            Estate e6 = new Estate(9000000.0, 12, 186, true, 50, "Partment", "Mukalla", 3, 3, 1, false, "Cash", "apartment for sale in the most prestigious complexees in Mukalla", new DateTime(2024, 12, 22));
            EstateList.Add(e6);
            Estate e7 = new Estate(1333000.0, 3, 150, false, 0, "partment", "Mukalla", 3, 2, 1, false, "Cash", "Front roof apartment, Gardenia shot 3", new DateTime(2024, 9, 28));
            EstateList.Add(e7);
            Estate e8 = new Estate(19530000.0, 32, 455, false, 0, "detached villa", "The Crown", 5, 3, 0, false, "Cash or installments", "Standalone for sale in palm hills the crown view land scape", new DateTime(2024, 3, 16));
            EstateList.Add(e8);
            Estate e9 = new Estate(1096000.0, 35, 173, true, 43, "partment", "Regent's Park/New Cairo", 3, 2, 1, false, "Cash", "A ﬁnished apartment with a private garden in Regent's Park in the New Settlement in installments with only 10 down payment", new DateTime(2024, 9, 3));
            EstateList.Add(e9);
            home:
            Console.WriteLine("-----Welcome in Dubizzle store-----\nfor Estate");
            Console.WriteLine("\n\t[1] Buying real estate.");
            Console.WriteLine("\n\t[2] Saling real estate.");
            Console.WriteLine("\n\t[3] Exit");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("please, select your choise.");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    page1:
                    Console.WriteLine("\n\t[1] Featured real estate.");
                    Console.WriteLine("\n\t[2] All estate.");
                    Console.WriteLine("\n\t[3] Newly added estate");
                    Console.WriteLine("\n\t[4] The lowest price real estate.");
                    Console.WriteLine("\n\t[5] The most price real estate.");
                    Console.WriteLine("\n\t[6] A specific amount.");
                    Console.WriteLine("\n\t[7] Homepage");
                    Console.WriteLine("\n\nPlease, select your choise.");
                    int m = int.Parse(Console.ReadLine());
                    switch (m)
                    {
                        case 1:
                            for (int i = 0; i < 3; i++)
                            {
                                Estate E_ = (Estate)EstateList[i];
                                Console.WriteLine($"[{i+1}]");
                                E_.DisplayShort();
                                Console.WriteLine("\n------------------------------------------\n");
                            }
                            Estate.UseItInMain(EstateList, 0, 3);
                            goto page1;
                            break;
                        case 2:
                            for (int i = 0; i < EstateList.Count; i++)
                            {
                                Estate E_ = (Estate)EstateList[i];
                                Console.WriteLine($"[{i+1}]");
                                E_.DisplayShort();
                                Console.WriteLine("\n------------------------------------------\n");
                            }
                            Estate.UseItInMain(EstateList, 0, EstateList.Count);
                            goto page1;
                            break;
                        case 3:
                            NewListed N1 = new NewListed();
                            ArrayList newarray1 = N1.Display_short_info(EstateList);
                            Estate.UseItInMain(newarray1, 0, EstateList.Count);
                            goto page1;
                            break;
                        case 4:
                            Ascending_Estate A1 = new Ascending_Estate();
                            ArrayList newarray2 = A1.Display_short_info(EstateList);
                            Estate.UseItInMain(newarray2, 0, EstateList.Count);
                            goto page1;
                            break;
                        case 5:
                            Descending_Estate D1 = new Descending_Estate();
                            ArrayList newarray3 = D1.Display_short_info(EstateList);
                            Estate.UseItInMain(newarray3, 0, EstateList.Count);
                            goto page1;
                            break;
                        case 6:
                            BetwenAmount B1 = new BetwenAmount();
                            ArrayList newarray4 = B1.Display_short_info(EstateList);
                            Estate.UseItInMain(newarray4, 0, EstateList.Count);
                            goto page1;
                            break;
                        default:
                            goto page1;
                    }
                    goto home;
                    break;
                case 2:
                    Console.WriteLine("\n\t[1]Saling real estate.");
                    Console.WriteLine("\n\t[2]Homepage");
                    Console.WriteLine("\n\nPlease, select your choise.");
                    int r = int.Parse(Console.ReadLine());
                    switch (r)
                    {
                        case 1:
                            page2:
                            Estate_Sale E_S = new Estate_Sale();
                            Estate E = E_S.GetInfo();
                            E.Time = DateTime.Now;
                            EstateList.Add(E);
                            goto home;
                            break;
                        case 2:
                            goto home;
                    }
                    break;
                case 3:
                    break;
                default:
                    goto home;
                    break;
            }
        }
    }
}

//Method isnot run
//ArrayList EstateInfo = new ArrayList() { new ArrayList() { 27000000.0, 30, 734, false, 0, "detached villa", "Pyramids Walk", 8, 6, 1, false, "Cash or installments", "Villa for sale in Pyramids Walk Compound", new DateTime(2024,2,12) },
//new ArrayList() { 1899000.0, 34, 180, true, 30, "partment", "Muklla", 3, 3, 1, false, "Cash", "Apartment for sale in Al Dis area in Mukalla", new DateTime(2024,7,14)  },
//    new ArrayList() { 1300000.0, 3, 150, false, 0, "partment", "Fifth Settlement New Cairo", 3, 2, 1, false, "Cash", "Front roof apartment, Gardenia shot 1", new DateTime(2024,5,31)  },
//    new ArrayList() { 21000000.0, 80, 730, false, 0, "detached villa", "Pyramids Walk", 8, 6, 0, false, "Cash or installments ", "Villa for sale in Pyramids Walk Compound in October", new DateTime(2024,1,12)  },
//    new ArrayList() { 29000000.0, 1, 756, false, 0, "detached villa", "Palm Valley Sheikh Zayed", 7, 6, 0, false, "Cash", "Independent villa for sale in Palm Valley Palm Hills Sheikh Zayed", new DateTime(2023,2,13)  },
//    new ArrayList() { 9000000.0, 12, 186, true, 50, "Partment", "Mukalla", 3, 3, 1, false, "Cash", "apartment for sale in the most prestigious complexees in Mukalla", new DateTime(2024,12,22)  },
//    new ArrayList() { 1333000.0, 3, 150, false, 0, "partment", "Mukalla", 3, 2, 1, false, "Cash", "Front roof apartment, Gardenia shot 3", new DateTime(2024,9,28)  },
//    new ArrayList() { 19530000.0, 32, 455, false, 0, "detached villa", "The Crown", 5, 3, 0, false, "Cash or installments", "Standalone for sale in palm hills the crown view land scape", new DateTime(2024,3,16)  },
//    new ArrayList() { 1096000.0, 35, 173, true, 43, "partment", "Regent Park New Cairo", 3, 2, 1, false, "Cash", "A ﬁnished apartment with a private garden in Regent's Park in the New Settlement in installments with only 10 down payment", new DateTime(2024, 9, 3) } };
//foreach (ArrayList i in EstateInfo)
//{
//    Estate e = new Estate((double)i[0], (int)i[1], (double)i[2], (bool)i[3], (double)i[4], (string)i[5], (string)i[6], (int)i[7], (int)i[8], (int)i[9], (bool)i[10], (string)i[11], (string)i[12], (DateTime)i[13]);
//    EstateList.Add(e);
//}



