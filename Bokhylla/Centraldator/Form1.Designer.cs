namespace Centraldator
{
    partial class CentralDator
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
            this.lbxCentral = new System.Windows.Forms.ListBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxCentral
            // 
            this.lbxCentral.FormattingEnabled = true;
            this.lbxCentral.ItemHeight = 16;
            this.lbxCentral.Location = new System.Drawing.Point(12, 12);
            this.lbxCentral.Name = "lbxCentral";
            this.lbxCentral.Size = new System.Drawing.Size(567, 372);
            this.lbxCentral.TabIndex = 0;
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(12, 390);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(133, 80);
            this.btnServer.TabIndex = 1;
            this.btnServer.Text = "Starta Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Enabled = false;
            this.btnDelAll.Location = new System.Drawing.Point(151, 390);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(163, 37);
            this.btnDelAll.TabIndex = 2;
            this.btnDelAll.Text = "Ta bort alla objekt";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnSaveText
            // 
            this.btnSaveText.Enabled = false;
            this.btnSaveText.Location = new System.Drawing.Point(320, 390);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(133, 80);
            this.btnSaveText.TabIndex = 4;
            this.btnSaveText.Text = "Exportera till textfil";
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adress: 127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port: 12345";
            // 
            // btnDelMark
            // 
            this.btnDelMark.Enabled = false;
            this.btnDelMark.Location = new System.Drawing.Point(151, 433);
            this.btnDelMark.Name = "btnDelMark";
            this.btnDelMark.Size = new System.Drawing.Size(163, 37);
            this.btnDelMark.TabIndex = 7;
            this.btnDelMark.Text = "Ta bort markerat objekt";
            this.btnDelMark.UseVisualStyleBackColor = true;
            this.btnDelMark.Click += new System.EventHandler(this.btnDelMark_Click);
            // 
            // CentralDator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 480);
            this.Controls.Add(this.btnDelMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveText);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.lbxCentral);
            this.Name = "CentralDator";
            this.Text = "CentralDator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCentral;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelMark;
    }
}

