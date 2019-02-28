namespace pv03_1700654_Muhammad_Luthfi_Naufal
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNim = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.submitNim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDid = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUid = new System.Windows.Forms.TextBox();
            this.tbUNamaK = new System.Windows.Forms.TextBox();
            this.tbUkategori = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNim
            // 
            this.tbNim.Location = new System.Drawing.Point(362, 86);
            this.tbNim.Name = "tbNim";
            this.tbNim.Size = new System.Drawing.Size(100, 22);
            this.tbNim.TabIndex = 1;
            this.tbNim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(235, 333);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(100, 22);
            this.tbNama.TabIndex = 2;
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(481, 333);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(100, 22);
            this.tbKategori.TabIndex = 3;
            // 
            // submitNim
            // 
            this.submitNim.Location = new System.Drawing.Point(468, 85);
            this.submitNim.Name = "submitNim";
            this.submitNim.Size = new System.Drawing.Size(75, 23);
            this.submitNim.TabIndex = 4;
            this.submitNim.Text = "OK";
            this.submitNim.UseVisualStyleBackColor = true;
            this.submitNim.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Kegiatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tambah To Do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategori Kegiatan";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(368, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Tambahkan";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(75, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(663, 150);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delete To Do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id";
            // 
            // tbDid
            // 
            this.tbDid.Location = new System.Drawing.Point(368, 562);
            this.tbDid.Name = "tbDid";
            this.tbDid.Size = new System.Drawing.Size(100, 22);
            this.tbDid.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(487, 562);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 633);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Update To Do";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 699);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 699);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nama Kegiatan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(484, 699);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Kategori Kegiatan";
            // 
            // tbUid
            // 
            this.tbUid.Location = new System.Drawing.Point(235, 719);
            this.tbUid.Name = "tbUid";
            this.tbUid.ReadOnly = true;
            this.tbUid.Size = new System.Drawing.Size(100, 22);
            this.tbUid.TabIndex = 18;
            // 
            // tbUNamaK
            // 
            this.tbUNamaK.Location = new System.Drawing.Point(368, 719);
            this.tbUNamaK.Name = "tbUNamaK";
            this.tbUNamaK.Size = new System.Drawing.Size(100, 22);
            this.tbUNamaK.TabIndex = 19;
            // 
            // tbUkategori
            // 
            this.tbUkategori.Location = new System.Drawing.Point(499, 719);
            this.tbUkategori.Name = "tbUkategori";
            this.tbUkategori.Size = new System.Drawing.Size(100, 22);
            this.tbUkategori.TabIndex = 20;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(629, 719);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Delete";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 875);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbUkategori);
            this.Controls.Add(this.tbUNamaK);
            this.Controls.Add(this.tbUid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbDid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitNim);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNim);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNim;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.Button submitNim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbUid;
        private System.Windows.Forms.TextBox tbUNamaK;
        private System.Windows.Forms.TextBox tbUkategori;
        private System.Windows.Forms.Button btnUpdate;
    }
}

