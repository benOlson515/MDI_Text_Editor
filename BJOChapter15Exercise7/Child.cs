using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJOChapter15Exercise7
{
    public partial class Child : Form
    {
        public Child( String title )
        {
            InitializeComponent();

            Text = title;

        }
    }
}
