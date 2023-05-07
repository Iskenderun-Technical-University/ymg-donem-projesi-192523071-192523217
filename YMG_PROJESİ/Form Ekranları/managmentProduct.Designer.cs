//MLHIDEFILE
namespace VeritabanıGörsel
{
    partial class managmentProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managmentProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_productName = new System.Windows.Forms.TextBox();
            this.textBox4_Km = new System.Windows.Forms.TextBox();
            this.comboBox1_category = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1_Color = new System.Windows.Forms.TextBox();
            this.richTextBox1_hasar = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2_yakıt = new System.Windows.Forms.ComboBox();
            this.comboBox2_vites = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1_stock = new System.Windows.Forms.TextBox();
            this.comboBox1_use = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1_carsYear = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonsClass4_search = new VeritabanıGörsel.buttonsClass();
            this.textBox1_searchProduct = new System.Windows.Forms.TextBox();
            this.textBox3_productPrice = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.buttonsClass3 = new VeritabanıGörsel.buttonsClass();
            this.buttonsClass2 = new VeritabanıGörsel.buttonsClass();
            this.buttonsClass1 = new VeritabanıGörsel.buttonsClass();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            // textBox1_productName
            // 
            resources.ApplyResources(this.textBox1_productName, "textBox1_productName");
            this.textBox1_productName.Name = "textBox1_productName";
            // 
            // textBox4_Km
            // 
            resources.ApplyResources(this.textBox4_Km, "textBox4_Km");
            this.textBox4_Km.Name = "textBox4_Km";
            this.textBox4_Km.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_Km_KeyPress);
            // 
            // comboBox1_category
            // 
            this.comboBox1_category.FormattingEnabled = true;
            this.comboBox1_category.Items.AddRange(new object[] {
            resources.GetString("comboBox1_category.Items"),
            resources.GetString("comboBox1_category.Items1"),
            resources.GetString("comboBox1_category.Items2"),
            resources.GetString("comboBox1_category.Items3"),
            resources.GetString("comboBox1_category.Items4"),
            resources.GetString("comboBox1_category.Items5")});
            resources.ApplyResources(this.comboBox1_category, "comboBox1_category");
            this.comboBox1_category.Name = "comboBox1_category";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBox1_Color
            // 
            resources.ApplyResources(this.textBox1_Color, "textBox1_Color");
            this.textBox1_Color.Name = "textBox1_Color";
            // 
            // richTextBox1_hasar
            // 
            resources.ApplyResources(this.richTextBox1_hasar, "richTextBox1_hasar");
            this.richTextBox1_hasar.Name = "richTextBox1_hasar";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // comboBox2_yakıt
            // 
            this.comboBox2_yakıt.FormattingEnabled = true;
            this.comboBox2_yakıt.Items.AddRange(new object[] {
            resources.GetString("comboBox2_yakıt.Items"),
            resources.GetString("comboBox2_yakıt.Items1"),
            resources.GetString("comboBox2_yakıt.Items2"),
            resources.GetString("comboBox2_yakıt.Items3")});
            resources.ApplyResources(this.comboBox2_yakıt, "comboBox2_yakıt");
            this.comboBox2_yakıt.Name = "comboBox2_yakıt";
            // 
            // comboBox2_vites
            // 
            this.comboBox2_vites.FormattingEnabled = true;
            this.comboBox2_vites.Items.AddRange(new object[] {
            resources.GetString("comboBox2_vites.Items"),
            resources.GetString("comboBox2_vites.Items1"),
            resources.GetString("comboBox2_vites.Items2"),
            resources.GetString("comboBox2_vites.Items3")});
            resources.ApplyResources(this.comboBox2_vites, "comboBox2_vites");
            this.comboBox2_vites.Name = "comboBox2_vites";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // textBox1_stock
            // 
            resources.ApplyResources(this.textBox1_stock, "textBox1_stock");
            this.textBox1_stock.Name = "textBox1_stock";
            this.textBox1_stock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_stock_KeyDown);
            this.textBox1_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_stock_KeyPress);
            // 
            // comboBox1_use
            // 
            this.comboBox1_use.FormattingEnabled = true;
            this.comboBox1_use.Items.AddRange(new object[] {
            resources.GetString("comboBox1_use.Items"),
            resources.GetString("comboBox1_use.Items1"),
            resources.GetString("comboBox1_use.Items2")});
            resources.ApplyResources(this.comboBox1_use, "comboBox1_use");
            this.comboBox1_use.Name = "comboBox1_use";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Checked = true;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton3_MouseClick);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // radioButton5
            // 
            resources.ApplyResources(this.radioButton5, "radioButton5");
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            resources.ApplyResources(this.radioButton4, "radioButton4");
            this.radioButton4.Checked = true;
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // textBox1_carsYear
            // 
            resources.ApplyResources(this.textBox1_carsYear, "textBox1_carsYear");
            this.textBox1_carsYear.Name = "textBox1_carsYear";
            this.textBox1_carsYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_carsYear_KeyDown);
            this.textBox1_carsYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_carsYear_KeyPress);
            // 
            // buttonsClass4_search
            // 
            this.buttonsClass4_search.BackColor = System.Drawing.Color.DimGray;
            this.buttonsClass4_search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsClass4_search.BorderRadius = 10;
            this.buttonsClass4_search.BorderSize = 0;
            this.buttonsClass4_search.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonsClass4_search, "buttonsClass4_search");
            this.buttonsClass4_search.ForeColor = System.Drawing.Color.White;
            this.buttonsClass4_search.Name = "buttonsClass4_search";
            this.toolTip1.SetToolTip(this.buttonsClass4_search, resources.GetString("buttonsClass4_search.ToolTip"));
            this.buttonsClass4_search.UseVisualStyleBackColor = false;
            this.buttonsClass4_search.Click += new System.EventHandler(this.buttonsClass4_search_Click);
            // 
            // textBox1_searchProduct
            // 
            resources.ApplyResources(this.textBox1_searchProduct, "textBox1_searchProduct");
            this.textBox1_searchProduct.Name = "textBox1_searchProduct";
            this.textBox1_searchProduct.TextChanged += new System.EventHandler(this.textBox1_searchProduct_TextChanged);
            // 
            // textBox3_productPrice
            // 
            resources.ApplyResources(this.textBox3_productPrice, "textBox3_productPrice");
            this.textBox3_productPrice.Name = "textBox3_productPrice";
            // 
            // maskedTextBox1
            // 
            resources.ApplyResources(this.maskedTextBox1, "maskedTextBox1");
            this.maskedTextBox1.Name = "maskedTextBox1";
            // 
            // maskedTextBox2
            // 
            resources.ApplyResources(this.maskedTextBox2, "maskedTextBox2");
            this.maskedTextBox2.Name = "maskedTextBox2";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // radioButton8
            // 
            resources.ApplyResources(this.radioButton8, "radioButton8");
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // buttonsClass3
            // 
            this.buttonsClass3.BackColor = System.Drawing.Color.Red;
            this.buttonsClass3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsClass3.BorderRadius = 0;
            this.buttonsClass3.BorderSize = 0;
            this.buttonsClass3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonsClass3, "buttonsClass3");
            this.buttonsClass3.ForeColor = System.Drawing.Color.Black;
            this.buttonsClass3.Name = "buttonsClass3";
            this.buttonsClass3.UseVisualStyleBackColor = false;
            this.buttonsClass3.Click += new System.EventHandler(this.buttonsClass3_Click);
            // 
            // buttonsClass2
            // 
            this.buttonsClass2.BackColor = System.Drawing.Color.Green;
            this.buttonsClass2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsClass2.BorderRadius = 0;
            this.buttonsClass2.BorderSize = 0;
            this.buttonsClass2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonsClass2, "buttonsClass2");
            this.buttonsClass2.ForeColor = System.Drawing.Color.Black;
            this.buttonsClass2.Name = "buttonsClass2";
            this.buttonsClass2.UseVisualStyleBackColor = false;
            this.buttonsClass2.Click += new System.EventHandler(this.buttonsClass2_Click);
            // 
            // buttonsClass1
            // 
            this.buttonsClass1.BackColor = System.Drawing.Color.Gold;
            this.buttonsClass1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsClass1.BorderRadius = 0;
            this.buttonsClass1.BorderSize = 0;
            this.buttonsClass1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonsClass1, "buttonsClass1");
            this.buttonsClass1.ForeColor = System.Drawing.Color.Black;
            this.buttonsClass1.Name = "buttonsClass1";
            this.buttonsClass1.UseVisualStyleBackColor = false;
            this.buttonsClass1.Click += new System.EventHandler(this.buttonsClass1_Click);
            // 
            // managmentProduct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox3_productPrice);
            this.Controls.Add(this.buttonsClass4_search);
            this.Controls.Add(this.textBox1_carsYear);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1_searchProduct);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1_use);
            this.Controls.Add(this.textBox1_stock);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox2_vites);
            this.Controls.Add(this.buttonsClass3);
            this.Controls.Add(this.buttonsClass2);
            this.Controls.Add(this.buttonsClass1);
            this.Controls.Add(this.comboBox2_yakıt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTextBox1_hasar);
            this.Controls.Add(this.textBox1_Color);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1_category);
            this.Controls.Add(this.textBox4_Km);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1_productName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "managmentProduct";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.managmentProduct_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_productName;
        private System.Windows.Forms.TextBox textBox4_Km;
        private System.Windows.Forms.ComboBox comboBox1_category;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1_Color;
        private System.Windows.Forms.RichTextBox richTextBox1_hasar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2_yakıt;
        private buttonsClass buttonsClass1;
        private buttonsClass buttonsClass2;
        private buttonsClass buttonsClass3;
        private System.Windows.Forms.ComboBox comboBox2_vites;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1_stock;
        private System.Windows.Forms.ComboBox comboBox1_use;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1_carsYear;
        private buttonsClass buttonsClass4_search;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1_searchProduct;
        private System.Windows.Forms.MaskedTextBox textBox3_productPrice;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radioButton8;
    }
}