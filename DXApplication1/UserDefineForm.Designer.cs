namespace DXApplication1
{
    partial class UserDefineForm
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
            this.userControl11 = new DXApplication1.UserControl1();
            this.button1 = new System.Windows.Forms.Button();
            this.activeXControl1 = new ClassLibrary1.TestCom.ActiveXControl();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(25, 37);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(629, 86);
            this.userControl11.TabIndex = 0;
            this.userControl11.Text1 = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // activeXControl1
            // 
            this.activeXControl1.Location = new System.Drawing.Point(465, 181);
            this.activeXControl1.Name = "activeXControl1";
            this.activeXControl1.Size = new System.Drawing.Size(150, 150);
            this.activeXControl1.TabIndex = 2;
            this.activeXControl1.Load += new System.EventHandler(this.activeXControl1_Load);
            // 
            // UserDefineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.activeXControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl11);
            this.Name = "UserDefineForm";
            this.Text = "UserDefineForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Button button1;
        private ClassLibrary1.TestCom.ActiveXControl activeXControl1;
    }
}