namespace projectbounce.Forms
{
    partial class LoginForm
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxViewPass = new System.Windows.Forms.CheckBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonRegIn = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.groupBoxLogIn = new System.Windows.Forms.GroupBox();
            this.groupBoxLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(6, 52);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(154, 30);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 111);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(154, 30);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxViewPass
            // 
            this.checkBoxViewPass.AutoSize = true;
            this.checkBoxViewPass.Location = new System.Drawing.Point(6, 147);
            this.checkBoxViewPass.Name = "checkBoxViewPass";
            this.checkBoxViewPass.Size = new System.Drawing.Size(154, 27);
            this.checkBoxViewPass.TabIndex = 2;
            this.checkBoxViewPass.Text = "показать пароль";
            this.checkBoxViewPass.UseVisualStyleBackColor = true;
            this.checkBoxViewPass.CheckedChanged += new System.EventHandler(this.checkBoxViewPass_CheckedChanged);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(6, 180);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(154, 30);
            this.buttonLogIn.TabIndex = 3;
            this.buttonLogIn.Text = "Авторизация";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonRegIn
            // 
            this.buttonRegIn.Location = new System.Drawing.Point(6, 216);
            this.buttonRegIn.Name = "buttonRegIn";
            this.buttonRegIn.Size = new System.Drawing.Size(154, 30);
            this.buttonRegIn.TabIndex = 4;
            this.buttonRegIn.Text = "Создать аккаунт";
            this.buttonRegIn.UseVisualStyleBackColor = true;
            this.buttonRegIn.Click += new System.EventHandler(this.buttonRegIn_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(6, 26);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(63, 23);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Логин:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(6, 85);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(74, 23);
            this.labelPass.TabIndex = 7;
            this.labelPass.Text = "Пароль:";
            // 
            // groupBoxLogIn
            // 
            this.groupBoxLogIn.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxLogIn.Controls.Add(this.labelLogin);
            this.groupBoxLogIn.Controls.Add(this.labelPass);
            this.groupBoxLogIn.Controls.Add(this.textBoxLogin);
            this.groupBoxLogIn.Controls.Add(this.textBoxPassword);
            this.groupBoxLogIn.Controls.Add(this.buttonRegIn);
            this.groupBoxLogIn.Controls.Add(this.checkBoxViewPass);
            this.groupBoxLogIn.Controls.Add(this.buttonLogIn);
            this.groupBoxLogIn.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLogIn.Name = "groupBoxLogIn";
            this.groupBoxLogIn.Size = new System.Drawing.Size(166, 252);
            this.groupBoxLogIn.TabIndex = 8;
            this.groupBoxLogIn.TabStop = false;
            this.groupBoxLogIn.Text = "Авторизация";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxLogIn);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(206, 315);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.groupBoxLogIn.ResumeLayout(false);
            this.groupBoxLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxViewPass;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonRegIn;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.GroupBox groupBoxLogIn;
    }
}