
namespace Peso_Estimado
{
    partial class Principal
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnayuda = new System.Windows.Forms.Button();
            this.btntabla = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.PanelComplemento = new System.Windows.Forms.Panel();
            this.picturePrincipal = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.PanelComplemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.btnmenu);
            this.PanelMenu.Controls.Add(this.LogoPicture);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(155, 450);
            this.PanelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnayuda);
            this.panel1.Controls.Add(this.btntabla);
            this.panel1.Controls.Add(this.btncalcular);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 90);
            this.panel1.TabIndex = 2;
            // 
            // btnayuda
            // 
            this.btnayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(30)))));
            this.btnayuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnayuda.FlatAppearance.BorderSize = 0;
            this.btnayuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnayuda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnayuda.ForeColor = System.Drawing.Color.White;
            this.btnayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnayuda.Location = new System.Drawing.Point(0, 58);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(155, 32);
            this.btnayuda.TabIndex = 4;
            this.btnayuda.Text = "Ayuda";
            this.btnayuda.UseVisualStyleBackColor = false;
            this.btnayuda.Click += new System.EventHandler(this.btnayuda_Click);
            // 
            // btntabla
            // 
            this.btntabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(30)))));
            this.btntabla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntabla.FlatAppearance.BorderSize = 0;
            this.btntabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btntabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntabla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btntabla.ForeColor = System.Drawing.Color.White;
            this.btntabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntabla.Location = new System.Drawing.Point(0, 29);
            this.btntabla.Name = "btntabla";
            this.btntabla.Size = new System.Drawing.Size(155, 29);
            this.btntabla.TabIndex = 3;
            this.btntabla.Text = "Ver tabla";
            this.btntabla.UseVisualStyleBackColor = false;
            this.btntabla.Click += new System.EventHandler(this.btntabla_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(30)))));
            this.btncalcular.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncalcular.FlatAppearance.BorderSize = 0;
            this.btncalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btncalcular.ForeColor = System.Drawing.Color.White;
            this.btncalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncalcular.Location = new System.Drawing.Point(0, 0);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(155, 29);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.btnmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenu.FlatAppearance.BorderSize = 0;
            this.btnmenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnmenu.ForeColor = System.Drawing.Color.White;
            this.btnmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenu.Location = new System.Drawing.Point(0, 78);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(155, 29);
            this.btnmenu.TabIndex = 1;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPicture.Location = new System.Drawing.Point(0, 0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(155, 78);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // PanelComplemento
            // 
            this.PanelComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.PanelComplemento.Controls.Add(this.picturePrincipal);
            this.PanelComplemento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelComplemento.Location = new System.Drawing.Point(155, 0);
            this.PanelComplemento.Name = "PanelComplemento";
            this.PanelComplemento.Size = new System.Drawing.Size(645, 450);
            this.PanelComplemento.TabIndex = 1;
            // 
            // picturePrincipal
            // 
            this.picturePrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePrincipal.Location = new System.Drawing.Point(0, 0);
            this.picturePrincipal.Name = "picturePrincipal";
            this.picturePrincipal.Size = new System.Drawing.Size(645, 450);
            this.picturePrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePrincipal.TabIndex = 0;
            this.picturePrincipal.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelComplemento);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Principal";
            this.Text = "Peso Ideal";
            this.PanelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.PanelComplemento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Panel PanelComplemento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btntabla;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.PictureBox picturePrincipal;
    }
}

