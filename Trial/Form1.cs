using System;
using System.Collections.Generic;
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

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayBox.AppendText(XButton.Text);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = string.Empty;
            InsertedFunLabel.Text = string.Empty;
            label2.Text = string.Empty;
            txtVariableValue.Text = string.Empty;
        }


        private void EnterButton_Click(object sender, EventArgs e)
        {
           string input = string.IsNullOrEmpty( DisplayBox.Text) ? "" : DisplayBox.Text;
           string variableValue = string.IsNullOrEmpty(txtVariableValue.Text) ? "" : txtVariableValue.Text;

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
            List<EquationItem> equations = Reader.ReadEquationString(readyText, variableValue);


            //Step 3  ---/Show in UI-------------------------------------
            label2.Text = Evaluator.Evaluate(equations);
        }
    }
}
