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
           string equationText = string.IsNullOrEmpty( DisplayBox.Text) ? "" : DisplayBox.Text;
           string variableValue = string.IsNullOrEmpty(txtVariableValue.Text) ? "" : txtVariableValue.Text;

            label2.Text = ""; // Clear Answer display when Clicking 'Enter'

            /*Step 1 --------------------------------------------------------------
            / alidate Input Values */
            string equationError = Validator.ValidateEquation(equationText);
            string variableValueError = Validator.ValidateVariableValue(variableValue);

            if (!string.IsNullOrEmpty(equationError))
            {
                label2.Text = equationError;
                return;
            }

            if (!string.IsNullOrEmpty(variableValueError))
            {
                label2.Text = variableValueError;
                return;
            }

            string readyText = equationText.ToLower().Replace(" ", "");
            InsertedFunLabel.Text = readyText;

            /* Step 2  ------------------------------------------------------------
               Get the x value from User Interface, set to 2 for now */
            List<EquationItem> equations = Reader.ReadEquationString(readyText, variableValue);


            /* Step 3  ------------------------------------------------------------
               Show Result in UI */
            label2.Text = Evaluator.Evaluate(equations);
        }
    }
}
