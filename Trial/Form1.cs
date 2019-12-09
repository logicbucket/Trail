﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Trial
{
    public partial class Form1 : Form 
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CosButton_Click(object sender, EventArgs e)
        {

            DisplayBox.AppendText(CosButton.Text);
           // DisplayBox.Text
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            DisplayBox.AppendText(SinButton.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DisplayBox.AppendText (AddButton.Text);
        }

        private void SubstractButton_Click(object sender, EventArgs e)
        {
            DisplayBox.AppendText (SubButton.Text);
        }

        private void LeftParenthesisButton_Click(object sender, EventArgs e)
        {
            DisplayBox.AppendText(LeftParenthesisButton.Text);
        }

        private void RightParenthesisButton_Click(object sender, EventArgs e)
        {
            DisplayBox.AppendText(RightParenthesisButton.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayBox.AppendText(XButton.Text);
        }

        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            try {
                DisplayBox.Text = DisplayBox.Text.Substring(0, DisplayBox.Text.Length - 1);
            }
            catch 
            {
                
            }
        }

        public void Function(Double X)
        {
             
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
           string input = string.IsNullOrEmpty( DisplayBox.Text) ? "" : DisplayBox.Text;

            label2.Text = ""; //reset display on Clicking 'Enter' 

            //Step 1 ---------------------------------------------------            
            string error = Validator.Validate(input); 
            if(!string.IsNullOrEmpty(error))
            {
                label2.Text = error;
                return;
            }

            string readyText = input.ToLower().Replace(" ", "");
            InsertedFunLabel.Text = readyText;

            //Step 2  ---------------------------------------------------
            // Get the x value from User Interface, set to 2 for now
            List<EquationItem> equations = Reader.ReadEquationString(readyText, "2"); 


            //Step 3  ---/Show in UI-------------------------------------           
            label2.Text = Evaluator.Evaluate(equations);
        }
    }
}
