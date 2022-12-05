namespace PANIFICADORA_CENTRAL_2
{
    partial class Login
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
            System.Windows.Forms.Button btnLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textUser = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.Transparent;
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogin.ForeColor = System.Drawing.Color.Transparent;
            btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnLogin.Location = new System.Drawing.Point(319, 278);
            btnLogin.Margin = new System.Windows.Forms.Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(48, 57);
            btnLogin.TabIndex = 62;
            btnLogin.TabStop = false;
            btnLogin.Text = "   ";
            btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUser.Location = new System.Drawing.Point(257, 185);
            this.textUser.Margin = new System.Windows.Forms.Padding(4);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(188, 29);
            this.textUser.TabIndex = 45;
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSenha.Location = new System.Drawing.Point(257, 231);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(188, 27);
            this.textSenha.TabIndex = 46;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = global::PANIFICADORA_CENTRAL_2.Properties.Resources.cancel;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(609, 13);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 39);
            this.btnFechar.TabIndex = 63;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(169, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(186, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Senha:";
            // 
            // Login
            // 
            this.AcceptButton = btnLogin;
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::PANIFICADORA_CENTRAL_2.Properties.Resources.blue_zoom_meeting_background_design_template_48741858a021be338214f56780c0283d_screen;
            this.ClientSize = new System.Drawing.Size(662, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(btnLogin);
            this.Controls.Add(this.textUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textUser;
        private TextBox textSenha;
        private Button btnLogin;
        private Button btnFechar;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}