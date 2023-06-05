namespace kanbankası
{
    partial class FrmBagıscılistesi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkangrupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagıscıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kANBANKASIDataSet = new kanbankası.KANBANKASIDataSet();
            this.bagıscıTableAdapter = new kanbankası.KANBANKASIDataSetTableAdapters.BagıscıTableAdapter();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TxtKanGrup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtYas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.Txtisimsoyisim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagıscıBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 56);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "KAN BANKASI YÖNETİM SİSTEMİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(268, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "BAĞIŞÇI LİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidDataGridViewTextBoxColumn,
            this.badsoyadDataGridViewTextBoxColumn,
            this.byasDataGridViewTextBoxColumn,
            this.bcinsiyetDataGridViewTextBoxColumn,
            this.btelefonDataGridViewTextBoxColumn,
            this.badresDataGridViewTextBoxColumn,
            this.bkangrupDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bagıscıBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 214);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "bid";
            this.bidDataGridViewTextBoxColumn.HeaderText = "bid";
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // badsoyadDataGridViewTextBoxColumn
            // 
            this.badsoyadDataGridViewTextBoxColumn.DataPropertyName = "badsoyad";
            this.badsoyadDataGridViewTextBoxColumn.HeaderText = "badsoyad";
            this.badsoyadDataGridViewTextBoxColumn.Name = "badsoyadDataGridViewTextBoxColumn";
            // 
            // byasDataGridViewTextBoxColumn
            // 
            this.byasDataGridViewTextBoxColumn.DataPropertyName = "byas";
            this.byasDataGridViewTextBoxColumn.HeaderText = "byas";
            this.byasDataGridViewTextBoxColumn.Name = "byasDataGridViewTextBoxColumn";
            // 
            // bcinsiyetDataGridViewTextBoxColumn
            // 
            this.bcinsiyetDataGridViewTextBoxColumn.DataPropertyName = "bcinsiyet";
            this.bcinsiyetDataGridViewTextBoxColumn.HeaderText = "bcinsiyet";
            this.bcinsiyetDataGridViewTextBoxColumn.Name = "bcinsiyetDataGridViewTextBoxColumn";
            // 
            // btelefonDataGridViewTextBoxColumn
            // 
            this.btelefonDataGridViewTextBoxColumn.DataPropertyName = "btelefon";
            this.btelefonDataGridViewTextBoxColumn.HeaderText = "btelefon";
            this.btelefonDataGridViewTextBoxColumn.Name = "btelefonDataGridViewTextBoxColumn";
            // 
            // badresDataGridViewTextBoxColumn
            // 
            this.badresDataGridViewTextBoxColumn.DataPropertyName = "badres";
            this.badresDataGridViewTextBoxColumn.HeaderText = "badres";
            this.badresDataGridViewTextBoxColumn.Name = "badresDataGridViewTextBoxColumn";
            // 
            // bkangrupDataGridViewTextBoxColumn
            // 
            this.bkangrupDataGridViewTextBoxColumn.DataPropertyName = "bkangrup";
            this.bkangrupDataGridViewTextBoxColumn.HeaderText = "bkangrup";
            this.bkangrupDataGridViewTextBoxColumn.Name = "bkangrupDataGridViewTextBoxColumn";
            // 
            // bagıscıBindingSource
            // 
            this.bagıscıBindingSource.DataMember = "Bagıscı";
            this.bagıscıBindingSource.DataSource = this.kANBANKASIDataSet;
            // 
            // kANBANKASIDataSet
            // 
            this.kANBANKASIDataSet.DataSetName = "KANBANKASIDataSet";
            this.kANBANKASIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bagıscıTableAdapter
            // 
            this.bagıscıTableAdapter.ClearBeforeFill = true;
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Red;
            this.BtnSil.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(216, 594);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(115, 34);
            this.BtnSil.TabIndex = 17;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Red;
            this.BtnGuncelle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(398, 594);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(115, 34);
            this.BtnGuncelle.TabIndex = 18;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtKanGrup
            // 
            this.TxtKanGrup.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKanGrup.Location = new System.Drawing.Point(157, 253);
            this.TxtKanGrup.Name = "TxtKanGrup";
            this.TxtKanGrup.Size = new System.Drawing.Size(334, 22);
            this.TxtKanGrup.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "YAŞ:";
            // 
            // TxtYas
            // 
            this.TxtYas.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYas.Location = new System.Drawing.Point(155, 172);
            this.TxtYas.Name = "TxtYas";
            this.TxtYas.Size = new System.Drawing.Size(334, 22);
            this.TxtYas.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(54, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 58;
            this.label8.Text = "CİNSİYET:";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "KADIN ",
            "ERKEK"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(155, 227);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(334, 21);
            this.CmbCinsiyet.TabIndex = 57;
            // 
            // RchAdres
            // 
            this.RchAdres.Location = new System.Drawing.Point(155, 281);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(334, 73);
            this.RchAdres.TabIndex = 56;
            this.RchAdres.Text = "";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(155, 200);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(334, 20);
            this.MskTelefon.TabIndex = 55;
            // 
            // Txtisimsoyisim
            // 
            this.Txtisimsoyisim.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtisimsoyisim.Location = new System.Drawing.Point(157, 144);
            this.Txtisimsoyisim.Name = "Txtisimsoyisim";
            this.Txtisimsoyisim.Size = new System.Drawing.Size(334, 22);
            this.Txtisimsoyisim.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(36, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 53;
            this.label7.Text = "KAN GRUBU:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(72, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "ADRES:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(63, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "TELEFON:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "AD/SOYAD:";
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtId.Location = new System.Drawing.Point(157, 116);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(334, 22);
            this.TxtId.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(52, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 63;
            this.label9.Text = "BAGIŞÇI ID:";
            // 
            // FrmBagıscılistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 640);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtKanGrup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtYas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.RchAdres);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.Txtisimsoyisim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmBagıscılistesi";
            this.Text = "BAĞIŞÇI LİSTESİ";
            this.Load += new System.EventHandler(this.Bagıscılistesi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagıscıBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KANBANKASIDataSet kANBANKASIDataSet;
        private System.Windows.Forms.BindingSource bagıscıBindingSource;
        private KANBANKASIDataSetTableAdapters.BagıscıTableAdapter bagıscıTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn badsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn badresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkangrupDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TxtKanGrup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtYas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.RichTextBox RchAdres;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TextBox Txtisimsoyisim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label9;
    }
}