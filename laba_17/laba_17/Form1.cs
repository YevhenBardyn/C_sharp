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
        Button b; // поле - посилання на кнопку
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
            b = new Button(); // створили кнопку
            b.Parent = this; // кнопка буде розміщена безпосередньо на формі
                             // (форма - батьківський елемент для кнопки, і відповідає за
                             // візуалізацію кнопки)
            b.Width = 150; // розміри кнопки - ширина
            b.Height = 50; // - висота
            b.Left = 75; // позиція кнопки - х
            b.Top = 50; // - y
            b.Text = "Button";// напис на кнопці
            
            p = new Label(); // створили панель
            p.Parent = this; // панель буде розміщена безпосередньо на формі
                             // (форма - батьківський елемент для панелі, і відповідає за
                             // візуалізацію панелі)
            p.Width = 150; // розміри панелі - ширина
            p.Height = 50; // - висота
            p.Left = 75; // позиція панелі - х
            p.Top = 150;
            p.Text = "LABEL";
            p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            b.Click += bClick;
        }

       
    }
}
