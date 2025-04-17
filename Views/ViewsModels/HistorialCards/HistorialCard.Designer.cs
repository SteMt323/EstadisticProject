namespace EstadisticProject.Views.ViewsModels.HistorialCards
{
    partial class HistorialCard
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
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_accion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_estado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_fecha
            // 
            this.label_fecha.BackColor = System.Drawing.Color.Transparent;
            this.label_fecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.ForeColor = System.Drawing.Color.DimGray;
            this.label_fecha.Location = new System.Drawing.Point(13, 16);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(132, 35);
            this.label_fecha.TabIndex = 7;
            this.label_fecha.Text = "FECHA";
            // 
            // label_accion
            // 
            this.label_accion.BackColor = System.Drawing.Color.Transparent;
            this.label_accion.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accion.ForeColor = System.Drawing.Color.DimGray;
            this.label_accion.Location = new System.Drawing.Point(13, 63);
            this.label_accion.Name = "label_accion";
            this.label_accion.Size = new System.Drawing.Size(506, 73);
            this.label_accion.TabIndex = 8;
            this.label_accion.Text = "ACCION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::EstadisticProject.Properties.Resources.mix_color_abstract_gradient_texture_with_mixed_colors_9930396;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label_estado);
            this.panel1.Controls.Add(this.label_accion);
            this.panel1.Controls.Add(this.label_fecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 150);
            this.panel1.TabIndex = 13;
            // 
            // label_estado
            // 
            this.label_estado.BackColor = System.Drawing.Color.Transparent;
            this.label_estado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estado.ForeColor = System.Drawing.Color.DimGray;
            this.label_estado.Location = new System.Drawing.Point(356, 16);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(163, 25);
            this.label_estado.TabIndex = 9;
            this.label_estado.Text = "ESTADO";
            // 
            // HistorialCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "HistorialCard";
            this.Size = new System.Drawing.Size(537, 150);
            this.Load += new System.EventHandler(this.HistorialCard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_accion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_estado;
    }
}
