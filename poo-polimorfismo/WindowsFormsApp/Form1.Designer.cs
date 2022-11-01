namespace WindowsFormsApp
{
    partial class Form1
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
            this.BtnCrearPeon = new System.Windows.Forms.Button();
            this.btnMoverTorre = new System.Windows.Forms.Button();
            this.btnMoverCaballo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCrearPeon
            // 
            this.BtnCrearPeon.Location = new System.Drawing.Point(272, 172);
            this.BtnCrearPeon.Name = "BtnCrearPeon";
            this.BtnCrearPeon.Size = new System.Drawing.Size(140, 60);
            this.BtnCrearPeon.TabIndex = 0;
            this.BtnCrearPeon.Text = "mover peon";
            this.BtnCrearPeon.UseVisualStyleBackColor = true;
            this.BtnCrearPeon.Click += new System.EventHandler(this.BtnCrearPeon_Click);
            // 
            // btnMoverTorre
            // 
            this.btnMoverTorre.Location = new System.Drawing.Point(447, 172);
            this.btnMoverTorre.Name = "btnMoverTorre";
            this.btnMoverTorre.Size = new System.Drawing.Size(143, 60);
            this.btnMoverTorre.TabIndex = 1;
            this.btnMoverTorre.Text = "mover torre";
            this.btnMoverTorre.UseVisualStyleBackColor = true;
            this.btnMoverTorre.Click += new System.EventHandler(this.btnMoverTorre_Click);
            // 
            // btnMoverCaballo
            // 
            this.btnMoverCaballo.Location = new System.Drawing.Point(110, 172);
            this.btnMoverCaballo.Name = "btnMoverCaballo";
            this.btnMoverCaballo.Size = new System.Drawing.Size(143, 60);
            this.btnMoverCaballo.TabIndex = 2;
            this.btnMoverCaballo.Text = "mover caballo";
            this.btnMoverCaballo.UseVisualStyleBackColor = true;
            this.btnMoverCaballo.Click += new System.EventHandler(this.btnMoverCaballo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoverCaballo);
            this.Controls.Add(this.btnMoverTorre);
            this.Controls.Add(this.BtnCrearPeon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearPeon;
        private System.Windows.Forms.Button btnMoverTorre;
        private System.Windows.Forms.Button btnMoverCaballo;
    }
}

