using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTYp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCalc_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && textBox1.Text != " ")
			{
				const int H = 0, QR = 1, S = 2, ER = 3;
				int CS = H;
				string mass = textBox1.Text;
				for (int i = 0; i < mass.Length && CS != ER; i++)
				{
					switch (CS)
					{
						case H:
							{
								if (mass[i] == '+' && mass.Length == 1)
								{
									listBox1.Items.Add(mass + "-->H");
									listBox1.Items.Add(mass[i] + "-->S");
									CS = S;
								}
								else if ((mass[i] == '+' || mass[i] == '-') && mass.Length > 1)
								{
									listBox1.Items.Add(mass + "-->H");
									listBox1.Items.Add(mass[i] + "-->QR");
									CS = QR;
								}
								else
								{
									CS = ER;
								}
								break;
							}
						case QR:
							{
								if (mass[i] == '+' && mass.Length == i)
								{
									listBox1.Items.Add(mass[i] + "-->S");
									CS = S;
								}
								else if (mass[i] == '+' && mass.Length > i)
								{
									listBox1.Items.Add(mass[i] + "-->QR");
									CS = QR;
								}
								else
								{
									CS = ER;
								}
								break;
							}
					}
				}

				if (CS != ER)
				{
					listBox1.Items.Add("Цепочка  принадлежит");
					listBox1.Items.Add("языку");
				}
				else
				{
					listBox1.Items.Add("Цепочка  не принадлежит");
					listBox1.Items.Add("языку");
				}

			}
			else
			{
				MessageBox.Show("Для вычисления заполните поле для цепочки языка!");
			}
		}
	}
}
