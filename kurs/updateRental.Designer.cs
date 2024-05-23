using System.ComponentModel;

namespace kurs
{
    partial class updateRental
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
            this.Deletinst = new System.Windows.Forms.Button();
            this.UpdinstBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_endAdd = new System.Windows.Forms.TextBox();
            this.PriceUpd = new System.Windows.Forms.TextBox();
            this.Date_startUpd = new System.Windows.Forms.TextBox();
            this.btnUpdInst = new System.Windows.Forms.Button();
            this.btnUpdClie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Deletinst
            // 
            this.Deletinst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.Deletinst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletinst.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.Deletinst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.Deletinst.Location = new System.Drawing.Point(97, 268);
            this.Deletinst.Name = "Deletinst";
            this.Deletinst.Size = new System.Drawing.Size(197, 36);
            this.Deletinst.TabIndex = 31;
            this.Deletinst.Text = "Видалити замовлення";
            this.Deletinst.UseVisualStyleBackColor = false;
            this.Deletinst.Click += new System.EventHandler(this.Deletinst_Click);
            // 
            // UpdinstBtn
            // 
            this.UpdinstBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.UpdinstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdinstBtn.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.UpdinstBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.UpdinstBtn.Location = new System.Drawing.Point(97, 226);
            this.UpdinstBtn.Name = "UpdinstBtn";
            this.UpdinstBtn.Size = new System.Drawing.Size(197, 36);
            this.UpdinstBtn.TabIndex = 30;
            this.UpdinstBtn.Text = "Змінити замовлення";
            this.UpdinstBtn.UseVisualStyleBackColor = false;
            this.UpdinstBtn.Click += new System.EventHandler(this.UpdinstBtn_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(31, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Назва інструмента :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Клієнт :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ціна ($ / місяць) :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Дата кінця оренди :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Дата початку оренди :";
            // 
            // Date_endAdd
            // 
            this.Date_endAdd.Location = new System.Drawing.Point(239, 185);
            this.Date_endAdd.Name = "Date_endAdd";
            this.Date_endAdd.Size = new System.Drawing.Size(124, 22);
            this.Date_endAdd.TabIndex = 36;
            // 
            // PriceUpd
            // 
            this.PriceUpd.Location = new System.Drawing.Point(239, 101);
            this.PriceUpd.Name = "PriceUpd";
            this.PriceUpd.Size = new System.Drawing.Size(124, 22);
            this.PriceUpd.TabIndex = 35;
            // 
            // Date_startUpd
            // 
            this.Date_startUpd.Location = new System.Drawing.Point(239, 141);
            this.Date_startUpd.Name = "Date_startUpd";
            this.Date_startUpd.Size = new System.Drawing.Size(124, 22);
            this.Date_startUpd.TabIndex = 34;
            // 
            // btnUpdInst
            // 
            this.btnUpdInst.Location = new System.Drawing.Point(239, 18);
            this.btnUpdInst.Name = "btnUpdInst";
            this.btnUpdInst.Size = new System.Drawing.Size(124, 26);
            this.btnUpdInst.TabIndex = 42;
            this.btnUpdInst.UseVisualStyleBackColor = true;
            this.btnUpdInst.Click += new System.EventHandler(this.btnUpdInst_Click);
            // 
            // btnUpdClie
            // 
            this.btnUpdClie.Location = new System.Drawing.Point(239, 58);
            this.btnUpdClie.Name = "btnUpdClie";
            this.btnUpdClie.Size = new System.Drawing.Size(124, 26);
            this.btnUpdClie.TabIndex = 43;
            this.btnUpdClie.UseVisualStyleBackColor = true;
            this.btnUpdClie.Click += new System.EventHandler(this.btnUpdClie_Click);
            // 
            // updateRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(398, 322);
            this.Controls.Add(this.btnUpdClie);
            this.Controls.Add(this.btnUpdInst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_endAdd);
            this.Controls.Add(this.PriceUpd);
            this.Controls.Add(this.Date_startUpd);
            this.Controls.Add(this.Deletinst);
            this.Controls.Add(this.UpdinstBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "updateRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оновити замовлення";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnUpdInst;
        private System.Windows.Forms.Button btnUpdClie;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Date_endAdd;
        private System.Windows.Forms.TextBox PriceUpd;
        private System.Windows.Forms.TextBox Date_startUpd;

        private System.Windows.Forms.Button Deletinst;
        private System.Windows.Forms.Button UpdinstBtn;

        #endregion
    }
}