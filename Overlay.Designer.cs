﻿namespace PUBGMobMacro
{
    partial class Overlay
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
            this.lblGun = new System.Windows.Forms.Label();
            this.lblisEnabled = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCrouch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.BackColor = System.Drawing.SystemColors.Control;
            this.lblGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGun.Location = new System.Drawing.Point(1306, 9);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(40, 24);
            this.lblGun.TabIndex = 0;
            this.lblGun.Text = "null";
            // 
            // lblisEnabled
            // 
            this.lblisEnabled.AutoSize = true;
            this.lblisEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.lblisEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisEnabled.Location = new System.Drawing.Point(1306, 47);
            this.lblisEnabled.Name = "lblisEnabled";
            this.lblisEnabled.Size = new System.Drawing.Size(83, 24);
            this.lblisEnabled.TabIndex = 1;
            this.lblisEnabled.Text = "Disabled";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currently selected:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1187, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crouching?:";
            // 
            // lblCrouch
            // 
            this.lblCrouch.AutoSize = true;
            this.lblCrouch.BackColor = System.Drawing.SystemColors.Control;
            this.lblCrouch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrouch.Location = new System.Drawing.Point(1306, 80);
            this.lblCrouch.Name = "lblCrouch";
            this.lblCrouch.Size = new System.Drawing.Size(40, 24);
            this.lblCrouch.TabIndex = 4;
            this.lblCrouch.Text = "null";
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblCrouch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblisEnabled);
            this.Controls.Add(this.lblGun);
            this.Name = "Overlay";
            this.Text = "Overlay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Overlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblisEnabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCrouch;
    }
}