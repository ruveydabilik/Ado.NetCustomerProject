namespace Ado.NetCustomerProject
{
    partial class FrmMap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenCustomerForm = new System.Windows.Forms.Button();
            this.btnOpenCityForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnOpenCustomerForm);
            this.panel1.Controls.Add(this.btnOpenCityForm);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 336);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(80, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 69);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnOpenCustomerForm
            // 
            this.btnOpenCustomerForm.Location = new System.Drawing.Point(80, 134);
            this.btnOpenCustomerForm.Name = "btnOpenCustomerForm";
            this.btnOpenCustomerForm.Size = new System.Drawing.Size(145, 69);
            this.btnOpenCustomerForm.TabIndex = 1;
            this.btnOpenCustomerForm.Text = "Müşteri İşlemleri";
            this.btnOpenCustomerForm.UseVisualStyleBackColor = true;
            this.btnOpenCustomerForm.Click += new System.EventHandler(this.btnOpenCustomerForm_Click);
            // 
            // btnOpenCityForm
            // 
            this.btnOpenCityForm.Location = new System.Drawing.Point(80, 30);
            this.btnOpenCityForm.Name = "btnOpenCityForm";
            this.btnOpenCityForm.Size = new System.Drawing.Size(145, 69);
            this.btnOpenCityForm.TabIndex = 0;
            this.btnOpenCityForm.Text = "Şehir İşlemleri";
            this.btnOpenCityForm.UseVisualStyleBackColor = true;
            this.btnOpenCityForm.Click += new System.EventHandler(this.btnOpenCityForm_Click);
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 340);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlar";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenCustomerForm;
        private System.Windows.Forms.Button btnOpenCityForm;
    }
}