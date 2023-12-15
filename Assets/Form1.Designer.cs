
namespace Assets
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAssetID = new System.Windows.Forms.TextBox();
            this.textBoxOSManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxOSVersion = new System.Windows.Forms.TextBox();
            this.textBoxOSName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AssetID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "SaveSystem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAssetID
            // 
            this.textBoxAssetID.Location = new System.Drawing.Point(126, 87);
            this.textBoxAssetID.Name = "textBoxAssetID";
            this.textBoxAssetID.Size = new System.Drawing.Size(100, 20);
            this.textBoxAssetID.TabIndex = 1;
            this.textBoxAssetID.TextChanged += new System.EventHandler(this.textBoxAssetID_TextChanged);
            // 
            // textBoxOSManufacturer
            // 
            this.textBoxOSManufacturer.Location = new System.Drawing.Point(126, 165);
            this.textBoxOSManufacturer.Name = "textBoxOSManufacturer";
            this.textBoxOSManufacturer.Size = new System.Drawing.Size(100, 20);
            this.textBoxOSManufacturer.TabIndex = 2;
            // 
            // textBoxOSVersion
            // 
            this.textBoxOSVersion.Location = new System.Drawing.Point(126, 139);
            this.textBoxOSVersion.Name = "textBoxOSVersion";
            this.textBoxOSVersion.Size = new System.Drawing.Size(100, 20);
            this.textBoxOSVersion.TabIndex = 3;
            // 
            // textBoxOSName
            // 
            this.textBoxOSName.Location = new System.Drawing.Point(126, 113);
            this.textBoxOSName.Name = "textBoxOSName";
            this.textBoxOSName.Size = new System.Drawing.Size(100, 20);
            this.textBoxOSName.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 74);
            this.button2.TabIndex = 5;
            this.button2.Text = "GoBack";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AssetID
            // 
            this.AssetID.AutoSize = true;
            this.AssetID.Location = new System.Drawing.Point(56, 87);
            this.AssetID.Name = "AssetID";
            this.AssetID.Size = new System.Drawing.Size(44, 13);
            this.AssetID.TabIndex = 6;
            this.AssetID.Text = "AssetID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AssetID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxOSName);
            this.Controls.Add(this.textBoxOSVersion);
            this.Controls.Add(this.textBoxOSManufacturer);
            this.Controls.Add(this.textBoxAssetID);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAssetID;
        private System.Windows.Forms.TextBox textBoxOSManufacturer;
        private System.Windows.Forms.TextBox textBoxOSVersion;
        private System.Windows.Forms.TextBox textBoxOSName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label AssetID;
    }
}