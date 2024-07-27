
namespace VoltageDropCalculator
{
    partial class BatchConverter
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
            this.btn_UploadFile = new System.Windows.Forms.Button();
            this.txt_fileUploaded = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_orgshortCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_UploadFile
            // 
            this.btn_UploadFile.Location = new System.Drawing.Point(200, 217);
            this.btn_UploadFile.Name = "btn_UploadFile";
            this.btn_UploadFile.Size = new System.Drawing.Size(87, 29);
            this.btn_UploadFile.TabIndex = 0;
            this.btn_UploadFile.Text = "Upload File";
            this.btn_UploadFile.UseVisualStyleBackColor = true;
            this.btn_UploadFile.Click += new System.EventHandler(this.btn_UploadFile_Click);
            // 
            // txt_fileUploaded
            // 
            this.txt_fileUploaded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fileUploaded.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fileUploaded.Location = new System.Drawing.Point(291, 220);
            this.txt_fileUploaded.Name = "txt_fileUploaded";
            this.txt_fileUploaded.Size = new System.Drawing.Size(246, 24);
            this.txt_fileUploaded.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(450, 262);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 29);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Generate";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_data
            // 
            this.txt_data.Font = new System.Drawing.Font("Open Sans", 9F);
            this.txt_data.Location = new System.Drawing.Point(495, 177);
            this.txt_data.Multiline = true;
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(42, 21);
            this.txt_data.TabIndex = 3;
            this.txt_data.Visible = false;
            // 
            // txt_orgshortCode
            // 
            this.txt_orgshortCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_orgshortCode.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orgshortCode.Location = new System.Drawing.Point(200, 177);
            this.txt_orgshortCode.MaxLength = 15;
            this.txt_orgshortCode.Name = "txt_orgshortCode";
            this.txt_orgshortCode.Size = new System.Drawing.Size(289, 24);
            this.txt_orgshortCode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Organization Short Code";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BatchConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_orgshortCode);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_fileUploaded);
            this.Controls.Add(this.btn_UploadFile);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BatchConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_UploadFile;
        private System.Windows.Forms.TextBox txt_fileUploaded;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_orgshortCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

