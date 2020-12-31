using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Category
    {
        private int id;
        private string name;

        public DTO_Category()
        {
            this.Id = -1;
            this.Name = "";
        }

        public DTO_Category(int id)
        {
            this.Id = id;
        }

        public DTO_Category(String name)
        {
            this.Name = name;
        }

        public DTO_Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
