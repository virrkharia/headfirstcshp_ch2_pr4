﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Head_First_CShp_Ch2_Pg4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void changeText_Click(object sender, EventArgs e)
		{
			if (enableCheckbox.Checked == true)
			{
				if (labelToChange.Text == "Right")
				{
					labelToChange.Text = "Left";
					labelToChange.TextAlign = ContentAlignment.MiddleLeft;
				}
				else
				{
					labelToChange.Text = "Right";
					labelToChange.TextAlign = ContentAlignment.MiddleRight;
				}
			}
			else
			{
				labelToChange.Text = "Text changing is disabled";
				labelToChange.TextAlign = ContentAlignment.MiddleCenter;
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
