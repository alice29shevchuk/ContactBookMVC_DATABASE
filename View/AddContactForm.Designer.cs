
namespace ContactBookMVC.View
{
    partial class AddContactForm
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.nameLB = new System.Windows.Forms.Label();
            this.surnameLB = new System.Windows.Forms.Label();
            this.adressLB = new System.Windows.Forms.Label();
            this.numberLB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(127, 52);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(321, 22);
            this.nameTB.TabIndex = 0;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(127, 134);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(321, 22);
            this.surnameTB.TabIndex = 1;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(127, 227);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(321, 22);
            this.addressTB.TabIndex = 2;
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(127, 316);
            this.numberTB.Multiline = true;
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(321, 22);
            this.numberTB.TabIndex = 3;
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLB.Location = new System.Drawing.Point(37, 49);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(68, 25);
            this.nameLB.TabIndex = 4;
            this.nameLB.Text = "Name";
            // 
            // surnameLB
            // 
            this.surnameLB.AutoSize = true;
            this.surnameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLB.Location = new System.Drawing.Point(19, 134);
            this.surnameLB.Name = "surnameLB";
            this.surnameLB.Size = new System.Drawing.Size(99, 25);
            this.surnameLB.TabIndex = 5;
            this.surnameLB.Text = "Surname";
            // 
            // adressLB
            // 
            this.adressLB.AutoSize = true;
            this.adressLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressLB.Location = new System.Drawing.Point(19, 227);
            this.adressLB.Name = "adressLB";
            this.adressLB.Size = new System.Drawing.Size(92, 25);
            this.adressLB.TabIndex = 6;
            this.adressLB.Text = "Address";
            // 
            // numberLB
            // 
            this.numberLB.AutoSize = true;
            this.numberLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLB.Location = new System.Drawing.Point(18, 313);
            this.numberLB.Name = "numberLB";
            this.numberLB.Size = new System.Drawing.Size(87, 25);
            this.numberLB.TabIndex = 7;
            this.numberLB.Text = "Number";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(351, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(12, 382);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(93, 41);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Назад";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 435);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberLB);
            this.Controls.Add(this.adressLB);
            this.Controls.Add(this.surnameLB);
            this.Controls.Add(this.nameLB);
            this.Controls.Add(this.numberTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.nameTB);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.Label surnameLB;
        private System.Windows.Forms.Label adressLB;
        private System.Windows.Forms.Label numberLB;
        private System.Windows.Forms.Button button1;
        ViewContactUserControl userControl;
        private System.Windows.Forms.Button cancelBtn;
    }
}