namespace TP2_Winform
{
    partial class FrmInicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de comercio 1.0";
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(305, 245);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(133, 49);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Acerca de esta aplicación";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 21);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogo.Location = new System.Drawing.Point(95, 245);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(133, 49);
            this.btnCatalogo.TabIndex = 3;
            this.btnCatalogo.Text = "Administrar catálogo";
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 363);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.label1);
            this.Name = "FrmInicio";
            this.Text = "Administrador de comercio 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCatalogo;
    }
}