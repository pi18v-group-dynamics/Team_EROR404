this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
this.Text = "Игра \"Крестики-нолики\"";
this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

#region Код, автоматически созданный конструктором форм Windows

/// <summary>
/// Обязательный метод для поддержки конструктора - не изменяйте
/// содержимое данного метода при помощи редактора кода.
/// </summary>
private void InitializeComponent()
{
System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
this.menuStrip1 = new System.Windows.Forms.MenuStrip();
this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.игратьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.играНаВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.включитьТаймерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.остановитьВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.помошьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.стратегииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.вкладкаДляТестДрайваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.разToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.разРазToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.разРазРазToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
this.textBox1 = new System.Windows.Forms.TextBox();
this.label1 = new System.Windows.Forms.Label();
this.label2 = new System.Windows.Forms.Label();
this.menuStrip1.SuspendLayout();
this.SuspendLayout();
//
// menuStrip1
//
this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
this.играToolStripMenuItem,
this.помошьToolStripMenuItem,
this.вкладкаДляТестДрайваToolStripMenuItem});
this.menuStrip1.Location = new System.Drawing.Point(0, 0);
this.menuStrip1.Name = "menuStrip1";
this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
this.menuStrip1.Size = new System.Drawing.Size(528, 24);
this.menuStrip1.TabIndex = 0;
this.menuStrip1.Text = "menuStrip1";
this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
//

//
// игратьЗановоToolStripMenuItem
//
this.игратьЗановоToolStripMenuItem.Name = "игратьЗановоToolStripMenuItem";
this.игратьЗановоToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
this.игратьЗановоToolStripMenuItem.Text = "Начать ещё раз";
this.игратьЗановоToolStripMenuItem.Click += new System.EventHandler(this.игратьЗановоToolStripMenuItem_Click);
//
// играНаВремяToolStripMenuItem
//
this.играНаВремяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
this.включитьТаймерToolStripMenuItem,
this.остановитьВремяToolStripMenuItem});
this.играНаВремяToolStripMenuItem.Name = "играНаВремяToolStripMenuItem";
this.играНаВремяToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
this.играНаВремяToolStripMenuItem.Text = "Время";
this.играНаВремяToolStripMenuItem.Click += new System.EventHandler(this.играНаВремяToolStripMenuItem_Click);
//
// включитьТаймерToolStripMenuItem
//
this.включитьТаймерToolStripMenuItem.Name = "включитьТаймерToolStripMenuItem";
this.включитьТаймерToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
this.включитьТаймерToolStripMenuItem.Text = "таймер";
this.включитьТаймерToolStripMenuItem.Click += new System.EventHandler(this.включитьТаймерToolStripMenuItem_Click_1);
//
// остановитьВремяToolStripMenuItem
//
this.остановитьВремяToolStripMenuItem.Name = "остановитьВремяToolStripMenuItem";
this.остановитьВремяToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
this.остановитьВремяToolStripMenuItem.Text
 
= "Не таймер";
this.остановитьВремяToolStripMenuItem.Click += new System.EventHandler(this.остановитьВремяToolStripMenuItem_Click);
//
// выходToolStripMenuItem
//
this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
this.выходToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
this.выходToolStripMenuItem.Text = "Выйти";
this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);

//
// стратегииToolStripMenuItem
//
this.стратегииToolStripMenuItem.Name = "стратегииToolStripMenuItem";
this.стратегииToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
this.стратегииToolStripMenuItem.Text = "рекомендации";
this.стратегииToolStripMenuItem.Click += new System.EventHandler(this.стратегииToolStripMenuItem_Click);
//
// правилаИгрыToolStripMenuItem
//
this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
this.правилаИгрыToolStripMenuItem.Text = "правила";
this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
//
// оПрограммеToolStripMenuItem
//
this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
this.оПрограммеToolStripMenuItem.Text = "О программе";
this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
//
// вкладкаДляТестДрайваToolStripMenuItem
//
this.вкладкаДляТестДрайваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
this.разToolStripMenuItem,
this.разРазToolStripMenuItem,
this.разРазРазToolStripMenuItem});
this.вкладкаДляТестДрайваToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
this.вкладкаДляТестДрайваToolStripMenuItem.Name = "вкладкаДляТестДрайваToolStripMenuItem";
this.вкладкаДляТестДрайваToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
this.вкладкаДляТестДрайваToolStripMenuItem.Text = "Вкладка для тест драйва";
this.вкладкаДляТестДрайваToolStripMenuItem.Click += new System.EventHandler(this.вкладкаДляТестДрайваToolStripMenuItem_Click);
//
// разToolStripMenuItem
//
this.разToolStripMenuItem.Name = "разToolStripMenuItem";
this.разToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
this.разToolStripMenuItem.Text = "1 раз";
//
// разРазToolStripMenuItem
//
this.разРазToolStripMenuItem.Name = "разРазToolStripMenuItem";
this.разРазToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
this.разРазToolStripMenuItem.Text = "2 раза";
//
// разРазРазToolStripMenuItem
//
this.разРазРазToolStripMenuItem.Name = "разРазРазToolStripMenuItem";
this.разРазРазToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
this.разРазРазToolStripMenuItem.Text = "3 раза";
//
// textBox1
//
this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
this.textBox1.Location = new System.Drawing.Point(134, 583);
this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
this.textBox1.Name = "textBox1";
this.textBox1.ReadOnly = true;
this.textBox1.Size = new System.Drawing.Size(246, 62);
this.textBox1.TabIndex = 2;
this.textBox1.Text = "00:00";
this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
//
// label1
//
this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
this.label1.AutoSize = true;
this.label1.BackColor = System.Drawing.Color.Transparent;
this.label1.Font = new System.Drawing.Font("Roboto", 13F);
this.label1.Location = new System.Drawing.Point(130, 552);
this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
this.label1.Name = "label1";
this.label1.Size = new
 
System.Drawing.Size(153, 22);
this.label1.TabIndex = 4;
this.label1.Text = "Таймер, от слова";
this.label1.Click += new System.EventHandler(this.label1_Click_1);
//
// label2
//
this.label2.AutoSize = true;
this.label2.BackColor = System.Drawing.Color.Transparent;
this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 25F);
this.label2.Location = new System.Drawing.Point(287, 536);
this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
this.label2.Name = "label2";
this.label2.Size = new System.Drawing.Size(110, 44);
this.label2.TabIndex = 4;
this.label2.Text = "Time";
this.label2.Click += new System.EventHandler(this.label2_Click);
//
// Form1
//
this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.BackColor = System.Drawing.Color.Teal;
this.ClientSize = new System.Drawing.Size(528, 609);
this.Controls.Add(this.textBox1);
this.Controls.Add(this.label1);
this.Controls.Add(this.label2);
this.Controls.Add(this.menuStrip1);

this.MainMenuStrip = this.menuStrip1;
this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
this.MinimizeBox = false;
this.Name = "Form1";

this.Load += new System.EventHandler(this.Form1_Load);
this.menuStrip1.ResumeLayout(false);
this.menuStrip1.PerformLayout();
this.ResumeLayout(false);
this.PerformLayout();

}

#endregion

private System.Windows.Forms.MenuStrip menuStrip1;
private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem игратьЗановоToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem помошьToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
private System.Windows.Forms.TextBox textBox1;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.ToolStripMenuItem играНаВремяToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem включитьТаймерToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem остановитьВремяToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem стратегииToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem вкладкаДляТестДрайваToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem разToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem разРазToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem разРазРазToolStripMenuItem;
}
}
