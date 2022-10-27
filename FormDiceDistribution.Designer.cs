namespace DiceDistribution
{
    partial class FormDiceDistrubtion
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
            this.labelNumberOfDice = new System.Windows.Forms.Label();
            this.textBoxNumberOfDice = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfThrows = new System.Windows.Forms.TextBox();
            this.labelNumberOfThrows = new System.Windows.Forms.Label();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumberOfDice
            // 
            this.labelNumberOfDice.AutoSize = true;
            this.labelNumberOfDice.Location = new System.Drawing.Point(39, 82);
            this.labelNumberOfDice.Name = "labelNumberOfDice";
            this.labelNumberOfDice.Size = new System.Drawing.Size(160, 25);
            this.labelNumberOfDice.TabIndex = 0;
            this.labelNumberOfDice.Text = "Number of Dice";
            // 
            // textBoxNumberOfDice
            // 
            this.textBoxNumberOfDice.Location = new System.Drawing.Point(205, 79);
            this.textBoxNumberOfDice.Name = "textBoxNumberOfDice";
            this.textBoxNumberOfDice.Size = new System.Drawing.Size(142, 31);
            this.textBoxNumberOfDice.TabIndex = 1;
            // 
            // textBoxNumberOfThrows
            // 
            this.textBoxNumberOfThrows.Location = new System.Drawing.Point(205, 134);
            this.textBoxNumberOfThrows.Name = "textBoxNumberOfThrows";
            this.textBoxNumberOfThrows.Size = new System.Drawing.Size(142, 31);
            this.textBoxNumberOfThrows.TabIndex = 3;
            // 
            // labelNumberOfThrows
            // 
            this.labelNumberOfThrows.AutoSize = true;
            this.labelNumberOfThrows.Location = new System.Drawing.Point(12, 137);
            this.labelNumberOfThrows.Name = "labelNumberOfThrows";
            this.labelNumberOfThrows.Size = new System.Drawing.Size(187, 25);
            this.labelNumberOfThrows.TabIndex = 2;
            this.labelNumberOfThrows.Text = "Number of Throws";
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 25;
            this.listBoxResults.Location = new System.Drawing.Point(411, 79);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(422, 554);
            this.listBoxResults.TabIndex = 4;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(205, 192);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(142, 66);
            this.buttonExecute.TabIndex = 5;
            this.buttonExecute.Text = "Go";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // FormDiceDistrubtion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 706);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.textBoxNumberOfThrows);
            this.Controls.Add(this.labelNumberOfThrows);
            this.Controls.Add(this.textBoxNumberOfDice);
            this.Controls.Add(this.labelNumberOfDice);
            this.Name = "FormDiceDistrubtion";
            this.Text = "Dice Distribution";
            this.Load += new System.EventHandler(this.FormDiceDistrubtion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfDice;
        private System.Windows.Forms.TextBox textBoxNumberOfDice;
        private System.Windows.Forms.TextBox textBoxNumberOfThrows;
        private System.Windows.Forms.Label labelNumberOfThrows;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Button buttonExecute;
    }
}

