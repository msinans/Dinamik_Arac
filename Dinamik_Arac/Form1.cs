using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Arac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label lbl = new Label();
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(20, 10);
            btn.Location = btnkonum;
            btn.Name = "Button2";
            btn.Text = "Tıkla";
            btn.BackColor = Color.Aquamarine;
            btn.Height = 50;
            btn.Width = 100;
            this.Controls.Add(btn);
            btn.Click += new EventHandler(btn_Click); // Yukarıda eklediğim dinamik butona bu kodla event ekliyorum ve aşağıda çağıryorum


            
            Point lblkonum = new Point(150, 10);
            lbl.Location = lblkonum;
            lbl.Name = "Label1";
            lbl.Text = "Merhaba";
            lbl.BackColor = Color.Yellow;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);

            for (int i = 1; i <= 10; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(350, i * 30);
                txt.Location = txtkonum;
                txt.Name = "TextBox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }
        }
        void btn_Click(object sender, EventArgs e)

        {

            lbl.Text = "Merhaba Gençler Nabeeeeer!"; // lbl yi global alanda tanımladım ki buradan erişebileyim 

        }
    }
}
