using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_17
{
    public partial class Form1 : Form
    {
        Button b; 
        Label p;
        public Form1()
        {
            InitializeComponent();
        }
        private void bClick(object sender, EventArgs e)
        {
            p.BackColor = Color.Firebrick;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Button(); 
            b.Parent = this; 
                             
            b.Width = 150; 
            b.Height = 50; 
            b.Left = 75; 
            b.Top = 50; 
            b.Text = "Button";
            
            p = new Label(); 
            p.Parent = this; 
            p.Width = 150; 
            p.Height = 50; 
            p.Left = 75; 
            p.Top = 150;
            p.Text = "LABEL";
            p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            b.Click += bClick;
        }

       
    }
}
