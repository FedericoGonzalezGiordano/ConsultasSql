namespace ReporteConsultaSQL
{
    partial class FrmConsultaSQL1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaSQL1));
            this.lblConsulta1 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dgvconsulta1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.LblEnunciado = new System.Windows.Forms.Label();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta1
            // 
            this.lblConsulta1.AutoSize = true;
            this.lblConsulta1.Location = new System.Drawing.Point(40, 117);
            this.lblConsulta1.Name = "lblConsulta1";
            this.lblConsulta1.Size = new System.Drawing.Size(57, 13);
            this.lblConsulta1.TabIndex = 0;
            this.lblConsulta1.Text = "Consulta 1";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(130, 117);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(660, 221);
            this.txtConsulta.TabIndex = 1;
            this.txtConsulta.Text = resources.GetString("txtConsulta.Text");
            // 
            // dgvconsulta1
            // 
            this.dgvconsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta1.Location = new System.Drawing.Point(42, 362);
            this.dgvconsulta1.Name = "dgvconsulta1";
            this.dgvconsulta1.Size = new System.Drawing.Size(793, 266);
            this.dgvconsulta1.TabIndex = 2;
            this.dgvconsulta1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvconsulta1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "CONSULTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(440, 658);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(143, 36);
            this.BtnAtras.TabIndex = 4;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // LblEnunciado
            // 
            this.LblEnunciado.AutoSize = true;
            this.LblEnunciado.Location = new System.Drawing.Point(39, 15);
            this.LblEnunciado.Name = "LblEnunciado";
            this.LblEnunciado.Size = new System.Drawing.Size(58, 13);
            this.LblEnunciado.TabIndex = 5;
            this.LblEnunciado.Text = "Enunciado";
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(130, 12);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(660, 86);
            this.txtEnunciado.TabIndex = 6;
            this.txtEnunciado.Text = resources.GetString("txtEnunciado.Text");
            // 
            // FrmConsultaSQL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 705);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.LblEnunciado);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvconsulta1);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.lblConsulta1);
            this.Name = "FrmConsultaSQL1";
            this.Text = "FrmConsultaSQL1";
            this.Load += new System.EventHandler(this.FrmConsultaSQL1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulta1;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dgvconsulta1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Label LblEnunciado;
        private System.Windows.Forms.TextBox txtEnunciado;
    }
}