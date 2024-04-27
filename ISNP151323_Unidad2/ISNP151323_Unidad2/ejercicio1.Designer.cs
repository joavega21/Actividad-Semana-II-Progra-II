
namespace ISNP151323_Unidad2 {
    partial class ejercicio1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.chkKilogramos = new System.Windows.Forms.CheckBox();
            this.chkLibras = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(21, 27);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(562, 32);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Conversor de libras a kilogramos y viceversa";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(157, 247);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(262, 22);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Ingrese la cantidad a convertir";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(139, 283);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(302, 28);
            this.txtValor.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(135, 425);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(146, 22);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "El resultado es: ";
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkKilogramos
            // 
            this.chkKilogramos.AutoSize = true;
            this.chkKilogramos.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKilogramos.Location = new System.Drawing.Point(177, 106);
            this.chkKilogramos.Name = "chkKilogramos";
            this.chkKilogramos.Size = new System.Drawing.Size(219, 26);
            this.chkKilogramos.TabIndex = 4;
            this.chkKilogramos.Text = "De libras a kilogramos";
            this.chkKilogramos.UseVisualStyleBackColor = true;
            // 
            // chkLibras
            // 
            this.chkLibras.AutoSize = true;
            this.chkLibras.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLibras.Location = new System.Drawing.Point(177, 155);
            this.chkLibras.Name = "chkLibras";
            this.chkLibras.Size = new System.Drawing.Size(219, 26);
            this.chkLibras.TabIndex = 5;
            this.chkLibras.Text = "De kilogramos a libras";
            this.chkLibras.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(229, 332);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 32);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 529);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.chkLibras);
            this.Controls.Add(this.chkKilogramos);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblSaludo);
            this.Name = "ejercicio1";
            this.Text = "ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.CheckBox chkKilogramos;
        private System.Windows.Forms.CheckBox chkLibras;
        private System.Windows.Forms.Button btnCalcular;
    }
}