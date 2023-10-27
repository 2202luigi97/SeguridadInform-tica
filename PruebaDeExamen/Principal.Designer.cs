namespace PruebaDeExamen
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
            this.btnEncryptText = new System.Windows.Forms.Button();
            this.btnencrypFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pderecho = new System.Windows.Forms.Panel();
            this.tbcontrol = new System.Windows.Forms.TabControl();
            this.tbpageWelcome = new System.Windows.Forms.TabPage();
            this.tbpageFolder = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btndesencriptarFolder = new System.Windows.Forms.Button();
            this.btnEncriptarFolder = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpageText = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pderecho.SuspendLayout();
            this.tbcontrol.SuspendLayout();
            this.tbpageWelcome.SuspendLayout();
            this.tbpageFolder.SuspendLayout();
            this.tbpageText.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncryptText
            // 
            this.btnEncryptText.BackColor = System.Drawing.Color.Transparent;
            this.btnEncryptText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryptText.FlatAppearance.BorderSize = 0;
            this.btnEncryptText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEncryptText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEncryptText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncryptText.Image = global::SeguridadInformática.Properties.Resources.MdiMessageOutline;
            this.btnEncryptText.Location = new System.Drawing.Point(10, 103);
            this.btnEncryptText.Name = "btnEncryptText";
            this.btnEncryptText.Size = new System.Drawing.Size(60, 60);
            this.btnEncryptText.TabIndex = 13;
            this.btnEncryptText.UseVisualStyleBackColor = false;
            this.btnEncryptText.Click += new System.EventHandler(this.btnDesencryp_Click);
            // 
            // btnencrypFolder
            // 
            this.btnencrypFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnencrypFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnencrypFolder.FlatAppearance.BorderSize = 0;
            this.btnencrypFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnencrypFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnencrypFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnencrypFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnencrypFolder.Image = global::SeguridadInformática.Properties.Resources.MdiFolderLockOutline;
            this.btnencrypFolder.Location = new System.Drawing.Point(10, 21);
            this.btnencrypFolder.Name = "btnencrypFolder";
            this.btnencrypFolder.Size = new System.Drawing.Size(60, 60);
            this.btnencrypFolder.TabIndex = 12;
            this.btnencrypFolder.UseVisualStyleBackColor = false;
            this.btnencrypFolder.Click += new System.EventHandler(this.btnencryp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(72, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bienvenido!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEncryptText);
            this.panel1.Controls.Add(this.btnencrypFolder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 201);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pderecho
            // 
            this.pderecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.pderecho.Controls.Add(this.tbcontrol);
            this.pderecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pderecho.Location = new System.Drawing.Point(85, 0);
            this.pderecho.Name = "pderecho";
            this.pderecho.Size = new System.Drawing.Size(327, 201);
            this.pderecho.TabIndex = 17;
            // 
            // tbcontrol
            // 
            this.tbcontrol.Controls.Add(this.tbpageWelcome);
            this.tbcontrol.Controls.Add(this.tbpageFolder);
            this.tbcontrol.Controls.Add(this.tbpageText);
            this.tbcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcontrol.ItemSize = new System.Drawing.Size(0, 1);
            this.tbcontrol.Location = new System.Drawing.Point(0, 0);
            this.tbcontrol.Name = "tbcontrol";
            this.tbcontrol.SelectedIndex = 0;
            this.tbcontrol.Size = new System.Drawing.Size(327, 201);
            this.tbcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcontrol.TabIndex = 0;
            this.tbcontrol.TabStop = false;
            // 
            // tbpageWelcome
            // 
            this.tbpageWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.tbpageWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpageWelcome.Controls.Add(this.label1);
            this.tbpageWelcome.Location = new System.Drawing.Point(4, 5);
            this.tbpageWelcome.Name = "tbpageWelcome";
            this.tbpageWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageWelcome.Size = new System.Drawing.Size(319, 192);
            this.tbpageWelcome.TabIndex = 0;
            // 
            // tbpageFolder
            // 
            this.tbpageFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.tbpageFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpageFolder.Controls.Add(this.btnCancelar);
            this.tbpageFolder.Controls.Add(this.btndesencriptarFolder);
            this.tbpageFolder.Controls.Add(this.btnEncriptarFolder);
            this.tbpageFolder.Controls.Add(this.btnSearch);
            this.tbpageFolder.Controls.Add(this.txtFolder);
            this.tbpageFolder.Controls.Add(this.label3);
            this.tbpageFolder.Location = new System.Drawing.Point(4, 5);
            this.tbpageFolder.Name = "tbpageFolder";
            this.tbpageFolder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageFolder.Size = new System.Drawing.Size(319, 192);
            this.tbpageFolder.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Image = global::SeguridadInformática.Properties.Resources.MdiBackspaceOutline1;
            this.btnCancelar.Location = new System.Drawing.Point(70, 129);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btndesencriptarFolder
            // 
            this.btndesencriptarFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndesencriptarFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.btndesencriptarFolder.FlatAppearance.BorderSize = 0;
            this.btndesencriptarFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndesencriptarFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndesencriptarFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndesencriptarFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndesencriptarFolder.Image = global::SeguridadInformática.Properties.Resources.MdiLockOpenVariantOutline1;
            this.btndesencriptarFolder.Location = new System.Drawing.Point(210, 129);
            this.btndesencriptarFolder.Name = "btndesencriptarFolder";
            this.btndesencriptarFolder.Size = new System.Drawing.Size(40, 40);
            this.btndesencriptarFolder.TabIndex = 17;
            this.btndesencriptarFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndesencriptarFolder.UseVisualStyleBackColor = true;
            this.btndesencriptarFolder.Click += new System.EventHandler(this.btndesencriptarFolder_Click);
            // 
            // btnEncriptarFolder
            // 
            this.btnEncriptarFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncriptarFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.btnEncriptarFolder.FlatAppearance.BorderSize = 0;
            this.btnEncriptarFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEncriptarFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEncriptarFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncriptarFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncriptarFolder.Image = global::SeguridadInformática.Properties.Resources.MdiLockOutline1;
            this.btnEncriptarFolder.Location = new System.Drawing.Point(140, 129);
            this.btnEncriptarFolder.Name = "btnEncriptarFolder";
            this.btnEncriptarFolder.Size = new System.Drawing.Size(40, 40);
            this.btnEncriptarFolder.TabIndex = 16;
            this.btnEncriptarFolder.UseVisualStyleBackColor = true;
            this.btnEncriptarFolder.Click += new System.EventHandler(this.btnEncriptarFolder_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = global::SeguridadInformática.Properties.Resources.MdiFolderSearchOutline;
            this.btnSearch.Location = new System.Drawing.Point(269, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFolder.Location = new System.Drawing.Point(13, 70);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(252, 26);
            this.txtFolder.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 48);
            this.label3.TabIndex = 13;
            this.label3.Text = "*Seleccione la carpeta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbpageText
            // 
            this.tbpageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.tbpageText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpageText.Controls.Add(this.btnClear);
            this.tbpageText.Controls.Add(this.btnDesencriptar);
            this.tbpageText.Controls.Add(this.btnEncriptar);
            this.tbpageText.Controls.Add(this.txtText);
            this.tbpageText.Controls.Add(this.label2);
            this.tbpageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.tbpageText.Location = new System.Drawing.Point(4, 5);
            this.tbpageText.Name = "tbpageText";
            this.tbpageText.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageText.Size = new System.Drawing.Size(319, 192);
            this.tbpageText.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Image = global::SeguridadInformática.Properties.Resources.MdiBackspaceOutline2;
            this.btnClear.Location = new System.Drawing.Point(70, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 16;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesencriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesencriptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.btnDesencriptar.FlatAppearance.BorderSize = 0;
            this.btnDesencriptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDesencriptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDesencriptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDesencriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesencriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDesencriptar.Image = global::SeguridadInformática.Properties.Resources.MdiLockOpenVariantOutline2;
            this.btnDesencriptar.Location = new System.Drawing.Point(210, 129);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(40, 40);
            this.btnDesencriptar.TabIndex = 15;
            this.btnDesencriptar.UseVisualStyleBackColor = false;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.BackColor = System.Drawing.Color.Transparent;
            this.btnEncriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncriptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.btnEncriptar.FlatAppearance.BorderSize = 0;
            this.btnEncriptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEncriptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEncriptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEncriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncriptar.Image = global::SeguridadInformática.Properties.Resources.MdiLockOutline2;
            this.btnEncriptar.Location = new System.Drawing.Point(140, 129);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(40, 40);
            this.btnEncriptar.TabIndex = 14;
            this.btnEncriptar.UseVisualStyleBackColor = false;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtText.Location = new System.Drawing.Point(13, 55);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(285, 58);
            this.txtText.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 48);
            this.label2.TabIndex = 12;
            this.label2.Text = "*Escriba en el cuadro de texto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 201);
            this.Controls.Add(this.pderecho);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.pderecho.ResumeLayout(false);
            this.tbcontrol.ResumeLayout(false);
            this.tbpageWelcome.ResumeLayout(false);
            this.tbpageWelcome.PerformLayout();
            this.tbpageFolder.ResumeLayout(false);
            this.tbpageFolder.PerformLayout();
            this.tbpageText.ResumeLayout(false);
            this.tbpageText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEncryptText;
        private Button btnencrypFolder;
        private Label label1;
        private Panel panel1;
        private Panel pderecho;
        private TabControl tbcontrol;
        private TabPage tbpageWelcome;
        private TabPage tbpageFolder;
        private Button btndesencriptarFolder;
        private Button btnEncriptarFolder;
        private Button btnSearch;
        private TextBox txtFolder;
        private Label label3;
        private TabPage tbpageText;
        private Button btnDesencriptar;
        private Button btnEncriptar;
        private TextBox txtText;
        private Label label2;
        private Button btnCancelar;
        private Button btnClear;
    }
}