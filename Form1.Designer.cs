
namespace Navegador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bBuscar = new System.Windows.Forms.Button();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bVioleta = new System.Windows.Forms.Button();
            this.bNaranja = new System.Windows.Forms.Button();
            this.bVerde = new System.Windows.Forms.Button();
            this.bIndex = new System.Windows.Forms.Button();
            this.bIr = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(146)))), ((int)(((byte)(152)))));
            this.bBuscar.ForeColor = System.Drawing.Color.White;
            this.bBuscar.Location = new System.Drawing.Point(124, 97);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(126, 21);
            this.bBuscar.TabIndex = 0;
            this.bBuscar.Text = "Search";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBuscar
            // 
            this.tBuscar.Location = new System.Drawing.Point(124, 58);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(480, 20);
            this.tBuscar.TabIndex = 1;
            this.tBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ESCRIBA";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bVioleta
            // 
            this.bVioleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.bVioleta.ForeColor = System.Drawing.Color.White;
            this.bVioleta.Location = new System.Drawing.Point(708, 12);
            this.bVioleta.Name = "bVioleta";
            this.bVioleta.Size = new System.Drawing.Size(75, 23);
            this.bVioleta.TabIndex = 3;
            this.bVioleta.Text = "Purple";
            this.bVioleta.UseVisualStyleBackColor = false;
            this.bVioleta.Click += new System.EventHandler(this.bVioleta_Click);
            // 
            // bNaranja
            // 
            this.bNaranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(47)))));
            this.bNaranja.ForeColor = System.Drawing.Color.White;
            this.bNaranja.Location = new System.Drawing.Point(708, 52);
            this.bNaranja.Name = "bNaranja";
            this.bNaranja.Size = new System.Drawing.Size(75, 23);
            this.bNaranja.TabIndex = 4;
            this.bNaranja.Text = "Orange";
            this.bNaranja.UseVisualStyleBackColor = false;
            this.bNaranja.Click += new System.EventHandler(this.bNaranja_Click);
            // 
            // bVerde
            // 
            this.bVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(85)))), ((int)(((byte)(45)))));
            this.bVerde.ForeColor = System.Drawing.Color.White;
            this.bVerde.Location = new System.Drawing.Point(708, 95);
            this.bVerde.Name = "bVerde";
            this.bVerde.Size = new System.Drawing.Size(75, 23);
            this.bVerde.TabIndex = 5;
            this.bVerde.Text = "Green";
            this.bVerde.UseVisualStyleBackColor = false;
            this.bVerde.Click += new System.EventHandler(this.button3_Click);
            // 
            // bIndex
            // 
            this.bIndex.Location = new System.Drawing.Point(708, 135);
            this.bIndex.Name = "bIndex";
            this.bIndex.Size = new System.Drawing.Size(75, 41);
            this.bIndex.TabIndex = 7;
            this.bIndex.Text = "Color inicial";
            this.bIndex.UseVisualStyleBackColor = true;
            this.bIndex.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bIr
            // 
            this.bIr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(146)))), ((int)(((byte)(152)))));
            this.bIr.ForeColor = System.Drawing.Color.White;
            this.bIr.Location = new System.Drawing.Point(529, 97);
            this.bIr.Name = "bIr";
            this.bIr.Size = new System.Drawing.Size(75, 23);
            this.bIr.TabIndex = 8;
            this.bIr.Text = "Ir a la url";
            this.bIr.UseVisualStyleBackColor = false;
            this.bIr.Click += new System.EventHandler(this.bIr_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 182);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(885, 387);
            this.webBrowser1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(933, 581);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bIr);
            this.Controls.Add(this.bIndex);
            this.Controls.Add(this.bVerde);
            this.Controls.Add(this.bNaranja);
            this.Controls.Add(this.bVioleta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBuscar);
            this.Controls.Add(this.bBuscar);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Navegador argentino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBuscar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVioleta;
        private System.Windows.Forms.Button bNaranja;
        private System.Windows.Forms.Button bVerde;
        private System.Windows.Forms.Button bIndex;
        private System.Windows.Forms.Button bIr;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

