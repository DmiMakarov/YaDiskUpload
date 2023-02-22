namespace YaDiskUpload
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAuth = new System.Windows.Forms.GroupBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.labelIsAuth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCodeAuth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelAuth = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxUpload = new System.Windows.Forms.GroupBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonBeginUpload = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFolderDisk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonFilePath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxAuth.SuspendLayout();
            this.groupBoxUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAuth
            // 
            this.groupBoxAuth.AutoSize = true;
            this.groupBoxAuth.Controls.Add(this.buttonApply);
            this.groupBoxAuth.Controls.Add(this.labelIsAuth);
            this.groupBoxAuth.Controls.Add(this.label3);
            this.groupBoxAuth.Controls.Add(this.textBoxCodeAuth);
            this.groupBoxAuth.Controls.Add(this.label2);
            this.groupBoxAuth.Controls.Add(this.linkLabelAuth);
            this.groupBoxAuth.Controls.Add(this.label1);
            this.groupBoxAuth.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAuth.Name = "groupBoxAuth";
            this.groupBoxAuth.Size = new System.Drawing.Size(370, 549);
            this.groupBoxAuth.TabIndex = 0;
            this.groupBoxAuth.TabStop = false;
            this.groupBoxAuth.Text = "Авторизация";
            // 
            // buttonApply
            // 
            this.buttonApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonApply.Location = new System.Drawing.Point(10, 310);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(125, 32);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // labelIsAuth
            // 
            this.labelIsAuth.AutoSize = true;
            this.labelIsAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIsAuth.Location = new System.Drawing.Point(6, 426);
            this.labelIsAuth.Name = "labelIsAuth";
            this.labelIsAuth.Size = new System.Drawing.Size(156, 20);
            this.labelIsAuth.TabIndex = 5;
            this.labelIsAuth.Text = "Не авторизовано";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(6, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "3. Статус авторизации";
            // 
            // textBoxCodeAuth
            // 
            this.textBoxCodeAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxCodeAuth.Location = new System.Drawing.Point(10, 255);
            this.textBoxCodeAuth.Name = "textBoxCodeAuth";
            this.textBoxCodeAuth.Size = new System.Drawing.Size(248, 32);
            this.textBoxCodeAuth.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Введите код подтверждения";
            // 
            // linkLabelAuth
            // 
            this.linkLabelAuth.AutoSize = true;
            this.linkLabelAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabelAuth.Location = new System.Drawing.Point(6, 83);
            this.linkLabelAuth.MaximumSize = new System.Drawing.Size(320, 80);
            this.linkLabelAuth.Name = "linkLabelAuth";
            this.linkLabelAuth.Size = new System.Drawing.Size(78, 20);
            this.linkLabelAuth.TabIndex = 1;
            this.linkLabelAuth.TabStop = true;
            this.linkLabelAuth.Text = "someText";
            this.linkLabelAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAuth_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Перейдите по ссылке для авторизации";
            // 
            // groupBoxUpload
            // 
            this.groupBoxUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUpload.AutoSize = true;
            this.groupBoxUpload.Controls.Add(this.checkBoxDelete);
            this.groupBoxUpload.Controls.Add(this.progressBar);
            this.groupBoxUpload.Controls.Add(this.buttonBeginUpload);
            this.groupBoxUpload.Controls.Add(this.label7);
            this.groupBoxUpload.Controls.Add(this.textBoxFolderDisk);
            this.groupBoxUpload.Controls.Add(this.label6);
            this.groupBoxUpload.Controls.Add(this.textBoxFilePath);
            this.groupBoxUpload.Controls.Add(this.buttonFilePath);
            this.groupBoxUpload.Controls.Add(this.label5);
            this.groupBoxUpload.Location = new System.Drawing.Point(416, 12);
            this.groupBoxUpload.Name = "groupBoxUpload";
            this.groupBoxUpload.Size = new System.Drawing.Size(370, 549);
            this.groupBoxUpload.TabIndex = 1;
            this.groupBoxUpload.TabStop = false;
            this.groupBoxUpload.Text = "Загрузка файлов";
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Checked = true;
            this.checkBoxDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxDelete.Location = new System.Drawing.Point(10, 195);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(271, 24);
            this.checkBoxDelete.TabIndex = 14;
            this.checkBoxDelete.Text = "Удалять файлы после загрузки";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(10, 488);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(334, 33);
            this.progressBar.TabIndex = 13;
            // 
            // buttonBeginUpload
            // 
            this.buttonBeginUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeginUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBeginUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBeginUpload.Location = new System.Drawing.Point(10, 426);
            this.buttonBeginUpload.Name = "buttonBeginUpload";
            this.buttonBeginUpload.Size = new System.Drawing.Size(125, 32);
            this.buttonBeginUpload.TabIndex = 12;
            this.buttonBeginUpload.Text = "Начать";
            this.buttonBeginUpload.UseVisualStyleBackColor = true;
            this.buttonBeginUpload.Click += new System.EventHandler(this.buttonBeginUpload_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(7, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "3. Начните загрузку изображений";
            // 
            // textBoxFolderDisk
            // 
            this.textBoxFolderDisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolderDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxFolderDisk.Location = new System.Drawing.Point(11, 309);
            this.textBoxFolderDisk.Name = "textBoxFolderDisk";
            this.textBoxFolderDisk.Size = new System.Drawing.Size(248, 32);
            this.textBoxFolderDisk.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(7, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "2. Укажите название папки на Яндекс.Диске";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxFilePath.Location = new System.Drawing.Point(10, 129);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(248, 32);
            this.textBoxFilePath.TabIndex = 8;
            // 
            // buttonFilePath
            // 
            this.buttonFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFilePath.Location = new System.Drawing.Point(10, 77);
            this.buttonFilePath.Name = "buttonFilePath";
            this.buttonFilePath.Size = new System.Drawing.Size(125, 32);
            this.buttonFilePath.TabIndex = 7;
            this.buttonFilePath.Text = "Выбрать";
            this.buttonFilePath.UseVisualStyleBackColor = true;
            this.buttonFilePath.Click += new System.EventHandler(this.buttonFilePath_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "1. Выберете путь до папки с изображениями";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 578);
            this.Controls.Add(this.groupBoxUpload);
            this.Controls.Add(this.groupBoxAuth);
            this.MinimumSize = new System.Drawing.Size(810, 617);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAuth.ResumeLayout(false);
            this.groupBoxAuth.PerformLayout();
            this.groupBoxUpload.ResumeLayout(false);
            this.groupBoxUpload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAuth;
        private System.Windows.Forms.GroupBox groupBoxUpload;
        private System.Windows.Forms.LinkLabel linkLabelAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label labelIsAuth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCodeAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFilePath;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonBeginUpload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFolderDisk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

