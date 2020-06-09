namespace PUBGMobMacro
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblScope1 = new System.Windows.Forms.Label();
            this.lblScope2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxGun1 = new System.Windows.Forms.ComboBox();
            this.comboBoxGun2 = new System.Windows.Forms.ComboBox();
            this.cbxComp1 = new System.Windows.Forms.CheckBox();
            this.cbxComp2 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCurrentGun = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gun 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gun 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Scope:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Scope:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "F7: On, F8: OFF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "1 and 2 to switch guns";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numpad to switch scopes of selected guns";
            // 
            // lblScope1
            // 
            this.lblScope1.AutoSize = true;
            this.lblScope1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScope1.Location = new System.Drawing.Point(364, 66);
            this.lblScope1.Name = "lblScope1";
            this.lblScope1.Size = new System.Drawing.Size(40, 24);
            this.lblScope1.TabIndex = 9;
            this.lblScope1.Text = "null";
            // 
            // lblScope2
            // 
            this.lblScope2.AutoSize = true;
            this.lblScope2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScope2.Location = new System.Drawing.Point(364, 116);
            this.lblScope2.Name = "lblScope2";
            this.lblScope2.Size = new System.Drawing.Size(40, 24);
            this.lblScope2.TabIndex = 10;
            this.lblScope2.Text = "null";
            // 
            // comboBoxGun1
            // 
            this.comboBoxGun1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGun1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGun1.FormattingEnabled = true;
            this.comboBoxGun1.Items.AddRange(new object[] {
            "AKM",
            "SCAR",
            "M416",
            "M762",
            "QBZ",
            "SKS",
            "MINI"});
            this.comboBoxGun1.Location = new System.Drawing.Point(129, 63);
            this.comboBoxGun1.Name = "comboBoxGun1";
            this.comboBoxGun1.Size = new System.Drawing.Size(153, 32);
            this.comboBoxGun1.TabIndex = 11;
            this.comboBoxGun1.SelectedIndexChanged += new System.EventHandler(this.comboBoxGun1_SelectedIndexChanged);
            // 
            // comboBoxGun2
            // 
            this.comboBoxGun2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGun2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGun2.FormattingEnabled = true;
            this.comboBoxGun2.Items.AddRange(new object[] {
            "AKM",
            "SCAR",
            "M416",
            "M762",
            "QBZ",
            "SKS",
            "MINI"});
            this.comboBoxGun2.Location = new System.Drawing.Point(129, 108);
            this.comboBoxGun2.Name = "comboBoxGun2";
            this.comboBoxGun2.Size = new System.Drawing.Size(153, 32);
            this.comboBoxGun2.TabIndex = 12;
            this.comboBoxGun2.SelectedIndexChanged += new System.EventHandler(this.comboBoxGun2_SelectedIndexChanged);
            // 
            // cbxComp1
            // 
            this.cbxComp1.AutoSize = true;
            this.cbxComp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxComp1.Location = new System.Drawing.Point(400, 66);
            this.cbxComp1.Name = "cbxComp1";
            this.cbxComp1.Size = new System.Drawing.Size(233, 28);
            this.cbxComp1.TabIndex = 13;
            this.cbxComp1.Text = "Compensator/Vert hold?";
            this.cbxComp1.UseVisualStyleBackColor = true;
            this.cbxComp1.CheckedChanged += new System.EventHandler(this.cbxComp1_CheckedChanged);
            // 
            // cbxComp2
            // 
            this.cbxComp2.AutoSize = true;
            this.cbxComp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxComp2.Location = new System.Drawing.Point(400, 115);
            this.cbxComp2.Name = "cbxComp2";
            this.cbxComp2.Size = new System.Drawing.Size(233, 28);
            this.cbxComp2.TabIndex = 14;
            this.cbxComp2.Text = "Compensator/Vert hold?";
            this.cbxComp2.UseVisualStyleBackColor = true;
            this.cbxComp2.CheckedChanged += new System.EventHandler(this.cbxComp2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(275, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Current gun selected: ";
            // 
            // lblCurrentGun
            // 
            this.lblCurrentGun.AutoSize = true;
            this.lblCurrentGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentGun.Location = new System.Drawing.Point(462, 9);
            this.lblCurrentGun.Name = "lblCurrentGun";
            this.lblCurrentGun.Size = new System.Drawing.Size(40, 24);
            this.lblCurrentGun.TabIndex = 16;
            this.lblCurrentGun.Text = "null";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Extra:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCurrentGun);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxComp2);
            this.Controls.Add(this.cbxComp1);
            this.Controls.Add(this.comboBoxGun2);
            this.Controls.Add(this.comboBoxGun1);
            this.Controls.Add(this.lblScope2);
            this.Controls.Add(this.lblScope1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblScope1;
        private System.Windows.Forms.Label lblScope2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxGun1;
        private System.Windows.Forms.ComboBox comboBoxGun2;
        private System.Windows.Forms.CheckBox cbxComp1;
        private System.Windows.Forms.CheckBox cbxComp2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurrentGun;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}

