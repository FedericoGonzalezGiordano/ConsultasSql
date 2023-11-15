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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvconsulta1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta1
            // 
            this.lblConsulta1.AutoSize = true;
            this.lblConsulta1.Location = new System.Drawing.Point(40, 12);
            this.lblConsulta1.Name = "lblConsulta1";
            this.lblConsulta1.Size = new System.Drawing.Size(57, 13);
            this.lblConsulta1.TabIndex = 0;
            this.lblConsulta1.Text = "Consulta 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(612, 232);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // dgvconsulta1
            // 
            this.dgvconsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta1.Location = new System.Drawing.Point(31, 286);
            this.dgvconsulta1.Name = "dgvconsulta1";
            this.dgvconsulta1.Size = new System.Drawing.Size(802, 374);
            this.dgvconsulta1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "CONSULTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(496, 686);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(199, 36);
            this.BtnAtras.TabIndex = 4;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaSQL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 744);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvconsulta1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblConsulta1);
            this.Name = "FrmConsultaSQL1";
            this.Text = "FrmConsultaSQL1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulta1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvconsulta1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAtras;
    }
}