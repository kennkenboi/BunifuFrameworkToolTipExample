using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BunifuTooltipExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuToolTip1.DisplayControl = new ToolTipImageControl();
            bunifuToolTip1.ClickToShowDisplayControl = true;

            // You can also set the ToolTip Title and/or Icon property.
            bunifuToolTip1.SetToolTipTitle(bunifuImageButton1, "Jada Pinketh Smith");
            bunifuToolTip1.SetToolTip(bunifuImageButton1, "Hello there... click for more details");
            bunifuToolTip1.SetToolTipIcon(bunifuImageButton1, Image.FromFile("C:\\Users\\Kenboi\\Downloads\\jada.jpg"));
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
