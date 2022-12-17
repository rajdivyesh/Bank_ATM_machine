namespace prjWinCsFinalExam
{
    partial class frmGuichetBancaire
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClient = new System.Windows.Forms.Button();
            this.txtClientNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPin = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnConsult = new System.Windows.Forms.RadioButton();
            this.rbtnDeposit = new System.Windows.Forms.RadioButton();
            this.rbtnWithdraw = new System.Windows.Forms.RadioButton();
            this.lblDepDollar = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.btnTypes = new System.Windows.Forms.Button();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.lblWitDollar = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblAccountDetails = new System.Windows.Forms.Label();
            this.rbtnFinish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANK OF MONTREAL";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnClient);
            this.groupBox1.Controls.Add(this.txtClientNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Identification";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(362, 80);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(137, 32);
            this.btnClient.TabIndex = 3;
            this.btnClient.Text = "Next >>";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // txtClientNum
            // 
            this.txtClientNum.ForeColor = System.Drawing.Color.Blue;
            this.txtClientNum.Location = new System.Drawing.Point(226, 43);
            this.txtClientNum.Multiline = true;
            this.txtClientNum.Name = "txtClientNum";
            this.txtClientNum.Size = new System.Drawing.Size(273, 31);
            this.txtClientNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your number : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.btnPin);
            this.groupBox2.Controls.Add(this.txtPin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pin Verification";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(29, 23);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(241, 34);
            this.lblName.TabIndex = 5;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPin
            // 
            this.btnPin.Location = new System.Drawing.Point(362, 97);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(137, 32);
            this.btnPin.TabIndex = 3;
            this.btnPin.Text = "Next >>";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // txtPin
            // 
            this.txtPin.ForeColor = System.Drawing.Color.Blue;
            this.txtPin.Location = new System.Drawing.Point(226, 60);
            this.txtPin.Multiline = true;
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(273, 31);
            this.txtPin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter your pin : ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.rbtnConsult);
            this.groupBox3.Controls.Add(this.rbtnDeposit);
            this.groupBox3.Controls.Add(this.rbtnWithdraw);
            this.groupBox3.Controls.Add(this.lblDepDollar);
            this.groupBox3.Controls.Add(this.txtDeposit);
            this.groupBox3.Controls.Add(this.btnTypes);
            this.groupBox3.Controls.Add(this.txtWithdraw);
            this.groupBox3.Controls.Add(this.lblWitDollar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(29, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 159);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Types of Transactions";
            // 
            // rbtnConsult
            // 
            this.rbtnConsult.AutoSize = true;
            this.rbtnConsult.Location = new System.Drawing.Point(44, 100);
            this.rbtnConsult.Name = "rbtnConsult";
            this.rbtnConsult.Size = new System.Drawing.Size(94, 24);
            this.rbtnConsult.TabIndex = 8;
            this.rbtnConsult.TabStop = true;
            this.rbtnConsult.Text = "Consult";
            this.rbtnConsult.UseVisualStyleBackColor = true;
            // 
            // rbtnDeposit
            // 
            this.rbtnDeposit.AutoSize = true;
            this.rbtnDeposit.Location = new System.Drawing.Point(44, 70);
            this.rbtnDeposit.Name = "rbtnDeposit";
            this.rbtnDeposit.Size = new System.Drawing.Size(95, 24);
            this.rbtnDeposit.TabIndex = 7;
            this.rbtnDeposit.TabStop = true;
            this.rbtnDeposit.Text = "Deposit";
            this.rbtnDeposit.UseVisualStyleBackColor = true;
            this.rbtnDeposit.CheckedChanged += new System.EventHandler(this.rbtnDeposit_CheckedChanged);
            // 
            // rbtnWithdraw
            // 
            this.rbtnWithdraw.AutoSize = true;
            this.rbtnWithdraw.Location = new System.Drawing.Point(44, 40);
            this.rbtnWithdraw.Name = "rbtnWithdraw";
            this.rbtnWithdraw.Size = new System.Drawing.Size(108, 24);
            this.rbtnWithdraw.TabIndex = 6;
            this.rbtnWithdraw.TabStop = true;
            this.rbtnWithdraw.Text = "Withdraw";
            this.rbtnWithdraw.UseVisualStyleBackColor = true;
            this.rbtnWithdraw.CheckedChanged += new System.EventHandler(this.rbtnWithdraw_CheckedChanged);
            // 
            // lblDepDollar
            // 
            this.lblDepDollar.AutoSize = true;
            this.lblDepDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepDollar.Location = new System.Drawing.Point(366, 77);
            this.lblDepDollar.Name = "lblDepDollar";
            this.lblDepDollar.Size = new System.Drawing.Size(21, 22);
            this.lblDepDollar.TabIndex = 5;
            this.lblDepDollar.Text = "$";
            // 
            // txtDeposit
            // 
            this.txtDeposit.ForeColor = System.Drawing.Color.Blue;
            this.txtDeposit.Location = new System.Drawing.Point(226, 76);
            this.txtDeposit.Multiline = true;
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(134, 31);
            this.txtDeposit.TabIndex = 4;
            // 
            // btnTypes
            // 
            this.btnTypes.Location = new System.Drawing.Point(362, 115);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(137, 32);
            this.btnTypes.TabIndex = 3;
            this.btnTypes.Text = "Next >>";
            this.btnTypes.UseVisualStyleBackColor = true;
            this.btnTypes.Click += new System.EventHandler(this.btnTypes_Click);
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.ForeColor = System.Drawing.Color.Blue;
            this.txtWithdraw.Location = new System.Drawing.Point(226, 39);
            this.txtWithdraw.Multiline = true;
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(134, 31);
            this.txtWithdraw.TabIndex = 2;
            // 
            // lblWitDollar
            // 
            this.lblWitDollar.AutoSize = true;
            this.lblWitDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWitDollar.Location = new System.Drawing.Point(366, 40);
            this.lblWitDollar.Name = "lblWitDollar";
            this.lblWitDollar.Size = new System.Drawing.Size(21, 22);
            this.lblWitDollar.TabIndex = 1;
            this.lblWitDollar.Text = "$";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.lblAccountDetails);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(29, 546);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(531, 154);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Client Identification";
            // 
            // lblAccountDetails
            // 
            this.lblAccountDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountDetails.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountDetails.ForeColor = System.Drawing.Color.Blue;
            this.lblAccountDetails.Location = new System.Drawing.Point(44, 23);
            this.lblAccountDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountDetails.Name = "lblAccountDetails";
            this.lblAccountDetails.Size = new System.Drawing.Size(455, 117);
            this.lblAccountDetails.TabIndex = 6;
            // 
            // rbtnFinish
            // 
            this.rbtnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFinish.Location = new System.Drawing.Point(208, 708);
            this.rbtnFinish.Name = "rbtnFinish";
            this.rbtnFinish.Size = new System.Drawing.Size(168, 32);
            this.rbtnFinish.TabIndex = 3;
            this.rbtnFinish.Text = "^^Terminer^^";
            this.rbtnFinish.UseVisualStyleBackColor = true;
            this.rbtnFinish.Click += new System.EventHandler(this.rbtnFinish_Click);
            // 
            // frmGuichetBancaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 747);
            this.Controls.Add(this.rbtnFinish);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmGuichetBancaire";
            this.Text = "frmGuichetBancaire";
            this.Load += new System.EventHandler(this.frmGuichetBancaire_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClientNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnConsult;
        private System.Windows.Forms.RadioButton rbtnDeposit;
        private System.Windows.Forms.RadioButton rbtnWithdraw;
        private System.Windows.Forms.Label lblDepDollar;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Button btnTypes;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Label lblWitDollar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblAccountDetails;
        private System.Windows.Forms.Button rbtnFinish;
    }
}