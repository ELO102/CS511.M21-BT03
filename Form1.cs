using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511.M21_BT03
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void main_panel_order()
        {
            this.Controls.Add(this.panel_homepage);
        }

    }
}
