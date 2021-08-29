
namespace Peso_Estimado
{
    partial class VentanaTabla
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
            this.tablaspicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaspicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaspicture
            // 
            this.tablaspicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaspicture.Location = new System.Drawing.Point(0, 0);
            this.tablaspicture.Name = "tablaspicture";
            this.tablaspicture.Size = new System.Drawing.Size(627, 403);
            this.tablaspicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tablaspicture.TabIndex = 0;
            this.tablaspicture.TabStop = false;
            // 
            // VentanaTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(627, 403);
            this.Controls.Add(this.tablaspicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "VentanaTabla";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.tablaspicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tablaspicture;
    }
}