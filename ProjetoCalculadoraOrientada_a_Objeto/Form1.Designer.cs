namespace ProjetoCalculadoraOrientada_a_Objeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResulatado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.cmbFunc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblResulatado
            // 
            this.lblResulatado.AutoSize = true;
            this.lblResulatado.Location = new System.Drawing.Point(401, 66);
            this.lblResulatado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResulatado.Name = "lblResulatado";
            this.lblResulatado.Size = new System.Drawing.Size(13, 13);
            this.lblResulatado.TabIndex = 0;
            this.lblResulatado.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(115, 64);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(68, 20);
            this.txtNumero1.TabIndex = 2;
            this.txtNumero1.TextChanged += new System.EventHandler(this.TxtNumero1_TextChanged);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(291, 64);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(68, 20);
            this.txtNumero2.TabIndex = 3;
            // 
            // cmbFunc
            // 
            this.cmbFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFunc.FormattingEnabled = true;
            this.cmbFunc.Items.AddRange(new object[] {
            "Somar",
            "Subtrair",
            "Multiplicar",
            "Potenciação",
            "Dividir",
            "ImparPar",
            "Compara"});
            this.cmbFunc.Location = new System.Drawing.Point(196, 62);
            this.cmbFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFunc.Name = "cmbFunc";
            this.cmbFunc.Size = new System.Drawing.Size(82, 21);
            this.cmbFunc.TabIndex = 4;
            this.cmbFunc.SelectedIndexChanged += new System.EventHandler(this.CmbFunc_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 332);
            this.Controls.Add(this.cmbFunc);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResulatado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResulatado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ComboBox cmbFunc;
    }
}

