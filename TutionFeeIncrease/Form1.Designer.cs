namespace TutionFeeIncrease
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
            this.btnCalTutFee = new System.Windows.Forms.Button();
            this.lstBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalTutFee
            // 
            this.btnCalTutFee.Location = new System.Drawing.Point(260, 33);
            this.btnCalTutFee.Name = "btnCalTutFee";
            this.btnCalTutFee.Size = new System.Drawing.Size(161, 74);
            this.btnCalTutFee.TabIndex = 0;
            this.btnCalTutFee.Text = "Tution For Next Five Years";
            this.btnCalTutFee.UseVisualStyleBackColor = true;
            this.btnCalTutFee.Click += new System.EventHandler(this.btnCalTutFee_Click);
            // 
            // lstBoxOutput
            // 
            this.lstBoxOutput.FormattingEnabled = true;
            this.lstBoxOutput.ItemHeight = 16;
            this.lstBoxOutput.Location = new System.Drawing.Point(216, 137);
            this.lstBoxOutput.Name = "lstBoxOutput";
            this.lstBoxOutput.Size = new System.Drawing.Size(384, 228);
            this.lstBoxOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxOutput);
            this.Controls.Add(this.btnCalTutFee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalTutFee;
        private System.Windows.Forms.ListBox lstBoxOutput;
    }
}

