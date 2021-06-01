
namespace MyBankApp.UI
{
    partial class MainForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.headerControl1 = new MyBankApp.UI.Controls.HeaderControl();
            this.pnlMainArea = new System.Windows.Forms.Panel();
            this.lnklblNewUser = new System.Windows.Forms.LinkLabel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMainArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.headerControl1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 97);
            this.pnlHeader.TabIndex = 0;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(760, 97);
            this.headerControl1.TabIndex = 0;
            // 
            // pnlMainArea
            // 
            this.pnlMainArea.BackColor = System.Drawing.Color.Navy;
            this.pnlMainArea.Controls.Add(this.lnklblNewUser);
            this.pnlMainArea.Controls.Add(this.lblPassword);
            this.pnlMainArea.Controls.Add(this.lblUserName);
            this.pnlMainArea.Controls.Add(this.txtBoxPassword);
            this.pnlMainArea.Controls.Add(this.txtBoxUserName);
            this.pnlMainArea.Controls.Add(this.btnLogIn);
            this.pnlMainArea.Controls.Add(this.lblRegister);
            this.pnlMainArea.Controls.Add(this.lblWelcome);
            this.pnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainArea.Location = new System.Drawing.Point(0, 97);
            this.pnlMainArea.Name = "pnlMainArea";
            this.pnlMainArea.Size = new System.Drawing.Size(760, 353);
            this.pnlMainArea.TabIndex = 1;
            this.pnlMainArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainArea_Paint);
            // 
            // lnklblNewUser
            // 
            this.lnklblNewUser.AutoSize = true;
            this.lnklblNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lnklblNewUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnklblNewUser.Location = new System.Drawing.Point(550, 289);
            this.lnklblNewUser.Name = "lnklblNewUser";
            this.lnklblNewUser.Size = new System.Drawing.Size(75, 25);
            this.lnklblNewUser.TabIndex = 9;
            this.lnklblNewUser.TabStop = true;
            this.lnklblNewUser.Text = "Sign Up";
            this.lnklblNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblNewUser_LinkClicked);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(367, 128);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 25);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(367, 50);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 25);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "User Name";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPassword.Location = new System.Drawing.Point(516, 116);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(150, 42);
            this.txtBoxPassword.TabIndex = 6;
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUserName.Location = new System.Drawing.Point(514, 38);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(152, 42);
            this.txtBoxUserName.TabIndex = 5;
            this.txtBoxUserName.TextChanged += new System.EventHandler(this.txtBoxUserName_TextChanged);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogIn.Location = new System.Drawing.Point(533, 186);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(112, 34);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "LOGIN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegister.Location = new System.Drawing.Point(533, 253);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(95, 25);
            this.lblRegister.TabIndex = 2;
            this.lblRegister.Text = "New User?";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(107, 89);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(155, 33);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.pnlMainArea);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlHeader.ResumeLayout(false);
            this.pnlMainArea.ResumeLayout(false);
            this.pnlMainArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMainArea;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.LinkLabel lnklblNewUser;
        private Controls.HeaderControl headerControl1;
    }
}

