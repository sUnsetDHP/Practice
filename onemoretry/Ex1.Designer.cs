﻿
namespace onemoretry
{
    partial class Ex1
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
            this.ex1DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ex1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ex1DataGridView
            // 
            this.ex1DataGridView.AllowUserToAddRows = false;
            this.ex1DataGridView.AllowUserToDeleteRows = false;
            this.ex1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ex1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ex1DataGridView.Location = new System.Drawing.Point(12, 52);
            this.ex1DataGridView.Name = "ex1DataGridView";
            this.ex1DataGridView.ReadOnly = true;
            this.ex1DataGridView.Size = new System.Drawing.Size(457, 345);
            this.ex1DataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Найти марку автомобиля с минимальной нормой затрат.";
            // 
            // Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ex1DataGridView);
            this.Name = "Ex1";
            this.Text = "Ex1";
            ((System.ComponentModel.ISupportInitialize)(this.ex1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ex1DataGridView;
        private System.Windows.Forms.Label label1;
    }
}