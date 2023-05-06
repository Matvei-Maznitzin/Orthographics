namespace Orthographics
{
    partial class MainMenuControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(3, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(255, 56);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Об игре";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loginButton);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(261, 188);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
