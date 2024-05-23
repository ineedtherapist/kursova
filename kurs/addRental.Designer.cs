using System.ComponentModel;

namespace kurs
{
    partial class addRental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnAddClien = new System.Windows.Forms.Button();
            this.btnAddInst = new System.Windows.Forms.Button();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.Date_startAdd = new System.Windows.Forms.TextBox();
            this.PriceAdd = new System.Windows.Forms.TextBox();
            this.Date_endAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddClien
            // 
            this.btnAddClien.Location = new System.Drawing.Point(251, 75);
            this.btnAddClien.Name = "btnAddClien";
            this.btnAddClien.Size = new System.Drawing.Size(124, 26);
            this.btnAddClien.TabIndex = 0;
            this.btnAddClien.UseVisualStyleBackColor = true;
            this.btnAddClien.Click += new System.EventHandler(this.btnAddClien_Click);
            // 
            // btnAddInst
            // 
            this.btnAddInst.Location = new System.Drawing.Point(251, 32);
            this.btnAddInst.Name = "btnAddInst";
            this.btnAddInst.Size = new System.Drawing.Size(124, 26);
            this.btnAddInst.TabIndex = 1;
            this.btnAddInst.UseVisualStyleBackColor = true;
            this.btnAddInst.Click += new System.EventHandler(this.btnAddInst_Click);
            // 
            // btnAddRental
            // 
            this.btnAddRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAddRental.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRental.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.btnAddRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.btnAddRental.Location = new System.Drawing.Point(100, 247);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddRental.Size = new System.Drawing.Size(206, 36);
            this.btnAddRental.TabIndex = 2;
            this.btnAddRental.Text = "Додати замовлення";
            this.btnAddRental.UseVisualStyleBackColor = false;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // Date_startAdd
            // 
            this.Date_startAdd.Location = new System.Drawing.Point(251, 159);
            this.Date_startAdd.Name = "Date_startAdd";
            this.Date_startAdd.Size = new System.Drawing.Size(124, 22);
            this.Date_startAdd.TabIndex = 3;
            // 
            // PriceAdd
            // 
            this.PriceAdd.Location = new System.Drawing.Point(251, 119);
            this.PriceAdd.Name = "PriceAdd";
            this.PriceAdd.Size = new System.Drawing.Size(124, 22);
            this.PriceAdd.TabIndex = 4;
            // 
            // Date_endAdd
            // 
            this.Date_endAdd.Location = new System.Drawing.Point(251, 203);
            this.Date_endAdd.Name = "Date_endAdd";
            this.Date_endAdd.Size = new System.Drawing.Size(124, 22);
            this.Date_endAdd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата початку оренди :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата кінця оренди :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ціна ($ / місяць) :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(38, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Виберіть клієнта :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(38, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Виберіть інструмент :";
            // 
            // addRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(410, 313);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_endAdd);
            this.Controls.Add(this.PriceAdd);
            this.Controls.Add(this.Date_startAdd);
            this.Controls.Add(this.btnAddRental);
            this.Controls.Add(this.btnAddInst);
            this.Controls.Add(this.btnAddClien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавити замовлення";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox Date_startAdd;
        private System.Windows.Forms.TextBox PriceAdd;
        private System.Windows.Forms.TextBox Date_endAdd;

        private System.Windows.Forms.Button btnAddRental;

        private System.Windows.Forms.Button btnAddClien;
        private System.Windows.Forms.Button btnAddInst;

        #endregion
    }
}