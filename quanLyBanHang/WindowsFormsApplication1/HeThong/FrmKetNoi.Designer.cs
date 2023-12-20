namespace WindowsFormsApplication1.HeThong
{
    partial class FrmKetNoi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxServer = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxDBname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBoxUID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtBoxPWD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAuth = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 404);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBoxServer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 61);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxServer
            // 
            this.txtBoxServer.Location = new System.Drawing.Point(183, 24);
            this.txtBoxServer.Name = "txtBoxServer";
            this.txtBoxServer.Size = new System.Drawing.Size(294, 20);
            this.txtBoxServer.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBoxDBname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 61);
            this.panel3.TabIndex = 2;
            // 
            // txtBoxDBname
            // 
            this.txtBoxDBname.Location = new System.Drawing.Point(183, 24);
            this.txtBoxDBname.Name = "txtBoxDBname";
            this.txtBoxDBname.Size = new System.Drawing.Size(294, 20);
            this.txtBoxDBname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbAuth);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 61);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Authentication:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtBoxUID);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 204);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(535, 61);
            this.panel5.TabIndex = 3;
            // 
            // txtBoxUID
            // 
            this.txtBoxUID.Location = new System.Drawing.Point(183, 24);
            this.txtBoxUID.Name = "txtBoxUID";
            this.txtBoxUID.Size = new System.Drawing.Size(294, 20);
            this.txtBoxUID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "User ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtBoxPWD);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(3, 271);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(535, 61);
            this.panel6.TabIndex = 3;
            // 
            // txtBoxPWD
            // 
            this.txtBoxPWD.Location = new System.Drawing.Point(183, 24);
            this.txtBoxPWD.Name = "txtBoxPWD";
            this.txtBoxPWD.PasswordChar = ')';
            this.txtBoxPWD.Size = new System.Drawing.Size(294, 20);
            this.txtBoxPWD.TabIndex = 1;
            this.txtBoxPWD.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(109, 338);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(429, 59);
            this.panel7.TabIndex = 4;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Connect to Sql server";
            // 
            // cbAuth
            // 
            this.cbAuth.FormattingEnabled = true;
            this.cbAuth.ItemHeight = 13;
            this.cbAuth.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Authentication"});
            this.cbAuth.Location = new System.Drawing.Point(183, 24);
            this.cbAuth.Name = "cbAuth";
            this.cbAuth.Size = new System.Drawing.Size(294, 21);
            this.cbAuth.TabIndex = 1;
            // 
            // FrmKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 468);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKetNoi";
            this.Text = "FrmKetNoi";
            this.Load += new System.EventHandler(this.FrmKetNoi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtBoxPWD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBoxUID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBoxDBname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAuth;
    }
}