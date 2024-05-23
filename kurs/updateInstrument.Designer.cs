using System.ComponentModel;

namespace kurs
{
    partial class updateInstrument
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
            this.InstrNameUpd = new System.Windows.Forms.TextBox();
            this.DescInstrUpd = new System.Windows.Forms.TextBox();
            this.PriceInstrUpd = new System.Windows.Forms.TextBox();
            this.labl1 = new System.Windows.Forms.Label();
            this.labl2 = new System.Windows.Forms.Label();
            this.labl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Deletinst
            // 
            this.Deletinst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.Deletinst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletinst.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.Deletinst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.Deletinst.Location = new System.Drawing.Point(76, 169);
            this.Deletinst.Name = "Deletinst";
            this.Deletinst.Size = new System.Drawing.Size(206, 36);
            this.Deletinst.TabIndex = 29;
            this.Deletinst.Text = "Видалити інструмент";
            this.Deletinst.UseVisualStyleBackColor = false;
            this.Deletinst.Click += new System.EventHandler(this.Deletinst_Click);
            // 
            // UpdinstBtn
            // 
            this.UpdinstBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.UpdinstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdinstBtn.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.UpdinstBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.UpdinstBtn.Location = new System.Drawing.Point(76, 127);
            this.UpdinstBtn.Name = "UpdinstBtn";
            this.UpdinstBtn.Size = new System.Drawing.Size(206, 36);
            this.UpdinstBtn.TabIndex = 22;
            this.UpdinstBtn.Text = "Змінити інструмент";
            this.UpdinstBtn.UseVisualStyleBackColor = false;
            this.UpdinstBtn.Click += new System.EventHandler(this.UpdinstBtn_Click);
            // 
            // InstrNameUpd
            // 
            this.InstrNameUpd.Location = new System.Drawing.Point(221, 32);
            this.InstrNameUpd.Name = "InstrNameUpd";
            this.InstrNameUpd.Size = new System.Drawing.Size(100, 22);
            this.InstrNameUpd.TabIndex = 35;
            // 
            // DescInstrUpd
            // 
            this.DescInstrUpd.Location = new System.Drawing.Point(221, 61);
            this.DescInstrUpd.Name = "DescInstrUpd";
            this.DescInstrUpd.Size = new System.Drawing.Size(100, 22);
            this.DescInstrUpd.TabIndex = 34;
            // 
            // PriceInstrUpd
            // 
            this.PriceInstrUpd.Location = new System.Drawing.Point(221, 89);
            this.PriceInstrUpd.Name = "PriceInstrUpd";
            this.PriceInstrUpd.Size = new System.Drawing.Size(100, 22);
            this.PriceInstrUpd.TabIndex = 33;
            // 
            // labl1
            // 
            this.labl1.BackColor = System.Drawing.Color.Transparent;
            this.labl1.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl1.Location = new System.Drawing.Point(38, 31);
            this.labl1.Name = "labl1";
            this.labl1.Size = new System.Drawing.Size(164, 23);
            this.labl1.TabIndex = 32;
            this.labl1.Text = "Назва інструмента :";
            this.labl1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labl2
            // 
            this.labl2.BackColor = System.Drawing.Color.Transparent;
            this.labl2.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl2.Location = new System.Drawing.Point(38, 60);
            this.labl2.Name = "labl2";
            this.labl2.Size = new System.Drawing.Size(164, 23);
            this.labl2.TabIndex = 31;
            this.labl2.Text = "Опис інструмента :";
            this.labl2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labl3
            // 
            this.labl3.BackColor = System.Drawing.Color.Transparent;
            this.labl3.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl3.Location = new System.Drawing.Point(38, 88);
            this.labl3.Name = "labl3";
            this.labl3.Size = new System.Drawing.Size(164, 23);
            this.labl3.TabIndex = 30;
            this.labl3.Text = "Ціна ($/month) :";
            this.labl3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // updateInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(366, 234);
            this.Controls.Add(this.InstrNameUpd);
            this.Controls.Add(this.DescInstrUpd);
            this.Controls.Add(this.PriceInstrUpd);
            this.Controls.Add(this.labl1);
            this.Controls.Add(this.labl2);
            this.Controls.Add(this.labl3);
            this.Controls.Add(this.Deletinst);
            this.Controls.Add(this.UpdinstBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "updateInstrument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Змінити інструмент";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox InstrNameUpd;
        private System.Windows.Forms.TextBox DescInstrUpd;
        private System.Windows.Forms.TextBox PriceInstrUpd;

        private System.Windows.Forms.Button Deletinst;
        private System.Windows.Forms.Label labl1;
        private System.Windows.Forms.Label labl2;
        private System.Windows.Forms.Label labl3;
        private System.Windows.Forms.Button UpdinstBtn;

        #endregion
    }
}