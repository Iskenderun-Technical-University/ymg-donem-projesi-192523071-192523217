namespace VeritabanıGörsel
{
    partial class AddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsers));
            this.textBox1_userName = new System.Windows.Forms.TextBox();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.textBox2_passwordTry = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1_admin = new System.Windows.Forms.RadioButton();
            this.radioButton1_personel = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1_userName
            // 
            resources.ApplyResources(this.textBox1_userName, "textBox1_userName");
            this.textBox1_userName.Name = "textBox1_userName";
            // 
            // textBox2_password
            // 
            resources.ApplyResources(this.textBox2_password, "textBox2_password");
            this.textBox2_password.Name = "textBox2_password";
            // 
            // textBox2_passwordTry
            // 
            resources.ApplyResources(this.textBox2_passwordTry, "textBox2_passwordTry");
            this.textBox2_passwordTry.Name = "textBox2_passwordTry";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // radioButton1_admin
            // 
            resources.ApplyResources(this.radioButton1_admin, "radioButton1_admin");
            this.radioButton1_admin.Name = "radioButton1_admin";
            this.radioButton1_admin.UseVisualStyleBackColor = true;
            // 
            // radioButton1_personel
            // 
            resources.ApplyResources(this.radioButton1_personel, "radioButton1_personel");
            this.radioButton1_personel.Checked = true;
            this.radioButton1_personel.Name = "radioButton1_personel";
            this.radioButton1_personel.TabStop = true;
            this.radioButton1_personel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // AddUsers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton1_personel);
            this.Controls.Add(this.radioButton1_admin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2_passwordTry);
            this.Controls.Add(this.textBox2_password);
            this.Controls.Add(this.textBox1_userName);
            this.Name = "AddUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_userName;
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.TextBox textBox2_passwordTry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1_admin;
        private System.Windows.Forms.RadioButton radioButton1_personel;
        private System.Windows.Forms.Label label4;
    }
}