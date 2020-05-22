namespace AplicacionesArduino_2020_II
{
    partial class Foco
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
            this.ptbFoco = new System.Windows.Forms.PictureBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoco)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbFoco
            // 
            this.ptbFoco.Image = global::AplicacionesArduino_2020_II.Properties.Resources.focoapagado;
            this.ptbFoco.Location = new System.Drawing.Point(133, 36);
            this.ptbFoco.Name = "ptbFoco";
            this.ptbFoco.Size = new System.Drawing.Size(197, 247);
            this.ptbFoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoco.TabIndex = 0;
            this.ptbFoco.TabStop = false;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(144, 327);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(174, 86);
            this.btnSwitch.TabIndex = 1;
            this.btnSwitch.Text = "Prende / Apaga";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.BtnSwitch_Click);
            // 
            // Foco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 481);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.ptbFoco);
            this.Name = "Foco";
            this.Text = "Foco";
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFoco;
        private System.Windows.Forms.Button btnSwitch;
    }
}