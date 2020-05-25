namespace Hash_Archivos.Formularios
{
    partial class Principal
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
            this.pnlArchivo = new System.Windows.Forms.Panel();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.tbArchivo = new System.Windows.Forms.TextBox();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.pnlMD5 = new System.Windows.Forms.Panel();
            this.lblMD5 = new System.Windows.Forms.Label();
            this.tbMD5 = new System.Windows.Forms.TextBox();
            this.pnlSHA1 = new System.Windows.Forms.Panel();
            this.tbSHA1 = new System.Windows.Forms.TextBox();
            this.lblSHA1 = new System.Windows.Forms.Label();
            this.pnlSHA256 = new System.Windows.Forms.Panel();
            this.tbSHA256 = new System.Windows.Forms.TextBox();
            this.lblSHA256 = new System.Windows.Forms.Label();
            this.pnlHash = new System.Windows.Forms.Panel();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.lblHash = new System.Windows.Forms.Label();
            this.pnlArchivo.SuspendLayout();
            this.pnlMD5.SuspendLayout();
            this.pnlSHA1.SuspendLayout();
            this.pnlSHA256.SuspendLayout();
            this.pnlHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlArchivo
            // 
            this.pnlArchivo.Controls.Add(this.btnArchivo);
            this.pnlArchivo.Controls.Add(this.tbArchivo);
            this.pnlArchivo.Controls.Add(this.lblArchivo);
            this.pnlArchivo.Location = new System.Drawing.Point(8, 8);
            this.pnlArchivo.Name = "pnlArchivo";
            this.pnlArchivo.Size = new System.Drawing.Size(464, 40);
            this.pnlArchivo.TabIndex = 0;
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(8, 8);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(46, 13);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "Archivo:";
            // 
            // tbArchivo
            // 
            this.tbArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArchivo.Location = new System.Drawing.Point(64, 8);
            this.tbArchivo.Name = "tbArchivo";
            this.tbArchivo.ReadOnly = true;
            this.tbArchivo.Size = new System.Drawing.Size(360, 20);
            this.tbArchivo.TabIndex = 1;
            // 
            // btnArchivo
            // 
            this.btnArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArchivo.Location = new System.Drawing.Point(432, 8);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(24, 24);
            this.btnArchivo.TabIndex = 2;
            this.btnArchivo.Text = "...";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.BtnArchivo_Click);
            // 
            // pnlMD5
            // 
            this.pnlMD5.Controls.Add(this.tbMD5);
            this.pnlMD5.Controls.Add(this.lblMD5);
            this.pnlMD5.Location = new System.Drawing.Point(8, 56);
            this.pnlMD5.Name = "pnlMD5";
            this.pnlMD5.Size = new System.Drawing.Size(464, 32);
            this.pnlMD5.TabIndex = 2;
            // 
            // lblMD5
            // 
            this.lblMD5.AutoSize = true;
            this.lblMD5.Location = new System.Drawing.Point(8, 8);
            this.lblMD5.Name = "lblMD5";
            this.lblMD5.Size = new System.Drawing.Size(33, 13);
            this.lblMD5.TabIndex = 0;
            this.lblMD5.Text = "MD5:";
            // 
            // tbMD5
            // 
            this.tbMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMD5.Location = new System.Drawing.Point(64, 8);
            this.tbMD5.Name = "tbMD5";
            this.tbMD5.ReadOnly = true;
            this.tbMD5.Size = new System.Drawing.Size(392, 20);
            this.tbMD5.TabIndex = 1;
            // 
            // pnlSHA1
            // 
            this.pnlSHA1.Controls.Add(this.tbSHA1);
            this.pnlSHA1.Controls.Add(this.lblSHA1);
            this.pnlSHA1.Location = new System.Drawing.Point(8, 96);
            this.pnlSHA1.Name = "pnlSHA1";
            this.pnlSHA1.Size = new System.Drawing.Size(464, 32);
            this.pnlSHA1.TabIndex = 2;
            // 
            // tbSHA1
            // 
            this.tbSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA1.Location = new System.Drawing.Point(64, 8);
            this.tbSHA1.Name = "tbSHA1";
            this.tbSHA1.ReadOnly = true;
            this.tbSHA1.Size = new System.Drawing.Size(392, 20);
            this.tbSHA1.TabIndex = 1;
            // 
            // lblSHA1
            // 
            this.lblSHA1.AutoSize = true;
            this.lblSHA1.Location = new System.Drawing.Point(8, 8);
            this.lblSHA1.Name = "lblSHA1";
            this.lblSHA1.Size = new System.Drawing.Size(38, 13);
            this.lblSHA1.TabIndex = 0;
            this.lblSHA1.Text = "SHA1:";
            // 
            // pnlSHA256
            // 
            this.pnlSHA256.Controls.Add(this.tbSHA256);
            this.pnlSHA256.Controls.Add(this.lblSHA256);
            this.pnlSHA256.Location = new System.Drawing.Point(8, 136);
            this.pnlSHA256.Name = "pnlSHA256";
            this.pnlSHA256.Size = new System.Drawing.Size(464, 32);
            this.pnlSHA256.TabIndex = 2;
            // 
            // tbSHA256
            // 
            this.tbSHA256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA256.Location = new System.Drawing.Point(64, 8);
            this.tbSHA256.Name = "tbSHA256";
            this.tbSHA256.ReadOnly = true;
            this.tbSHA256.Size = new System.Drawing.Size(392, 20);
            this.tbSHA256.TabIndex = 1;
            // 
            // lblSHA256
            // 
            this.lblSHA256.AutoSize = true;
            this.lblSHA256.Location = new System.Drawing.Point(8, 8);
            this.lblSHA256.Name = "lblSHA256";
            this.lblSHA256.Size = new System.Drawing.Size(50, 13);
            this.lblSHA256.TabIndex = 0;
            this.lblSHA256.Text = "SHA256:";
            // 
            // pnlHash
            // 
            this.pnlHash.Controls.Add(this.tbHash);
            this.pnlHash.Controls.Add(this.lblHash);
            this.pnlHash.Location = new System.Drawing.Point(8, 184);
            this.pnlHash.Name = "pnlHash";
            this.pnlHash.Size = new System.Drawing.Size(464, 32);
            this.pnlHash.TabIndex = 2;
            // 
            // tbHash
            // 
            this.tbHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHash.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbHash.Location = new System.Drawing.Point(56, 8);
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(400, 20);
            this.tbHash.TabIndex = 1;
            this.tbHash.TextChanged += new System.EventHandler(this.TbHash_TextChanged);
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(8, 8);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(35, 13);
            this.lblHash.TabIndex = 0;
            this.lblHash.Text = "Hash:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 225);
            this.Controls.Add(this.pnlHash);
            this.Controls.Add(this.pnlSHA256);
            this.Controls.Add(this.pnlSHA1);
            this.Controls.Add(this.pnlMD5);
            this.Controls.Add(this.pnlArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Calculadora Hashes";
            this.pnlArchivo.ResumeLayout(false);
            this.pnlArchivo.PerformLayout();
            this.pnlMD5.ResumeLayout(false);
            this.pnlMD5.PerformLayout();
            this.pnlSHA1.ResumeLayout(false);
            this.pnlSHA1.PerformLayout();
            this.pnlSHA256.ResumeLayout(false);
            this.pnlSHA256.PerformLayout();
            this.pnlHash.ResumeLayout(false);
            this.pnlHash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArchivo;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.TextBox tbArchivo;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Panel pnlMD5;
        private System.Windows.Forms.TextBox tbMD5;
        private System.Windows.Forms.Label lblMD5;
        private System.Windows.Forms.Panel pnlSHA1;
        private System.Windows.Forms.TextBox tbSHA1;
        private System.Windows.Forms.Label lblSHA1;
        private System.Windows.Forms.Panel pnlSHA256;
        private System.Windows.Forms.TextBox tbSHA256;
        private System.Windows.Forms.Label lblSHA256;
        private System.Windows.Forms.Panel pnlHash;
        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.Label lblHash;
    }
}