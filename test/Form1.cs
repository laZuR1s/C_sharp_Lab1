using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private int clickCount = 0;
        private string[] icons = { "Youtube.ico", "Telegram.ico",
            "Twitch.ico" };
        
        public Form1()
        {
            InitializeComponent();
            Text = "Начальная форма";
            this.BackColor = Color.Aqua;
            this.Size = new Size(1000, 1000);
            this.Icon = new Icon("Youtube.ico");
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           clickCount=(clickCount+1)%icons.Length;
            this.Icon = new Icon(icons[clickCount]);
            string iconName = icons[clickCount].Split('.')[0];
            this.Text = iconName;
        }
    }
}
