namespace EstadisticProject.Views.ViewsModels
{
    partial class documentation
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flp_historial = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_time = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_objetivo = new FontAwesome.Sharp.IconButton();
            this.btn_colaboradores = new FontAwesome.Sharp.IconButton();
            this.panel_time.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flp_historial
            // 
            this.flp_historial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.flp_historial.Location = new System.Drawing.Point(32, 244);
            this.flp_historial.Name = "flp_historial";
            this.flp_historial.Size = new System.Drawing.Size(534, 419);
            this.flp_historial.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImage = global::EstadisticProject.Properties.Resources.wallpaper;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 137);
            this.panel1.TabIndex = 10;
            // 
            // panel_time
            // 
            this.panel_time.BackgroundImage = global::EstadisticProject.Properties.Resources.color_jpg;
            this.panel_time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_time.Controls.Add(this.label1);
            this.panel_time.Location = new System.Drawing.Point(598, 78);
            this.panel_time.Name = "panel_time";
            this.panel_time.Size = new System.Drawing.Size(378, 192);
            this.panel_time.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(103, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 47);
            this.label1.TabIndex = 21;
            this.label1.Text = "TIME";
            // 
            // btn_objetivo
            // 
            this.btn_objetivo.BackgroundImage = global::EstadisticProject.Properties.Resources.simple_colorful_lines_gradient_mixed_e_commerce_texture_background_6221984;
            this.btn_objetivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_objetivo.FlatAppearance.BorderSize = 0;
            this.btn_objetivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_objetivo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_objetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btn_objetivo.IconChar = FontAwesome.Sharp.IconChar.FlagCheckered;
            this.btn_objetivo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btn_objetivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_objetivo.IconSize = 50;
            this.btn_objetivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_objetivo.Location = new System.Drawing.Point(308, 78);
            this.btn_objetivo.Name = "btn_objetivo";
            this.btn_objetivo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_objetivo.Size = new System.Drawing.Size(258, 130);
            this.btn_objetivo.TabIndex = 6;
            this.btn_objetivo.Text = "Objetivo del Proyecto";
            this.btn_objetivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_objetivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_objetivo.UseVisualStyleBackColor = true;
            // 
            // btn_colaboradores
            // 
            this.btn_colaboradores.BackgroundImage = global::EstadisticProject.Properties.Resources.abstract_mixed_pastel_colors_background_free_vector;
            this.btn_colaboradores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_colaboradores.FlatAppearance.BorderSize = 0;
            this.btn_colaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colaboradores.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_colaboradores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btn_colaboradores.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btn_colaboradores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btn_colaboradores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_colaboradores.IconSize = 50;
            this.btn_colaboradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_colaboradores.Location = new System.Drawing.Point(32, 78);
            this.btn_colaboradores.Name = "btn_colaboradores";
            this.btn_colaboradores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_colaboradores.Size = new System.Drawing.Size(244, 130);
            this.btn_colaboradores.TabIndex = 5;
            this.btn_colaboradores.Text = "Colaboradores";
            this.btn_colaboradores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_colaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_colaboradores.UseVisualStyleBackColor = true;
            // 
            // documentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.flp_historial);
            this.Controls.Add(this.panel_time);
            this.Controls.Add(this.btn_objetivo);
            this.Controls.Add(this.btn_colaboradores);
            this.Controls.Add(this.panel1);
            this.Name = "documentation";
            this.Size = new System.Drawing.Size(1008, 706);
            this.Load += new System.EventHandler(this.documentation_Load);
            this.panel_time.ResumeLayout(false);
            this.panel_time.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_time;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_objetivo;
        private FontAwesome.Sharp.IconButton btn_colaboradores;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flp_historial;
        private System.Windows.Forms.Panel panel1;
    }
}
