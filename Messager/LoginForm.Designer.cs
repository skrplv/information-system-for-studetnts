namespace Messager
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Enterbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CloseButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.LoginField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PasswordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(36, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(352, 48);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "         Добро пожаловать в ИС!\r\nАвторизируйтесь, чтобы продолжить.";
            // 
            // Enterbutton
            // 
            this.Enterbutton.Depth = 0;
            this.Enterbutton.Location = new System.Drawing.Point(144, 588);
            this.Enterbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.Enterbutton.Name = "Enterbutton";
            this.Enterbutton.Primary = true;
            this.Enterbutton.Size = new System.Drawing.Size(166, 46);
            this.Enterbutton.TabIndex = 10;
            this.Enterbutton.Text = "Войти";
            this.Enterbutton.UseVisualStyleBackColor = true;
            this.Enterbutton.Click += new System.EventHandler(this.Enterbutton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.Depth = 0;
            this.CloseButton.Location = new System.Drawing.Point(181, 643);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Primary = false;
            this.CloseButton.Size = new System.Drawing.Size(93, 36);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(53, 433);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 24);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "login";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(53, 514);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(93, 24);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "password";
            // 
            // LoginField
            // 
            this.LoginField.Depth = 0;
            this.LoginField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginField.Hint = "";
            this.LoginField.Location = new System.Drawing.Point(111, 460);
            this.LoginField.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginField.Name = "LoginField";
            this.LoginField.PasswordChar = '\0';
            this.LoginField.SelectedText = "";
            this.LoginField.SelectionLength = 0;
            this.LoginField.SelectionStart = 0;
            this.LoginField.Size = new System.Drawing.Size(245, 28);
            this.LoginField.TabIndex = 19;
            this.LoginField.UseSystemPasswordChar = false;
            // 
            // PasswordField
            // 
            this.PasswordField.Depth = 0;
            this.PasswordField.Hint = "";
            this.PasswordField.Location = new System.Drawing.Point(111, 541);
            this.PasswordField.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '\0';
            this.PasswordField.SelectedText = "";
            this.PasswordField.SelectionLength = 0;
            this.PasswordField.SelectionStart = 0;
            this.PasswordField.Size = new System.Drawing.Size(245, 28);
            this.PasswordField.TabIndex = 20;
            this.PasswordField.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Messager.Properties.Resources.avtoriz1;
            this.pictureBox1.Location = new System.Drawing.Point(85, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 694);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Enterbutton);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(455, 694);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 694);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information System For Students";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton Enterbutton;
        private MaterialSkin.Controls.MaterialFlatButton CloseButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoginField;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordField;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

