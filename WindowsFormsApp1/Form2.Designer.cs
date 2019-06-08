namespace WindowsFormsApp1
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("AA Bebas Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(542, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Имя пользователя: Андрей";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("AA Bebas Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(26, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "КОФЕ-SHOP";
			// 
			// button2
			// 
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("AA Bebas Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(545, 182);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 45);
			this.button2.TabIndex = 7;
			this.button2.Text = "Выход из приложения";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("AA Bebas Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(164, 242);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(258, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Учебная практика - Канайчев Андрей Михайлович (ИСП-922) ";
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsVisibleIfAvailable = false;
			this.propertyGrid1.HelpVisible = false;
			this.propertyGrid1.Location = new System.Drawing.Point(29, 63);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(195, 130);
			this.propertyGrid1.TabIndex = 9;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(230, 72);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(125, 121);
			this.listBox1.TabIndex = 10;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("AA Bebas Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new System.Drawing.Point(26, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(298, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Сколько было продано кофе за определённый промежуток времени:";
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("AA Bebas Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(545, 118);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 45);
			this.button1.TabIndex = 12;
			this.button1.Text = "Запись продаж кофе";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(663, 267);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Name = "Form2";
			this.Text = "Кофейня: Вход в систему";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
	}
}