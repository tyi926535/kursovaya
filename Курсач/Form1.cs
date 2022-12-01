using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Курсач
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton15.Enabled = false;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            numericUpDown7.Visible = true;
            numericUpDown9.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label10.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            if (radioButton11.Checked)
                label9.Visible = true;
            else label9.Visible = false;

            label28.Visible = false;
            label29.Visible = false;
            comboBox6.Visible = true;
            comboBox7.Visible = false;
            comboBox8.Visible = false;

           

            if (radioButton9.Checked)
            {
                groupBox4.Visible = true;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                textBox1.Text = "30";
                label14.Visible = false;
            }
            if (groupBox4.Visible && (radioButton12.Checked || radioButton13.Checked))
            {
                radioButton15.Enabled = true;
            }
            if (radioButton8.Checked || radioButton9.Checked || radioButton10.Checked)
            {
                label18.Visible = false;
                label19.Visible = false;
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = true;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = false;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
            numericUpDown7.Visible = false;
            numericUpDown9.Visible = true;

            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label10.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            if (radioButton11.Checked)
                label9.Visible = true;
            else label9.Visible = false;

            label28.Visible = false;
            label29.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = true;
            comboBox8.Visible = false;

           

            radioButton15.Enabled = false;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            if (radioButton9.Checked)
            {
                groupBox4.Visible = true;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                textBox1.Text = "50";
                label14.Visible = false;
            }
            if (groupBox4.Visible && (radioButton12.Checked || radioButton13.Checked))
            {
                radioButton15.Enabled = true;
            }
            

            if (radioButton8.Checked || radioButton9.Checked || radioButton10.Checked)
            {
                label18.Visible = false;
                label19.Visible = false;
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = false;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = true;
                numericUpDown11.Visible = false;
               
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            numericUpDown7.Visible = false;
            numericUpDown9.Visible = true;


            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label10.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            if (radioButton11.Checked)
                label9.Visible = true;
            else label9.Visible = false;

            label28.Visible = false;
            label29.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = true;

            

            radioButton6.Visible = true;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton7.Visible = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton7.Checked = false;
            if (radioButton9.Checked)
            {

                groupBox4.Visible = true;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                textBox1.Text = "100";
                label14.Visible = false;
            }
            radioButton15.Enabled = false;
            radioButton15.Checked = false;
            

            if (radioButton8.Checked || radioButton9.Checked || radioButton10.Checked)
            {
                label18.Visible = false;
                label19.Visible = false;
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = false;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = true;
                numericUpDown11.Visible = false;
                
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Visible = true;
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                label18.Visible = true;
                label19.Visible = true;
            }
            radioButton14.Enabled = false;
            radioButton15.Enabled = false;
            label11.Visible = true;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label10.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            textBox1.Visible = false;
            label14.Visible = false;
            groupBox4.Visible = true;
            radioButton12.Checked = false;
            radioButton13.Checked = false;


            if (radioButton1.Checked && checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = true;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = false;
            }
            if (radioButton1.Checked && !checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = false;
                numericUpDown8.Visible = true;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = false;
            }
            if ((radioButton2.Checked || radioButton3.Checked) && checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = false;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = true;
                numericUpDown11.Visible = false;
            }
            if ((radioButton2.Checked || radioButton3.Checked) && !checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = false;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = true;
            }
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            label18.Visible = false;
            label19.Visible = false;
            label12.Visible = false;
            radioButton14.Enabled = false;
            radioButton15.Enabled = false;
            label14.Visible = true;
            textBox1.Visible = false;
            numericUpDown3.Visible = false;
            label11.Visible = false;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            label10.Visible = true;
            checkBox3.Visible = false;
            label17.Visible = false;
            numericUpDown6.Visible = false;
            numericUpDown8.Visible = false;
            numericUpDown10.Visible = false;
            numericUpDown11.Visible = false;
            if (checkBox1.Checked && radioButton5.Checked && radioButton11.Checked)
            {
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                label9.Visible = false;
                label14.Visible = false;
                groupBox4.Visible = true;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                
            }
            if (radioButton5.Checked && !checkBox1.Checked)
            {
                comboBox1.Visible = false;
                comboBox2.Visible = true;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                label9.Visible = false;
                label14.Visible = false;
                groupBox4.Visible = true;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                
            }
            if (radioButton4.Checked && checkBox1.Checked)
            {
                comboBox3.Visible = true;
                label9.Visible = false;
                label14.Visible = false;
                groupBox4.Visible = true;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                
            }
            if (radioButton4.Checked && !checkBox1.Checked)
            {
                comboBox4.Visible = true;
                label9.Visible = false;
                label14.Visible = false;
                groupBox4.Visible = true;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                
            }
            if (radioButton6.Checked || radioButton7.Checked || radioButton5.Checked || radioButton4.Checked)
            {
                comboBox5.Visible = true;
                label9.Visible = false;
                label14.Visible = false;
                groupBox4.Visible = true;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
            }
            else
            {
                label9.Visible = true;
                groupBox4.Visible = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Enabled = false;
                radioButton15.Enabled = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
            }
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton11.Checked)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                label10.Visible = true;
                label9.Visible = false;
            }

            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            if (radioButton11.Checked)
            {
                if (checkBox1.Checked)
                {
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = true;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    label14.Visible = false;
                    groupBox4.Visible = true;
                    radioButton12.Checked = false;
                    radioButton13.Checked = false;
                    
                }
                else
                {
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = true;
                    comboBox5.Visible = false;
                    label14.Visible = false;
                    groupBox4.Visible = true;
                    radioButton12.Checked = false;
                    radioButton13.Checked = false;
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                label10.Visible = true;
                label9.Visible = false;
            }
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            if (radioButton11.Checked)
            {
                if (checkBox1.Checked)
                {
                    comboBox1.Visible = true;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    label14.Visible = false;
                    groupBox4.Visible = true;
                    radioButton12.Checked = false;
                    radioButton13.Checked = false;
                }
                else
                {
                    comboBox1.Visible = false;
                    comboBox2.Visible = true;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    label14.Visible = false;
                    groupBox4.Visible = true;
                    radioButton12.Checked = false;
                    radioButton13.Checked = false;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                label10.Visible = true;
                label9.Visible = false;
            }
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            if (radioButton11.Checked)
            {
                comboBox5.Visible = true;
                label14.Visible = false;
                groupBox4.Visible = true;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
            }

           

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                label10.Visible = true;
                label9.Visible = false;
            }
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            if (radioButton11.Checked)
            {
                comboBox5.Visible = true;
                label14.Visible = false;
                groupBox4.Visible = true;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
            }
            

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label14.Visible = true;
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                label18.Visible = true;
                label19.Visible = true;
            }
            radioButton14.Enabled = false;
            radioButton15.Enabled = false;
            groupBox4.Visible = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            numericUpDown3.Visible = false;
            label11.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label10.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            label9.Visible = false;
            label12.Visible = true;
            textBox1.Visible = true;
            if (radioButton1.Checked)
            {
                textBox1.Text = "30";
                groupBox4.Visible = true;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                label14.Visible = false;
            }
            else
            {
                if (radioButton3.Checked)
                {
                    textBox1.Text = "50";
                    groupBox4.Visible = true;
                    radioButton12.Checked = false;
                    radioButton13.Checked = false;
                    label14.Visible = false;
                }
                else
                {
                    if (radioButton2.Checked)
                    {
                        textBox1.Text = "100";
                        groupBox4.Visible = true;
                        radioButton12.Checked = false;
                        radioButton13.Checked = false;
                        label14.Visible = false;
                    }
                }
            }


            if (radioButton1.Checked && checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = true;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = false;
            }
            if (radioButton1.Checked && !checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = false;
                numericUpDown8.Visible = true;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = false;
            }
            if ((radioButton2.Checked || radioButton3.Checked) && checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = false;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = true;
                numericUpDown11.Visible = false;
            }
            if ((radioButton2.Checked || radioButton3.Checked) && !checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = false;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = true;
            }

           
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                label18.Visible = true;
                label19.Visible = true;
            }
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            numericUpDown3.Visible = false;
            label11.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label10.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            textBox1.Visible = false;
            label14.Visible = false;

            if (radioButton1.Checked && checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = true;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = false;
            }
            if (radioButton1.Checked && !checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = false;
                numericUpDown8.Visible = true;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = false;
            }
            if ((radioButton2.Checked || radioButton3.Checked) && checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = false;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = true;
                numericUpDown11.Visible = false;
            }
            if ((radioButton2.Checked || radioButton3.Checked) && !checkBox3.Checked)
            {
                checkBox3.Visible = true;
                label17.Visible = true;
                numericUpDown6.Visible = false;
                numericUpDown8.Visible = false;
                numericUpDown10.Visible = false;
                numericUpDown11.Visible = true;
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (radioButton5.Checked)
                {
                    comboBox1.Visible = true;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    label9.Visible = false;
                }
                else if (radioButton4.Checked)
                {
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = true;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    label9.Visible = false;
                }

            }
            else
            {
                if (radioButton5.Checked)
                {
                    comboBox1.Visible = false;
                    comboBox2.Visible = true;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    label9.Visible = false;
                    label9.Visible = false;
                }
                else if (radioButton4.Checked)
                {
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = true;
                    comboBox5.Visible = false;
                    label9.Visible = false;
                    label9.Visible = false;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            radioButton14.Enabled = true;
            if (radioButton1.Checked || radioButton3.Checked)
                radioButton15.Enabled = true;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            radioButton14.Enabled = true;
            if (radioButton1.Checked || radioButton3.Checked)
                radioButton15.Enabled = true;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && (radioButton8.Checked || radioButton9.Checked || radioButton10.Checked))
            {
                if (checkBox3.Visible && checkBox3.Checked)
                {
                    numericUpDown6.Visible = true;
                    numericUpDown8.Visible = false;
                    numericUpDown10.Visible = false;
                    numericUpDown11.Visible = false;
                }
                if (checkBox3.Visible && !checkBox3.Checked)
                {
                    numericUpDown6.Visible = false;
                    numericUpDown8.Visible = true;
                    numericUpDown10.Visible = false;
                    numericUpDown11.Visible = false;
                }
            }
            if ((radioButton2.Checked || radioButton3.Checked) && (radioButton8.Checked || radioButton9.Checked || radioButton10.Checked))
            {
                if (checkBox3.Visible && checkBox3.Checked)
                {
                    numericUpDown6.Visible = false;
                    numericUpDown8.Visible = false;
                    numericUpDown10.Visible = true;
                    numericUpDown11.Visible = false;
                }
                if (checkBox3.Visible && !checkBox3.Checked)
                {
                    numericUpDown6.Visible = false;
                    numericUpDown8.Visible = false;
                    numericUpDown10.Visible = false;
                    numericUpDown11.Visible = true;
                }
            }
        }

        

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        double rd1(double d1)
        { /////////////////округление d1
            if (d1 < 62.2)
                d1 = 62.2;
            else if (d1 > 318.2)
                d1 = 318.2;
            else if (d1 > 63.8 && d1 <= 67)
                d1 = 63.8;
            else if (d1 > 67 && d1 < 70)
                d1 = 70;
            else if (d1 > 72 && d1 <= 75.5)
                d1 = 72;
            else if (d1 > 75.5 && d1 < 79)
                d1 = 79;
            else if (d1 > 81 && d1 <= 85)
                d1 = 81;
            else if (d1 > 85 && d1 < 88.8)
                d1 = 88.8;
            else if (d1 > 91.2 && d1 <= 95)
                d1 = 91.2;
            else if (d1 > 95 && d1 < 98.8)
                d1 = 98.8;
            else if (d1 > 101.2 && d1 <= 106)
                d1 = 101.2;
            else if (d1 > 106 && d1 < 110.8)
                d1 = 110.8;
            else if (d1 > 112.2 && d1 <= 118.5)
                d1 = 112.2;
            else if (d1 > 118.5 && d1 < 123.4)
                d1 = 123.4;
            else if (d1 > 126.6 && d1 <= 132.5)
                d1 = 126.6;
            else if (d1 > 132.5 && d1 < 138.4)
                d1 = 138.4;
            else if (d1 > 141.6 && d1 <= 150)
                d1 = 141.1;
            else if (d1 > 150 && d1 < 158)
                d1 = 158;
            else if (d1 > 162 && d1 <= 170)
                d1 = 162;
            else if (d1 > 170 && d1 < 178)
                d1 = 178;
            else if (d1 > 182 && d1 <= 190)
                d1 = 182;
            else if (d1 > 190 && d1 < 197.5)
                d1 = 197.5;
            else if (d1 > 202.5 && d1 <= 212)
                d1 = 202.5;
            else if (d1 > 212 && d1 < 221.5)
                d1 = 221.5;
            else if (d1 > 226.5 && d1 <= 237)
                d1 = 226.5;
            else if (d1 > 237 && d1 < 247.5)
                d1 = 247.7;
            else if (d1 > 252.5 && d1 <= 265)
                d1 = 252.5;
            else if (d1 > 265 && d1 < 276.8)
                d1 = 276.8;
            else if (d1 > 283.2 && d1 <= 297.5)
                d1 = 283.2;
            else if (d1 > 297.5 && d1 < 311.8)
                d1 = 311.8;
            else d1 = -5;
            return d1;
        }


        double dod1()
        {
            double d1;
            if (radioButton8.Checked)
            {
                d1 = 125 * Math.Pow((((double)numericUpDown2.Value * 1000) / (double)numericUpDown1.Value), (1.0 / 3));
                d1 = rd1(d1);
                return d1;
            }
            else if (radioButton9.Checked)
            {
                if (radioButton1.Checked)
                {
                    d1 = (30 * 60000) / (3.1415926 * (double)numericUpDown1.Value);
                    d1 = rd1(d1);
                    return d1;
                }
                else if (radioButton3.Checked)
                {
                    d1 = (50 * 60000) / (3.1415926 * (double)numericUpDown1.Value);
                    d1 = rd1(d1);
                    return d1;
                }

                else if (radioButton2.Checked)
                {
                    d1 = (100 * 60000) / (3.1415926 * (double)numericUpDown1.Value);
                    d1 = rd1(d1);
                    return d1;
                }
                else return -5;
            }
            else if (radioButton10.Checked)
            {
                return (double)numericUpDown3.Value - 5;
            }
            else if (radioButton11.Checked)
            {
                if (!label9.Visible)
                {
                    if (comboBox1.Visible)
                    {
                        if ((double)comboBox1.SelectedIndex == 0)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 180;
                                return d1;
                            }
                            else return 140;
                        }
                        else if ((double)comboBox1.SelectedIndex == 1)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 224;
                                return d1;
                            }
                            else return 180;
                        }
                        else if ((double)comboBox1.SelectedIndex == 2)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 315;
                                return d1;
                            }
                            else return 224;
                        }
                        else if ((double)comboBox1.SelectedIndex == 3)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 355;
                                return d1;
                            }
                            else return 315;
                        }
                        else return -5;
                    }
                    else if (comboBox2.Visible)
                    {
                        if ((double)comboBox2.SelectedIndex == 0)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 140;
                                return d1;
                            }
                            else return 112;
                        }
                        else if ((double)comboBox2.SelectedIndex == 1)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 200;
                                return d1;
                            }
                            else return 140;
                        }
                        else if ((double)comboBox2.SelectedIndex == 2)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 250;
                                return d1;
                            }
                            else return 180;
                        }
                        else if ((double)comboBox2.SelectedIndex == 3)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 315;
                                return d1;
                            }
                            else return 224;
                        }
                        else return -5;
                    }
                    else if (comboBox3.Visible)
                    {
                        if ((double)comboBox3.SelectedIndex == 0)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 140;
                                return d1;
                            }
                            else return 112;
                        }
                        else if ((double)comboBox3.SelectedIndex == 1)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 180;
                                return d1;
                            }
                            else return 140;
                        }
                        else if ((double)comboBox3.SelectedIndex == 2)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 224;
                                return d1;
                            }
                            else return 180;
                        }
                        else if ((double)comboBox3.SelectedIndex == 3)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 280;
                                return d1;
                            }
                            else return 200;
                        }
                        else return -5;
                    }
                    else if (comboBox4.Visible)
                    {
                        if ((double)comboBox4.SelectedIndex == 0)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 125;
                                return d1;
                            }
                            else return 90;
                        }
                        else if ((double)comboBox4.SelectedIndex == 1)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 160;
                                return d1;
                            }
                            else return 112;
                        }
                        else if ((double)comboBox4.SelectedIndex == 2)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 200;
                                return d1;
                            }
                            else return 140;
                        }
                        else if ((double)comboBox4.SelectedIndex == 3)
                        {
                            if (checkBox2.Checked)
                            {
                                d1 = 224;
                                return d1;
                            }
                            else return 180;
                        }
                        else return -5;
                    }
                    else if (comboBox5.Visible)
                    {
                        if ((double)comboBox5.SelectedIndex == 0)
                        {
                            d1 = 28;
                            return d1;
                        }
                        else if ((double)comboBox5.SelectedIndex == 1)
                        {
                            d1 = 36;
                            return d1;
                        }
                        else if ((double)comboBox5.SelectedIndex == 2)
                        {
                            d1 = 45;
                            return d1;
                        }
                        else if ((double)comboBox5.SelectedIndex == 3)
                        {
                            d1 = 56;
                            return d1;
                        }
                        else if ((double)comboBox5.SelectedIndex == 4)
                        {
                            d1 = 63;
                            return d1;
                        }
                        else if ((double)comboBox5.SelectedIndex == 5)
                        {
                            d1 = 71;
                            return d1;
                        }
                        else if ((double)comboBox5.SelectedIndex == 6)
                        {
                            d1 = 80;
                            return d1;
                        }
                        else if ((double)comboBox5.SelectedIndex == 7)
                        {
                            d1 = 90;
                            return d1;
                        }
                        else if ((double)comboBox5.SelectedIndex == 8)
                        {
                            d1 = 100;
                            return d1;
                        }
                        else return -5;
                    }
                    else return -5;
                }
                else return -5;
            }
            else return -5;
        }

        double dod2(double d1)
        {
            double d2;
            if (radioButton12.Visible && radioButton12.Checked)
                d2 = (d1 * (double)numericUpDown4.Value) / (1 - (double)numericUpDown5.Value);
            else if (radioButton13.Visible && radioButton13.Checked)
                d2 = d1 * (double)numericUpDown4.Value * (1 - (double)numericUpDown5.Value);
            else d2 = -5;
            return d2;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((!radioButton4.Checked && radioButton4.Visible) && (!radioButton5.Checked && radioButton5.Visible) && (!radioButton6.Checked && radioButton6.Visible) && (!radioButton7.Visible && radioButton7.Visible))
            {
                MessageBox.Show("Недостаточно данных!\nВыберите материал ремня.", "Внимание!");
                return;
            }
            if (!radioButton11.Checked && !radioButton10.Checked && !radioButton9.Checked && !radioButton8.Checked)
            {
                MessageBox.Show("Недостаточно данных!\nЗадайте параметры для рассчёта D1.", "Внимание!");
                return;
            }
            
            if ((!radioButton12.Checked && radioButton12.Enabled && radioButton12.Visible) && (!radioButton13.Checked && radioButton13.Enabled && radioButton13.Visible))
            {
                MessageBox.Show("Недостаточно данных!\nВыберите тип передачи.", "Внимание!");
                return;
            }
            if (!radioButton14.Checked &&!radioButton15.Checked)
            {
                MessageBox.Show("Недостаточно данных!\nВыберите метод определения длины ремня.", "Внимание!");
                return;
            }
           

            int all = 1;
            /////////////////
            double d1 = 1;
            if (dod1() != -5)
                d1 = dod1();
            else all--;
            double d2 = 1;
            if (dod2(d1) != -5)
                d2 = dod2(d1);
            else all--;
            double v = 3.1415926 * d1 * (double)numericUpDown1.Value / 60000.0;
            double vmax = 30;
            if (radioButton1.Checked)
                vmax = 30;
            if (radioButton2.Checked)
                vmax = 100;
            if (radioButton2.Checked)
                vmax = 50;
            ///////////////
            //DataGrid2
            dataGridView2.Rows.Add();
            {
                dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[0].Value = dataGridView2.RowCount - 1;
                {//Vmax
                    if (radioButton1.Checked)
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[1].Value = 30;
                    else if (radioButton3.Checked)
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[1].Value = 50;
                    else if (radioButton2.Checked)
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[1].Value = 100;
                    else all--;
                }
                { //zi
                    if (radioButton8.Checked || (radioButton9.Checked && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)) || radioButton10.Checked || (radioButton11.Checked && (!label9.Visible)))
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[2].Value = numericUpDown5.Value;
                    else all--;
                }
                {//N 
                    dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[3].Value = numericUpDown2.Value;
                }
                {//n1 
                    dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[4].Value = numericUpDown1.Value;
                }
                {//h 
                    if (radioButton10.Checked)
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[5].Value = numericUpDown3.Value;
                    else
                    {
                        if (radioButton11.Checked || radioButton8.Checked || radioButton9.Checked)
                            dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[5].Value = '-';
                        else all--;
                    }
                }
                {//sigma 
                    if (radioButton11.Checked)
                    {
                        if (!label9.Visible)
                        {
                            if (comboBox1.Visible)
                                dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[6].Value =  comboBox1.SelectedItem;
                            else if (comboBox2.Visible)
                                dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[6].Value =  comboBox2.SelectedItem;
                            else if (comboBox3.Visible)
                                dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[6].Value =  comboBox3.SelectedItem;
                            else if (comboBox4.Visible)
                                dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[6].Value =  comboBox4.SelectedItem;
                            else if (comboBox5.Visible)
                                dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[6].Value =  comboBox5.SelectedItem;
                        }
                        else all--;
                    }
                    else if (numericUpDown11.Visible)
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[6].Value = d1 / (double)numericUpDown11.Value;
                    else if (numericUpDown10.Visible)
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[6].Value = d1 / (double)numericUpDown10.Value;
                    else if (numericUpDown8.Visible)
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[6].Value = d1 / (double)numericUpDown8.Value;
                    else if (numericUpDown6.Visible)
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[6].Value = d1 / (double)numericUpDown6.Value;
                    else all--;
                }
                {//U 
                    if (radioButton11.Checked)
                    {
                        if (!label9.Visible)
                        {
                            dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[7].Value = numericUpDown4.Value;
                            dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[8].Value = numericUpDown1.Value / numericUpDown4.Value;//n2
                        }
                        else all--;
                    }
                    else if (radioButton8.Checked || radioButton10.Checked || (radioButton9.Checked && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)))
                    {
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[7].Value = numericUpDown4.Value;
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[8].Value = numericUpDown1.Value / numericUpDown4.Value;//n2
                    }
                    else all--;
                }
                {//i
                    if (radioButton1.Checked)
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[9].Value = numericUpDown7.Value;
                    if (radioButton2.Checked || radioButton3.Checked)
                        dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[9].Value = numericUpDown9.Value;
                }
            }

            //DataGrid3
            dataGridView3.Rows.Add();
            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[0].Value = dataGridView3.RowCount - 1;
            {
                {//uf 
                    if (radioButton12.Checked && radioButton12.Visible)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[1].Value = (d2 * (1 - (double)numericUpDown5.Value) / d1);
                    else if (radioButton13.Checked && radioButton13.Visible)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[1].Value = (d2 / ((1 - (double)numericUpDown5.Value) * d1));
                }
                {//n2f 
                    dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[2].Value = (double)numericUpDown1.Value / Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[1].Value.ToString());
                }
                {//amin 
                    if (radioButton1.Checked)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[3].Value = 2 * (d1 + d2);
                    else if (radioButton2.Checked || radioButton3.Checked)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[3].Value = 1.5 * (d1 + d2);
                    else all--;
                }
                {//Lmin 
                    if (radioButton1.Checked)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[4].Value = vmax / 5;
                    if (radioButton2.Checked || radioButton3.Checked)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[4].Value = vmax / 50;
                }
                ////////////
                double Mezhosmin = Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[3].Value.ToString());
                double dlina = 2 * Mezhosmin + (3.1415926 * (d1 + d2) / 2) + ((d2 - d1) * (d2 - d1) / (4 * Mezhosmin));
                double dlinamin = 1000 * Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[4].Value.ToString());
                if (dlina < dlinamin)
                    dlina = dlinamin;
                ////////
                {//lambda 
                    dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[5].Value = dlina - 3.1415926 * ((d1 + d2) / 2);
                }
                {//delta 
                    dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[6].Value = (d2 - d1) / 2;
                }
                {//sigm0 
                   
                    if (numericUpDown10.Visible)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value = 5;
                    else if (numericUpDown11.Visible)
                    {
                        if (numericUpDown11.Value <= 80)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value = 5;
                        if (numericUpDown11.Value > 80 && numericUpDown11.Value < 100)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value = 7.5;
                        if (numericUpDown11.Value > 100)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value = 10;
                    }
                }
                {//A 
                    if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 1.6)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[8].Value = 2.3;
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 1.8)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[8].Value = 2.5;
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 2.0)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[8].Value = 2.7;
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 2.4)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[8].Value = 3.05;
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 5)
                    {
                        if (radioButton6.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[8].Value = 7.0;
                        else if (radioButton7.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[8].Value = 8.0;
                        else all--;
                    }
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 7.5)
                    {
                        if (radioButton6.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[8].Value = 9.6;
                        else if (radioButton7.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[8].Value = 11.4;
                        else all--;
                    }
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 10)
                    {
                        if (radioButton6.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[8].Value = 11.6;
                        else if (radioButton7.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[8].Value = 14.3;
                        else all--;
                    }
                    else all--;

                }
                {//W 
                    if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 1.6)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[9].Value = 9;
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 1.8)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[9].Value = 10;
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 2.0)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[9].Value = 11;
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 2.4)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[9].Value = 13.5;
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 5)
                    {
                        if (radioButton6.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[9].Value = 220;
                        else if (radioButton7.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[9].Value = 156;
                        else all--;
                    }
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 7.5)
                    {
                        if (radioButton6.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[9].Value = 330;
                        else if (radioButton7.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[9].Value = 233;
                        else all--;
                    }
                    else if (Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) == 10)
                    {
                        if (radioButton6.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[9].Value = 440;
                        else if (radioButton7.Checked)
                            dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[9].Value = 311;
                        else all--;
                    }
                    else all--;
                }
                {//C0 
                    dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[10].Value = 1;
                }
                ////////////
                double lambda, delta, a, alp;
                lambda = Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[5].Value.ToString());
                delta = Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[6].Value.ToString());
                a = (lambda + Math.Pow((lambda * lambda - 8 * delta * delta), (1.0 / 2))) / 4.0;
                alp = 180 - (d2 - d1) / a * 57;
                if (alp > 359)
                    alp = 359;
                if (radioButton1.Checked)
                {
                    if (alp < 150)
                        alp = 150;
                }
                if (radioButton2.Checked || radioButton3.Checked)
                {
                    if (alp < 120)
                        alp = 120;
                }
                ////////////
                {//C1 
                    if (alp <= 125)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[11].Value = 0.82;
                    else if (alp <= 135)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[11].Value = 0.85;
                    else if (alp <= 145)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[11].Value = 0.88;
                    else if (alp <= 155)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[11].Value = 0.91;
                    else if (alp <= 165)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[11].Value = 0.94;
                    else if (alp <= 175)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[11].Value = 0.97;
                    else if (alp > 175)
                        dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[11].Value = 1;
                }
                {//C2 
                    dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[12].Value = 1;
                }
                {//C3 
                    

                }
                {//sigmF0 
                    double A = Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[8].Value.ToString());
                    double W = Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[9].Value.ToString());
                    double sig = Convert.ToDouble(dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[6].Value.ToString());
                    dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[14].Value = A - W * sig / d1;
                }
            }

            //DataGrid1
            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = dataGridView1.RowCount - 1;
            {
                {//D1
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[1].Value = d1;
                }
                {//D2 
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[2].Value = d2;
                }
                {//v 
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[3].Value = v;
                }
                {//L 
                    double Mezhosmin = Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[3].Value.ToString());
                    double dlina = 2 * Mezhosmin + (3.1415926 * (d1 + d2) / 2) + ((d2 - d1) * (d2 - d1) / (4 * Mezhosmin));
                    double dlinamin = 1000 * Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[4].Value.ToString());
                    if (dlina < dlinamin)
                        dlina = dlinamin;
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[4].Value = dlina;
                }
                {//a 
                    double lambda, delta, a;
                    lambda = Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[5].Value.ToString());
                    delta = Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[6].Value.ToString());
                    a = (lambda + Math.Pow((lambda * lambda - 8 * delta * delta), (1.0 / 2))) / 4.0;
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[5].Value = a;
                }
                {//alpha 
                    double lambda, delta, a, alp;
                    lambda = Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[5].Value.ToString());
                    delta = Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[6].Value.ToString());
                    a = (lambda + Math.Pow((lambda * lambda - 8 * delta * delta), (1.0 / 2))) / 4.0;
                    alp = 180 - (d2 - d1) / a * 57;
                    if (alp > 359)
                        alp = 359;
                    if (radioButton1.Checked)
                    {
                        if (alp < 150)
                            alp = 150;
                    }
                    if (radioButton2.Checked || radioButton3.Checked)
                    {
                        if (alp < 120)
                            alp = 120;
                    }
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[6].Value = alp;
                }
                {//H 
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[7].Value = (1000 * (double)numericUpDown2.Value) / Convert.ToDouble(dataGridView1.Rows[dataGridView3.RowCount - 2].Cells[3].Value.ToString());
                }
                {//sigmF 
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[8].Value = Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[10].Value.ToString()) * Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[11].Value.ToString()) * Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[12].Value.ToString()) * Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[13].Value.ToString()) * Convert.ToDouble(dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[14].Value.ToString());
                }
                {//b 
                    double be = Convert.ToDouble(dataGridView1.Rows[dataGridView3.RowCount - 2].Cells[7].Value.ToString()) / (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[8].Value.ToString()) * Convert.ToDouble(dataGridView2.Rows[dataGridView2.RowCount - 2].Cells[6].Value.ToString()));
                    if (be > 250)
                        be = 250;
                    if (be < 10)
                        be = 10;
                    if (be > 10 && be < 14)
                        be = 10;
                    if (be >= 14 && be < 15)
                        be = 15;
                    if (be > 15 && be <= 17)
                        be = 15;
                    if (be > 17 && be < 20)
                        be = 20;
                    if (be > 20 && be < 25)
                        be = 25;
                    if (be > 25 && be < 30)
                        be = 30;
                    if (be > 30 && be < 32)
                        be = 32;
                    if (be > 32 && be <= 35)
                        be = 32;
                    if (be > 35 && be < 40)
                        be = 40;
                    if (be > 40 && be <= 45)
                        be = 40;
                    if (be > 45 && be < 50)
                        be = 50;
                    if (be > 50 && be <= 55)
                        be = 50;
                    if (be > 55 && be < 60)
                        be = 60;
                    if (be > 60 && be < 63)
                        be = 63;
                    if (be > 63 && be < 70)
                        be = 60;
                    if (be > 70 && be < 71)
                        be = 71;
                    if (be > 71 && be < 75)
                        be = 75;
                    if (be > 75 && be < 80)
                        be = 80;
                    if (be > 80 && be < 85)
                        be = 85;
                    if (be > 85 && be < 90)
                        be = 90;
                    if (be > 90 && be < 100)
                        be = 100;
                    if (be > 100 && be < 112)
                        be = 112;
                    if (be > 112 && be < 115)
                        be = 115;
                    if (be > 115 && be < 120)
                        be = 120;
                    if (be > 120 && be < 125)
                        be = 125;
                    if (be > 125 && be < 140)
                        be = 140;
                    if (be > 140 && be < 150)
                        be = 150;
                    if (be > 150 && be < 160)
                        be = 160;
                    if (be > 160 && be < 175)
                        be = 175;
                    if (be > 175 && be < 180)
                        be = 180;
                    if (be > 180 && be < 200)
                        be = 200;
                    if (be > 200 && be < 224)
                        be = 224;
                    if (be > 224 && be < 225)
                        be = 225;
                    if (be > 225 && be < 250)
                        be = 250;
                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value = be;
                }
                {//B 
                    if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 20)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 25;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 25)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 32;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 32)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 40;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 40)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 50;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 50)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 63;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 63)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 71;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 71)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 80;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 80)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 90;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 90)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 100;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 100)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 112;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 112)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 125;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 125)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 140;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 140)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 160;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 160)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 180;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) <= 180)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 200;
                    else if (Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[9].Value.ToString()) > 180)
                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[10].Value = 200;
                }
            }

            if (all != 1)
            {
                MessageBox.Show("Недостаточно данных!\nЗаполните все поля.", "Внимание!");
                dataGridView1.Rows.RemoveAt(dataGridView1.RowCount - 2);
                dataGridView2.Rows.RemoveAt(dataGridView2.RowCount - 2);
                dataGridView3.Rows.RemoveAt(dataGridView3.RowCount - 2);
            }
        }
            int j= 1;
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = 0;
            dataGridView4.Visible = true;
            dataGridView1.Visible = false;
            for (int i = 0; i < (dataGridView1.RowCount); i++)
            {
               
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView4.Visible = false;
            dataGridView4.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Текстовые файлы |*.txt",
                Title = "Сохранить"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFile.FileName,
                    FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8);
                for (int i = 0; i < (dataGridView1.RowCount - 1);i++ )
                    writer.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\\" + dataGridView1.Rows[i].Cells[1].Value.ToString()+"\\"+dataGridView1.Rows[i].Cells[2].Value.ToString() + "\\" +dataGridView1.Rows[i].Cells[3].Value.ToString() + "\\" +dataGridView1.Rows[i].Cells[4].Value.ToString() + "\\" +dataGridView1.Rows[i].Cells[5].Value.ToString() + "\\" +dataGridView1.Rows[i].Cells[6].Value.ToString() + "\\" +dataGridView1.Rows[i].Cells[7].Value.ToString() + "\\" +dataGridView1.Rows[i].Cells[8].Value.ToString() + "\\" +dataGridView1.Rows[i].Cells[9].Value.ToString() + "\\" +dataGridView1.Rows[i].Cells[10].Value.ToString()+"\\"+dataGridView2.Rows[i].Cells[0].Value.ToString() + "\\" +dataGridView2.Rows[i].Cells[1].Value.ToString() + "\\" +dataGridView2.Rows[i].Cells[2].Value.ToString() + "\\" +dataGridView2.Rows[i].Cells[3].Value.ToString() + "\\" +dataGridView2.Rows[i].Cells[4].Value.ToString() + "\\" +dataGridView2.Rows[i].Cells[5].Value.ToString() + "\\" +dataGridView2.Rows[i].Cells[6].Value.ToString() + "\\" +dataGridView2.Rows[i].Cells[7].Value.ToString() + "\\" +dataGridView2.Rows[i].Cells[8].Value.ToString() + "\\" +dataGridView2.Rows[i].Cells[9].Value.ToString() + "\\"+dataGridView3.Rows[i].Cells[0].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[1].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[2].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[3].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[4].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[5].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[6].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[7].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[8].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[9].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[10].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[11].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[12].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[13].Value.ToString() + "\\" +dataGridView3.Rows[i].Cells[14].Value.ToString());
                     writer.Dispose();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.Stream myStr = null;
            OpenFileDialog OpenTags = new OpenFileDialog();
            OpenTags.Filter = "All file (*.*) | *.*| Text file |*.txt";
            OpenTags.FilterIndex = 2;
            if (OpenTags.ShowDialog() == DialogResult.OK)
            {
                if ((myStr = OpenTags.OpenFile()) != null)
                {
                    StreamReader myRead = new StreamReader(myStr, System.Text.Encoding.Default);
                    string[] str;
                    int num = 0;
                    try
                    {

                        string[] str1 = myRead.ReadToEnd().Split('\n');
                        num = str1.Count()-1;
                        dataGridView1.RowCount = num ;
                        dataGridView2.RowCount = num ;
                        dataGridView3.RowCount = num ;
                        for (int i = 0; i < num; i++)
                        {
                            {
                                int j;
                                str = str1[i].Split('\\');
                                for ( j = 0; j < dataGridView1.ColumnCount; j++)
                                {
                                    try
                                    {
                                        dataGridView1.Rows[i].Cells[j].Value = str[j];
                                    }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                for (j = 0 + dataGridView1.ColumnCount; j < dataGridView2.ColumnCount + dataGridView1.ColumnCount; j++)
                                {
                                    try
                                    {
                                        dataGridView2.Rows[i].Cells[j - dataGridView1.ColumnCount].Value = str[j];
                                    }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                for (j = 0 + dataGridView2.ColumnCount + dataGridView1.ColumnCount; j < dataGridView3.ColumnCount + dataGridView2.ColumnCount + dataGridView1.ColumnCount; j++)
                                {
                                    try
                                    {
                                        dataGridView3.Rows[i].Cells[j - (dataGridView2.ColumnCount + dataGridView1.ColumnCount)].Value = str[j];
                                    }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
        }
    }
}