using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace OOP
{
    public partial class Order : Form
    {
        int SamNum = 0;
        int MokNum = 0;
        int HangNum = 0;
        int KkupNum = 0;
        int SojuNum = 0;
        int BeerNum = 0;
        int SoupNum = 0;
        int Total = 0;


        public Order()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Sam = "삼겹살";
            listBox1.Items.Add(Sam);
            SamNum++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Mok = "목살";
            listBox1.Items.Add(Mok);
            MokNum++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Hang = "항정살";
            listBox1.Items.Add(Hang);
            HangNum++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String Kkup = "껍데기";
            listBox1.Items.Add(Kkup);
            KkupNum++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String Soup = "된장찌게";
            listBox1.Items.Add(Soup);
            KkupNum++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String Soju = "소주";
            listBox1.Items.Add(Soju);
            SojuNum++; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String Beer = "맥주";
            listBox1.Items.Add(Beer);
            BeerNum++;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int Total = SamNum * 4000 + MokNum * 5000 + HangNum * 6000 + KkupNum * 4000
                    + SojuNum * 4500 + BeerNum * 4500 + SoupNum * 5000;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox3.Items.Add("삼겹살: "+SamNum);
            listBox3.Items.Add("목살: " + MokNum);
            listBox3.Items.Add("항정살: " + HangNum);
            listBox3.Items.Add("껍데기: " + KkupNum);
            listBox3.Items.Add("된장찌게: " + SoupNum);
            listBox3.Items.Add("소주: " + SojuNum);
            listBox3.Items.Add("맥주: " + BeerNum);
            listBox2.Items.Add("합계 :" + Total + "원");
        }



        private void button9_Click(object sender, EventArgs e)
        {
            SamNum = 0;
            MokNum = 0;
            HangNum = 0;
            KkupNum = 0;
            SojuNum = 0;
            BeerNum = 0;
            SoupNum = 0;
            Total = 0;

            listBox3.Items.Clear() ;
            listBox2.Items.Clear() ;
        }
    }
}
