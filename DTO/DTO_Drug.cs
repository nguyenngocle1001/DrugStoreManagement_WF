using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Drug
    {
        private String id;
        private String name;
        private double price;
        private int quantity;
        private DateTime mfd;
        private DateTime exp;
        private int category;
        private String dvt;

        public DTO_Drug() { }
        public DTO_Drug(string id) {
            this.Id = id;
        }
        public DTO_Drug(String id, String name, double price, int quantity, DateTime mfd, DateTime exp, int category, string dvt)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Mfd = mfd;
            this.Exp = exp;
            this.Category = category;
            this.Dvt = dvt;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public DateTime Mfd { get => mfd; set => mfd = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime Exp { get => exp; set => exp = value; }
        public int Category { get => category; set => category = value; }
        public string Dvt { get => dvt; set => dvt = value; }
    }
}
