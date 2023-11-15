namespace ReporteConsultaSQL
{
    partial class FrmConsultaSQL2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaSQL2));
            this.LblAnio = new System.Windows.Forms.Label();
            this.TxtAnio = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.DgvConsulta2 = new System.Windows.Forms.DataGridView();
            this.LblConsulta = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Location = new System.Drawing.Point(33, 238);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(33, 13);
            this.LblAnio.TabIndex = 0;
            this.LblAnio.Text = "ANIO";
            // 
            // TxtAnio
            // 
            this.TxtAnio.Location = new System.Drawing.Point(79, 236);
            this.TxtAnio.Name = "TxtAnio";
            this.TxtAnio.Size = new System.Drawing.Size(63, 20);
            this.TxtAnio.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(298, 233);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // DgvConsulta2
            // 
            this.DgvConsulta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta2.Location = new System.Drawing.Point(79, 271);
            this.DgvConsulta2.Name = "DgvConsulta2";
            this.DgvConsulta2.Size = new System.Drawing.Size(375, 177);
            this.DgvConsulta2.TabIndex = 3;
            this.DgvConsulta2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsulta2_CellContentClick);
            // 
            // LblConsulta
            // 
            this.LblConsulta.AutoSize = true;
            this.LblConsulta.Location = new System.Drawing.Point(5, 117);
            this.LblConsulta.Name = "LblConsulta";
            this.LblConsulta.Size = new System.Drawing.Size(68, 13);
            this.LblConsulta.TabIndex = 4;
            this.LblConsulta.Text = "CONSULTA:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(79, 114);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(375, 113);
            this.txtConsulta.TabIndex = 5;
            this.txtConsulta.Text = resources.GetString("txtConsulta.Text");
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(379, 233);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 23);
            this.BtnAtras.TabIndex = 6;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ENUNCIADO:";
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(79, 24);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(375, 84);
            this.txtEnunciado.TabIndex = 8;
            this.txtEnunciado.Text = resources.GetString("txtEnunciado.Text");
            // 
            // FrmConsultaSQL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 456);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.LblConsulta);
            this.Controls.Add(this.DgvConsulta2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.TxtAnio);
            this.Controls.Add(this.LblAnio);
            this.Name = "FrmConsultaSQL2";
            this.Text = "FrmConsultaSQL2";
            this.Load += new System.EventHandler(this.FrmConsultaSQL2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.TextBox TxtAnio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView DgvConsulta2;
        private System.Windows.Forms.Label LblConsulta;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnunciado;
    }
}