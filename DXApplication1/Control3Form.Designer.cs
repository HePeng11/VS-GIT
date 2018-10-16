namespace DXApplication1
{
    partial class Control3Form
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
            this.userControl31 = new DXApplication1.UserControl3();
            this.SuspendLayout();
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(12, 12);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(673, 296);
            this.userControl31.TabIndex = 0;
            // 
            // Control3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl31);
            this.Name = "Control3Form";
            this.Text = "Control3Form";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl3 userControl31;
    }
}