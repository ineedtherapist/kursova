namespace kurs
{
    partial class enter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(100, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 99);
            this.label1.TabIndex = 1;
            this.label1.Text = "Система для оренди \r\nбудівельних інструментів";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnenter
            // 
            this.btnenter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnenter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnenter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnenter.FlatAppearance.BorderSize = 10;
            this.btnenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnenter.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            this.btnenter.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnenter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnenter.Location = new System.Drawing.Point(255, 270);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(100, 35);
            this.btnenter.TabIndex = 0;
            this.btnenter.Text = "Увійти";
            this.btnenter.UseVisualStyleBackColor = false;
            this.btnenter.Click += new System.EventHandler(this.button1_Click);
            // 
            // enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::kurs.Properties.Resources.illustration;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(600, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnenter);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "enter";
            this.Text = "Застосунок";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnenter;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}