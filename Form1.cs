if (!indicator)
{

MessageBox.Show("На этот раз победили Крестики");


}
else
{

MessageBox.Show("Победу в этом сражении одержали Нолики");
namespace WindowsFormsApplication2
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
this.label1 = new System.Windows.Forms.Label();
this.button1 = new System.Windows.Forms.Button();
this.button2 = new System.Windows.Forms.Button();
this.SuspendLayout();
//
// label1
//
this.label1.AutoSize = true;
this.label1.BackColor = System.Drawing.Color.Transparent;
this.label1.Font = new System.Drawing.Font("Sans-serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
this.label1.Location = new System.Drawing.Point(30, 43);
this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
this.label1.Name = "label1";
this.label1.Size = new System.Drawing.Size(335, 32);
this.label1.TabIndex = 0;
this.label1.Text = "Êòî ïåðâûé õîäèò";
this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
this.label1.Click += new System.EventHandler(this.label1_Click);
//
// button1
//
this.button1.BackColor = System.Drawing.Color.Transparent;
this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
this.button1.Font = new System.Drawing.Font("Sans-serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
this.button1.Location = new System.Drawing.Point(25, 85);
this.button1.Margin = new System.Windows.Forms.Padding(4);
this.button1.Name = "button1";
this.button1.Size = new System.Drawing.Size(150, 31);
this.button1.TabIndex = 1;
this.button1.Text = "Õ";
this.button1.UseVisualStyleBackColor = false;
//
// button2
//
this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
this.button2.Font = new System.Drawing.Font("Sans-serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
this.button2.Location = new System.Drawing.Point(200, 91);
this.button2.Margin = new System.Windows.Forms.Padding(4);
this.button2.Name = "button2";
this.button2.Size = new System.Drawing.Size(115, 35);
this.button2.TabIndex = 2;
this.button2.Text = "0";
this.button2.UseVisualStyleBackColor = true;
//
// Form2
//
this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.BackColor = System.Drawing.Color.Teal;

this.ClientSize = new System.Drawing.Size(519, 237);
this.Controls.Add(this.button2);
this.Controls.Add(this.button1);
this.Controls.Add(this.label1);
this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
this.Margin = new System.Windows.Forms.Padding(4);
this.Name = "Form2";
this.Load += new System.EventHandler(this.Form2_Load);
this.ResumeLayout(false);
this.PerformLayout();

}

#endregion

private System.Windows.Forms.Label label1;
private System.Windows.Forms.Button button1;
private System.Windows.Forms.Button button2;
}
}

namespace WindowsFormsApplication2
{
partial class Form1
{
/// <summary>
/// Требуется переменная конструктора.
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
public Form1()
{
int i,j;
InitializeComponent();
for (i = 1; i < 13; i++) //генерация кнопок
{
for (j = 1; j < 13; j++)
{
but = new Button();
but.Size = new Size(50, 50); //размер кнопки
but.Location = new Point(i*50, j*50); //ее позиция
but.Click += new EventHandler(but_Click); //действие при клике
but.Text = " ";
this.Controls.Add(but);
}
}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
public partial class Form1 : Form
{
System.Timers.Timer t;//Обьявление таймера
int m, s; // Минуты , секуны

bool indicator = true;
int x, y;
int counter = 0;
int[,] field = new int[14, 14];
public Button but = new Button();
public Form1()
{
int i,j;
InitializeComponent();
for (i = 1; i < 13; i++) //генерация кнопок
{
for (j = 1; j < 13; j++)
{
but = new Button();
but.Size = new Size(50, 50); //размер кнопки
but.Location = new Point(i*50, j*50); //ее позиция
but.Click += new EventHandler(but_Click); //действие при клике
but.Text = " ";
this.Controls.Add(but);
}
}
}
private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
{
s += 1;
Invoke(new Action(() =>
{
if (s == 60)
{
s = 0;
m += 1;
if (m == 01)//Таймер на 10 минут
{
Application.DoEvents();

t.Stop();
Application.DoEvents();
DialogResult dialogResult = MessageBox.Show("10 минут... Это уже слишком\nПерезапустить игру?", "Уведомление", MessageBoxButtons.YesNo);
if (dialogResult == DialogResult.Yes)
{
Application.Restart();//если да
}
else if (dialogResult == DialogResult.No)
{
this.Close(); //если нет
}


}


}
if (m==60)
{
m = 0;

}

textBox1.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
}));
}
