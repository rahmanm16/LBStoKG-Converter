namespace MetricConverter
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
            this.lbsInput = new System.Windows.Forms.NumericUpDown();
            this.convertKG = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lbsInput
            // 
            this.lbsInput.Location = new System.Drawing.Point(90, 153);
            this.lbsInput.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.lbsInput.Name = "lbsInput";
            this.lbsInput.Size = new System.Drawing.Size(165, 20);
            this.lbsInput.TabIndex = 0;
            // 
            // convertKG
            // 
            this.convertKG.Location = new System.Drawing.Point(344, 150);
            this.convertKG.Name = "convertKG";
            this.convertKG.Size = new System.Drawing.Size(191, 23);
            this.convertKG.TabIndex = 2;
            this.convertKG.Text = "Convert into KG";
            this.convertKG.UseVisualStyleBackColor = true;
            this.convertKG.Click += new System.EventHandler(this.convertKG_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Answer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "LBS:";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(136, 281);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(340, 20);
            this.resultBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 479);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.convertKG);
            this.Controls.Add(this.lbsInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lbsInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown lbsInput;
        private System.Windows.Forms.Button convertKG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultBox;
    }
}

