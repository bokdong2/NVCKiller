namespace CSUACSelfElevation
{
    partial class MainForm
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
            this.btnElevate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInAdminGroup = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIsRunAsAdmin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIsElevated = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbIntegrityLevel = new System.Windows.Forms.Label();
            this.btnKill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElevate
            // 
            this.btnElevate.Location = new System.Drawing.Point(19, 108);
            this.btnElevate.Name = "btnElevate";
            this.btnElevate.Size = new System.Drawing.Size(211, 24);
            this.btnElevate.TabIndex = 0;
            this.btnElevate.Text = "Bypass Protection";
            this.btnElevate.UseVisualStyleBackColor = true;
            this.btnElevate.Click += new System.EventHandler(this.btnElevate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IsUserInAdminGroup:";
            // 
            // lbInAdminGroup
            // 
            this.lbInAdminGroup.AutoSize = true;
            this.lbInAdminGroup.Location = new System.Drawing.Point(163, 12);
            this.lbInAdminGroup.Name = "lbInAdminGroup";
            this.lbInAdminGroup.Size = new System.Drawing.Size(0, 12);
            this.lbInAdminGroup.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "IsRunAsAdmin:";
            // 
            // lbIsRunAsAdmin
            // 
            this.lbIsRunAsAdmin.AutoSize = true;
            this.lbIsRunAsAdmin.Location = new System.Drawing.Point(163, 35);
            this.lbIsRunAsAdmin.Name = "lbIsRunAsAdmin";
            this.lbIsRunAsAdmin.Size = new System.Drawing.Size(0, 12);
            this.lbIsRunAsAdmin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "IsProcessElevated:";
            // 
            // lbIsElevated
            // 
            this.lbIsElevated.AutoSize = true;
            this.lbIsElevated.Location = new System.Drawing.Point(163, 58);
            this.lbIsElevated.Name = "lbIsElevated";
            this.lbIsElevated.Size = new System.Drawing.Size(0, 12);
            this.lbIsElevated.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Integrity Level:";
            // 
            // lbIntegrityLevel
            // 
            this.lbIntegrityLevel.AutoSize = true;
            this.lbIntegrityLevel.Location = new System.Drawing.Point(163, 81);
            this.lbIntegrityLevel.Name = "lbIntegrityLevel";
            this.lbIntegrityLevel.Size = new System.Drawing.Size(0, 12);
            this.lbIntegrityLevel.TabIndex = 8;
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(19, 138);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(211, 27);
            this.btnKill.TabIndex = 9;
            this.btnKill.Text = "Kill";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 174);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.lbIntegrityLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbIsElevated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbIsRunAsAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInAdminGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnElevate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NVCKiller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElevate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInAdminGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIsRunAsAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIsElevated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbIntegrityLevel;
        private System.Windows.Forms.Button btnKill;
    }
}

