namespace ServiceDesk
{
    partial class ULogin
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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.txtboxpassword = new System.Windows.Forms.TextBox();
            this.btnhelp = new System.Windows.Forms.RadioButton();
            this.btnadmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(26, 56);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(123, 20);
            this.Username.TabIndex = 0;
            this.Username.Text = "Nom d\'utilisateur";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(48, 101);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(98, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Mot de passe";
            // 
            // txtboxusername
            // 
            this.txtboxusername.Location = new System.Drawing.Point(169, 56);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(268, 23);
            this.txtboxusername.TabIndex = 2;
            // 
            // txtboxpassword
            // 
            this.txtboxpassword.Location = new System.Drawing.Point(169, 101);
            this.txtboxpassword.Name = "txtboxpassword";
            this.txtboxpassword.Size = new System.Drawing.Size(268, 23);
            this.txtboxpassword.TabIndex = 3;
            this.txtboxpassword.UseSystemPasswordChar = true;
            // 
            // btnhelp
            // 
            this.btnhelp.AutoSize = true;
            this.btnhelp.Location = new System.Drawing.Point(169, 145);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(97, 19);
            this.btnhelp.TabIndex = 4;
            this.btnhelp.TabStop = true;
            this.btnhelp.Text = "Bureau d\'aide";
            this.btnhelp.UseVisualStyleBackColor = true;
            // 
            // btnadmin
            // 
            this.btnadmin.AutoSize = true;
            this.btnadmin.Location = new System.Drawing.Point(283, 145);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(104, 19);
            this.btnadmin.TabIndex = 5;
            this.btnadmin.TabStop = true;
            this.btnadmin.Text = "Administration";
            this.btnadmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Votre rôle";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(169, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Connexion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(292, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ULogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(510, 229);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.txtboxpassword);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ULogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ULogin";
            this.Load += new System.EventHandler(this.ULogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox txtboxusername;
        private TextBox txtboxpassword;
        private RadioButton btnhelp;
        private RadioButton btnadmin;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}