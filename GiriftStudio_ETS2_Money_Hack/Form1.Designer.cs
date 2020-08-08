namespace GiriftStudio_ETS2_Money_Hack
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentMoneyText = new System.Windows.Forms.Label();
            this.RunProgram = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.addMoney = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moneyGroupBox = new System.Windows.Forms.GroupBox();
            this.moneyAddCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.moneyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waiting..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Money :";
            // 
            // CurrentMoneyText
            // 
            this.CurrentMoneyText.AutoSize = true;
            this.CurrentMoneyText.Location = new System.Drawing.Point(83, 39);
            this.CurrentMoneyText.Name = "CurrentMoneyText";
            this.CurrentMoneyText.Size = new System.Drawing.Size(0, 13);
            this.CurrentMoneyText.TabIndex = 3;
            // 
            // RunProgram
            // 
            this.RunProgram.Location = new System.Drawing.Point(52, 68);
            this.RunProgram.Name = "RunProgram";
            this.RunProgram.Size = new System.Drawing.Size(88, 23);
            this.RunProgram.TabIndex = 4;
            this.RunProgram.Text = "Control Game";
            this.RunProgram.UseVisualStyleBackColor = true;
            this.RunProgram.Click += new System.EventHandler(this.RunProgramButton_Click);
            // 
            // addMoney
            // 
            this.addMoney.Location = new System.Drawing.Point(116, 70);
            this.addMoney.Name = "addMoney";
            this.addMoney.Size = new System.Drawing.Size(75, 23);
            this.addMoney.TabIndex = 5;
            this.addMoney.Text = "Add Money";
            this.addMoney.UseVisualStyleBackColor = true;
            this.addMoney.Click += new System.EventHandler(this.AddMoneyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RunProgram);
            this.groupBox1.Location = new System.Drawing.Point(51, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // moneyGroupBox
            // 
            this.moneyGroupBox.Controls.Add(this.moneyAddCount);
            this.moneyGroupBox.Controls.Add(this.addMoney);
            this.moneyGroupBox.Controls.Add(this.CurrentMoneyText);
            this.moneyGroupBox.Controls.Add(this.label3);
            this.moneyGroupBox.Location = new System.Drawing.Point(51, 150);
            this.moneyGroupBox.Name = "moneyGroupBox";
            this.moneyGroupBox.Size = new System.Drawing.Size(200, 116);
            this.moneyGroupBox.TabIndex = 7;
            this.moneyGroupBox.TabStop = false;
            this.moneyGroupBox.Text = "Money";
            // 
            // moneyAddCount
            // 
            this.moneyAddCount.Location = new System.Drawing.Point(6, 72);
            this.moneyAddCount.Name = "moneyAddCount";
            this.moneyAddCount.Size = new System.Drawing.Size(104, 20);
            this.moneyAddCount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "v1.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "www.giriftstudio.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 308);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moneyGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ETS 2 Money Hack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.moneyGroupBox.ResumeLayout(false);
            this.moneyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentMoneyText;
        private System.Windows.Forms.Button RunProgram;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button addMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox moneyGroupBox;
        private System.Windows.Forms.TextBox moneyAddCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

