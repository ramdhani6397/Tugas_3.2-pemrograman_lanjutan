namespace Tugas3._2.II
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPesan1 = new System.Windows.Forms.TextBox();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNama, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPendidikan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lstPekerjaan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtPesan1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPesan2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPesan3, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pendidikan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNama
            // 
            this.txtNama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNama.Location = new System.Drawing.Point(113, 3);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(684, 26);
            this.txtNama.TabIndex = 2;
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "   SD",
            "   SMP",
            "   SMA",
            "   D3",
            "   S1",
            "   S2"});
            this.cmbPendidikan.Location = new System.Drawing.Point(113, 33);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(684, 28);
            this.cmbPendidikan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pekerjaan";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.ItemHeight = 20;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "   Pedagang",
            "   PNS",
            "   Dosen",
            "   Swasta",
            "   ABRI"});
            this.lstPekerjaan.Location = new System.Drawing.Point(113, 63);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(684, 254);
            this.lstPekerjaan.TabIndex = 5;
            // 
            // btnOK
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnOK, 2);
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Location = new System.Drawing.Point(3, 413);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(794, 34);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPesan1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPesan1, 2);
            this.txtPesan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesan1.Location = new System.Drawing.Point(3, 323);
            this.txtPesan1.Name = "txtPesan1";
            this.txtPesan1.ReadOnly = true;
            this.txtPesan1.Size = new System.Drawing.Size(794, 26);
            this.txtPesan1.TabIndex = 7;
            // 
            // txtPesan2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPesan2, 2);
            this.txtPesan2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesan2.Location = new System.Drawing.Point(3, 353);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.ReadOnly = true;
            this.txtPesan2.Size = new System.Drawing.Size(794, 26);
            this.txtPesan2.TabIndex = 8;
            // 
            // txtPesan3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPesan3, 2);
            this.txtPesan3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesan3.Location = new System.Drawing.Point(3, 383);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.ReadOnly = true;
            this.txtPesan3.Size = new System.Drawing.Size(794, 26);
            this.txtPesan3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Tugas 3.2 menggunakan layout";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbPendidikan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPesan1;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.TextBox txtPesan3;
    }
}

