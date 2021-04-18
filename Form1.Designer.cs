
namespace VPPR2
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.создатьКнопкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьКнопкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(231, 148);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(300, 150);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripSeparator3,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 31);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripTextBox1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTextBox1.Image")));
			this.toolStripTextBox1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(13, 28);
			this.toolStripTextBox1.Text = "!";
			this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьКнопкуToolStripMenuItem,
            this.удалитьКнопкуToolStripMenuItem});
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(32, 24);
			this.toolStripDropDownButton1.Text = "...";
			this.toolStripDropDownButton1.ToolTipText = "...";
			this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
			// 
			// создатьКнопкуToolStripMenuItem
			// 
			this.создатьКнопкуToolStripMenuItem.Name = "создатьКнопкуToolStripMenuItem";
			this.создатьКнопкуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.создатьКнопкуToolStripMenuItem.Text = "Создать кнопку";
			this.создатьКнопкуToolStripMenuItem.Click += new System.EventHandler(this.создатьКнопкуToolStripMenuItem_Click);
			// 
			// удалитьКнопкуToolStripMenuItem
			// 
			this.удалитьКнопкуToolStripMenuItem.Name = "удалитьКнопкуToolStripMenuItem";
			this.удалитьКнопкуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.удалитьКнопкуToolStripMenuItem.Text = "Удалить кнопку";
			this.удалитьКнопкуToolStripMenuItem.Click += new System.EventHandler(this.удалитьКнопкуToolStripMenuItem_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Lab.#6. ст. гр. ИС/б-19-3-о. Пасевич А. П.";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel toolStripTextBox1;
		private System.Windows.Forms.ToolStripMenuItem создатьКнопкуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьКнопкуToolStripMenuItem;
	}
}

