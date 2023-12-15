
namespace Assets
{
    partial class EditForm
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
            this.SnBox = new System.Windows.Forms.TextBox();
            this.NoBox = new System.Windows.Forms.TextBox();
            this.PdBox = new System.Windows.Forms.TextBox();
            this.IpBox = new System.Windows.Forms.TextBox();
            this.tBox = new System.Windows.Forms.TextBox();
            this.MaBox = new System.Windows.Forms.TextBox();
            this.MoBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SnBox
            // 
            this.SnBox.Location = new System.Drawing.Point(80, 81);
            this.SnBox.Name = "SnBox";
            this.SnBox.Size = new System.Drawing.Size(100, 20);
            this.SnBox.TabIndex = 1;
            // 
            // NoBox
            // 
            this.NoBox.Location = new System.Drawing.Point(80, 325);
            this.NoBox.Name = "NoBox";
            this.NoBox.Size = new System.Drawing.Size(100, 20);
            this.NoBox.TabIndex = 2;
            // 
            // PdBox
            // 
            this.PdBox.Location = new System.Drawing.Point(80, 280);
            this.PdBox.Name = "PdBox";
            this.PdBox.Size = new System.Drawing.Size(100, 20);
            this.PdBox.TabIndex = 3;
            // 
            // IpBox
            // 
            this.IpBox.Location = new System.Drawing.Point(80, 237);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(100, 20);
            this.IpBox.TabIndex = 4;
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(80, 196);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(100, 20);
            this.tBox.TabIndex = 5;
            // 
            // MaBox
            // 
            this.MaBox.Location = new System.Drawing.Point(80, 155);
            this.MaBox.Name = "MaBox";
            this.MaBox.Size = new System.Drawing.Size(100, 20);
            this.MaBox.TabIndex = 6;
            // 
            // MoBox
            // 
            this.MoBox.Location = new System.Drawing.Point(80, 120);
            this.MoBox.Name = "MoBox";
            this.MoBox.Size = new System.Drawing.Size(100, 20);
            this.MoBox.TabIndex = 7;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(80, 38);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 20);
            this.IDBox.TabIndex = 8;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(204, 34);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "FindAsset";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(12, 351);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(96, 87);
            this.goBack.TabIndex = 10;
            this.goBack.Text = "GoBack";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "AssetsID";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.MoBox);
            this.Controls.Add(this.MaBox);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.IpBox);
            this.Controls.Add(this.PdBox);
            this.Controls.Add(this.NoBox);
            this.Controls.Add(this.SnBox);
            this.Controls.Add(this.button1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SnBox;
        private System.Windows.Forms.TextBox NoBox;
        private System.Windows.Forms.TextBox PdBox;
        private System.Windows.Forms.TextBox IpBox;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.TextBox MaBox;
        private System.Windows.Forms.TextBox MoBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label label1;
    }
}