
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbBoxWeapons = new System.Windows.Forms.ComboBox();
            this.cbBoxBiteAway = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUseBiteAway = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.rtBoxLocation = new System.Windows.Forms.RichTextBox();
            this.rtBoxMessages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvMissions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissions)).BeginInit();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select action";
            // 
            // cbBoxWeapons
            // 
            this.cbBoxWeapons.FormattingEnabled = true;
            this.cbBoxWeapons.Location = new System.Drawing.Point(369, 559);
            this.cbBoxWeapons.Name = "cbBoxWeapons";
            this.cbBoxWeapons.Size = new System.Drawing.Size(85, 23);
            this.cbBoxWeapons.TabIndex = 9;
            // 
            // cbBoxBiteAway
            // 
            this.cbBoxBiteAway.FormattingEnabled = true;
            this.cbBoxBiteAway.Location = new System.Drawing.Point(369, 593);
            this.cbBoxBiteAway.Name = "cbBoxBiteAway";
            this.cbBoxBiteAway.Size = new System.Drawing.Size(85, 23);
            this.cbBoxBiteAway.TabIndex = 10;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(620, 559);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(87, 23);
            this.btnUseWeapon.TabIndex = 11;
            this.btnUseWeapon.Text = "Attack";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUseBiteAway
            // 
            this.btnUseBiteAway.Location = new System.Drawing.Point(620, 593);
            this.btnUseBiteAway.Name = "btnUseBiteAway";
            this.btnUseBiteAway.Size = new System.Drawing.Size(87, 23);
            this.btnUseBiteAway.TabIndex = 12;
            this.btnUseBiteAway.Text = "Heal";
            this.btnUseBiteAway.UseVisualStyleBackColor = true;
            this.btnUseBiteAway.Click += new System.EventHandler(this.btnUseBiteAway_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(493, 433);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(87, 23);
            this.btnNorth.TabIndex = 13;
            this.btnNorth.Text = "Move North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(573, 457);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(87, 23);
            this.btnEast.TabIndex = 14;
            this.btnEast.Text = "Move East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(493, 487);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(87, 23);
            this.btnSouth.TabIndex = 15;
            this.btnSouth.Text = "Move South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(412, 457);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(87, 23);
            this.btnWest.TabIndex = 16;
            this.btnWest.Text = "Move West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // rtBoxLocation
            // 
            this.rtBoxLocation.Location = new System.Drawing.Point(347, 19);
            this.rtBoxLocation.Name = "rtBoxLocation";
            this.rtBoxLocation.Size = new System.Drawing.Size(360, 105);
            this.rtBoxLocation.TabIndex = 17;
            this.rtBoxLocation.Text = "";
            // 
            // rtBoxMessages
            // 
            this.rtBoxMessages.Location = new System.Drawing.Point(347, 130);
            this.rtBoxMessages.Name = "rtBoxMessages";
            this.rtBoxMessages.Size = new System.Drawing.Size(360, 286);
            this.rtBoxMessages.TabIndex = 18;
            this.rtBoxMessages.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(16, 130);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowTemplate.Height = 25;
            this.dgvInventory.Size = new System.Drawing.Size(312, 309);
            this.dgvInventory.TabIndex = 19;
            // 
            // dgvMissions
            // 
            this.dgvMissions.AllowUserToAddRows = false;
            this.dgvMissions.AllowUserToDeleteRows = false;
            this.dgvMissions.AllowUserToResizeRows = false;
            this.dgvMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMissions.Enabled = false;
            this.dgvMissions.Location = new System.Drawing.Point(16, 446);
            this.dgvMissions.MultiSelect = false;
            this.dgvMissions.Name = "dgvMissions";
            this.dgvMissions.ReadOnly = true;
            this.dgvMissions.RowHeadersVisible = false;
            this.dgvMissions.RowTemplate.Height = 25;
            this.dgvMissions.Size = new System.Drawing.Size(312, 189);
            this.dgvMissions.TabIndex = 20;
            // 
            // HumansNZombies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.dgvMissions);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtBoxMessages);
            this.Controls.Add(this.rtBoxLocation);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUseBiteAway);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cbBoxBiteAway);
            this.Controls.Add(this.cbBoxWeapons);
            this.Controls.Add(this.label5);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissions)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBoxWeapons;
        private System.Windows.Forms.ComboBox cbBoxBiteAway;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUseBiteAway;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.RichTextBox rtBoxLocation;
        private System.Windows.Forms.RichTextBox rtBoxMessages;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvMissions;
    }
}

