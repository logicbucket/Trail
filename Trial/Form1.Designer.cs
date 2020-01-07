namespace Trial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.CosButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SinButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.XButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.InsertedFunLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVariableValue = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.BackColor = System.Drawing.SystemColors.Info;
            this.DisplayBox.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBox.Location = new System.Drawing.Point(17, 153);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(426, 40);
            this.DisplayBox.TabIndex = 4;
            // 
            // CosButton
            // 
            this.CosButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CosButton.Location = new System.Drawing.Point(23, 419);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(95, 69);
            this.CosButton.TabIndex = 5;
            this.CosButton.Text = "Cos[]";
            this.CosButton.UseVisualStyleBackColor = false;
            this.CosButton.Click += new System.EventHandler(this.CosButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(23, 343);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(95, 69);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SinButton
            // 
            this.SinButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinButton.Location = new System.Drawing.Point(132, 419);
            this.SinButton.Name = "SinButton";
            this.SinButton.Size = new System.Drawing.Size(95, 70);
            this.SinButton.TabIndex = 7;
            this.SinButton.Text = "Sin[]";
            this.SinButton.UseVisualStyleBackColor = false;
            this.SinButton.Click += new System.EventHandler(this.SinButton_Click);
            // 
            // SubButton
            // 
            this.SubButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubButton.Location = new System.Drawing.Point(132, 343);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(95, 66);
            this.SubButton.TabIndex = 8;
            this.SubButton.Text = "-";
            this.SubButton.UseVisualStyleBackColor = false;
            this.SubButton.Click += new System.EventHandler(this.SubstractButton_Click);
            // 
            // XButton
            // 
            this.XButton.AccessibleDescription = "XButton";
            this.XButton.AccessibleName = "XButton";
            this.XButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.XButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XButton.Location = new System.Drawing.Point(245, 343);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(95, 69);
            this.XButton.TabIndex = 9;
            this.XButton.Text = "*";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(537, 332);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(127, 145);
            this.EnterButton.TabIndex = 13;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // InsertedFunLabel
            // 
            this.InsertedFunLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.InsertedFunLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertedFunLabel.Location = new System.Drawing.Point(17, 34);
            this.InsertedFunLabel.Name = "InsertedFunLabel";
            this.InsertedFunLabel.Size = new System.Drawing.Size(431, 41);
            this.InsertedFunLabel.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(458, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 40);
            this.label2.TabIndex = 16;
            // 
            // txtVariableValue
            // 
            this.txtVariableValue.BackColor = System.Drawing.SystemColors.Info;
            this.txtVariableValue.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariableValue.Location = new System.Drawing.Point(96, 214);
            this.txtVariableValue.Name = "txtVariableValue";
            this.txtVariableValue.Size = new System.Drawing.Size(118, 40);
            this.txtVariableValue.TabIndex = 18;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(465, 34);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(199, 41);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "x = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(694, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVariableValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertedFunLabel);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.XButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.SinButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CosButton);
            this.Controls.Add(this.DisplayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DisplayBox;
        private System.Windows.Forms.Button CosButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SinButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label InsertedFunLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVariableValue;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
    }
}

