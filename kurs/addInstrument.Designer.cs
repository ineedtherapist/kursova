using System.ComponentModel;

namespace kurs
{
    partial class addInstrument
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
            this.AddInstBtn = new System.Windows.Forms.Button();
            this.labl3 = new System.Windows.Forms.Label();
            this.labl2 = new System.Windows.Forms.Label();
            this.labl1 = new System.Windows.Forms.Label();
            this.PriceInstrAdd = new System.Windows.Forms.TextBox();
            this.DescInstrAdd = new System.Windows.Forms.TextBox();
            this.InstrNameAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddInstBtn
            // 
            this.AddInstBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.AddInstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddInstBtn.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.AddInstBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.AddInstBtn.Location = new System.Drawing.Point(101, 138);
            this.AddInstBtn.Name = "AddInstBtn";
            this.AddInstBtn.Size = new System.Drawing.Size(159, 36);
            this.AddInstBtn.TabIndex = 0;
            this.AddInstBtn.Text = "Додати інструмент";
            this.AddInstBtn.UseVisualStyleBackColor = false;
            this.AddInstBtn.Click += new System.EventHandler(this.AddInstBtn_Click);
            // 
            // labl3
            // 
            this.labl3.BackColor = System.Drawing.Color.Transparent;
            this.labl3.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl3.Location = new System.Drawing.Point(49, 97);
            this.labl3.Name = "labl3";
            this.labl3.Size = new System.Drawing.Size(164, 23);
            this.labl3.TabIndex = 1;
            this.labl3.Text = "Ціна ($/month) :";
            this.labl3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labl2
            // 
            this.labl2.BackColor = System.Drawing.Color.Transparent;
            this.labl2.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl2.Location = new System.Drawing.Point(49, 69);
            this.labl2.Name = "labl2";
            this.labl2.Size = new System.Drawing.Size(164, 23);
            this.labl2.TabIndex = 2;
            this.labl2.Text = "Опис інструмента :";
            this.labl2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labl1
            // 
            this.labl1.BackColor = System.Drawing.Color.Transparent;
            this.labl1.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.labl1.Location = new System.Drawing.Point(49, 40);
            this.labl1.Name = "labl1";
            this.labl1.Size = new System.Drawing.Size(164, 23);
            this.labl1.TabIndex = 3;
            this.labl1.Text = "Назва інструмента :";
            this.labl1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PriceInstrAdd
            // 
            this.PriceInstrAdd.Location = new System.Drawing.Point(232, 98);
            this.PriceInstrAdd.Name = "PriceInstrAdd";
            this.PriceInstrAdd.Size = new System.Drawing.Size(100, 22);
            this.PriceInstrAdd.TabIndex = 4;
            // 
            // DescInstrAdd
            // 
            this.DescInstrAdd.Location = new System.Drawing.Point(232, 70);
            this.DescInstrAdd.Name = "DescInstrAdd";
            this.DescInstrAdd.Size = new System.Drawing.Size(100, 22);
            this.DescInstrAdd.TabIndex = 5;
            // 
            // InstrNameAdd
            // 
            this.InstrNameAdd.Location = new System.Drawing.Point(232, 41);
            this.InstrNameAdd.Name = "InstrNameAdd";
            this.InstrNameAdd.Size = new System.Drawing.Size(100, 22);
            this.InstrNameAdd.TabIndex = 6;
            // 
            // addInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(378, 221);
            this.Controls.Add(this.InstrNameAdd);
            this.Controls.Add(this.DescInstrAdd);
            this.Controls.Add(this.PriceInstrAdd);
            this.Controls.Add(this.labl1);
            this.Controls.Add(this.labl2);
            this.Controls.Add(this.labl3);
            this.Controls.Add(this.AddInstBtn);
            this.Name = "addInstrument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати інструмент";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox PriceInstrAdd;
        private System.Windows.Forms.TextBox DescInstrAdd;
        private System.Windows.Forms.TextBox InstrNameAdd;
        private System.Windows.Forms.Label labl1;
        private System.Windows.Forms.Label labl2;
        private System.Windows.Forms.Label labl3;

        private System.Windows.Forms.Button AddInstBtn;

        #endregion
    }
}