using System.ComponentModel;

namespace kurs
{
    partial class Clients
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
            this.btngoback2 = new System.Windows.Forms.Button();
            this.addCliebtn = new System.Windows.Forms.Button();
            this.clientDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btngoback2
            // 
            this.btngoback2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btngoback2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btngoback2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngoback2.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.btngoback2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.btngoback2.Location = new System.Drawing.Point(12, 12);
            this.btngoback2.Name = "btngoback2";
            this.btngoback2.Size = new System.Drawing.Size(239, 33);
            this.btngoback2.TabIndex = 19;
            this.btngoback2.Text = "Повернутись назад";
            this.btngoback2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngoback2.UseVisualStyleBackColor = false;
            this.btngoback2.Click += new System.EventHandler(this.btngoback2_Click);
            // 
            // addCliebtn
            // 
            this.addCliebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.addCliebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addCliebtn.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.addCliebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.addCliebtn.Location = new System.Drawing.Point(12, 519);
            this.addCliebtn.Name = "addCliebtn";
            this.addCliebtn.Size = new System.Drawing.Size(182, 31);
            this.addCliebtn.TabIndex = 16;
            this.addCliebtn.Text = "Додати клієнта";
            this.addCliebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addCliebtn.UseVisualStyleBackColor = false;
            this.addCliebtn.Click += new System.EventHandler(this.addCliebtn_Click);
            // 
            // clientDataGrid
            // 
            this.clientDataGrid.AllowUserToOrderColumns = true;
            this.clientDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(218)))), ((int)(((byte)(196)))));
            this.clientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGrid.Location = new System.Drawing.Point(12, 78);
            this.clientDataGrid.Name = "clientDataGrid";
            this.clientDataGrid.RowTemplate.Height = 24;
            this.clientDataGrid.Size = new System.Drawing.Size(756, 432);
            this.clientDataGrid.TabIndex = 15;
            this.clientDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDataGrid_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Клієнти :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 7F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(200, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 45);
            this.label2.TabIndex = 21;
            this.label2.Text = "Для редагування / видалення інформації про клієнта \r\nнатисніть двічі по вибраному" + " клієнту";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(222)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(780, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngoback2);
            this.Controls.Add(this.addCliebtn);
            this.Controls.Add(this.clientDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клієнти";
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGrid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btngoback2;
        private System.Windows.Forms.Button addCliebtn;
        private System.Windows.Forms.DataGridView clientDataGrid;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}