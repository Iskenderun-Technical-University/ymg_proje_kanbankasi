namespace kanbankası
{
    partial class FrmBagıscı
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txtisim = new System.Windows.Forms.TextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtYas = new System.Windows.Forms.TextBox();
            this.kANBANKASIDataSet5 = new kanbankası.KANBANKASIDataSet5();
            this.bagıscıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kANBANKASIDataSet6 = new kanbankası.KANBANKASIDataSet6();
            this.bagıscıBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bagıscıTableAdapter1 = new kanbankası.KANBANKASIDataSet6TableAdapters.BagıscıTableAdapter();
            this.kANBANKASIDataSet7 = new kanbankası.KANBANKASIDataSet7();
            this.cinsiyetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinsiyetTableAdapter = new kanbankası.KANBANKASIDataSet7TableAdapters.cinsiyetTableAdapter();
            this.kANBANKASIDataSet8 = new kanbankası.KANBANKASIDataSet8();
            this.kANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kANTableAdapter = new kanbankası.KANBANKASIDataSet8TableAdapters.KANTableAdapter();
            this.TxtKanGrup = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagıscıBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagıscıBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinsiyetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 56);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 14);
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
            this.label2.Location = new System.Drawing.Point(164, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAĞIŞÇI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "AD/SOYAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "TELEFON:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(94, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "ADRES:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(56, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "KAN GRUBU:";
            // 
            // Txtisim
            // 
            this.Txtisim.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtisim.Location = new System.Drawing.Point(176, 250);
            this.Txtisim.Name = "Txtisim";
            this.Txtisim.Size = new System.Drawing.Size(334, 22);
            this.Txtisim.TabIndex = 10;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(176, 339);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(334, 20);
            this.MskTelefon.TabIndex = 12;
            // 
            // RchAdres
            // 
            this.RchAdres.Location = new System.Drawing.Point(176, 387);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(334, 73);
            this.RchAdres.TabIndex = 14;
            this.RchAdres.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(289, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(176, 312);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(334, 21);
            this.CmbCinsiyet.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(80, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "CİNSİYET:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kanbankası.Properties.Resources.bagıs;
            this.pictureBox1.Location = new System.Drawing.Point(344, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(115, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "YAŞ:";
            // 
            // TxtYas
            // 
            this.TxtYas.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYas.Location = new System.Drawing.Point(176, 278);
            this.TxtYas.Name = "TxtYas";
            this.TxtYas.Size = new System.Drawing.Size(334, 22);
            this.TxtYas.TabIndex = 19;
            // 
            // kANBANKASIDataSet5
            // 
            this.kANBANKASIDataSet5.DataSetName = "KANBANKASIDataSet5";
            this.kANBANKASIDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bagıscıBindingSource
            // 
            this.bagıscıBindingSource.DataMember = "Bagıscı";
            this.bagıscıBindingSource.DataSource = this.kANBANKASIDataSet5;
            // 
            // kANBANKASIDataSet6
            // 
            this.kANBANKASIDataSet6.DataSetName = "KANBANKASIDataSet6";
            this.kANBANKASIDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bagıscıBindingSource1
            // 
            this.bagıscıBindingSource1.DataMember = "Bagıscı";
            this.bagıscıBindingSource1.DataSource = this.kANBANKASIDataSet6;
            // 
            // bagıscıTableAdapter1
            // 
            this.bagıscıTableAdapter1.ClearBeforeFill = true;
            // 
            // kANBANKASIDataSet7
            // 
            this.kANBANKASIDataSet7.DataSetName = "KANBANKASIDataSet7";
            this.kANBANKASIDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cinsiyetBindingSource
            // 
            this.cinsiyetBindingSource.DataMember = "cinsiyet";
            this.cinsiyetBindingSource.DataSource = this.kANBANKASIDataSet7;
            // 
            // cinsiyetTableAdapter
            // 
            this.cinsiyetTableAdapter.ClearBeforeFill = true;
            // 
            // kANBANKASIDataSet8
            // 
            this.kANBANKASIDataSet8.DataSetName = "KANBANKASIDataSet8";
            this.kANBANKASIDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kANBindingSource
            // 
            this.kANBindingSource.DataMember = "KAN";
            this.kANBindingSource.DataSource = this.kANBANKASIDataSet8;
            // 
            // kANTableAdapter
            // 
            this.kANTableAdapter.ClearBeforeFill = true;
            // 
            // TxtKanGrup
            // 
            this.TxtKanGrup.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKanGrup.Location = new System.Drawing.Point(176, 362);
            this.TxtKanGrup.Name = "TxtKanGrup";
            this.TxtKanGrup.Size = new System.Drawing.Size(334, 22);
            this.TxtKanGrup.TabIndex = 20;
            this.TxtKanGrup.TextChanged += new System.EventHandler(this.TxtKanGrup_TextChanged);
            // 
            // FrmBagıscı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(712, 512);
            this.Controls.Add(this.TxtKanGrup);
            this.Controls.Add(this.TxtYas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RchAdres);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.Txtisim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmBagıscı";
            this.Text = "BAĞIŞÇI";
            this.Load += new System.EventHandler(this.FrmBagıscı_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagıscıBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagıscıBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinsiyetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txtisim;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.RichTextBox RchAdres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtYas;
        private KANBANKASIDataSet5 kANBANKASIDataSet5;
        private System.Windows.Forms.BindingSource bagıscıBindingSource;
        private KANBANKASIDataSet6 kANBANKASIDataSet6;
        private System.Windows.Forms.BindingSource bagıscıBindingSource1;
        private KANBANKASIDataSet6TableAdapters.BagıscıTableAdapter bagıscıTableAdapter1;
        private KANBANKASIDataSet7 kANBANKASIDataSet7;
        private System.Windows.Forms.BindingSource cinsiyetBindingSource;
        private KANBANKASIDataSet7TableAdapters.cinsiyetTableAdapter cinsiyetTableAdapter;
        private KANBANKASIDataSet8 kANBANKASIDataSet8;
        private System.Windows.Forms.BindingSource kANBindingSource;
        private KANBANKASIDataSet8TableAdapters.KANTableAdapter kANTableAdapter;
        private System.Windows.Forms.TextBox TxtKanGrup;
    }
}