using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mang_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[,] buttons = new Button[5, 5];
        int[,] array = new int[,]
            {
                { 1,2,5,7,9 },
                { 8,2,5,7,6 },
                { 1,2,5,7,9 },
                { 4,2,5,7,1 },
                { 5,2,9,7,9 },
            };

        private void Form1_Load(object sender, EventArgs e)
        {//0 dòng, 1 cột
            int i=0,j=0;
            for(i=0;i<buttons.GetLength(0);i++)
            {
                for(j=0;j<buttons.GetLength(1);j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 35;
                    buttons[i, j].Location = new Point(i * 40, j * 40);
                    //buttons[i, j].Text = array[i, j].ToString();
                    buttons[i, j].Click += button_Click;
                    buttons[i,j].Tag = i + "," + j;
                    panel1.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string[] getTag = button.Tag.ToString().Split(',');
            int tag = Int32.Parse(getTag[0]);
            int row = Int32.Parse(getTag[1]);
            button.Text = array[row, tag].ToString();
            int tong = 0;
            for(int i=0;i<5;i++)
            {
                tong += array[tag, i];
            }
            txtTong.Text = tong.ToString();
        }
    }
}
