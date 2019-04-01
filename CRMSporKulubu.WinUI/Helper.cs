using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSporKulubu.WinUI
{
	public class Helper
	{
		public static void Temizle(Form form)
		{
			foreach (Control item in form.Controls)
			{
				if (item is CheckBox)
				{
					(item as CheckBox).Checked = false;
				}
				else if (item is ComboBox)
				{
					(item as ComboBox).SelectedItem = null;
				}
				else if (item is RadioButton)
				{
					(item as RadioButton).Checked = false;
				}
				else if (item is DateTimePicker)
				{
					(item as DateTimePicker).Value = DateTime.Now;
				}
				else if (item is TextBox)
				{
					(item as TextBox).Text = "";
				}


			}
		}
	}
}
