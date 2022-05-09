
namespace MenuTabuadaCPF.View.Tabuada
{
    partial class TelaTabuada
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
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(25, 101);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(168, 23);
            this.tbxNumero.TabIndex = 0;
            this.tbxNumero.TextChanged += new System.EventHandler(this.tbxNumero_TextChanged);
            this.tbxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumero_KeyPress);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(163, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Calcular Tabuada";
            // 
            // lbxResultado
            // 
            this.lbxResultado.FormattingEnabled = true;
            this.lbxResultado.ItemHeight = 15;
            this.lbxResultado.Location = new System.Drawing.Point(25, 175);
            this.lbxResultado.Name = "lbxResultado";
            this.lbxResultado.Size = new System.Drawing.Size(213, 229);
            this.lbxResultado.TabIndex = 2;
            // 
            // TelaTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.lbxResultado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tbxNumero);
            this.KeyPreview = true;
            this.Name = "TelaTabuada";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaTabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lbxResultado;
    }
}