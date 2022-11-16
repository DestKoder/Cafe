namespace Cafe.forms
{
    partial class AdministratorForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuAddButton = new System.Windows.Forms.Button();
            this.menuDelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 420);
            this.listBox1.TabIndex = 0;
            // 
            // menuAddButton
            // 
            this.menuAddButton.Location = new System.Drawing.Point(13, 454);
            this.menuAddButton.Name = "menuAddButton";
            this.menuAddButton.Size = new System.Drawing.Size(126, 49);
            this.menuAddButton.TabIndex = 1;
            this.menuAddButton.Text = "Добавить";
            this.menuAddButton.UseVisualStyleBackColor = true;
            this.menuAddButton.Click += new System.EventHandler(this.menuAddButton_Click);
            // 
            // menuDelButton
            // 
            this.menuDelButton.Location = new System.Drawing.Point(166, 454);
            this.menuDelButton.Name = "menuDelButton";
            this.menuDelButton.Size = new System.Drawing.Size(144, 49);
            this.menuDelButton.TabIndex = 2;
            this.menuDelButton.Text = "Удалить";
            this.menuDelButton.UseVisualStyleBackColor = true;
            this.menuDelButton.Click += new System.EventHandler(this.menuDelButton_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 514);
            this.Controls.Add(this.menuDelButton);
            this.Controls.Add(this.menuAddButton);
            this.Controls.Add(this.listBox1);
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorForm_FormClosing);
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button menuAddButton;
        private System.Windows.Forms.Button menuDelButton;
    }
}