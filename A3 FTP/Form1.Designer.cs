namespace A3_FTP
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_modpack = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txtBox_Modpack = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_modpack
            // 
            this.btn_modpack.Location = new System.Drawing.Point(380, 79);
            this.btn_modpack.Name = "btn_modpack";
            this.btn_modpack.Size = new System.Drawing.Size(121, 23);
            this.btn_modpack.TabIndex = 0;
            this.btn_modpack.Text = "Open Modpack";
            this.btn_modpack.UseVisualStyleBackColor = true;
            this.btn_modpack.Click += new System.EventHandler(this.btn_modpack_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(161, 150);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(121, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Copy mod IDs";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txtBox_Modpack
            // 
            this.txtBox_Modpack.Location = new System.Drawing.Point(78, 81);
            this.txtBox_Modpack.Name = "txtBox_Modpack";
            this.txtBox_Modpack.Size = new System.Drawing.Size(296, 20);
            this.txtBox_Modpack.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Arma 3 Modpack file to retrieve Mod Ids";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Modpack);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_modpack);
            this.Name = "Form1";
            this.Text = "Mod Id Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_modpack;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txtBox_Modpack;
        private System.Windows.Forms.Label label1;
    }
}

