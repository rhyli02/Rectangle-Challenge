using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            int widthSize = Convert.ToInt32(textBox1.Text);
            int heightSize = Convert.ToInt32(textBox2.Text);
            setPanelSize(widthSize, heightSize,panel1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int widthSize = Convert.ToInt32(textBox5.Text);
            int heightSize = Convert.ToInt32(textBox6.Text);


            setPanelSize(widthSize, heightSize, panel2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int widthSize = Convert.ToInt32(textBox9.Text);
            int heightSize = Convert.ToInt32(textBox10.Text);


            setPanelSize(widthSize, heightSize, panel3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox3.Text);
            int y = Convert.ToInt32(textBox4.Text);

            adjustLocation( x, y, panel1);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox7.Text);
            int y = Convert.ToInt32(textBox8.Text);

            adjustLocation(x, y, panel2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox11.Text);
            int y = Convert.ToInt32(textBox12.Text);

            adjustLocation(x, y, panel3);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(55,65);
            panel1.Size = new Size(200, 115);

            textBox1.Text = "200";
            textBox2.Text = "115";

            textBox3.Text = "55";
            textBox4.Text = "65";

            panel2.Location = new Point(326, 60);
            panel2.Size = new Size(200, 115);

            textBox5.Text = "200";
            textBox6.Text = "115";

            textBox7.Text = "326";
            textBox8.Text = "60";


            panel3.Location = new Point(120, 242);
            panel3.Size = new Size(200, 115);

            textBox9.Text = "200";
            textBox10.Text = "115";

            textBox11.Text = "120";
            textBox12.Text = "242";
        }
        public void adjustLocation(int x, int y, Panel updatePanel)
        {
            int oldX = updatePanel.Location.X;
            int oldY = updatePanel.Location.Y;
            updatePanel.Location = new Point(x, y);
            if (IsPanelOverlap(updatePanel))
            {
                string message = "This panel overlap to another panel";
                string title = "Error";
                MessageBox.Show(message, title);

                updatePanel.Location = new Point(oldX, oldY);

            }
        }

        public bool IsPanelOverlap(Panel updatePanel)
        {

            Rectangle sr = new Rectangle(updatePanel.Left, updatePanel.Top, updatePanel.Width, updatePanel.Height);
            foreach (Panel ctrl in this.groupBox1.Controls)
            {
                if (ctrl is Panel && ctrl != updatePanel)
                {
                    Rectangle r = new Rectangle(ctrl.Left, ctrl.Top, ctrl.Width, ctrl.Height);
                    if (sr.IntersectsWith(r))
                    {
                        return true;
                    }
                }
            }
            return false;


        }

        public void setPanelSize(int widthSize, int heightSize, Panel updatePanel)
        {

            int oldW = updatePanel.Width;
            int oldH = updatePanel.Height;

            if (widthSize <= 500 && widthSize >= 50 && heightSize <= 500 && heightSize >= 50)
            {
                updatePanel.Size = new Size(widthSize, heightSize);
                if (IsPanelOverlap(updatePanel))
                {
                    string message = "This panel overlap to another panel";
                    string title = "Error";
                    MessageBox.Show(message, title);
                    updatePanel.Size = new Size(oldW, oldH);
                }

            }


        }

       
    }
}
