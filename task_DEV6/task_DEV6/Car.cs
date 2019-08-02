using System;
using System.Xml;

namespace Task_DEV5
{
    /// <summary>
    /// This class takes information about cars.
    /// </summary>
    class Car
    {
        public string brand;
        public string model;
        public int quantity;
        public int price;

        /// <summary>
        /// This constructor takes params of cars from xml file.
        /// </summary>
        public Car()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("D:/cworkspaceTAT2019/task_DEV6/Cars.xml");            
            XmlElement xRoot = xDoc.DocumentElement;
           
            foreach (XmlNode xnode in xRoot)
            {               
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "brand")
                    {
                        brand = childnode.InnerText;
                    }                    
                    if (childnode.Name == "model")
                    {
                        model = Console.ReadLine();
                    }
                    
                    if (childnode.Name == "quantity")
                    {
                        quantity = Convert.ToInt32(Console.ReadLine());
                    }
                    
                    if (childnode.Name == "price")
                    {
                        price = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }
    }
}