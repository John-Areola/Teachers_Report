using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Cgp
{
    public partial class Student_Result : Form
    {
        public Student_Result()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_CGPA_Click(object sender, EventArgs e)
        {
            int Mathematics = Int32.Parse(Mathematics_Box.Text);
            int English_Language = Int32.Parse(English_Box.Text);
            int Finance = Int32.Parse(Finance_Box.Text);
            int Economics = Int32.Parse(Economics_Box.Text);
            int Physics = Int32.Parse(Physics_Box.Text);
            CGPA.Text = TotalCgpa (Mathematics, English_Language, Finance, Economics, Physics).ToString ();
        }
        public float TotalCgpa(int Mathematics, int English_Language, int Finance, int Economics, int Physics) 
        {
            return ((Mathematics + English_Language + Finance + Economics + Physics)/5);


        }

        private void Mathematics_TextChanged(object sender, EventArgs e)
        {
           

        }
    }   
}
