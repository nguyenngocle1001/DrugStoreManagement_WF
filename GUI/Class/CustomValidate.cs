using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Class
{
    public class CustomValidate
    {
        private static CustomValidate instance = new CustomValidate();

        public bool Required(TextBox txt, Label lbl)
        {
            if (txt.Text.Trim() == "")
            {
                lbl.ForeColor = Color.Red;
                return false;
            }
            else lbl.ForeColor = Color.Black;
            return true;
        }

        public bool Compare(String value,TextBox txt, Label lbl)
        {
            if (txt.Text.Trim() != value)
            {
                txt.Text = value;
                return false;
            }
            return true;
        }

        public bool IsInteger(TextBox txt, Label lbl)
        {
            try
            {
                int.Parse(txt.Text.Trim());
                lbl.ForeColor = Color.Black;
                return true;
            }
            catch (Exception e)
            {

                lbl.ForeColor = Color.Red;
                return false;
            }
        }

        public bool IsQuantity(TextBox txt, Label lbl)
        {
            try
            {
                int value = int.Parse(txt.Text.Trim());
                if(value> 0)
                {
                    lbl.ForeColor = Color.Black;
                    return true;
                }
                else
                {
                    lbl.ForeColor = Color.Red;
                    return false;
                }
            }
            catch (Exception e)
            {

                lbl.ForeColor = Color.Red;
                return false;
            }
        }

        public bool IsPrice(TextBox txt, Label lbl)
        {
            try
            {
                double value = double.Parse(txt.Text.Trim());
                if (value > 0)
                {
                    lbl.ForeColor = Color.Black;
                    return true;
                }
                else
                {
                    lbl.ForeColor = Color.Red;
                    return false;
                }
            }
            catch (Exception e)
            {

                lbl.ForeColor = Color.Red;
                return false;
            }
        }

        public static CustomValidate Instance { get => instance; set => instance = value; }
    }
}
