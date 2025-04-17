﻿namespace EstadisticProject.Views.ViewsModels.HistorialCards
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
            this.label_estado = new System.Windows.Forms.Label();
            this.panel_fecha = new System.Windows.Forms.Panel();
            this.panel_accion = new System.Windows.Forms.Panel();
            this.panel_estado = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_fecha.SuspendLayout();
            this.panel_accion.SuspendLayout();
            this.panel_estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_fecha
            // 
            this.label_fecha.BackColor = System.Drawing.Color.Transparent;
            this.label_fecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label_fecha.Location = new System.Drawing.Point(3, 0);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(132, 35);
            this.label_fecha.TabIndex = 7;
            this.label_fecha.Text = "FECHA";
            // 
            // label_accion
            // 
            this.label_accion.BackColor = System.Drawing.Color.Transparent;
            this.label_accion.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label_accion.Location = new System.Drawing.Point(0, 0);
            this.label_accion.Name = "label_accion";
            this.label_accion.Size = new System.Drawing.Size(324, 73);
            this.label_accion.TabIndex = 8;
            this.label_accion.Text = "ACCION";
            // 
            // label_estado
            // 
            this.label_estado.BackColor = System.Drawing.Color.Transparent;
            this.label_estado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label_estado.Location = new System.Drawing.Point(1, 0);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(163, 25);
            this.label_estado.TabIndex = 9;
            this.label_estado.Text = "ESTADO";
            // 
            // panel_fecha
            // 
            this.panel_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.panel_fecha.Controls.Add(this.label_fecha);
            this.panel_fecha.Location = new System.Drawing.Point(13, 16);
            this.panel_fecha.Name = "panel_fecha";
            this.panel_fecha.Size = new System.Drawing.Size(131, 33);
            this.panel_fecha.TabIndex = 10;
            // 
            // panel_accion
            // 
            this.panel_accion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.panel_accion.Controls.Add(this.label_accion);
            this.panel_accion.Location = new System.Drawing.Point(13, 64);
            this.panel_accion.Name = "panel_accion";
            this.panel_accion.Size = new System.Drawing.Size(327, 73);
            this.panel_accion.TabIndex = 11;
            // 
            // panel_estado
            // 
            this.panel_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.panel_estado.Controls.Add(this.label_estado);
            this.panel_estado.Location = new System.Drawing.Point(358, 109);
            this.panel_estado.Name = "panel_estado";
            this.panel_estado.Size = new System.Drawing.Size(164, 28);
            this.panel_estado.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 150);
            this.panel1.TabIndex = 13;
            // 
            // HistorialCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel_estado);
            this.Controls.Add(this.panel_accion);
            this.Controls.Add(this.panel_fecha);
            this.Controls.Add(this.panel1);
            this.Name = "HistorialCard";
            this.Size = new System.Drawing.Size(537, 150);
            this.Load += new System.EventHandler(this.HistorialCard_Load);
            this.panel_fecha.ResumeLayout(false);
            this.panel_accion.ResumeLayout(false);
            this.panel_estado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_accion;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.Panel panel_fecha;
        private System.Windows.Forms.Panel panel_accion;
        private System.Windows.Forms.Panel panel_estado;
        private System.Windows.Forms.Panel panel1;
    }
}
