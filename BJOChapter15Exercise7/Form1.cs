//Benjamin Olson
//Chapter 15 Ecercise 7
//Text Editor


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
    public partial class Form1 : Form
    {

        int fileNumber = 1; //counter to allow the numbering of filenames

        public Form1()
        {
            InitializeComponent();
        }


        //  **********  close application when exit button is hit *********
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // ********** create the new file when you click new  **********
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create new child window
            Child child = new Child("File " + fileNumber);
            child.MdiParent = this; //set parent
            child.Show(); //display the child element
            fileNumber++; //increment the counter for next file
        }


        //                  ****************set window layouts*****************

        //tile in cascade
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        //tile horizontally
        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        //tile vertically
        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //close the active child
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }



        //                         *********change font colors************

        //clear checks for font colors
        private void clearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = false;
            pinkToolStripMenuItem.Checked = false;
            purpleToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            
        }
        //make text black
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }
        //make font blues
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }
        //make text green
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }
        //make text oragne
        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Orange;
            orangeToolStripMenuItem.Checked = true;
        }
        //make text pink
        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Pink;
            pinkToolStripMenuItem.Checked = true;
        }
        //make text purple
        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Purple;
            purpleToolStripMenuItem.Checked = true;
        }
        //make text red
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }
        //make text yellow
        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Yellow;
            yellowToolStripMenuItem.Checked = true;
        }


        //          ***************set font sizes*********************

        //clear checks for font size
        private void clearFontSize()
        {
            size8btn.Checked = false;
            size10btn.Checked = false;
            size12btn.Checked = false;
            size14btn.Checked = false;
            size16btn.Checked = false;
            size18btn.Checked = false;
        }

        //size 8
        private void size8btn_Click(object sender, EventArgs e)
        {
            clearFontSize();
            ActiveMdiChild.Controls["richTextbox1"].Font = new Font(ActiveMdiChild.Controls["richTextbox1"].Font.Name, 8);
            size8btn.Checked = true;
        }
        //size 10
        private void size10btn_Click(object sender, EventArgs e)
        {
            clearFontSize();
            ActiveMdiChild.Controls["richTextbox1"].Font = new Font(ActiveMdiChild.Controls["richTextbox1"].Font.Name, 10);
            size10btn.Checked = true;
        }
        //size 12
        private void size12btn_Click(object sender, EventArgs e)
        {
            clearFontSize();
            ActiveMdiChild.Controls["richTextbox1"].Font = new Font(ActiveMdiChild.Controls["richTextbox1"].Font.Name, 12);
            size12btn.Checked = true;
        }
        //size 14
        private void size14btn_Click(object sender, EventArgs e)
        {
            clearFontSize();
            ActiveMdiChild.Controls["richTextbox1"].Font = new Font(ActiveMdiChild.Controls["richTextbox1"].Font.Name, 14);
            size14btn.Checked = true;
        }
        //size 16
        private void size16btn_Click(object sender, EventArgs e)
        {
            clearFontSize();
            ActiveMdiChild.Controls["richTextbox1"].Font = new Font(ActiveMdiChild.Controls["richTextbox1"].Font.Name, 16);
            size16btn.Checked = true;
        }
        //size 18
        private void size18btn_Click(object sender, EventArgs e)
        {
            clearFontSize();
            ActiveMdiChild.Controls["richTextbox1"].Font = new Font(ActiveMdiChild.Controls["richTextbox1"].Font.Name, 18);
            size18btn.Checked = true;
        }

        //         *****************set font type********************

        //clear font type checks
        private void clearType()
        {
            timesToolStripMenuItem.Checked = false;
            microsoftSansSerifToolStripMenuItem.Checked = false;
            arielToolStripMenuItem.Checked = false;
            courierNewToolStripMenuItem.Checked = false;

        }

        //set to times new roman
        private void timesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearType();
            ActiveMdiChild.Controls["richTextbox1"].Font = new Font("Times New Roman", ActiveMdiChild.Controls["richTextbox1"].Font.Size);
            timesToolStripMenuItem.Checked = true;
        }
        //set to microsoft sans serif
        private void microsoftSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearType();
            ActiveMdiChild.Controls["richTextbox1"].Font = new Font("Microsoft Sans Serif", ActiveMdiChild.Controls["richTextbox1"].Font.Size);
            microsoftSansSerifToolStripMenuItem.Checked = true;
        }
        //set to ariel
        private void arielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearType();
            ActiveMdiChild.Controls["richTextbox1"].Font = new Font("Ariel", ActiveMdiChild.Controls["richTextbox1"].Font.Size);
            arielToolStripMenuItem.Checked = true;
        }
        //set to courier new
        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearType();
            ActiveMdiChild.Controls["richTextbox1"].Font = new Font("Courier New", ActiveMdiChild.Controls["richTextbox1"].Font.Size);
            courierNewToolStripMenuItem.Checked = true;
        }
        
        

    }
}
