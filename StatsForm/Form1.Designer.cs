namespace StatsForm
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
            this.UserInput = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.InputDescription = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(27, 70);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(600, 20);
            this.UserInput.TabIndex = 0;
            this.UserInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.Location = new System.Drawing.Point(466, 135);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(161, 78);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputDescription
            // 
            this.InputDescription.AutoSize = true;
            this.InputDescription.Location = new System.Drawing.Point(24, 54);
            this.InputDescription.Name = "InputDescription";
            this.InputDescription.Size = new System.Drawing.Size(206, 13);
            this.InputDescription.TabIndex = 2;
            this.InputDescription.Text = "Enter values of list (Separated by a space)";
            this.InputDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(27, 229);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(655, 264);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.InputDescription);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.UserInput);
            this.Name = "Form1";
            this.Text = "Five Number Summary Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label InputDescription;
        private System.Windows.Forms.Button ExitButton;
    }
}

