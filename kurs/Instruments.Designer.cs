using System.ComponentModel;

namespace kurs
{
    partial class Instruments
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
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddInstr = new System.Windows.Forms.Button();
            this.instrDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btngoback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.instrDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.button1.Location = new System.Drawing.Point(200, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Змінити інструмент";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.button4.Location = new System.Drawing.Point(388, 516);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 31);
            this.button4.TabIndex = 10;
            this.button4.Text = "Видалити інструмент";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddInstr
            // 
            this.btnAddInstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAddInstr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddInstr.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.btnAddInstr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.btnAddInstr.Location = new System.Drawing.Point(12, 516);
            this.btnAddInstr.Name = "btnAddInstr";
            this.btnAddInstr.Size = new System.Drawing.Size(182, 31);
            this.btnAddInstr.TabIndex = 9;
            this.btnAddInstr.Text = "Додати інструмент";
            this.btnAddInstr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddInstr.UseVisualStyleBackColor = false;
            this.btnAddInstr.Click += new System.EventHandler(this.btnAddInstr_Click);
            // 
            // instrDataGrid
            // 
            this.instrDataGrid.AllowUserToOrderColumns = true;
            this.instrDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(218)))), ((int)(((byte)(196)))));
            this.instrDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instrDataGrid.Location = new System.Drawing.Point(12, 78);
            this.instrDataGrid.Name = "instrDataGrid";
            this.instrDataGrid.RowTemplate.Height = 24;
            this.instrDataGrid.Size = new System.Drawing.Size(756, 432);
            this.instrDataGrid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Інструменти :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btngoback
            // 
            this.btngoback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btngoback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btngoback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngoback.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.btngoback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.btngoback.Location = new System.Drawing.Point(12, 12);
            this.btngoback.Name = "btngoback";
            this.btngoback.Size = new System.Drawing.Size(239, 33);
            this.btngoback.TabIndex = 13;
            this.btngoback.Text = "Повернутись назад";
            this.btngoback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngoback.UseVisualStyleBackColor = false;
            this.btngoback.Click += new System.EventHandler(this.btngoback_Click);
            // 
            // Instruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(780, 559);
            this.Controls.Add(this.btngoback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAddInstr);
            this.Controls.Add(this.instrDataGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Instruments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Інструменти";
            ((System.ComponentModel.ISupportInitialize)(this.instrDataGrid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btngoback;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddInstr;
        private System.Windows.Forms.DataGridView instrDataGrid;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}