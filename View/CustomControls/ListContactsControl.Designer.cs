
namespace ContactBookMVC.Controller
{
    partial class ListContactsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.startSearchBTN = new System.Windows.Forms.Button();
            this.RightGoCB = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Location = new System.Drawing.Point(190, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 630);
            this.panel1.TabIndex = 0;
                       // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 42);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // searchTB
            // 
            this.searchTB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.searchTB.Location = new System.Drawing.Point(190, 53);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(694, 31);
            this.searchTB.TabIndex = 1;
            this.searchTB.Text = "Search";
            this.searchTB.Click += new System.EventHandler(this.searchTB_Click);
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // startSearchBTN
            // 
            this.startSearchBTN.Location = new System.Drawing.Point(0, 305);
            this.startSearchBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startSearchBTN.Name = "startSearchBTN";
            this.startSearchBTN.Size = new System.Drawing.Size(135, 67);
            this.startSearchBTN.TabIndex = 2;
            this.startSearchBTN.Text = "Start Search";
            this.startSearchBTN.UseVisualStyleBackColor = true;
            this.startSearchBTN.Click += new System.EventHandler(this.startSearchBTN_Click);
            // 
            // RightGoCB
            // 
            this.RightGoCB.AutoSize = true;
            this.RightGoCB.Location = new System.Drawing.Point(12, 53);
            this.RightGoCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RightGoCB.Name = "RightGoCB";
            this.RightGoCB.Size = new System.Drawing.Size(167, 29);
            this.RightGoCB.TabIndex = 3;
            this.RightGoCB.Text = "Strict Search";
            this.RightGoCB.UseVisualStyleBackColor = true;
            // 
            // ListContactsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.RightGoCB);
            this.Controls.Add(this.startSearchBTN);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListContactsControl";
            this.Size = new System.Drawing.Size(1006, 806);
            this.Load += new System.EventHandler(this.ListContactsControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button startSearchBTN;
        private System.Windows.Forms.CheckBox RightGoCB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
