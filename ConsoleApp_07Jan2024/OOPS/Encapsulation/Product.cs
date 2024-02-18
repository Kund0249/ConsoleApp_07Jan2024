using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Encapsulation
{
    public class Product
    {
        private int _Id;
        private string _Name;
        private int _Price;

        //public void SetData(int Id, string Name, int price)
        //{
        //    if (Id > 0)
        //        _Id = Id;
        //    else
        //        throw new Exception("Product Id must be greater than 0");

        //    if (!string.IsNullOrEmpty(Name))
        //        _Name = Name;
        //    else
        //        throw new Exception("Product Name can't be null or empty");

        //    if (price > 0)
        //        _Price = price;
        //    else
        //        throw new Exception("Product price must be greater than 0");
        //}

        //public void SetId(int Id)
        //{
        //    if (Id > 0)
        //        _Id = Id;
        //    else
        //        throw new Exception("Product Id must be greater than 0");
        //}

        public int Id
        {
            set
            {
                if(value > 0)
                    _Id = value;
                else
                    throw new Exception("Product Id must be greater than 0");
            }
            get
            {
                return _Id;
            }
        }


        //public void SetName(string Name)
        //{
        //    if (!string.IsNullOrEmpty(Name))
        //        _Name = Name;
        //    else
        //        throw new Exception("Product Name can't be null or empty");
        //}

        public string Name
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _Name = value;
                else
                    throw new Exception("Product Name can't be null or empty");
            }
            get
            {
                return _Name;
            }
        }

        //public void SetPrice(int Price)
        //{
        //    if (Price > 0)
        //        _Price = Price;
        //    else
        //        throw new Exception("Product Price must be greater than 0");
        //}

        public int Price
        {
            set
            {
                if (value > 0)
                    _Price = value;
                else
                    throw new Exception("Product Price must be greater than 0");
            }
            get
            {
                return _Price;
            }
        }

        //public void GetProduct()
        //{
        //    Console.WriteLine($"Id : {_Id} Name : {_Name} Price : {_Price}");
        //}

        //public int GetId()
        //{
        //    return _Id;
        //}
        //public string GetName()
        //{
        //    return _Name;
        //}

        //public int GetPrice()
        //{
        //    return _Price;
        //}
    }
}
