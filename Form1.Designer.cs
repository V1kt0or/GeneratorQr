﻿namespace GeneradorQr
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Subir = new System.Windows.Forms.Button();
            this.openFileSubirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.btn_QRconv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Qr_quantity = new System.Windows.Forms.ComboBox();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(23, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(498, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(81, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(304, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Subir
            // 
            this.btn_Subir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subir.Location = new System.Drawing.Point(391, 20);
            this.btn_Subir.Name = "btn_Subir";
            this.btn_Subir.Size = new System.Drawing.Size(130, 28);
            this.btn_Subir.TabIndex = 3;
            this.btn_Subir.Text = "Upload file";
            this.btn_Subir.UseVisualStyleBackColor = true;
            this.btn_Subir.Click += new System.EventHandler(this.btn_Subir_Click);
            // 
            // openFileSubirArchivo
            // 
            this.openFileSubirArchivo.FileName = "openFileDialog1";
            // 
            // btn_QRconv
            // 
            this.btn_QRconv.Enabled = false;
            this.btn_QRconv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QRconv.Location = new System.Drawing.Point(565, 181);
            this.btn_QRconv.Name = "btn_QRconv";
            this.btn_QRconv.Size = new System.Drawing.Size(148, 122);
            this.btn_QRconv.TabIndex = 4;
            this.btn_QRconv.Text = "Convert to QR";
            this.btn_QRconv.UseVisualStyleBackColor = true;
            this.btn_QRconv.Click += new System.EventHandler(this.btn_QRconv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity per page";
            // 
            // Qr_quantity
            // 
            this.Qr_quantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Qr_quantity.FormattingEnabled = true;
            this.Qr_quantity.Location = new System.Drawing.Point(582, 117);
            this.Qr_quantity.Name = "Qr_quantity";
            this.Qr_quantity.Size = new System.Drawing.Size(121, 21);
            this.Qr_quantity.TabIndex = 6;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 150;
            // 
            // Description
            // 
            this.Description.FillWeight = 200F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.Qr_quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_QRconv);
            this.Controls.Add(this.btn_Subir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Subir;
        private System.Windows.Forms.OpenFileDialog openFileSubirArchivo;
        private System.Windows.Forms.Button btn_QRconv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Qr_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

