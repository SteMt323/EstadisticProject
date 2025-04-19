namespace EstadisticProject.Views.ViewsModels.TableFrecuenciesLoads
{
    partial class TableContainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.intervals_nums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite_inferior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite_superior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca_clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_absoluta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_relativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_absoluta_acumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_relativa_acumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervals_nums,
            this.Limite_inferior,
            this.Limite_superior,
            this.Marca_clase,
            this.Frecuencia_absoluta,
            this.Frecuencia_relativa,
            this.Frecuencia_absoluta_acumulada,
            this.Frecuencia_relativa_acumulada});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(880, 452);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.TabStop = false;
            // 
            // intervals_nums
            // 
            this.intervals_nums.HeaderText = "K";
            this.intervals_nums.Name = "intervals_nums";
            this.intervals_nums.ReadOnly = true;
            // 
            // Limite_inferior
            // 
            this.Limite_inferior.HeaderText = "Li";
            this.Limite_inferior.Name = "Limite_inferior";
            this.Limite_inferior.ReadOnly = true;
            // 
            // Limite_superior
            // 
            this.Limite_superior.HeaderText = "Ls";
            this.Limite_superior.Name = "Limite_superior";
            this.Limite_superior.ReadOnly = true;
            // 
            // Marca_clase
            // 
            this.Marca_clase.HeaderText = "X";
            this.Marca_clase.Name = "Marca_clase";
            this.Marca_clase.ReadOnly = true;
            // 
            // Frecuencia_absoluta
            // 
            this.Frecuencia_absoluta.HeaderText = "fi";
            this.Frecuencia_absoluta.Name = "Frecuencia_absoluta";
            this.Frecuencia_absoluta.ReadOnly = true;
            // 
            // Frecuencia_relativa
            // 
            this.Frecuencia_relativa.HeaderText = "Fr";
            this.Frecuencia_relativa.Name = "Frecuencia_relativa";
            this.Frecuencia_relativa.ReadOnly = true;
            // 
            // Frecuencia_absoluta_acumulada
            // 
            this.Frecuencia_absoluta_acumulada.HeaderText = "Fi";
            this.Frecuencia_absoluta_acumulada.Name = "Frecuencia_absoluta_acumulada";
            this.Frecuencia_absoluta_acumulada.ReadOnly = true;
            // 
            // Frecuencia_relativa_acumulada
            // 
            this.Frecuencia_relativa_acumulada.HeaderText = "Fra";
            this.Frecuencia_relativa_acumulada.Name = "Frecuencia_relativa_acumulada";
            this.Frecuencia_relativa_acumulada.ReadOnly = true;
            // 
            // TableContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.dataGridView1);
            this.Name = "TableContainer";
            this.Size = new System.Drawing.Size(880, 455);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervals_nums;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite_inferior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite_superior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca_clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_absoluta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_relativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_absoluta_acumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_relativa_acumulada;
    }
}
