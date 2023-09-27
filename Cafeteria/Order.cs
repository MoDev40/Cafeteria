using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    class Order
    {
        //each item price

        //cafe price small medium xl 2xl
        private double[] cafePrice = {0.5,0.75,1,1.5};
        //tea price small medium xl 2xl
        private double[] teaPrice = { 0.25, 0.5, 0.75, 1 };
        //qahwa price small medium xl 2xl
        private double[] qahwaPrice = { 0.25, 0.5, 0.75, 1.25 };

        //dataFields

        private string item;
        private string size;
        private int quantity;
        private double price;

        //Deaful constructor
        public Order() { }
        //Prameterized constructor
        public Order(string item, string size, int quantity)
        {
            this.item = item;
            this.size = size;
            this.quantity = quantity;
        }

        //Accessers && Modifiers
        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        public string Size
        {
            get { return size;  }
            set { size = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        //Method's 

        //Check items Size 
        void getTeaPrice()
        {
            switch (size)
            {
                case "small":
                     price = quantity * teaPrice[0];
                    break;
                case "Md":
                    price = quantity * teaPrice[1];
                    break;
                case "Xl":
                    price = quantity * teaPrice[2];
                    break;
                case "2xl":
                    price = quantity * teaPrice[3];
                    break;
                default: price = 0;
                    break;
            }
        }
        void getCafePrice ()
        {
            switch (size)
            {
                case "small":
                     price = quantity * cafePrice[0];
                    break;
                case "Md":
                     price = quantity * cafePrice[1];
                    break;
                case "Xl":
                     price = quantity * cafePrice[2];
                    break;
                case "2xl":
                     price = quantity * cafePrice[3];
                    break;
                default: price = 0;
                    break;
            }
        }
        void getQahwaPrice()
        {
            switch (size)
            {
                case "small":
                    price = quantity * qahwaPrice[0];
                    break;
                case "Md":
                    price = quantity * qahwaPrice[1];
                    break;
                case "Xl":
                    price = quantity * qahwaPrice[2];
                    break;
                case "2xl":
                    price = quantity * qahwaPrice[3];
                    break;
                default:
                    price = 0;
                    break;
            }
        }

        //check selected item and then get total price 
        public double getPrice ()
        {
            if(item == "Cafe")
            {
                getCafePrice();
            }
            else if (item == "Tea")
            {
               getTeaPrice();
            }
            else if (item == "Qahwa")
            {
                getQahwaPrice();
            }
            else
            {
                MessageBox.Show("Select an item");
            }
            return price;
        }


    }
}
