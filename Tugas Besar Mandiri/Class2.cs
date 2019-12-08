using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TGS_090518_5160411129_B
{


    class fc
    {

        protected string cicPart;
        protected string price;
        protected string calory;
        protected string menuName;
        protected string spicy;

        public string CicPart
        {
            get { return cicPart; }
            set { cicPart = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Calory
        {
            get { return calory; }
            set { calory = value; }
        }
        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }
        public string Spicy
        {
            get { return spicy; }
            set { spicy = value; }
        }

        public fc ( string cP, string cal, string menuNm, string pric, string spc)
        {
            cicPart = cP;
            price = pric;
            calory = cal;
            menuName = menuNm;
            spicy = spc;
        }
        public fc()
        {

        }
        public static List<fc> LoadUserListFromFile(string path)
        {
            var fc1 = new List<fc>();

            foreach (var line in File.ReadAllLines(path))
            {
                var columns = line.Split(';');
                fc1.Add(new fc
                {
                    cicPart = columns[0],
                    calory = columns[1],
                    menuName = columns[2],
                    price = columns[3],
                    spicy = columns[4]
                });
            }

            return fc1;
        }
    }

    class pz
    {
        protected string pizzaName;
        protected string calory;
        protected string menuName;
        protected string pizzaSize;
        protected string crustType;
        protected string topingItem;
        protected string price;

        public string PizzaName
        {
            get { return pizzaName; }
            set { pizzaName = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Calory
        {
            get { return calory; }
            set { calory = value; }
        }
        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }
        public string PizzaSize
        {
            get { return pizzaSize; }
            set { pizzaSize = value; }
        }
        public string CrustType
        {
            get { return crustType; }
            set { crustType = value; }
        }
        public string TopingItem
        {
            get { return topingItem; }
            set { topingItem = value; }
        }
        public pz(string pznm, string cal, string menuNm, string pizzSzi ,string crtpy, string topItm, string pric)
        {
            pizzaName = pznm;
            price = pric;
            calory = cal;
            menuName = menuNm;
            pizzaSize = pizzSzi;
            crustType = crtpy;
            topingItem = topItm;
        }
        public pz()
        {

        }

    }

    class hbg
    {
        protected string patyType;
        protected string calory;
        protected string menuName;
        protected string numOfPaty;
        protected string extraFiller;
        
        protected string price;

        public string PatyType
        {
            get { return patyType; }
            set { patyType = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Calory
        {
            get { return calory; }
            set { calory = value; }
        }
        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }
        public string ExtraFiller
        {
            get { return extraFiller; }
            set { extraFiller = value; }
        }
       
        public string NumOfPaty
        {
            get { return numOfPaty; }
            set { numOfPaty = value; }
        }
        public hbg(string patyTyp, string cal, string menuNm, string nop, string extrfill, string pric)
        {
            patyType = patyTyp;
            price = pric;
            calory = cal;
            menuName = menuNm;
            ExtraFiller = extrfill;
            NumOfPaty = nop;
            
        }
        public hbg()
        {

        }

    }
}
