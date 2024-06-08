namespace CRUDD
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt1 = new System.Windows.Forms.Label();
            this.editarButton = new System.Windows.Forms.Button();
            this.recuperarButton = new System.Windows.Forms.Button();
            this.borrarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(104, 57);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(74, 24);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "Usuario";
            this.txt1.Click += new System.EventHandler(this.txt1_Click);
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(198, 142);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 23);
            this.editarButton.TabIndex = 3;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // recuperarButton
            // 
            this.recuperarButton.Location = new System.Drawing.Point(292, 142);
            this.recuperarButton.Name = "recuperarButton";
            this.recuperarButton.Size = new System.Drawing.Size(75, 23);
            this.recuperarButton.TabIndex = 4;
            this.recuperarButton.Text = "Recuperar";
            this.recuperarButton.UseVisualStyleBackColor = true;
            this.recuperarButton.Click += new System.EventHandler(this.recuperarButton_Click);
            // 
            // borrarButton
            // 
            this.borrarButton.Location = new System.Drawing.Point(391, 142);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(75, 23);
            this.borrarButton.TabIndex = 5;
            this.borrarButton.Text = "Borrar";
            this.borrarButton.UseVisualStyleBackColor = true;
            this.borrarButton.Click += new System.EventHandler(this.borrarButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(103, 142);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 6;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(599, 421);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.borrarButton);
            this.Controls.Add(this.recuperarButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button recuperarButton;
        private System.Windows.Forms.Button borrarButton;
        private System.Windows.Forms.Button guardarButton;
    }
}

