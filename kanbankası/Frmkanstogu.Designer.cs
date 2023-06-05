namespace kanbankası
{
    partial class Frmkanstogu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kangrupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanstokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanStokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kANBANKASIDataSet2 = new kanbankası.KANBANKASIDataSet2();
            this.kanStokTableAdapter = new kanbankası.KANBANKASIDataSet2TableAdapters.KanStokTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanStokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(281, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "KAN STOĞU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 56);
            this.panel2.TabIndex = 10;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kangrupDataGridViewTextBoxColumn,
            this.kanstokDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kanStokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(69, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 226);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kangrupDataGridViewTextBoxColumn
            // 
            this.kangrupDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kangrupDataGridViewTextBoxColumn.DataPropertyName = "kangrup";
            this.kangrupDataGridViewTextBoxColumn.HeaderText = "kangrup";
            this.kangrupDataGridViewTextBoxColumn.Name = "kangrupDataGridViewTextBoxColumn";
            // 
            // kanstokDataGridViewTextBoxColumn
            // 
            this.kanstokDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kanstokDataGridViewTextBoxColumn.DataPropertyName = "kanstok";
            this.kanstokDataGridViewTextBoxColumn.HeaderText = "kanstok";
            this.kanstokDataGridViewTextBoxColumn.Name = "kanstokDataGridViewTextBoxColumn";
            // 
            // kanStokBindingSource
            // 
            this.kanStokBindingSource.DataMember = "KanStok";
            this.kanStokBindingSource.DataSource = this.kANBANKASIDataSet2;
            // 
            // kANBANKASIDataSet2
            // 
            this.kANBANKASIDataSet2.DataSetName = "KANBANKASIDataSet2";
            this.kANBANKASIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kanStokTableAdapter
            // 
            this.kanStokTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kanbankası.Properties.Resources.kan1;
            this.pictureBox1.Location = new System.Drawing.Point(288, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frmkanstogu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(723, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frmkanstogu";
            this.Text = "KAN STOĞU";
            this.Load += new System.EventHandler(this.kanstogu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanStokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANBANKASIDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KANBANKASIDataSet2 kANBANKASIDataSet2;
        private System.Windows.Forms.BindingSource kanStokBindingSource;
        private KANBANKASIDataSet2TableAdapters.KanStokTableAdapter kanStokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kangrupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanstokDataGridViewTextBoxColumn;
    }
}