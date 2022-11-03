
using ContactBookMVC.Controller;

namespace ContactBookMVC.View
{
    partial class MainForm
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
            contactController = new ContactController();
            writeReadController = new WriteReadController();
            this.writeReadController.Read(this.contactController);
            this.addContactLB = new System.Windows.Forms.Label();
            this.listContactsControl1 = new ContactBookMVC.Controller.ListContactsControl(this.contactController);
            this.SuspendLayout();
            // 
            // addContactLB
            // 
            this.addContactLB.AutoSize = true;
            this.addContactLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addContactLB.Location = new System.Drawing.Point(180, 15);
            this.addContactLB.Name = "addContactLB";
            this.addContactLB.Size = new System.Drawing.Size(269, 32);
            this.addContactLB.TabIndex = 1;
            this.addContactLB.Text = "Добавить контакт";
            this.addContactLB.Click += new System.EventHandler(this.addContactLB_Click);
            // 
            // listContactsControl1
            // 
            this.listContactsControl1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listContactsControl1.Location = new System.Drawing.Point(20, 60);
            this.listContactsControl1.Name = "listContactsControl1";
            this.listContactsControl1.Size = new System.Drawing.Size(610, 500);
            this.listContactsControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.LightGray;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 580);
            this.Controls.Add(this.listContactsControl1);
            this.Controls.Add(this.addContactLB);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addContactLB;
        public ListContactsControl listContactsControl1;
        ContactController contactController;
        WriteReadController writeReadController;
    }
}