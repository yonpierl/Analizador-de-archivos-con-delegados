namespace Analizador_de_archivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnalizarArchivos = new System.Windows.Forms.Button();
            this.txtRutaDirectorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnalizarArchivos
            // 
            this.btnAnalizarArchivos.Location = new System.Drawing.Point(136, 226);
            this.btnAnalizarArchivos.Name = "btnAnalizarArchivos";
            this.btnAnalizarArchivos.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizarArchivos.TabIndex = 0;
            this.btnAnalizarArchivos.Text = "ENTER";
            this.btnAnalizarArchivos.UseVisualStyleBackColor = true;
            this.btnAnalizarArchivos.Click += new System.EventHandler(this.btnVerificarRuta_Click);
            // 
            // txtRutaDirectorio
            // 
            this.txtRutaDirectorio.Location = new System.Drawing.Point(111, 74);
            this.txtRutaDirectorio.Name = "txtRutaDirectorio";
            this.txtRutaDirectorio.Size = new System.Drawing.Size(100, 23);
            this.txtRutaDirectorio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ruta Directorio";
            // 
            // txtFiltroExtension
            // 
            this.txtFiltroExtension.Location = new System.Drawing.Point(111, 151);
            this.txtFiltroExtension.Name = "txtFiltroExtension";
            this.txtFiltroExtension.Size = new System.Drawing.Size(100, 23);
            this.txtFiltroExtension.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtro de extension";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltroExtension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRutaDirectorio);
            this.Controls.Add(this.btnAnalizarArchivos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAnalizarArchivos;
        private TextBox txtRutaDirectorio;
        private Label label1;
        private TextBox txtFiltroExtension;
        private Label label2;
    }
}