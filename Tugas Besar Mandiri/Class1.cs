using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TGS_090518_5160411129_B
{

    public class Name
    {
        public string Nama;
        public Name(string name)
        {
            Nama = name;
        }
    }
    public class set
    {
        public bool sett;
        public set(bool seting)
            {
                sett = seting;
            }
    }


    class FastFood
    {
        protected string category;
        protected int price;
        protected int calory;
        protected string menuName;

        public FastFood()
        {
            category = "";
            price = 0;
            calory = 0;
            menuName = "";
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Calory
        {
            get { return calory; }
            set { calory = value; }
        }
        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }

        public void printFFInfo()
        {
            Console.WriteLine("Category : " + category);
            Console.WriteLine("Menu Name : " + menuName);
            Console.WriteLine("Price : Rp. " + price);
            Console.WriteLine("Calory : " + calory + " Calories");

        }

    }

    class FriedChicken : FastFood
    {
        protected string partOfchicken;
        protected Boolean isSpicy;
        protected string harga;

        public FriedChicken(string pochicken, Boolean iSpicy, int Caly)
        {
            partOfchicken = pochicken;
            isSpicy = iSpicy;
            Calory = Caly;
        }

        public string GenerateFCName()
        {
            category = " Fried Chicken";
            if (isSpicy == true)
            {
                MenuName = "Spicy " + partOfchicken + Category;
            }
            else if (isSpicy == false)
            {
                MenuName = partOfchicken + Category;
            }
            return MenuName;
        }

        public string SetPriceForFC()
        {
            if (isSpicy == true)
            {

                if (partOfchicken == "Tight")
                {
                    price = 23000;
                }
                else if (partOfchicken == "Rib")
                {
                    price = 25000;
                }
                else if (partOfchicken == "Drumstick")
                {
                    price = 18000;
                }
                else if (partOfchicken == "wing")
                {
                    price = 15000;
                }
            }
            else if (isSpicy == false)
            {
                if (partOfchicken == "Tight")
                {
                    price = 20000;
                }
                else if (partOfchicken == "Rib")
                {
                    price = 22000;
                }
                else if (partOfchicken == "Drumstick")
                {
                    price = 15000;
                }
                else if (partOfchicken == "wing")
                {
                    price = 12000;
                }
            }
            harga = Convert.ToString(price);
            return harga;
        }


    }

    class Pizza : FastFood
    {
        protected string[] Topping = new string[4];
        protected int jmlh_toping;
        protected string Crust;
        protected string Size;
        protected string MenuName2;
        protected string pric;

        public int Jmlh_toping
        {
            get { return jmlh_toping; }
            set { jmlh_toping = value; }
        }
        public string crust
        {
            get { return Crust; }
            set { Crust = value; }
        }
        public string size
        {
            get { return Size; }
            set { Size = value; }
        }
        public string menuName2
        {
            get { return MenuName2; }
            set { MenuName2 = value; }
        }

        public Pizza(string MenName, string Toping1, string Crst, string Sze,int Caly)
        {
            MenuName = MenName;
            Topping[0] = Toping1;
            Crust = Crst;
            Size = Sze;
            jmlh_toping = 1;
            calory = Caly;

        }
        public Pizza(string MenName, string Toping1, string Toping2, string Crst, string Sze, int Caly)
        {
            MenuName = MenName;
            Topping[0] = Toping1;
            Topping[1] = Toping2;
            Crust = Crst;
            Size = Sze;
            jmlh_toping = 2;
            calory = Caly;
        }
        public Pizza(string MenName, string Toping1, string Toping2, string Toping3, string Crst, string Sze, int Caly)
        {
            MenuName = MenName;
            Topping[0] = Toping1;
            Topping[1] = Toping2;
            Topping[2] = Toping3;
            Crust = Crst;
            Size = Sze;
            jmlh_toping = 3;
            calory = Caly;
        }
        public Pizza(string MenName, string Toping1, string Toping2, string Toping3, string Toping4, string Crst, string Sze, int Caly)
        {
            MenuName = MenName;
            Topping[0] = Toping1;
            Topping[1] = Toping2;
            Topping[2] = Toping3;
            Topping[3] = Toping4;
            Crust = Crst;
            jmlh_toping = 4;
            Size = Sze;
            calory = Caly;
        }

        public string GeneratePizzaName()
        {
            category = "Pizza";
            MenuName2 = Size + " " + Crust + " " + MenuName + " Pizza";
            return MenuName2;
        }

        public string SetPriceForPizza()
        {
            int harga = 0;
            switch (jmlh_toping)
            {
                case 1:

                    if (Size == "Personal")
                    {

                        if (Crust == "Simple")
                        {
                            price = 49000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 55000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 70000;
                        }

                    }
                    else if (Size == "Medium")
                    {

                        if (Crust == "Simple")
                        {
                            price = 69000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 75000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 90000;
                        }
                    }
                    else if (Size == "Large")
                    {

                        if (Crust == "Simple")
                        {
                            price = 99000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 105000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 120000;
                        }
                    }


                    break;

                case 2:

                    if (Size == "Personal")
                    {

                        if (Crust == "Simple")
                        {
                            price = 54000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 60000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 75000;
                        }

                    }
                    else if (Size == "Medium")
                    {

                        if (Crust == "Simple")
                        {
                            price = 74000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 80000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 95000;
                        }
                    }
                    else if (Size == "Large")
                    {

                        if (Crust == "Simple")
                        {
                            price = 104000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 110000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 125000;
                        }
                    }

                    break;

                case 3:

                    if (Size == "Personal")
                    {

                        if (Crust == "Simple")
                        {
                            price = 59000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 65000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 80000;
                        }

                    }
                    else if (Size == "Medium")
                    {

                        if (Crust == "Simple")
                        {
                            price = 79000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 85000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 100000;
                        }
                    }
                    else if (Size == "Large")
                    {

                        if (Crust == "Simple")
                        {
                            price = 109000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 115000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 130000;
                        }
                    }

                    break;

                case 4:

                    if (Size == "Personal")
                    {

                        if (Crust == "Simple")
                        {
                            price = 79000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 85000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 100000;
                        }

                    }
                    else if (Size == "Medium")
                    {
                        if (Crust == "Simple")
                        {
                            price = 99000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 105000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 120000;
                        }
                    }
                    else if (Size == "Large")
                    {

                        if (Crust == "Simple")
                        {
                            price = 129000;
                        }
                        else if (Crust == "Cheese")
                        {
                            price = 135000;
                        }
                        else if (Crust == "Sausage")
                        {
                            price = 150000;
                        }
                    }

                    break;

            }
            harga = price;

            pric = Convert.ToString(harga);

            return pric;
        }

        



    }

    class hamburger : FastFood
    {
        protected int nMeat;
        protected string meatType;
        protected string[] extraFiller = new string[3];
        protected int HarExFil;
        protected int jmlef;
        protected string with = "  " ;
        protected string pri;

        public int NMeat
        {
            get { return nMeat; }
            set { nMeat = value; }
        }
        public string MeatType
        {
            get { return meatType; }
            set { meatType = value; }
        }
        public int harExFil
        {
            get { return HarExFil; }
            set { HarExFil = value; }
        }
        public int Jmlef
        {
            get { return jmlef; }
            set { jmlef = value; }
        }
        public string With
        {
            get { return with; }
            set { with = value; }
        }

        public hamburger(int nMat, string mType, string eFiller1, int cal)
        {
            nMeat = nMat;
            meatType = mType;
            extraFiller[0] = eFiller1;
            calory = cal;
            jmlef = 1;

            if (eFiller1 == "Mushroom")
            {
                HarExFil = 3000;
            }
            if (eFiller1 == "Cheese")
            {
                HarExFil = 5000;
            }
            if (eFiller1 == "Egg")
            {
                HarExFil = 2500;
            }
            else
                HarExFil = 0;

            if (eFiller1 == "")
            {
                with = "";
            }
            else
            {
                with = "With ";
            }                
                
        }
        public hamburger(int nMat, string mType, string eFiller1, string eFiller2, int cal)
        {
            nMeat = nMat;
            meatType = mType;
            extraFiller[0] = eFiller1;
            extraFiller[1] = eFiller2;
            calory = cal;
            jmlef = 2;
            with = " with ";
            if (eFiller1 == "Mushroom")
            {
                HarExFil = 3000;
                if (eFiller2 == "Cheese")
                {
                    HarExFil += 5000;
                }
                else if (eFiller2 == "Egg")
                {
                    HarExFil += 2500;
                }
                else
                    HarExFil += 0;
            }
            else if (eFiller1 == "Cheese")
            {
                HarExFil = 5000;
                if (eFiller2 == "Mushroom")
                {
                    HarExFil += 3000;
                }
                if (eFiller2 == "Egg")
                {
                    HarExFil += 2500;
                }
                else
                    HarExFil += 0;
            }

            else if (eFiller1 == "Egg")
            {
                HarExFil = 2500;
                if (eFiller2 == "Mushroom")
                {
                    HarExFil += 3000;
                }
                if (eFiller2 == "Cheese")
                {
                    HarExFil += 5000;
                }

                else
                    HarExFil += 0;
            }
            else
                HarExFil = 0;
        }
        public hamburger(int nMat, string mType, string eFiller1, string eFiller2, string eFiller3, int caly)
        {
            nMeat = nMat;
            meatType = mType;
            calory = caly;
            jmlef = 3;
            extraFiller[0] = eFiller1;
            extraFiller[1] = eFiller2;
            extraFiller[2] = eFiller3;

            with = " with ";
            if (eFiller1 == "Mushroom")
            {
                HarExFil = 3000;
                if (eFiller2 == "Cheese")
                {
                    HarExFil += 5000;

                    if (eFiller3 == "Egg")
                    {
                        HarExFil += 2500;
                    }
                    else
                        HarExFil += 0;
                }

                else if (eFiller2 == "Egg")
                {
                    HarExFil = 2500;

                    if (eFiller3 == "Cheese")
                    {
                        HarExFil += 5000;
                    }

                    else
                        HarExFil += 0;
                }
            }
            if (eFiller1 == "Cheese")
            {
                HarExFil = 5000;
                if (eFiller2 == "Mushroom")
                {
                    HarExFil += 3000;
                    if (eFiller3 == "Egg")
                    {
                        HarExFil += 2500;
                    }
                    else
                        HarExFil += 0;
                }


                else if (eFiller2 == "Egg")
                {
                    HarExFil += 2500;
                    if (eFiller3 == "Mushroom")
                    {
                        HarExFil += 3000;
                    }


                    else
                        HarExFil += 0;
                }
            }
            else if (eFiller1 == "Egg")
            {
                HarExFil += 2500;
                if (eFiller2 == "Mushroom")
                {
                    HarExFil += 3000;
                    if (eFiller3 == "Cheese")
                    {
                        HarExFil += 5000;
                    }

                    else
                        HarExFil += 0;
                }
                else if (eFiller2 == "Cheese")
                {
                    HarExFil += 5000;
                    if (eFiller1 == "Mushroom")
                    {
                        HarExFil += 3000;
                    }

                    else
                        HarExFil += 0;
                }


            }
            else
                HarExFil = 0;
        }
        public string GenerateBurgerName()
        {
            category = "Hamburger";
            switch (nMeat)
            {
                case 1:
                    menuName = "Reguler " + meatType + " " + "Burger " + with;
                    for (int h = 0; h < jmlef; h++)
                    {
                        menuName += extraFiller[h] + " ";
                    }

                    break;

                case 2:
                    menuName = "Double " + meatType + " " + "Burger " + with;
                    for (int h = 0; h < jmlef; h++)
                    {
                        menuName += extraFiller[h] + " ";
                    }
                    break;

                case 3:
                    menuName = "Triple " + meatType + " " + "Burger " + with;
                    for (int h = 0; h < jmlef; h++)
                    {
                        menuName += extraFiller[h] + " ";
                    }
                    break;
            }
            return menuName;
        }

        public string SetPriceForBurger()
        {
            if (meatType == "Beef")
            {

                int N = 10000;
                price = nMeat * N + HarExFil;
            }
            else if (meatType == "Chicken")
            {
                int N = 5000;
                price = nMeat * N + HarExFil;
            }
            else if (meatType == "Fish")
            {
                int N = 8000;
                price = nMeat * N + HarExFil;
            }
            pri = Convert.ToString(price);
            return pri;
        }        
    }    
}

public class TempIsZeroException : ApplicationException
{
    public TempIsZeroException(string message) : base(message)
    {
    }
}

public class TempIsMinusException : ApplicationException
{
    public TempIsMinusException(string message) : base(message)
    {
    }
}

public class Calorykurang : ApplicationException
{

    public Calorykurang()
    {
    }
}


public class NumOfPat : ApplicationException
{

    public NumOfPat()
    {
    }
}

public class panjangNama : ApplicationException
{
    public panjangNama()
    {
    }
}

public class formatJanganInteger : ApplicationException
{
    public formatJanganInteger()
    {

    }
}