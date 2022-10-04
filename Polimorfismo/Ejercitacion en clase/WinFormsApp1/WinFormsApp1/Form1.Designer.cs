namespace WinFormsApp1
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
            this.btnHacha = new System.Windows.Forms.Button();
            this.btnEspada = new System.Windows.Forms.Button();
            this.btnArco = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.CrearGuerrero = new System.Windows.Forms.Button();
            this.crearHacha = new System.Windows.Forms.Button();
            this.crearEspada = new System.Windows.Forms.Button();
            this.crearArco = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHacha
            // 
            this.btnHacha.Location = new System.Drawing.Point(447, 134);
            this.btnHacha.Name = "btnHacha";
            this.btnHacha.Size = new System.Drawing.Size(127, 51);
            this.btnHacha.TabIndex = 0;
            this.btnHacha.Text = "Usar Hacha";
            this.btnHacha.UseVisualStyleBackColor = true;
            this.btnHacha.Click += new System.EventHandler(this.btnHacha_Click);
            // 
            // btnEspada
            // 
            this.btnEspada.Location = new System.Drawing.Point(447, 191);
            this.btnEspada.Name = "btnEspada";
            this.btnEspada.Size = new System.Drawing.Size(127, 51);
            this.btnEspada.TabIndex = 1;
            this.btnEspada.Text = "Usar Espada";
            this.btnEspada.UseVisualStyleBackColor = true;
            this.btnEspada.Click += new System.EventHandler(this.btnEspada_Click);
            // 
            // btnArco
            // 
            this.btnArco.Location = new System.Drawing.Point(447, 248);
            this.btnArco.Name = "btnArco";
            this.btnArco.Size = new System.Drawing.Size(127, 51);
            this.btnArco.TabIndex = 2;
            this.btnArco.Text = "Usar Arco";
            this.btnArco.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(178, 140);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(69, 30);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "label1";
            // 
            // CrearGuerrero
            // 
            this.CrearGuerrero.Location = new System.Drawing.Point(72, 366);
            this.CrearGuerrero.Name = "CrearGuerrero";
            this.CrearGuerrero.Size = new System.Drawing.Size(258, 50);
            this.CrearGuerrero.TabIndex = 4;
            this.CrearGuerrero.Text = "Crear Guerrero";
            this.CrearGuerrero.UseVisualStyleBackColor = true;
            // 
            // crearHacha
            // 
            this.crearHacha.Location = new System.Drawing.Point(-1, 422);
            this.crearHacha.Name = "crearHacha";
            this.crearHacha.Size = new System.Drawing.Size(129, 23);
            this.crearHacha.TabIndex = 5;
            this.crearHacha.Text = "Crear Hacha";
            this.crearHacha.UseVisualStyleBackColor = true;
            // 
            // crearEspada
            // 
            this.crearEspada.Location = new System.Drawing.Point(134, 422);
            this.crearEspada.Name = "crearEspada";
            this.crearEspada.Size = new System.Drawing.Size(129, 23);
            this.crearEspada.TabIndex = 6;
            this.crearEspada.Text = "Crear Espada";
            this.crearEspada.UseVisualStyleBackColor = true;
            // 
            // crearArco
            // 
            this.crearArco.Location = new System.Drawing.Point(269, 422);
            this.crearArco.Name = "crearArco";
            this.crearArco.Size = new System.Drawing.Size(129, 23);
            this.crearArco.TabIndex = 7;
            this.crearArco.Text = "Crear Arco";
            this.crearArco.UseVisualStyleBackColor = true;
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(157, 191);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(127, 51);
            this.btnAtacar.TabIndex = 8;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 554);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.crearArco);
            this.Controls.Add(this.crearEspada);
            this.Controls.Add(this.crearHacha);
            this.Controls.Add(this.CrearGuerrero);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnArco);
            this.Controls.Add(this.btnEspada);
            this.Controls.Add(this.btnHacha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHacha;
        private System.Windows.Forms.Button btnEspada;
        private System.Windows.Forms.Button btnArco;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button CrearGuerrero;
        private System.Windows.Forms.Button crearHacha;
        private System.Windows.Forms.Button crearEspada;
        private System.Windows.Forms.Button crearArco;
        private System.Windows.Forms.Button btnAtacar;
    }
}
