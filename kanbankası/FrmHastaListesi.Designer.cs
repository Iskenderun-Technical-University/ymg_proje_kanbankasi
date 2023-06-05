namespace kanbankası
{
    partial class FrmHastaListesi
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
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hadsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hyasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.htelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hcinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hkangrupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kANBANKASIDataSet1 = new kanbankası.KANBANKASIDataSet1();
            this.hastaTableAdapter = new kanbankası.KANBANKASIDataSet1TableAdapters.HastaTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.Txtİd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(110, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "HASTA LİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hidDataGridViewTextBoxColumn,
            this.hadsoyadDataGridViewTextBoxColumn,
            this.hyasDataGridViewTextBoxColumn,
            this.htelefonDataGridViewTextBoxColumn,
            this.hcinsiyetDataGridViewTextBoxColumn,
            this.hkangrupDataGridViewTextBoxColumn,
            this.hadresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 198);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hidDataGridViewTextBoxColumn
            // 
            this.hidDataGridViewTextBoxColumn.DataPropertyName = "hid";
            this.hidDataGridViewTextBoxColumn.HeaderText = "hid";
            this.hidDataGridViewTextBoxColumn.Name = "hidDataGridViewTextBoxColumn";
            this.hidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hadsoyadDataGridViewTextBoxColumn
            // 
            this.hadsoyadDataGridViewTextBoxColumn.DataPropertyName = "hadsoyad";
            this.hadsoyadDataGridViewTextBoxColumn.HeaderText = "hadsoyad";
            this.hadsoyadDataGridViewTextBoxColumn.Name = "hadsoyadDataGridViewTextBoxColumn";
            // 
            // hyasDataGridViewTextBoxColumn
            // 
            this.hyasDataGridViewTextBoxColumn.DataPropertyName = "hyas";
            this.hyasDataGridViewTextBoxColumn.HeaderText = "hyas";
            this.hyasDataGridViewTextBoxColumn.Name = "hyasDataGridViewTextBoxColumn";
            // 
            // htelefonDataGridViewTextBoxColumn
            // 
            this.htelefonDataGridViewTextBoxColumn.DataPropertyName = "htelefon";
            this.htelefonDataGridViewTextBoxColumn.HeaderText = "htelefon";
            this.htelefonDataGridViewTextBoxColumn.Name = "htelefonDataGridViewTextBoxColumn";
            // 
            // hcinsiyetDataGridViewTextBoxColumn
            // 
            this.hcinsiyetDataGridViewTextBoxColumn.DataPropertyName = "hcinsiyet";
            this.hcinsiyetDataGridViewTextBoxColumn.HeaderText = "hcinsiyet";
            this.hcinsiyetDataGridViewTextBoxColumn.Name = "hcinsiyetDataGridViewTextBoxColumn";
            // 
            // hkangrupDataGridViewTextBoxColumn
            // 
            this.hkangrupDataGridViewTextBoxColumn.DataPropertyName = "hkangrup";
            this.hkangrupDataGridViewTextBoxColumn.HeaderText = "hkangrup";
            this.hkangrupDataGridViewTextBoxColumn.Name = "hkangrupDataGridViewTextBoxColumn";
            // 
            // hadresDataGridViewTextBoxColumn
            // 
            this.hadresDataGridViewTextBoxColumn.DataPropertyName = "hadres";
            this.hadresDataGridViewTextBoxColumn.HeaderText = "hadres";
            this.hadresDataGridViewTextBoxColumn.Name = "hadresDataGridViewTextBoxColumn";
            // 
            // hastaBindingSource
            // 
            this.hastaBindingSource.DataMember = "Hasta";
            this.hastaBindingSource.DataSource = this.kANBANKASIDataSet1;
            // 
            // kANBANKASIDataSet1
            // 
            this.kANBANKASIDataSet1.DataSetName = "KANBANKASIDataSet1";
            this.kANBANKASIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 56);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "KAN BANKASI YÖNETİM SİSTEMİ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(233, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(382, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtKanGrup
            // 
            this.TxtKanGrup.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKanGrup.Location = new System.Drawing.Point(129, 246);
            this.TxtKanGrup.Name = "TxtKanGrup";
            this.TxtKanGrup.Size = new System.Drawing.Size(334, 22);
            this.TxtKanGrup.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(77, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "YAŞ:";
            // 
            // TxtYas
            // 
            this.TxtYas.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYas.Location = new System.Drawing.Point(127, 165);
            this.TxtYas.Name = "TxtYas";
            this.TxtYas.Size = new System.Drawing.Size(334, 22);
            this.TxtYas.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(26, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "CİNSİYET:";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "KADIN ",
            "ERKEK"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(127, 220);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(334, 21);
            this.CmbCinsiyet.TabIndex = 45;
            // 
            // RchAdres
            // 
            this.RchAdres.Location = new System.Drawing.Point(127, 274);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(334, 73);
            this.RchAdres.TabIndex = 44;
            this.RchAdres.Text = "";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(127, 193);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(334, 20);
            this.MskTelefon.TabIndex = 43;
            // 
            // Txtisimsoyisim
            // 
            this.Txtisimsoyisim.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtisimsoyisim.Location = new System.Drawing.Point(129, 137);
            this.Txtisimsoyisim.Name = "Txtisimsoyisim";
            this.Txtisimsoyisim.Size = new System.Drawing.Size(334, 22);
            this.Txtisimsoyisim.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "KAN GRUBU:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(44, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "ADRES:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "TELEFON:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "AD/SOYAD:";
            // 
            // Txtİd
            // 
            this.Txtİd.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtİd.Location = new System.Drawing.Point(129, 109);
            this.Txtİd.Name = "Txtİd";
            this.Txtİd.Size = new System.Drawing.Size(334, 22);
            this.Txtİd.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(27, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 51;
            this.label9.Text = "HASTA ID:";
            // 
            // FrmHastaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(755, 612);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txtİd);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmHastaListesi";
            this.Text = "Hasta Listesi";
            this.Load += new System.EventHandler(this.HastaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KANBANKASIDataSet1 kANBANKASIDataSet1;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private KANBANKASIDataSet1TableAdapters.HastaTableAdapter hastaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hadsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hyasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn htelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hcinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hkangrupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.TextBox Txtİd;
        private System.Windows.Forms.Label label9;
    }
}