using System.ComponentModel;

namespace kurs
{
    partial class Rentals
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
            this.label1 = new System.Windows.Forms.Label();
            this.rentalDataGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butShowInst = new System.Windows.Forms.Button();
            this.butShowClin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Інструменти доступні для оренди :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rentalDataGrid
            // 
            this.rentalDataGrid.AllowUserToOrderColumns = true;
            this.rentalDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(218)))), ((int)(((byte)(196)))));
            this.rentalDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalDataGrid.Location = new System.Drawing.Point(12, 78);
            this.rentalDataGrid.Name = "rentalDataGrid";
            this.rentalDataGrid.RowTemplate.Height = 24;
            this.rentalDataGrid.Size = new System.Drawing.Size(756, 432);
            this.rentalDataGrid.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.button3.Location = new System.Drawing.Point(12, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Додати запис";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.button4.Location = new System.Drawing.Point(360, 516);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "Видалити запис";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.button1.Location = new System.Drawing.Point(186, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Змінити запис";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // butShowInst
            // 
            this.butShowInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.butShowInst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butShowInst.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.butShowInst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.butShowInst.Location = new System.Drawing.Point(257, 12);
            this.butShowInst.Name = "butShowInst";
            this.butShowInst.Size = new System.Drawing.Size(239, 33);
            this.butShowInst.TabIndex = 7;
            this.butShowInst.Text = "Показати всі інструменти";
            this.butShowInst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butShowInst.UseVisualStyleBackColor = false;
            this.butShowInst.Click += new System.EventHandler(this.butShowInst_Click);
            // 
            // butShowClin
            // 
            this.butShowClin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butShowClin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.butShowClin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butShowClin.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.butShowClin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.butShowClin.Location = new System.Drawing.Point(12, 12);
            this.butShowClin.Name = "butShowClin";
            this.butShowClin.Size = new System.Drawing.Size(239, 33);
            this.butShowClin.TabIndex = 8;
            this.butShowClin.Text = "Показати всіх клієнтів";
            this.butShowClin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butShowClin.UseVisualStyleBackColor = false;
            this.butShowClin.Click += new System.EventHandler(this.bntShowClien_Click);
            // 
            // Rentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(780, 559);
            this.Controls.Add(this.butShowClin);
            this.Controls.Add(this.butShowInst);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rentalDataGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Rentals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оренди";
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataGrid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button butShowInst;
        private System.Windows.Forms.Button butShowClin;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView rentalDataGrid;

        #endregion
    }
}