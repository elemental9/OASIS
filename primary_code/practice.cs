using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BingoConLabels
{
	public partial class Form1 : Form
	{
		Random RandomClass = new Random();
		string[] numllamados = new string[15];

		public Form1()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			int RandomNumber = RandomClass.Next(1, 100);
			numllamados[1] = Convert.ToString(RandomNumber);

			for (int i = 1; i <= 48; i++)
			{
				Label label = (Label)Controls["label" + i];
				label.Text = Convert.ToString(RandomClass.Next(1, 100));
				label.BackColor = Color.White;
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			int RandomNumber = RandomClass.Next(1, 100);
			numllamados[1] = Convert.ToString(RandomNumber);
			this.listBox1.Items.Add(numllamados[1]);

			for (int i = 1; i <= 48; i++)
			{
				Label label = (Label)Controls["label" + i];
				if (label.Text == numllamados[1])
				label.BackColor = Color.GreenYellow;

				if (label1.BackColor == Color.GreenYellow && label2.BackColor == Color.GreenYellow && label3.BackColor == Color.GreenYellow && label4.BackColor == Color.GreenYellow && label5.BackColor == Color.GreenYellow && label6.BackColor == Color.GreenYellow && label7.BackColor == Color.GreenYellow && label8.BackColor == Color.GreenYellow && label9.BackColor == Color.GreenYellow && label10.BackColor == Color.GreenYellow && label11.BackColor == Color.GreenYellow && label12.BackColor == Color.GreenYellow && label13.BackColor == Color.GreenYellow && label14.BackColor == Color.GreenYellow && label15.BackColor == Color.GreenYellow && label16.BackColor == Color.GreenYellow)
				{
					MessageBox.Show("Has hecho BINGO en el 1er Carton!");
					break;
				}
				else
				{
					if (label17.BackColor == Color.GreenYellow && label8.BackColor == Color.GreenYellow && label9.BackColor == Color.GreenYellow && label20.BackColor == Color.GreenYellow && label21.BackColor == Color.GreenYellow && label22.BackColor == Color.GreenYellow && label23.BackColor == Color.GreenYellow && label24.BackColor == Color.GreenYellow && label25.BackColor == Color.GreenYellow && label26.BackColor == Color.GreenYellow && label27.BackColor == Color.GreenYellow && label28.BackColor == Color.GreenYellow && label29.BackColor == Color.GreenYellow && label30.BackColor == Color.GreenYellow && label31.BackColor == Color.GreenYellow && label32.BackColor == Color.GreenYellow)
					{
						MessageBox.Show("Has hecho BINGO en el 2do Carton!");
						break;
					}
					else
					{
						if (label33.BackColor == Color.GreenYellow && label34.BackColor == Color.GreenYellow && label35.BackColor == Color.GreenYellow && label36.BackColor == Color.GreenYellow && label37.BackColor == Color.GreenYellow && label38.BackColor == Color.GreenYellow && label39.BackColor == Color.GreenYellow && label40.BackColor == Color.GreenYellow && label41.BackColor == Color.GreenYellow && label42.BackColor == Color.GreenYellow && label43.BackColor == Color.GreenYellow && label44.BackColor == Color.GreenYellow && label45.BackColor == Color.GreenYellow && label46.BackColor == Color.GreenYellow && label47.BackColor == Color.GreenYellow && label48.BackColor == Color.GreenYellow)
						{
							MessageBox.Show("Has hecho BINGO en el 2do Carton!");
							break;
						}
					}
				}
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			int RandomNumber = RandomClass.Next(1, 100);
			numllamados[1] = Convert.ToString(RandomNumber);
			this.listBox1.Items.Clear();

			for (int i = 1; i <= 48; i++)
			{
				Label label = (Label)Controls["label" + i];
				label.BackColor = Color.White;
				label.Text = "";
			}
		}
		private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int RandomNumber = RandomClass.Next(1, 100);
			numllamados[1] = Convert.ToString(RandomNumber);
			this.listBox1.Items.Clear();

			for (int i = 1; i <= 48; i++)
			{
				Label label = (Label)Controls["label" + i];
				label.Text = Convert.ToString(RandomClass.Next(1, 100));
				label.BackColor = Color.White;
			}
		}
		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void acercaDelJuegoToolStripMenuItem_Click(object sender, EventArgs e)
		{
				AboutBox1 form = new AboutBox1();
				form.Show();
				// or
		}
	}
}
