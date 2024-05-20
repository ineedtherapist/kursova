using System.ComponentModel;

namespace kurs
{
    partial class AddClient
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
            this.ClieNameAdd = new System.Windows.Forms.TextBox();
            this.DBClieAdd = new System.Windows.Forms.TextBox();
            this.PhoneClieAdd = new System.Windows.Forms.TextBox();
            this.labl1 = new System.Windows.Forms.Label();
            this.labl2 = new System.Windows.Forms.Label();
            this.labl3 = new System.Windows.Forms.Label();
            this.AddClieBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClieNameAdd
            // 
            this.ClieNameAdd.Location = new System.Drawing.Point(231, 44);
            this.ClieNameAdd.Name = "ClieNameAdd";
            this.ClieNameAdd.Size = new System.Drawing.Size(100, 22);
            this.ClieNameAdd.TabIndex = 13;
            // 
            // DBClieAdd
            // 
            this.DBClieAdd.Location = new System.Drawing.Point(231, 73);
            this.DBClieAdd.Name = "DBClieAdd";
            this.DBClieAdd.Size = new System.Drawing.Size(100, 22);
            this.DBClieAdd.TabIndex = 12;
            // 
            // PhoneClieAdd
            // 
            this.PhoneClieAdd.Location = new System.Drawing.Point(231, 101);
            this.PhoneClieAdd.Name = "PhoneClieAdd";
            this.PhoneClieAdd.Size = new System.Drawing.Size(100, 22);
            this.PhoneClieAdd.TabIndex = 11;
            // 
            // labl1
            // 
            this.labl1.BackColor = System.Drawing.Color.Transparent;
            this.labl1.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl1.Location = new System.Drawing.Point(48, 43);
            this.labl1.Name = "labl1";
            this.labl1.Size = new System.Drawing.Size(164, 23);
            this.labl1.TabIndex = 10;
            this.labl1.Text = "Ім\'я та прізвище  :";
            this.labl1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labl2
            // 
            this.labl2.BackColor = System.Drawing.Color.Transparent;
            this.labl2.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl2.Location = new System.Drawing.Point(48, 72);
            this.labl2.Name = "labl2";
            this.labl2.Size = new System.Drawing.Size(164, 23);
            this.labl2.TabIndex = 9;
            this.labl2.Text = "День народження :";
            this.labl2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labl3
            // 
            this.labl3.BackColor = System.Drawing.Color.Transparent;
            this.labl3.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl3.Location = new System.Drawing.Point(48, 100);
            this.labl3.Name = "labl3";
            this.labl3.Size = new System.Drawing.Size(164, 23);
            this.labl3.TabIndex = 8;
            this.labl3.Text = "Номер телефону :";
            this.labl3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AddClieBtn
            // 
            this.AddClieBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.AddClieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddClieBtn.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.AddClieBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.AddClieBtn.Location = new System.Drawing.Point(109, 141);
            this.AddClieBtn.Name = "AddClieBtn";
            this.AddClieBtn.Size = new System.Drawing.Size(159, 36);
            this.AddClieBtn.TabIndex = 7;
            this.AddClieBtn.Text = "Додати клієнта";
            this.AddClieBtn.UseVisualStyleBackColor = false;
            this.AddClieBtn.Click += new System.EventHandler(this.AddClieBtn_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(378, 221);
            this.Controls.Add(this.ClieNameAdd);
            this.Controls.Add(this.DBClieAdd);
            this.Controls.Add(this.PhoneClieAdd);
            this.Controls.Add(this.labl1);
            this.Controls.Add(this.labl2);
            this.Controls.Add(this.labl3);
            this.Controls.Add(this.AddClieBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати Клієнта";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox ClieNameAdd;
        private System.Windows.Forms.TextBox DBClieAdd;
        private System.Windows.Forms.TextBox PhoneClieAdd;
        private System.Windows.Forms.Label labl1;
        private System.Windows.Forms.Label labl2;
        private System.Windows.Forms.Label labl3;
        private System.Windows.Forms.Button AddClieBtn;

        #endregion
    }
}