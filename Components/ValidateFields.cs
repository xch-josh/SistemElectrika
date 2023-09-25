using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public class ValidateFields
    {
        public void OnlyNumbersField(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar("."))
                if (((TextBox)sender).Text.Contains("."))
                    e.Handled = true;
        }

        public void ValidateFirstLetter(object sender, KeyPressEventArgs e)
        {
            string keyPressed = e.KeyChar.ToString();

            bool matchFound = ((ComboBox)sender).Items.Cast<string>().Any(item => item.StartsWith(keyPressed, StringComparison.OrdinalIgnoreCase));

            e.Handled = !matchFound;
        }
    }
}
