namespace EstadisticProject.Views.ViewsModels
{
    partial class Cargar_Datos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_historial = new System.Windows.Forms.Label();
            this.txt_datos_manuales = new System.Windows.Forms.TextBox();
            this.btn_adjuntar_archivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ruta = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_datos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImage = global::EstadisticProject.Properties.Resources.wallpaper2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 137);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.lbl_ruta);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_adjuntar_archivo);
            this.panel2.Controls.Add(this.txt_datos_manuales);
            this.panel2.Controls.Add(this.label_historial);
            this.panel2.Location = new System.Drawing.Point(38, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 560);
            this.panel2.TabIndex = 12;
            // 
            // label_historial
            // 
            this.label_historial.AutoSize = true;
            this.label_historial.BackColor = System.Drawing.Color.Transparent;
            this.label_historial.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.label_historial.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_historial.Location = new System.Drawing.Point(57, 23);
            this.label_historial.Name = "label_historial";
            this.label_historial.Size = new System.Drawing.Size(354, 47);
            this.label_historial.TabIndex = 23;
            this.label_historial.Text = "Ingrese los Datos";
            // 
            // txt_datos_manuales
            // 
            this.txt_datos_manuales.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_datos_manuales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_datos_manuales.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datos_manuales.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_datos_manuales.Location = new System.Drawing.Point(31, 109);
            this.txt_datos_manuales.Multiline = true;
            this.txt_datos_manuales.Name = "txt_datos_manuales";
            this.txt_datos_manuales.Size = new System.Drawing.Size(413, 149);
            this.txt_datos_manuales.TabIndex = 25;
            this.txt_datos_manuales.Text = "Ingresar Manualmente (separado por comas)";
            this.txt_datos_manuales.Enter += new System.EventHandler(this.txt_datos_manuales_Enter);
            this.txt_datos_manuales.Leave += new System.EventHandler(this.txt_datos_manuales_Leave);
            // 
            // btn_adjuntar_archivo
            // 
            this.btn_adjuntar_archivo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_adjuntar_archivo.FlatAppearance.BorderSize = 0;
            this.btn_adjuntar_archivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_adjuntar_archivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_adjuntar_archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adjuntar_archivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adjuntar_archivo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_adjuntar_archivo.Location = new System.Drawing.Point(92, 367);
            this.btn_adjuntar_archivo.Name = "btn_adjuntar_archivo";
            this.btn_adjuntar_archivo.Size = new System.Drawing.Size(270, 40);
            this.btn_adjuntar_archivo.TabIndex = 26;
            this.btn_adjuntar_archivo.Text = "Adjuntar Archivo";
            this.btn_adjuntar_archivo.UseVisualStyleBackColor = false;
            this.btn_adjuntar_archivo.Click += new System.EventHandler(this.btn_adjuntar_archivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(206, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 47);
            this.label1.TabIndex = 27;
            this.label1.Text = "O";
            // 
            // lbl_ruta
            // 
            this.lbl_ruta.BackColor = System.Drawing.Color.White;
            this.lbl_ruta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ruta.ForeColor = System.Drawing.Color.Black;
            this.lbl_ruta.Location = new System.Drawing.Point(92, 424);
            this.lbl_ruta.Name = "lbl_ruta";
            this.lbl_ruta.Size = new System.Drawing.Size(270, 28);
            this.lbl_ruta.TabIndex = 28;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_guardar.Location = new System.Drawing.Point(92, 475);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(270, 40);
            this.btn_guardar.TabIndex = 29;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_datos
            // 
            this.txt_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.txt_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_datos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datos.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_datos.Location = new System.Drawing.Point(620, 214);
            this.txt_datos.Multiline = true;
            this.txt_datos.Name = "txt_datos";
            this.txt_datos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_datos.Size = new System.Drawing.Size(313, 266);
            this.txt_datos.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(612, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 47);
            this.label2.TabIndex = 27;
            this.label2.Text = "Datos";
            // 
            // Cargar_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_datos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Cargar_Datos";
            this.Size = new System.Drawing.Size(1008, 706);
            this.Load += new System.EventHandler(this.Cargar_Datos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_historial;
        private System.Windows.Forms.Label lbl_ruta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adjuntar_archivo;
        private System.Windows.Forms.TextBox txt_datos_manuales;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_datos;
        private System.Windows.Forms.Label label2;
    }
}
