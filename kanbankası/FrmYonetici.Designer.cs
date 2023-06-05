namespace kanbankası
{
    partial class FrmYonetici
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.TxtSıfre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kANBANKASIDataSet11 = new kanbankası.KANBANKASIDataSet11();
            this.kullanıcıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanıcıTableAdapter = new kanbankası.KANBANKASIDataSet11TableAdapters.KullanıcıTableAdapter();
            this.yoneticiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcısifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSıl = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiidDataGridViewTextBoxColumn,
            this.kullanıcıDataGridViewTextBoxColumn,
            this.kullanıcısifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullanıcıBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "YÖNETİCİ ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "KULLANICI ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ŞİFRE:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(176, 84);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(249, 20);
            this.TxtId.TabIndex = 4;
            // 
            // TxtKullanıcıAdı
            // 
            this.TxtKullanıcıAdı.Location = new System.Drawing.Point(176, 120);
            this.TxtKullanıcıAdı.Name = "TxtKullanıcıAdı";
            this.TxtKullanıcıAdı.Size = new System.Drawing.Size(249, 20);
            this.TxtKullanıcıAdı.TabIndex = 5;
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.Location = new System.Drawing.Point(176, 152);
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.Size = new System.Drawing.Size(249, 20);
            this.TxtSıfre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(183, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(82, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "KAN BAĞIŞI YÖNETİCİ SİSTEMİ \r\n";
            // 
            // kANBANKASIDataSet11
            // 
            this.kANBANKASIDataSet11.DataSetName = "KANBANKASIDataSet11";
            this.kANBANKASIDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanıcıBindingSource
            // 
            this.kullanıcıBindingSource.DataMember = "Kullanıcı";
            this.kullanıcıBindingSource.DataSource = this.kANBANKASIDataSet11;
            // 
            // kullanıcıTableAdapter
            // 
            this.kullanıcıTableAdapter.ClearBeforeFill = true;
            // 
            // yoneticiidDataGridViewTextBoxColumn
            // 
            this.yoneticiidDataGridViewTextBoxColumn.DataPropertyName = "yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.HeaderText = "yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.Name = "yoneticiidDataGridViewTextBoxColumn";
            this.yoneticiidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullanıcıDataGridViewTextBoxColumn
            // 
            this.kullanıcıDataGridViewTextBoxColumn.DataPropertyName = "kullanıcı";
            this.kullanıcıDataGridViewTextBoxColumn.HeaderText = "kullanıcı";
            this.kullanıcıDataGridViewTextBoxColumn.Name = "kullanıcıDataGridViewTextBoxColumn";
            // 
            // kullanıcısifreDataGridViewTextBoxColumn
            // 
            this.kullanıcısifreDataGridViewTextBoxColumn.DataPropertyName = "kullanıcısifre";
            this.kullanıcısifreDataGridViewTextBoxColumn.HeaderText = "kullanıcısifre";
            this.kullanıcısifreDataGridViewTextBoxColumn.Name = "kullanıcısifreDataGridViewTextBoxColumn";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.Red;
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(54, 199);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(115, 34);
            this.BtnKaydet.TabIndex = 29;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSıl
            // 
            this.BtnSıl.BackColor = System.Drawing.Color.Red;
            this.BtnSıl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSıl.Location = new System.Drawing.Point(186, 199);
            this.BtnSıl.Name = "BtnSıl";
            this.BtnSıl.Size = new System.Drawing.Size(115, 34);
            this.BtnSıl.TabIndex = 30;
            this.BtnSıl.Text = "SİL";
            this.BtnSıl.UseVisualStyleBackColor = false;
            this.BtnSıl.Click += new System.EventHandler(this.BtnSıl_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Red;
            this.BtnGuncelle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(319, 199);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(115, 34);
            this.BtnGuncelle.TabIndex = 31;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // FrmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(474, 484);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSıl);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSıfre);
            this.Controls.Add(this.TxtKullanıcıAdı);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmYonetici";
            this.Text = "FrmYonetici";
            this.Load += new System.EventHandler(this.FrmYonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtKullanıcıAdı;
        private System.Windows.Forms.TextBox TxtSıfre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private KANBANKASIDataSet11 kANBANKASIDataSet11;
        private System.Windows.Forms.BindingSource kullanıcıBindingSource;
        private KANBANKASIDataSet11TableAdapters.KullanıcıTableAdapter kullanıcıTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcısifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSıl;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}