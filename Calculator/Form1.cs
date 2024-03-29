﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// constructor of form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// button event for add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                labelOutput.Text = (Convert.ToDouble(textBoxA.Text) + Convert.ToDouble(textBoxB.Text)).ToString();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        /// <summary>
        /// button click event for divide button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                labelOutput.Text = (Convert.ToDouble(textBoxA.Text) / Convert.ToDouble(textBoxB.Text)).ToString();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        /// <summary>
        /// button click event for subtraction button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                labelOutput.Text = (Convert.ToDouble(textBoxA.Text) - Convert.ToDouble(textBoxB.Text)).ToString();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }



        /// <summary>
        /// button click event for modulus button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                labelOutput.Text = (Convert.ToDouble(textBoxA.Text) % Convert.ToDouble(textBoxB.Text)).ToString();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        /// <summary>
        /// button click event for power/exponent button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                labelOutput.Text = (Math.Pow(Convert.ToDouble(textBoxA.Text),Convert.ToDouble(textBoxB.Text))).ToString();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        /// <summary>
        /// button click event for multiply button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                labelOutput.Text = (Convert.ToDouble(textBoxA.Text) * Convert.ToDouble(textBoxB.Text)).ToString();

            }catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        /// <summary>
        /// button event for clear button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            labelOutput.Text = "0";
        }


   

        /// <summary>
        /// button event for close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }



        /// <summary>
        /// Keydown event for shortcut of buttons using keyboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                try
                {
                    labelOutput.Text = (Convert.ToDouble(textBoxA.Text) + Convert.ToDouble(textBoxB.Text)).ToString();

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }

            if (e.KeyCode == Keys.Multiply)
            {
                try
                {
                    labelOutput.Text = (Convert.ToDouble(textBoxA.Text) * Convert.ToDouble(textBoxB.Text)).ToString();

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }

            if (e.KeyCode == Keys.Subtract)
            {
                try
                {
                    labelOutput.Text = (Convert.ToDouble(textBoxA.Text) - Convert.ToDouble(textBoxB.Text)).ToString();

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }

            if (e.Shift==true && e.KeyCode == Keys.D6)
            {
                try
                {
                    labelOutput.Text = (Math.Pow(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text))).ToString();

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }

            if (e.Shift == true && e.KeyCode == Keys.D5)
            {
                try
                {
                    labelOutput.Text = (Convert.ToDouble(textBoxA.Text)%Convert.ToDouble(textBoxB.Text)).ToString();

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }

            if(e.KeyCode == Keys.Divide)
            {
                try
                {
                    labelOutput.Text = (Convert.ToDouble(textBoxA.Text)/Convert.ToDouble(textBoxB.Text)).ToString();

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }

        }
    }
}
