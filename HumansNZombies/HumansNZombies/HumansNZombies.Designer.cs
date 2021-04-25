
namespace HumansNZombies
{
    partial class HumansNZombies
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblGldCount = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblLvl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Location = new System.Drawing.Point(110, 19);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(0, 15);
            this.lblHp.TabIndex = 4;
            // 
            // lblGldCount
            // 
            this.lblGldCount.AutoSize = true;
            this.lblGldCount.Location = new System.Drawing.Point(110, 45);
            this.lblGldCount.Name = "lblGldCount";
            this.lblGldCount.Size = new System.Drawing.Size(0, 15);
            this.lblGldCount.TabIndex = 5;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(110, 73);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(0, 15);
            this.lblExp.TabIndex = 6;
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Location = new System.Drawing.Point(110, 99);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(0, 15);
            this.lblLvl.TabIndex = 7;
            // 
            // HumansNZombies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.lblLvl);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblGldCount);
            this.Controls.Add(this.lblHp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HumansNZombies";
            this.Text = "My Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblGldCount;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblLvl;
    }
}

