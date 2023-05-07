namespace VeritabanıGörsel
{
    partial class addCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCustomer));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2_surName = new System.Windows.Forms.TextBox();
            this.textBox1_userName = new System.Windows.Forms.TextBox();
            this.maskedTextBox1_telephone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2_surName
            // 
            resources.ApplyResources(this.textBox2_surName, "textBox2_surName");
            this.textBox2_surName.Name = "textBox2_surName";
            // 
            // textBox1_userName
            // 
            resources.ApplyResources(this.textBox1_userName, "textBox1_userName");
            this.textBox1_userName.Name = "textBox1_userName";
            // 
            // maskedTextBox1_telephone
            // 
            resources.ApplyResources(this.maskedTextBox1_telephone, "maskedTextBox1_telephone");
            this.maskedTextBox1_telephone.Name = "maskedTextBox1_telephone";
            // 
            // addCustomer
            // 
            this.AcceptButton = this.button1;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maskedTextBox1_telephone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2_surName);
            this.Controls.Add(this.textBox1_userName);
            this.Name = "addCustomer";
            this.Load += new System.EventHandler(this.addCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2_surName;
        private System.Windows.Forms.TextBox textBox1_userName;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1_telephone;
    }
}