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
            btnEncryptText = new Button();
            btnencrypFolder = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pderecho = new Panel();
            tbcontrol = new TabControl();
            tbpageWelcome = new TabPage();
            tbpageFolder = new TabPage();
            btnCancelar = new Button();
            btndesencriptarFolder = new Button();
            btnEncriptarFolder = new Button();
            btnSearch = new Button();
            txtFolder = new TextBox();
            label3 = new Label();
            tbpageText = new TabPage();
            btnClear = new Button();
            btnDesencriptar = new Button();
            btnEncriptar = new Button();
            txtText = new TextBox();
            label2 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            pderecho.SuspendLayout();
            tbcontrol.SuspendLayout();
            tbpageWelcome.SuspendLayout();
            tbpageFolder.SuspendLayout();
            tbpageText.SuspendLayout();
            SuspendLayout();
            // 
            // btnEncryptText
            // 
            btnEncryptText.BackColor = Color.Transparent;
            btnEncryptText.Cursor = Cursors.Hand;
            btnEncryptText.FlatAppearance.BorderSize = 0;
            btnEncryptText.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEncryptText.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEncryptText.FlatStyle = FlatStyle.Flat;
            btnEncryptText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEncryptText.Image = SeguridadInformática.Properties.Resources.MdiMessageOutline;
            btnEncryptText.Location = new Point(10, 103);
            btnEncryptText.Name = "btnEncryptText";
            btnEncryptText.Size = new Size(60, 60);
            btnEncryptText.TabIndex = 13;
            btnEncryptText.UseVisualStyleBackColor = false;
            btnEncryptText.Click += btnDesencryp_Click;
            // 
            // btnencrypFolder
            // 
            btnencrypFolder.BackColor = Color.Transparent;
            btnencrypFolder.Cursor = Cursors.Hand;
            btnencrypFolder.FlatAppearance.BorderSize = 0;
            btnencrypFolder.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnencrypFolder.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnencrypFolder.FlatStyle = FlatStyle.Flat;
            btnencrypFolder.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnencrypFolder.Image = SeguridadInformática.Properties.Resources.MdiFolderLockOutline;
            btnencrypFolder.Location = new Point(10, 21);
            btnencrypFolder.Name = "btnencrypFolder";
            btnencrypFolder.Size = new Size(60, 60);
            btnencrypFolder.TabIndex = 12;
            btnencrypFolder.UseVisualStyleBackColor = false;
            btnencrypFolder.Click += btnencryp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(31, 185, 211);
            label1.Location = new Point(72, 76);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 14;
            label1.Text = "Bienvenido!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 32, 39);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnEncryptText);
            panel1.Controls.Add(btnencrypFolder);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(85, 201);
            panel1.TabIndex = 16;
            // 
            // pderecho
            // 
            pderecho.BackColor = Color.FromArgb(198, 203, 216);
            pderecho.Controls.Add(tbcontrol);
            pderecho.Dock = DockStyle.Fill;
            pderecho.Location = new Point(85, 0);
            pderecho.Name = "pderecho";
            pderecho.Size = new Size(327, 201);
            pderecho.TabIndex = 17;
            // 
            // tbcontrol
            // 
            tbcontrol.Controls.Add(tbpageWelcome);
            tbcontrol.Controls.Add(tbpageFolder);
            tbcontrol.Controls.Add(tbpageText);
            tbcontrol.Dock = DockStyle.Fill;
            tbcontrol.ItemSize = new Size(0, 1);
            tbcontrol.Location = new Point(0, 0);
            tbcontrol.Name = "tbcontrol";
            tbcontrol.SelectedIndex = 0;
            tbcontrol.Size = new Size(327, 201);
            tbcontrol.SizeMode = TabSizeMode.Fixed;
            tbcontrol.TabIndex = 0;
            tbcontrol.TabStop = false;
            // 
            // tbpageWelcome
            // 
            tbpageWelcome.BackColor = Color.FromArgb(12, 48, 63);
            tbpageWelcome.BorderStyle = BorderStyle.Fixed3D;
            tbpageWelcome.Controls.Add(label4);
            tbpageWelcome.Controls.Add(label1);
            tbpageWelcome.Location = new Point(4, 5);
            tbpageWelcome.Name = "tbpageWelcome";
            tbpageWelcome.Padding = new Padding(3);
            tbpageWelcome.Size = new Size(319, 192);
            tbpageWelcome.TabIndex = 0;
            // 
            // tbpageFolder
            // 
            tbpageFolder.BackColor = Color.FromArgb(12, 48, 63);
            tbpageFolder.BorderStyle = BorderStyle.Fixed3D;
            tbpageFolder.Controls.Add(btnCancelar);
            tbpageFolder.Controls.Add(btndesencriptarFolder);
            tbpageFolder.Controls.Add(btnEncriptarFolder);
            tbpageFolder.Controls.Add(btnSearch);
            tbpageFolder.Controls.Add(txtFolder);
            tbpageFolder.Controls.Add(label3);
            tbpageFolder.Location = new Point(4, 5);
            tbpageFolder.Name = "tbpageFolder";
            tbpageFolder.Padding = new Padding(3);
            tbpageFolder.Size = new Size(319, 192);
            tbpageFolder.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(12, 48, 63);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Image = SeguridadInformática.Properties.Resources.MdiBackspaceOutline1;
            btnCancelar.Location = new Point(70, 129);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(40, 40);
            btnCancelar.TabIndex = 18;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btndesencriptarFolder
            // 
            btndesencriptarFolder.Cursor = Cursors.Hand;
            btndesencriptarFolder.FlatAppearance.BorderColor = Color.FromArgb(12, 48, 63);
            btndesencriptarFolder.FlatAppearance.BorderSize = 0;
            btndesencriptarFolder.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btndesencriptarFolder.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btndesencriptarFolder.FlatStyle = FlatStyle.Flat;
            btndesencriptarFolder.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btndesencriptarFolder.Image = SeguridadInformática.Properties.Resources.MdiLockOpenVariantOutline1;
            btndesencriptarFolder.Location = new Point(210, 129);
            btndesencriptarFolder.Name = "btndesencriptarFolder";
            btndesencriptarFolder.Size = new Size(40, 40);
            btndesencriptarFolder.TabIndex = 17;
            btndesencriptarFolder.TextAlign = ContentAlignment.MiddleRight;
            btndesencriptarFolder.UseVisualStyleBackColor = true;
            btndesencriptarFolder.Click += btndesencriptarFolder_Click;
            // 
            // btnEncriptarFolder
            // 
            btnEncriptarFolder.Cursor = Cursors.Hand;
            btnEncriptarFolder.FlatAppearance.BorderColor = Color.FromArgb(12, 48, 63);
            btnEncriptarFolder.FlatAppearance.BorderSize = 0;
            btnEncriptarFolder.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEncriptarFolder.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEncriptarFolder.FlatStyle = FlatStyle.Flat;
            btnEncriptarFolder.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEncriptarFolder.Image = SeguridadInformática.Properties.Resources.MdiLockOutline1;
            btnEncriptarFolder.Location = new Point(140, 129);
            btnEncriptarFolder.Name = "btnEncriptarFolder";
            btnEncriptarFolder.Size = new Size(40, 40);
            btnEncriptarFolder.TabIndex = 16;
            btnEncriptarFolder.UseVisualStyleBackColor = true;
            btnEncriptarFolder.Click += btnEncriptarFolder_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(198, 203, 216);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Image = SeguridadInformática.Properties.Resources.MdiFolderSearchOutline;
            btnSearch.Location = new Point(269, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(40, 40);
            btnSearch.TabIndex = 15;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFolder
            // 
            txtFolder.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFolder.Location = new Point(13, 70);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(252, 26);
            txtFolder.TabIndex = 14;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(31, 185, 211);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(303, 48);
            label3.TabIndex = 13;
            label3.Text = "*Seleccione la carpeta";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbpageText
            // 
            tbpageText.BackColor = Color.FromArgb(12, 48, 63);
            tbpageText.BorderStyle = BorderStyle.Fixed3D;
            tbpageText.Controls.Add(btnClear);
            tbpageText.Controls.Add(btnDesencriptar);
            tbpageText.Controls.Add(btnEncriptar);
            tbpageText.Controls.Add(txtText);
            tbpageText.Controls.Add(label2);
            tbpageText.ForeColor = Color.FromArgb(31, 185, 211);
            tbpageText.Location = new Point(4, 5);
            tbpageText.Name = "tbpageText";
            tbpageText.Padding = new Padding(3);
            tbpageText.Size = new Size(319, 192);
            tbpageText.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(12, 48, 63);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnClear.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Image = SeguridadInformática.Properties.Resources.MdiBackspaceOutline2;
            btnClear.Location = new Point(70, 129);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(40, 40);
            btnClear.TabIndex = 16;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDesencriptar
            // 
            btnDesencriptar.BackColor = Color.Transparent;
            btnDesencriptar.Cursor = Cursors.Hand;
            btnDesencriptar.FlatAppearance.BorderColor = Color.FromArgb(12, 48, 63);
            btnDesencriptar.FlatAppearance.BorderSize = 0;
            btnDesencriptar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnDesencriptar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDesencriptar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDesencriptar.FlatStyle = FlatStyle.Flat;
            btnDesencriptar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDesencriptar.Image = SeguridadInformática.Properties.Resources.MdiLockOpenVariantOutline2;
            btnDesencriptar.Location = new Point(210, 129);
            btnDesencriptar.Name = "btnDesencriptar";
            btnDesencriptar.Size = new Size(40, 40);
            btnDesencriptar.TabIndex = 15;
            btnDesencriptar.UseVisualStyleBackColor = false;
            btnDesencriptar.Click += btnDesencriptar_Click;
            // 
            // btnEncriptar
            // 
            btnEncriptar.BackColor = Color.Transparent;
            btnEncriptar.Cursor = Cursors.Hand;
            btnEncriptar.FlatAppearance.BorderColor = Color.FromArgb(12, 48, 63);
            btnEncriptar.FlatAppearance.BorderSize = 0;
            btnEncriptar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnEncriptar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEncriptar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEncriptar.FlatStyle = FlatStyle.Flat;
            btnEncriptar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEncriptar.Image = SeguridadInformática.Properties.Resources.MdiLockOutline2;
            btnEncriptar.Location = new Point(140, 129);
            btnEncriptar.Name = "btnEncriptar";
            btnEncriptar.Size = new Size(40, 40);
            btnEncriptar.TabIndex = 14;
            btnEncriptar.UseVisualStyleBackColor = false;
            btnEncriptar.Click += btnEncriptar_Click;
            // 
            // txtText
            // 
            txtText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtText.Location = new Point(13, 55);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(285, 58);
            txtText.TabIndex = 13;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(304, 48);
            label2.TabIndex = 12;
            label2.Text = "*Escriba en el cuadro de texto";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(31, 185, 211);
            label4.Location = new Point(186, 172);
            label4.Name = "label4";
            label4.Size = new Size(123, 13);
            label4.TabIndex = 15;
            label4.Text = "Luis Ariel Cuadra Salinas";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 201);
            Controls.Add(pderecho);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            panel1.ResumeLayout(false);
            pderecho.ResumeLayout(false);
            tbcontrol.ResumeLayout(false);
            tbpageWelcome.ResumeLayout(false);
            tbpageWelcome.PerformLayout();
            tbpageFolder.ResumeLayout(false);
            tbpageFolder.PerformLayout();
            tbpageText.ResumeLayout(false);
            tbpageText.PerformLayout();
            ResumeLayout(false);
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
        private Label label4;
    }
}