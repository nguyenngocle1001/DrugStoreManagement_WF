using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Category
    {
        public BUS_Category() { }

        DAL_Category dalCategory = new DAL_Category();

        public void InsertCategory(DTO_Category category)
        {
            dalCategory.InsertCategory(category);
        }

        public void UpdateCategory(DTO_Category category)
        {
            dalCategory.UpdateCategory(category);
        }

        public void DeleteCategory(DTO_Category category)
        {
            dalCategory.DeleteCategory(category);
        }
    }
}
