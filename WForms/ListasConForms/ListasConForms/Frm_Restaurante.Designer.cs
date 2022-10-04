using System.Media;
namespace ListasConForms
{
    partial class Frm_Restaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Restaurante));
            this.btn_CargarProducto = new System.Windows.Forms.Button();
            this.btn_FinalizarCompra = new System.Windows.Forms.Button();
            this.btn_CrearProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CargarProducto
            // 
            this.btn_CargarProducto.BackColor = System.Drawing.Color.White;
            this.btn_CargarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CargarProducto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CargarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CargarProducto.Location = new System.Drawing.Point(12, 324);
            this.btn_CargarProducto.Name = "btn_CargarProducto";
            this.btn_CargarProducto.Size = new System.Drawing.Size(113, 38);
            this.btn_CargarProducto.TabIndex = 0;
            this.btn_CargarProducto.Text = "Gestionar Mesa";
            this.btn_CargarProducto.UseVisualStyleBackColor = false;
            // 
            // btn_FinalizarCompra
            // 
            this.btn_FinalizarCompra.BackColor = System.Drawing.Color.White;
            this.btn_FinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FinalizarCompra.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_FinalizarCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_FinalizarCompra.Location = new System.Drawing.Point(372, 324);
            this.btn_FinalizarCompra.Name = "btn_FinalizarCompra";
            this.btn_FinalizarCompra.Size = new System.Drawing.Size(113, 38);
            this.btn_FinalizarCompra.TabIndex = 1;
            this.btn_FinalizarCompra.Text = "Cerrar Mesa";
            this.btn_FinalizarCompra.UseVisualStyleBackColor = false;
            this.btn_FinalizarCompra.Click += new System.EventHandler(this.btn_FinalizarCompra_Click);
            // 
            // btn_CrearProducto
            // 
            this.btn_CrearProducto.BackColor = System.Drawing.Color.White;
            this.btn_CrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CrearProducto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CrearProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CrearProducto.Location = new System.Drawing.Point(372, 44);
            this.btn_CrearProducto.Name = "btn_CrearProducto";
            this.btn_CrearProducto.Size = new System.Drawing.Size(113, 38);
            this.btn_CrearProducto.TabIndex = 10;
            this.btn_CrearProducto.Text = "ABM Producto";
            this.btn_CrearProducto.UseVisualStyleBackColor = false;
            this.btn_CrearProducto.Click += new System.EventHandler(this.btn_CrearProducto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Frm_Buffet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(497, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_CrearProducto);
            this.Controls.Add(this.btn_FinalizarCompra);
            this.Controls.Add(this.btn_CargarProducto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Buffet";
            this.Text = "FrmCompra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CargarProducto;
        private System.Windows.Forms.Button btn_FinalizarCompra;
        private System.Windows.Forms.Button btn_AbmProducto;
        private System.Windows.Forms.Button btn_CrearProducto;
        private System.Windows.Forms.Button button1;
    }
}
