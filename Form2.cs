using System;
using System.Windows.Forms;

namespace VPPR2
{
	public partial class Form2 : Form
	{

		private int count_gold = 500,
					gold_speed = 0,
					My_soldiers = 100,
					Enemy_soldier = 12404254;

		private Timer timer;

		private int i = 0;

		public Form2(){
			InitializeComponent();
			label1.Text = "Собирайте деньги и захватите МИР!";
			timer = new Timer() { Interval = 1000 };
			timer.Tick += timer_Tick;
			timer.Start();
		}

		private void timer_Tick(object sender, EventArgs e){
			i++;
			count_gold += gold_speed;
			if(i==5){
				My_soldiers-=2;
				Enemy_soldier -= My_soldiers;
				i = 0;
			}



			label2.Text = "Количество золота: " + count_gold.ToString()+"г.";
			label5.Text = "Скорость добычи золота: " + gold_speed.ToString()+"г/с";
			label3.Text = "Количество ваших солдат: " + My_soldiers.ToString();
			label4.Text = "Количество солдат врага: " + Enemy_soldier.ToString();

			if (Enemy_soldier <= 0)
			{
				timer.Stop();
				MessageBox.Show("Это великая победа! Теперь весь мир ВАШ. Но....\n" +
					"О БОЖЕ! На мир нападают ПРИШЕЛЬЦЫ с других миров!\n\n" +
					"Предзаказать игру: \"Супер Игра Года 2\" можно уже на всех игровых плащадках ВАШЕГО мира");
				Close();
			}
			else if (My_soldiers <= 0)
			{
				timer.Stop();
				MessageBox.Show("Вы проиграли! Мир выстоял ;(");
				Close();
			}
		}

		private void Form2_Load(object sender, EventArgs e){

		}

		private void label1_Click(object sender, EventArgs e){

		}

		private void button2_Click(object sender, EventArgs e){
			if (count_gold >= 100){
				count_gold -= 100;
				++gold_speed;
			}
		}

		private void button4_Click(object sender, EventArgs e){
			MessageBox.Show("Функция \'Построить супер шахту (-200г. +10г/с)\' доступна только в Prime версии");
		}

		private void button5_Click(object sender, EventArgs e){
			MessageBox.Show("Функция \'Запустить ракету во врагов (-150г.)\' доступна только в Prime версии");
		}

		private void button6_Click(object sender, EventArgs e){
			MessageBox.Show("Функция \'Скрыться (Неуязвимость 10с.)\' доступна только в Prime версии");
		}

		private void button3_Click(object sender, EventArgs e){
			if (count_gold >= 20){
				count_gold -= 20;
				++My_soldiers;
			}
		}

		private void label2_Click(object sender, EventArgs e){

		}

		private void button1_Click(object sender, EventArgs e){
			Close();
		}
	}
}
