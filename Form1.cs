using System;
using System.Drawing;
using System.Windows.Forms;

namespace VPPR2
{
	public partial class Form1 : Form
	{

		private ToolStripSplitButton MyButton;
		private static int countButton = 0;

		public Form1(){
			InitializeComponent();
			button1.Text = "Играть";
			button1.Font = new Font("Arial", button1.Font.Size * 3, FontStyle.Bold);
		}

		private void Form1_Load(object sender, EventArgs e){}

		private void button1_Click(object sender, EventArgs e){
			Form2 newForm2 = new Form2();
			newForm2.Show();
		}

		private void toolStripDropDownButton1_Click(object sender, EventArgs e){}

		private void toolStripTextBox1_Click(object sender, EventArgs e){
			MessageBox.Show("Вы нажали на кнопку \'!\'");
		}

		private void создатьКнопкуToolStripMenuItem_Click(object sender, EventArgs e){
			++countButton;
			MyButton = new ToolStripSplitButton();
			MyButton.Text = "Кнопка";
			MyButton.AutoSize = true;
			toolStrip1.Items.Add(MyButton);
		}

		private void удалитьКнопкуToolStripMenuItem_Click_1(object sender, EventArgs e){
			if (countButton != 0){
				--countButton;
				toolStrip1.Items.RemoveAt(5);
			}
		}
	}
}
