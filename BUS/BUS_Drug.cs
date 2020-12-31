using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Drug
    {
        DAL_Drug busDrug = new DAL_Drug();

        public void InsertDrug(DTO_Drug drug)
        {
            busDrug.InsertDrug(drug);
        }

        public void UpdateDrug(DTO_Drug drug)
        {
            busDrug.UpdateDrug(drug);
        }

        public void DeleteDrug(DTO_Drug drug)
        {
            busDrug.DeleteDrug(drug);
        }
    }
}
