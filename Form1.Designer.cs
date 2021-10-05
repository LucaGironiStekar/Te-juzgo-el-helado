
namespace Te_juzgo_el_helado
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
            this.cmbSabores = new System.Windows.Forms.ComboBox();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.btJuzgar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSabores
            // 
            this.cmbSabores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSabores.FormattingEnabled = true;
            this.cmbSabores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSabores.Location = new System.Drawing.Point(33, 96);
            this.cmbSabores.Name = "cmbSabores";
            this.cmbSabores.Size = new System.Drawing.Size(236, 23);
            this.cmbSabores.TabIndex = 0;
            this.cmbSabores.SelectedIndexChanged += new System.EventHandler(this.cmbSabores_SelectedIndexChanged);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionar.Location = new System.Drawing.Point(33, 32);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(340, 30);
            this.lblSeleccionar.TabIndex = 1;
            this.lblSeleccionar.Text = "¡Elige tu sabor de helado favorito!";
            // 
            // btJuzgar
            // 
            this.btJuzgar.Location = new System.Drawing.Point(286, 96);
            this.btJuzgar.Name = "btJuzgar";
            this.btJuzgar.Size = new System.Drawing.Size(81, 25);
            this.btJuzgar.TabIndex = 3;
            this.btJuzgar.Text = "Juzgar";
            this.btJuzgar.UseVisualStyleBackColor = true;
            this.btJuzgar.Click += new System.EventHandler(this.btJuzgar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(420, 99);
            this.lblResultado.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 15);
            this.lblResultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btJuzgar);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.cmbSabores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSabores;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.Button btJuzgar;
        private System.Windows.Forms.Label lblResultado;
    }
}

