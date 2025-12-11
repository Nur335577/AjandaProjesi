namespace ornek3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxgorev = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saatgünDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pazartesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.çarşambaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perşembeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cumartesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajandatableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ajandaDataSet = new ornek3.ajandaDataSet();
            this.ajanda_tableTableAdapter = new ornek3.ajandaDataSetTableAdapters.ajanda_tableTableAdapter();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonguncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxsaat = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGun = new System.Windows.Forms.ComboBox();
            this.buttonlistele = new System.Windows.Forms.Button();
            this.buttontemizle = new System.Windows.Forms.Button();
            this.radioOnemli = new System.Windows.Forms.RadioButton();
            this.radioTamam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandatableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "---------Ajanda-------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "görev gir :";
            // 
            // textBoxgorev
            // 
            this.textBoxgorev.Location = new System.Drawing.Point(12, 38);
            this.textBoxgorev.Multiline = true;
            this.textBoxgorev.Name = "textBoxgorev";
            this.textBoxgorev.Size = new System.Drawing.Size(190, 77);
            this.textBoxgorev.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saatgünDataGridViewTextBoxColumn,
            this.pazartesiDataGridViewTextBoxColumn,
            this.salıDataGridViewTextBoxColumn,
            this.çarşambaDataGridViewTextBoxColumn,
            this.perşembeDataGridViewTextBoxColumn,
            this.cumaDataGridViewTextBoxColumn,
            this.cumartesiDataGridViewTextBoxColumn,
            this.pazarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ajandatableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(212, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 403);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // saatgünDataGridViewTextBoxColumn
            // 
            this.saatgünDataGridViewTextBoxColumn.DataPropertyName = "saat/gün";
            this.saatgünDataGridViewTextBoxColumn.HeaderText = "saat/gün";
            this.saatgünDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saatgünDataGridViewTextBoxColumn.Name = "saatgünDataGridViewTextBoxColumn";
            this.saatgünDataGridViewTextBoxColumn.Width = 125;
            // 
            // pazartesiDataGridViewTextBoxColumn
            // 
            this.pazartesiDataGridViewTextBoxColumn.DataPropertyName = "pazartesi";
            this.pazartesiDataGridViewTextBoxColumn.HeaderText = "pazartesi";
            this.pazartesiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pazartesiDataGridViewTextBoxColumn.Name = "pazartesiDataGridViewTextBoxColumn";
            this.pazartesiDataGridViewTextBoxColumn.Width = 125;
            // 
            // salıDataGridViewTextBoxColumn
            // 
            this.salıDataGridViewTextBoxColumn.DataPropertyName = "salı";
            this.salıDataGridViewTextBoxColumn.HeaderText = "salı";
            this.salıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salıDataGridViewTextBoxColumn.Name = "salıDataGridViewTextBoxColumn";
            this.salıDataGridViewTextBoxColumn.Width = 125;
            // 
            // çarşambaDataGridViewTextBoxColumn
            // 
            this.çarşambaDataGridViewTextBoxColumn.DataPropertyName = "çarşamba";
            this.çarşambaDataGridViewTextBoxColumn.HeaderText = "çarşamba";
            this.çarşambaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.çarşambaDataGridViewTextBoxColumn.Name = "çarşambaDataGridViewTextBoxColumn";
            this.çarşambaDataGridViewTextBoxColumn.Width = 125;
            // 
            // perşembeDataGridViewTextBoxColumn
            // 
            this.perşembeDataGridViewTextBoxColumn.DataPropertyName = "perşembe";
            this.perşembeDataGridViewTextBoxColumn.HeaderText = "perşembe";
            this.perşembeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perşembeDataGridViewTextBoxColumn.Name = "perşembeDataGridViewTextBoxColumn";
            this.perşembeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cumaDataGridViewTextBoxColumn
            // 
            this.cumaDataGridViewTextBoxColumn.DataPropertyName = "cuma";
            this.cumaDataGridViewTextBoxColumn.HeaderText = "cuma";
            this.cumaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cumaDataGridViewTextBoxColumn.Name = "cumaDataGridViewTextBoxColumn";
            this.cumaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cumartesiDataGridViewTextBoxColumn
            // 
            this.cumartesiDataGridViewTextBoxColumn.DataPropertyName = "cumartesi";
            this.cumartesiDataGridViewTextBoxColumn.HeaderText = "cumartesi";
            this.cumartesiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cumartesiDataGridViewTextBoxColumn.Name = "cumartesiDataGridViewTextBoxColumn";
            this.cumartesiDataGridViewTextBoxColumn.Width = 125;
            // 
            // pazarDataGridViewTextBoxColumn
            // 
            this.pazarDataGridViewTextBoxColumn.DataPropertyName = "pazar";
            this.pazarDataGridViewTextBoxColumn.HeaderText = "pazar";
            this.pazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pazarDataGridViewTextBoxColumn.Name = "pazarDataGridViewTextBoxColumn";
            this.pazarDataGridViewTextBoxColumn.Width = 125;
            // 
            // ajandatableBindingSource
            // 
            this.ajandatableBindingSource.DataMember = "ajanda_table";
            this.ajandatableBindingSource.DataSource = this.ajandaDataSet;
            // 
            // ajandaDataSet
            // 
            this.ajandaDataSet.DataSetName = "ajandaDataSet";
            this.ajandaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ajanda_tableTableAdapter
            // 
            this.ajanda_tableTableAdapter.ClearBeforeFill = true;
            // 
            // buttonekle
            // 
            this.buttonekle.ForeColor = System.Drawing.Color.Black;
            this.buttonekle.Location = new System.Drawing.Point(11, 236);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(160, 37);
            this.buttonekle.TabIndex = 4;
            this.buttonekle.Text = "ekle";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(12, 279);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(160, 37);
            this.buttonsil.TabIndex = 5;
            this.buttonsil.Text = "sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonguncelle
            // 
            this.buttonguncelle.Location = new System.Drawing.Point(12, 322);
            this.buttonguncelle.Name = "buttonguncelle";
            this.buttonguncelle.Size = new System.Drawing.Size(160, 37);
            this.buttonguncelle.TabIndex = 6;
            this.buttonguncelle.Text = "güncelle";
            this.buttonguncelle.UseVisualStyleBackColor = true;
            this.buttonguncelle.Click += new System.EventHandler(this.buttonguncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "saat gir";
            // 
            // maskedTextBoxsaat
            // 
            this.maskedTextBoxsaat.Location = new System.Drawing.Point(12, 148);
            this.maskedTextBoxsaat.Mask = "00:00:00";
            this.maskedTextBoxsaat.Name = "maskedTextBoxsaat";
            this.maskedTextBoxsaat.Size = new System.Drawing.Size(100, 27);
            this.maskedTextBoxsaat.TabIndex = 8;
            this.maskedTextBoxsaat.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "gün seç:";
            // 
            // comboBoxGun
            // 
            this.comboBoxGun.FormattingEnabled = true;
            this.comboBoxGun.Items.AddRange(new object[] {
            "pazartesi",
            "salı",
            "çarşamba",
            "perşembe",
            "cuma",
            "cumartesi",
            "pazar"});
            this.comboBoxGun.Location = new System.Drawing.Point(11, 206);
            this.comboBoxGun.Name = "comboBoxGun";
            this.comboBoxGun.Size = new System.Drawing.Size(121, 28);
            this.comboBoxGun.TabIndex = 10;
            // 
            // buttonlistele
            // 
            this.buttonlistele.Location = new System.Drawing.Point(11, 365);
            this.buttonlistele.Name = "buttonlistele";
            this.buttonlistele.Size = new System.Drawing.Size(160, 37);
            this.buttonlistele.TabIndex = 11;
            this.buttonlistele.Text = "listele";
            this.buttonlistele.UseVisualStyleBackColor = true;
            this.buttonlistele.Click += new System.EventHandler(this.buttonlistele_Click);
            // 
            // buttontemizle
            // 
            this.buttontemizle.Location = new System.Drawing.Point(12, 408);
            this.buttontemizle.Name = "buttontemizle";
            this.buttontemizle.Size = new System.Drawing.Size(160, 37);
            this.buttontemizle.TabIndex = 12;
            this.buttontemizle.Text = "temizle";
            this.buttontemizle.UseVisualStyleBackColor = true;
            this.buttontemizle.Click += new System.EventHandler(this.buttontemizle_Click);
            // 
            // radioOnemli
            // 
            this.radioOnemli.AutoSize = true;
            this.radioOnemli.Location = new System.Drawing.Point(540, 9);
            this.radioOnemli.Name = "radioOnemli";
            this.radioOnemli.Size = new System.Drawing.Size(83, 24);
            this.radioOnemli.TabIndex = 13;
            this.radioOnemli.TabStop = true;
            this.radioOnemli.Text = "Önemli";
            this.radioOnemli.UseVisualStyleBackColor = true;
            this.radioOnemli.CheckedChanged += new System.EventHandler(this.radioOnemli_CheckedChanged);
            // 
            // radioTamam
            // 
            this.radioTamam.AutoSize = true;
            this.radioTamam.Location = new System.Drawing.Point(629, 9);
            this.radioTamam.Name = "radioTamam";
            this.radioTamam.Size = new System.Drawing.Size(121, 24);
            this.radioTamam.TabIndex = 14;
            this.radioTamam.TabStop = true;
            this.radioTamam.Text = "Tamamlandı";
            this.radioTamam.UseVisualStyleBackColor = true;
            this.radioTamam.CheckedChanged += new System.EventHandler(this.radioTamam_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1050, 444);
            this.Controls.Add(this.radioTamam);
            this.Controls.Add(this.radioOnemli);
            this.Controls.Add(this.buttontemizle);
            this.Controls.Add(this.buttonlistele);
            this.Controls.Add(this.comboBoxGun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBoxsaat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonguncelle);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxgorev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandatableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxgorev;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ajandaDataSet ajandaDataSet;
        private System.Windows.Forms.BindingSource ajandatableBindingSource;
        private ajandaDataSetTableAdapters.ajanda_tableTableAdapter ajanda_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatgünDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pazartesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn çarşambaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perşembeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cumartesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonguncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxsaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGun;
        private System.Windows.Forms.Button buttonlistele;
        private System.Windows.Forms.Button buttontemizle;
        private System.Windows.Forms.RadioButton radioOnemli;
        private System.Windows.Forms.RadioButton radioTamam;
    }
}

