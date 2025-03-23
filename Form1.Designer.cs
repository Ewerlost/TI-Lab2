namespace Streamencryption
{
    partial class Form1
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
            txtRegister = new TextBox();
            lbRegister = new Label();
            btnSelectFile = new Button();
            btnEncrypt = new Button();
            txtKeyBits = new TextBox();
            txtSourceBits = new TextBox();
            txtEncryptedBits = new TextBox();
            lbKey = new Label();
            lbSource = new Label();
            lbDecryption = new Label();
            txtFile = new TextBox();
            SuspendLayout();
            // 
            // txtRegister
            // 
            txtRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtRegister.Location = new Point(12, 83);
            txtRegister.MaxLength = 38;
            txtRegister.Name = "txtRegister";
            txtRegister.Size = new Size(415, 33);
            txtRegister.TabIndex = 0;
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbRegister.ForeColor = SystemColors.ControlText;
            lbRegister.Location = new Point(155, 31);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(79, 25);
            lbRegister.TabIndex = 1;
            lbRegister.Text = "Регистр";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectFile.Location = new Point(12, 201);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(120, 33);
            btnSelectFile.TabIndex = 2;
            btnSelectFile.Text = "Выбор файла";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEncrypt.Location = new Point(28, 305);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(237, 87);
            btnEncrypt.TabIndex = 3;
            btnEncrypt.Text = "Зашифровать/дешифровать";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // txtKeyBits
            // 
            txtKeyBits.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtKeyBits.Location = new Point(446, 67);
            txtKeyBits.Multiline = true;
            txtKeyBits.Name = "txtKeyBits";
            txtKeyBits.ReadOnly = true;
            txtKeyBits.ScrollBars = ScrollBars.Vertical;
            txtKeyBits.Size = new Size(553, 124);
            txtKeyBits.TabIndex = 5;
            // 
            // txtSourceBits
            // 
            txtSourceBits.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSourceBits.Location = new Point(446, 237);
            txtSourceBits.Multiline = true;
            txtSourceBits.Name = "txtSourceBits";
            txtSourceBits.ReadOnly = true;
            txtSourceBits.ScrollBars = ScrollBars.Vertical;
            txtSourceBits.Size = new Size(553, 124);
            txtSourceBits.TabIndex = 6;
            txtSourceBits.TextChanged += textBox3_TextChanged;
            // 
            // txtEncryptedBits
            // 
            txtEncryptedBits.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtEncryptedBits.Location = new Point(446, 424);
            txtEncryptedBits.Multiline = true;
            txtEncryptedBits.Name = "txtEncryptedBits";
            txtEncryptedBits.ReadOnly = true;
            txtEncryptedBits.ScrollBars = ScrollBars.Vertical;
            txtEncryptedBits.Size = new Size(553, 124);
            txtEncryptedBits.TabIndex = 7;
            txtEncryptedBits.TextChanged += textBox4_TextChanged;
            // 
            // lbKey
            // 
            lbKey.AutoSize = true;
            lbKey.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbKey.Location = new Point(686, 22);
            lbKey.Name = "lbKey";
            lbKey.Size = new Size(49, 21);
            lbKey.TabIndex = 8;
            lbKey.Text = "Ключ";
            // 
            // lbSource
            // 
            lbSource.AutoSize = true;
            lbSource.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbSource.Location = new Point(644, 207);
            lbSource.Name = "lbSource";
            lbSource.Size = new Size(147, 21);
            lbSource.TabIndex = 9;
            lbSource.Text = "Изначальные биты";
            // 
            // lbDecryption
            // 
            lbDecryption.AutoSize = true;
            lbDecryption.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbDecryption.Location = new Point(634, 383);
            lbDecryption.Name = "lbDecryption";
            lbDecryption.Size = new Size(171, 21);
            lbDecryption.TabIndex = 10;
            lbDecryption.Text = "Зашифрованные биты";
            lbDecryption.Click += lbDecryption_Click;
            // 
            // txtFile
            // 
            txtFile.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtFile.Location = new Point(164, 201);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(189, 33);
            txtFile.TabIndex = 11;
            txtFile.TextChanged += txtFile_TextChanged;
            txtFile.KeyPress += txtFile_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 581);
            Controls.Add(txtFile);
            Controls.Add(lbDecryption);
            Controls.Add(lbSource);
            Controls.Add(lbKey);
            Controls.Add(txtEncryptedBits);
            Controls.Add(txtSourceBits);
            Controls.Add(txtKeyBits);
            Controls.Add(btnEncrypt);
            Controls.Add(btnSelectFile);
            Controls.Add(lbRegister);
            Controls.Add(txtRegister);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Потоковое шифрование";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRegister;
        private Label lbRegister;
        private Button btnSelectFile;
        private Button btnEncrypt;
        private TextBox txtKeyBits;
        private TextBox txtSourceBits;
        private TextBox txtEncryptedBits;
        private Label lbKey;
        private Label lbSource;
        private Label lbDecryption;
        private TextBox txtFile;
    }
}
