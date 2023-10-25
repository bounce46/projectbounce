namespace projectbounce.Forms
{
    partial class RegForm
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
            this.groupBoxReg = new System.Windows.Forms.GroupBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPassRepeat = new System.Windows.Forms.Label();
            this.textBoxPassRepeat = new System.Windows.Forms.TextBox();
            this.checkBoxViewPass = new System.Windows.Forms.CheckBox();
            this.buttonRegIn = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxReg
            // 
            this.groupBoxReg.Controls.Add(this.buttonBack);
            this.groupBoxReg.Controls.Add(this.checkBoxViewPass);
            this.groupBoxReg.Controls.Add(this.buttonRegIn);
            this.groupBoxReg.Controls.Add(this.labelPassRepeat);
            this.groupBoxReg.Controls.Add(this.textBoxPassRepeat);
            this.groupBoxReg.Controls.Add(this.labelPass);
            this.groupBoxReg.Controls.Add(this.textBoxPass);
            this.groupBoxReg.Controls.Add(this.labelLogin);
            this.groupBoxReg.Controls.Add(this.textBoxLogin);
            this.groupBoxReg.Location = new System.Drawing.Point(12, 12);
            this.groupBoxReg.Name = "groupBoxReg";
            this.groupBoxReg.Size = new System.Drawing.Size(166, 311);
            this.groupBoxReg.TabIndex = 0;
            this.groupBoxReg.TabStop = false;
            this.groupBoxReg.Text = "Регистрация";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(6, 52);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(154, 30);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(6, 26);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(63, 23);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(6, 85);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(74, 23);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "Пароль:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(6, 111);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(154, 30);
            this.textBoxPass.TabIndex = 3;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // labelPassRepeat
            // 
            this.labelPassRepeat.AutoSize = true;
            this.labelPassRepeat.Location = new System.Drawing.Point(6, 144);
            this.labelPassRepeat.Name = "labelPassRepeat";
            this.labelPassRepeat.Size = new System.Drawing.Size(132, 23);
            this.labelPassRepeat.TabIndex = 6;
            this.labelPassRepeat.Text = "Повтор пароля:";
            // 
            // textBoxPassRepeat
            // 
            this.textBoxPassRepeat.Location = new System.Drawing.Point(6, 170);
            this.textBoxPassRepeat.Name = "textBoxPassRepeat";
            this.textBoxPassRepeat.Size = new System.Drawing.Size(154, 30);
            this.textBoxPassRepeat.TabIndex = 5;
            this.textBoxPassRepeat.UseSystemPasswordChar = true;
            // 
            // checkBoxViewPass
            // 
            this.checkBoxViewPass.AutoSize = true;
            this.checkBoxViewPass.Location = new System.Drawing.Point(6, 206);
            this.checkBoxViewPass.Name = "checkBoxViewPass";
            this.checkBoxViewPass.Size = new System.Drawing.Size(154, 27);
            this.checkBoxViewPass.TabIndex = 7;
            this.checkBoxViewPass.Text = "показать пароль";
            this.checkBoxViewPass.UseVisualStyleBackColor = true;
            this.checkBoxViewPass.CheckedChanged += new System.EventHandler(this.checkBoxViewPass_CheckedChanged);
            // 
            // buttonRegIn
            // 
            this.buttonRegIn.Location = new System.Drawing.Point(6, 239);
            this.buttonRegIn.Name = "buttonRegIn";
            this.buttonRegIn.Size = new System.Drawing.Size(154, 30);
            this.buttonRegIn.TabIndex = 8;
            this.buttonRegIn.Text = "Создать аккаунт";
            this.buttonRegIn.UseVisualStyleBackColor = true;
            this.buttonRegIn.Click += new System.EventHandler(this.buttonRegIn_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(6, 275);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(154, 30);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Вернуться";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxReg);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.groupBoxReg.ResumeLayout(false);
            this.groupBoxReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxReg;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassRepeat;
        private System.Windows.Forms.TextBox textBoxPassRepeat;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.CheckBox checkBoxViewPass;
        private System.Windows.Forms.Button buttonRegIn;
        private System.Windows.Forms.Button buttonBack;
    }
}