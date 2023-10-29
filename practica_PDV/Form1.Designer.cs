namespace practica_PDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelFrom = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.panelControls);
            this.panelLogo.Controls.Add(this.logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(238, 549);
            this.panelLogo.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnBuscar);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 100);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(238, 242);
            this.panelControls.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(0, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(238, 68);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "Productos";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // logo
            // 
            this.logo.Controls.Add(this.pictureBoxLogo);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(238, 100);
            this.logo.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(238, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panelFrom
            // 
            this.panelFrom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFrom.BackgroundImage")));
            this.panelFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFrom.Controls.Add(this.panelLogo);
            this.panelFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrom.Location = new System.Drawing.Point(0, 0);
            this.panelFrom.Name = "panelFrom";
            this.panelFrom.Size = new System.Drawing.Size(1219, 549);
            this.panelFrom.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1219, 549);
            this.Controls.Add(this.panelFrom);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLogo.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelFrom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelFrom;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

