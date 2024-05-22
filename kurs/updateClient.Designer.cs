using System.ComponentModel;

namespace kurs
{
    partial class updateClient
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
            this.ClieNameUpd = new System.Windows.Forms.TextBox();
            this.DBClieUpd = new System.Windows.Forms.TextBox();
            this.PhoneClieUpd = new System.Windows.Forms.TextBox();
            this.labl1 = new System.Windows.Forms.Label();
            this.labl2 = new System.Windows.Forms.Label();
            this.labl3 = new System.Windows.Forms.Label();
            this.UpdClieBtn = new System.Windows.Forms.Button();
            this.DeletClie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClieNameUpd
            // 
            this.ClieNameUpd.Location = new System.Drawing.Point(222, 29);
            this.ClieNameUpd.Name = "ClieNameUpd";
            this.ClieNameUpd.Size = new System.Drawing.Size(100, 22);
            this.ClieNameUpd.TabIndex = 20;
            // 
            // DBClieUpd
            // 
            this.DBClieUpd.Location = new System.Drawing.Point(222, 58);
            this.DBClieUpd.Name = "DBClieUpd";
            this.DBClieUpd.Size = new System.Drawing.Size(100, 22);
            this.DBClieUpd.TabIndex = 19;
            // 
            // PhoneClieUpd
            // 
            this.PhoneClieUpd.Location = new System.Drawing.Point(222, 86);
            this.PhoneClieUpd.Name = "PhoneClieUpd";
            this.PhoneClieUpd.Size = new System.Drawing.Size(100, 22);
            this.PhoneClieUpd.TabIndex = 18;
            // 
            // labl1
            // 
            this.labl1.BackColor = System.Drawing.Color.Transparent;
            this.labl1.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl1.Location = new System.Drawing.Point(39, 28);
            this.labl1.Name = "labl1";
            this.labl1.Size = new System.Drawing.Size(164, 23);
            this.labl1.TabIndex = 17;
            this.labl1.Text = "Ім\'я та прізвище  :";
            this.labl1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labl2
            // 
            this.labl2.BackColor = System.Drawing.Color.Transparent;
            this.labl2.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl2.Location = new System.Drawing.Point(39, 57);
            this.labl2.Name = "labl2";
            this.labl2.Size = new System.Drawing.Size(164, 23);
            this.labl2.TabIndex = 16;
            this.labl2.Text = "День народження :";
            this.labl2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labl3
            // 
            this.labl3.BackColor = System.Drawing.Color.Transparent;
            this.labl3.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl3.Location = new System.Drawing.Point(39, 85);
            this.labl3.Name = "labl3";
            this.labl3.Size = new System.Drawing.Size(164, 23);
            this.labl3.TabIndex = 15;
            this.labl3.Text = "Номер телефону :";
            this.labl3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UpdClieBtn
            // 
            this.UpdClieBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.UpdClieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdClieBtn.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.UpdClieBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.UpdClieBtn.Location = new System.Drawing.Point(100, 126);
            this.UpdClieBtn.Name = "UpdClieBtn";
            this.UpdClieBtn.Size = new System.Drawing.Size(159, 36);
            this.UpdClieBtn.TabIndex = 14;
            this.UpdClieBtn.Text = "Змінити клієнта";
            this.UpdClieBtn.UseVisualStyleBackColor = false;
            this.UpdClieBtn.Click += new System.EventHandler(this.UpdClieBtn_Click);
            // 
            // DeletClie
            // 
            this.DeletClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.DeletClie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeletClie.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.DeletClie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.DeletClie.Location = new System.Drawing.Point(100, 168);
            this.DeletClie.Name = "DeletClie";
            this.DeletClie.Size = new System.Drawing.Size(159, 36);
            this.DeletClie.TabIndex = 21;
            this.DeletClie.Text = "Видалити клієнта";
            this.DeletClie.UseVisualStyleBackColor = false;
            this.DeletClie.Click += new System.EventHandler(this.DeletClie_Click);
            // 
            // updateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(366, 234);
            this.Controls.Add(this.DeletClie);
            this.Controls.Add(this.ClieNameUpd);
            this.Controls.Add(this.DBClieUpd);
            this.Controls.Add(this.PhoneClieUpd);
            this.Controls.Add(this.labl1);
            this.Controls.Add(this.labl2);
            this.Controls.Add(this.labl3);
            this.Controls.Add(this.UpdClieBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "updateClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Змінити клієнта";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button DeletClie;

        private System.Windows.Forms.TextBox ClieNameUpd;
        private System.Windows.Forms.TextBox DBClieUpd;
        private System.Windows.Forms.TextBox PhoneClieUpd;
        private System.Windows.Forms.Label labl1;
        private System.Windows.Forms.Label labl2;
        private System.Windows.Forms.Label labl3;
        private System.Windows.Forms.Button UpdClieBtn;

        #endregion
    }
}