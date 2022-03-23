namespace Lesson3WFhomework.Views
{
    partial class MainView
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
            this.grpb_TotalPay = new System.Windows.Forms.GroupBox();
            this.btn_pay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_pay3 = new System.Windows.Forms.Label();
            this.grpb_cafe = new System.Windows.Forms.GroupBox();
            this.ckb_cocacola = new System.Windows.Forms.CheckBox();
            this.ckb_potFree = new System.Windows.Forms.CheckBox();
            this.ckb_hamburger = new System.Windows.Forms.CheckBox();
            this.ckb_hotdog = new System.Windows.Forms.CheckBox();
            this.grpb_topay2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_pay2 = new System.Windows.Forms.Label();
            this.txtb_colaCount = new System.Windows.Forms.TextBox();
            this.txtb_colaPrice = new System.Windows.Forms.TextBox();
            this.txtb_pttCount = new System.Windows.Forms.TextBox();
            this.txtb_pttPrice = new System.Windows.Forms.TextBox();
            this.txtb_hambCount = new System.Windows.Forms.TextBox();
            this.txtb_hambPrice = new System.Windows.Forms.TextBox();
            this.txtb_hotdogcount = new System.Windows.Forms.TextBox();
            this.txtb_hotdogPrice = new System.Windows.Forms.TextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_priceMC = new System.Windows.Forms.Label();
            this.grpb_gasST = new System.Windows.Forms.GroupBox();
            this.grpb_topay1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_pay1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_priceG = new System.Windows.Forms.TextBox();
            this.txtb_quantity = new System.Windows.Forms.TextBox();
            this.grpb_QP = new System.Windows.Forms.GroupBox();
            this.rb_price = new System.Windows.Forms.RadioButton();
            this.rb_quantity = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_priceGS = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.cmbb_gasoline = new System.Windows.Forms.ComboBox();
            this.lbl_gasoline = new System.Windows.Forms.Label();
            this.grpb_TotalPay.SuspendLayout();
            this.grpb_cafe.SuspendLayout();
            this.grpb_topay2.SuspendLayout();
            this.grpb_gasST.SuspendLayout();
            this.grpb_topay1.SuspendLayout();
            this.grpb_QP.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpb_TotalPay
            // 
            this.grpb_TotalPay.Controls.Add(this.btn_pay);
            this.grpb_TotalPay.Controls.Add(this.label7);
            this.grpb_TotalPay.Controls.Add(this.btn_calculate);
            this.grpb_TotalPay.Controls.Add(this.lbl_pay3);
            this.grpb_TotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpb_TotalPay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpb_TotalPay.Location = new System.Drawing.Point(13, 328);
            this.grpb_TotalPay.Name = "grpb_TotalPay";
            this.grpb_TotalPay.Size = new System.Drawing.Size(485, 100);
            this.grpb_TotalPay.TabIndex = 15;
            this.grpb_TotalPay.TabStop = false;
            this.grpb_TotalPay.Text = "TOTAL to pay";
            // 
            // btn_pay
            // 
            this.btn_pay.BackgroundImage = global::Lesson3WFhomework.Properties.Resources.apple_pay;
            this.btn_pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pay.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pay.Location = new System.Drawing.Point(138, 28);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(146, 61);
            this.btn_pay.TabIndex = 14;
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(441, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "man.";
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackgroundImage = global::Lesson3WFhomework.Properties.Resources.header;
            this.btn_calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_calculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_calculate.Location = new System.Drawing.Point(17, 28);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(112, 61);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_pay3
            // 
            this.lbl_pay3.AutoSize = true;
            this.lbl_pay3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_pay3.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_pay3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_pay3.Location = new System.Drawing.Point(304, 41);
            this.lbl_pay3.Name = "lbl_pay3";
            this.lbl_pay3.Size = new System.Drawing.Size(85, 43);
            this.lbl_pay3.TabIndex = 12;
            this.lbl_pay3.Text = "0,00";
            // 
            // grpb_cafe
            // 
            this.grpb_cafe.Controls.Add(this.ckb_cocacola);
            this.grpb_cafe.Controls.Add(this.ckb_potFree);
            this.grpb_cafe.Controls.Add(this.ckb_hamburger);
            this.grpb_cafe.Controls.Add(this.ckb_hotdog);
            this.grpb_cafe.Controls.Add(this.grpb_topay2);
            this.grpb_cafe.Controls.Add(this.txtb_colaCount);
            this.grpb_cafe.Controls.Add(this.txtb_colaPrice);
            this.grpb_cafe.Controls.Add(this.txtb_pttCount);
            this.grpb_cafe.Controls.Add(this.txtb_pttPrice);
            this.grpb_cafe.Controls.Add(this.txtb_hambCount);
            this.grpb_cafe.Controls.Add(this.txtb_hambPrice);
            this.grpb_cafe.Controls.Add(this.txtb_hotdogcount);
            this.grpb_cafe.Controls.Add(this.txtb_hotdogPrice);
            this.grpb_cafe.Controls.Add(this.lbl_count);
            this.grpb_cafe.Controls.Add(this.lbl_priceMC);
            this.grpb_cafe.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpb_cafe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpb_cafe.Location = new System.Drawing.Point(271, 17);
            this.grpb_cafe.Name = "grpb_cafe";
            this.grpb_cafe.Size = new System.Drawing.Size(227, 291);
            this.grpb_cafe.TabIndex = 14;
            this.grpb_cafe.TabStop = false;
            this.grpb_cafe.Text = "Mini-Cafe";
            // 
            // ckb_cocacola
            // 
            this.ckb_cocacola.AutoSize = true;
            this.ckb_cocacola.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckb_cocacola.ForeColor = System.Drawing.Color.White;
            this.ckb_cocacola.Location = new System.Drawing.Point(16, 164);
            this.ckb_cocacola.Name = "ckb_cocacola";
            this.ckb_cocacola.Size = new System.Drawing.Size(76, 20);
            this.ckb_cocacola.TabIndex = 16;
            this.ckb_cocacola.Text = "Coca-Cola";
            this.ckb_cocacola.UseVisualStyleBackColor = true;
            this.ckb_cocacola.CheckedChanged += new System.EventHandler(this.ckb_hotdog_CheckedChanged);
            // 
            // ckb_potFree
            // 
            this.ckb_potFree.AutoSize = true;
            this.ckb_potFree.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckb_potFree.ForeColor = System.Drawing.Color.White;
            this.ckb_potFree.Location = new System.Drawing.Point(16, 129);
            this.ckb_potFree.Name = "ckb_potFree";
            this.ckb_potFree.Size = new System.Drawing.Size(90, 20);
            this.ckb_potFree.TabIndex = 15;
            this.ckb_potFree.Text = "Potatoe Free";
            this.ckb_potFree.UseVisualStyleBackColor = true;
            this.ckb_potFree.CheckedChanged += new System.EventHandler(this.ckb_hotdog_CheckedChanged);
            // 
            // ckb_hamburger
            // 
            this.ckb_hamburger.AutoSize = true;
            this.ckb_hamburger.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckb_hamburger.ForeColor = System.Drawing.Color.White;
            this.ckb_hamburger.Location = new System.Drawing.Point(16, 92);
            this.ckb_hamburger.Name = "ckb_hamburger";
            this.ckb_hamburger.Size = new System.Drawing.Size(85, 20);
            this.ckb_hamburger.TabIndex = 14;
            this.ckb_hamburger.Text = "Hamburger";
            this.ckb_hamburger.UseVisualStyleBackColor = true;
            this.ckb_hamburger.CheckedChanged += new System.EventHandler(this.ckb_hotdog_CheckedChanged);
            // 
            // ckb_hotdog
            // 
            this.ckb_hotdog.AutoSize = true;
            this.ckb_hotdog.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckb_hotdog.ForeColor = System.Drawing.Color.White;
            this.ckb_hotdog.Location = new System.Drawing.Point(16, 54);
            this.ckb_hotdog.Name = "ckb_hotdog";
            this.ckb_hotdog.Size = new System.Drawing.Size(68, 20);
            this.ckb_hotdog.TabIndex = 13;
            this.ckb_hotdog.Text = "Hot-Dog";
            this.ckb_hotdog.UseVisualStyleBackColor = true;
            this.ckb_hotdog.CheckedChanged += new System.EventHandler(this.ckb_hotdog_CheckedChanged);
            // 
            // grpb_topay2
            // 
            this.grpb_topay2.Controls.Add(this.label5);
            this.grpb_topay2.Controls.Add(this.lbl_pay2);
            this.grpb_topay2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpb_topay2.Location = new System.Drawing.Point(11, 203);
            this.grpb_topay2.Name = "grpb_topay2";
            this.grpb_topay2.Size = new System.Drawing.Size(205, 79);
            this.grpb_topay2.TabIndex = 12;
            this.grpb_topay2.TabStop = false;
            this.grpb_topay2.Text = "To pay:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(166, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "man.";
            // 
            // lbl_pay2
            // 
            this.lbl_pay2.AutoSize = true;
            this.lbl_pay2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_pay2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_pay2.ForeColor = System.Drawing.Color.White;
            this.lbl_pay2.Location = new System.Drawing.Point(48, 27);
            this.lbl_pay2.Name = "lbl_pay2";
            this.lbl_pay2.Size = new System.Drawing.Size(72, 37);
            this.lbl_pay2.TabIndex = 0;
            this.lbl_pay2.Text = "0,00";
            // 
            // txtb_colaCount
            // 
            this.txtb_colaCount.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_colaCount.Location = new System.Drawing.Point(162, 163);
            this.txtb_colaCount.Name = "txtb_colaCount";
            this.txtb_colaCount.Size = new System.Drawing.Size(39, 25);
            this.txtb_colaCount.TabIndex = 9;
            this.txtb_colaCount.TextChanged += new System.EventHandler(this.txtb_hotdogcount_TextChanged);
            // 
            // txtb_colaPrice
            // 
            this.txtb_colaPrice.Enabled = false;
            this.txtb_colaPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_colaPrice.Location = new System.Drawing.Point(106, 163);
            this.txtb_colaPrice.Name = "txtb_colaPrice";
            this.txtb_colaPrice.Size = new System.Drawing.Size(39, 21);
            this.txtb_colaPrice.TabIndex = 8;
            this.txtb_colaPrice.Text = "4,40";
            // 
            // txtb_pttCount
            // 
            this.txtb_pttCount.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_pttCount.Location = new System.Drawing.Point(162, 128);
            this.txtb_pttCount.Name = "txtb_pttCount";
            this.txtb_pttCount.Size = new System.Drawing.Size(39, 25);
            this.txtb_pttCount.TabIndex = 7;
            this.txtb_pttCount.TextChanged += new System.EventHandler(this.txtb_hotdogcount_TextChanged);
            // 
            // txtb_pttPrice
            // 
            this.txtb_pttPrice.Enabled = false;
            this.txtb_pttPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_pttPrice.Location = new System.Drawing.Point(106, 128);
            this.txtb_pttPrice.Name = "txtb_pttPrice";
            this.txtb_pttPrice.Size = new System.Drawing.Size(39, 21);
            this.txtb_pttPrice.TabIndex = 6;
            this.txtb_pttPrice.Text = "7,20";
            // 
            // txtb_hambCount
            // 
            this.txtb_hambCount.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_hambCount.Location = new System.Drawing.Point(162, 90);
            this.txtb_hambCount.Name = "txtb_hambCount";
            this.txtb_hambCount.Size = new System.Drawing.Size(39, 25);
            this.txtb_hambCount.TabIndex = 5;
            this.txtb_hambCount.TextChanged += new System.EventHandler(this.txtb_hotdogcount_TextChanged);
            // 
            // txtb_hambPrice
            // 
            this.txtb_hambPrice.Enabled = false;
            this.txtb_hambPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_hambPrice.Location = new System.Drawing.Point(106, 90);
            this.txtb_hambPrice.Name = "txtb_hambPrice";
            this.txtb_hambPrice.Size = new System.Drawing.Size(39, 21);
            this.txtb_hambPrice.TabIndex = 4;
            this.txtb_hambPrice.Text = "5,40";
            // 
            // txtb_hotdogcount
            // 
            this.txtb_hotdogcount.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_hotdogcount.Location = new System.Drawing.Point(162, 52);
            this.txtb_hotdogcount.Name = "txtb_hotdogcount";
            this.txtb_hotdogcount.Size = new System.Drawing.Size(39, 25);
            this.txtb_hotdogcount.TabIndex = 3;
            this.txtb_hotdogcount.TextChanged += new System.EventHandler(this.txtb_hotdogcount_TextChanged);
            // 
            // txtb_hotdogPrice
            // 
            this.txtb_hotdogPrice.Enabled = false;
            this.txtb_hotdogPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_hotdogPrice.Location = new System.Drawing.Point(106, 52);
            this.txtb_hotdogPrice.Name = "txtb_hotdogPrice";
            this.txtb_hotdogPrice.Size = new System.Drawing.Size(39, 21);
            this.txtb_hotdogPrice.TabIndex = 2;
            this.txtb_hotdogPrice.Text = "4,00";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_count.ForeColor = System.Drawing.Color.White;
            this.lbl_count.Location = new System.Drawing.Point(163, 25);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(38, 16);
            this.lbl_count.TabIndex = 1;
            this.lbl_count.Text = "Count";
            // 
            // lbl_priceMC
            // 
            this.lbl_priceMC.AutoSize = true;
            this.lbl_priceMC.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_priceMC.ForeColor = System.Drawing.Color.White;
            this.lbl_priceMC.Location = new System.Drawing.Point(107, 25);
            this.lbl_priceMC.Name = "lbl_priceMC";
            this.lbl_priceMC.Size = new System.Drawing.Size(33, 16);
            this.lbl_priceMC.TabIndex = 0;
            this.lbl_priceMC.Text = "Price";
            // 
            // grpb_gasST
            // 
            this.grpb_gasST.Controls.Add(this.grpb_topay1);
            this.grpb_gasST.Controls.Add(this.label3);
            this.grpb_gasST.Controls.Add(this.label2);
            this.grpb_gasST.Controls.Add(this.txtb_priceG);
            this.grpb_gasST.Controls.Add(this.txtb_quantity);
            this.grpb_gasST.Controls.Add(this.grpb_QP);
            this.grpb_gasST.Controls.Add(this.label1);
            this.grpb_gasST.Controls.Add(this.txtb_priceGS);
            this.grpb_gasST.Controls.Add(this.lbl_price);
            this.grpb_gasST.Controls.Add(this.cmbb_gasoline);
            this.grpb_gasST.Controls.Add(this.lbl_gasoline);
            this.grpb_gasST.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpb_gasST.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpb_gasST.Location = new System.Drawing.Point(12, 17);
            this.grpb_gasST.Name = "grpb_gasST";
            this.grpb_gasST.Size = new System.Drawing.Size(227, 291);
            this.grpb_gasST.TabIndex = 13;
            this.grpb_gasST.TabStop = false;
            this.grpb_gasST.Text = "Gas Station";
            // 
            // grpb_topay1
            // 
            this.grpb_topay1.Controls.Add(this.label4);
            this.grpb_topay1.Controls.Add(this.lbl_pay1);
            this.grpb_topay1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpb_topay1.Location = new System.Drawing.Point(11, 203);
            this.grpb_topay1.Name = "grpb_topay1";
            this.grpb_topay1.Size = new System.Drawing.Size(205, 79);
            this.grpb_topay1.TabIndex = 10;
            this.grpb_topay1.TabStop = false;
            this.grpb_topay1.Text = "To pay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(166, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "man.";
            // 
            // lbl_pay1
            // 
            this.lbl_pay1.AutoSize = true;
            this.lbl_pay1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_pay1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_pay1.ForeColor = System.Drawing.Color.White;
            this.lbl_pay1.Location = new System.Drawing.Point(47, 27);
            this.lbl_pay1.Name = "lbl_pay1";
            this.lbl_pay1.Size = new System.Drawing.Size(72, 37);
            this.lbl_pay1.TabIndex = 0;
            this.lbl_pay1.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(183, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "man.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(183, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "l.";
            // 
            // txtb_priceG
            // 
            this.txtb_priceG.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_priceG.Location = new System.Drawing.Point(118, 162);
            this.txtb_priceG.Name = "txtb_priceG";
            this.txtb_priceG.Size = new System.Drawing.Size(59, 25);
            this.txtb_priceG.TabIndex = 7;
            this.txtb_priceG.TextChanged += new System.EventHandler(this.txtb_priceG_TextChanged);
            // 
            // txtb_quantity
            // 
            this.txtb_quantity.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_quantity.Location = new System.Drawing.Point(118, 133);
            this.txtb_quantity.Name = "txtb_quantity";
            this.txtb_quantity.Size = new System.Drawing.Size(59, 25);
            this.txtb_quantity.TabIndex = 6;
            this.txtb_quantity.TextChanged += new System.EventHandler(this.txtb_quantity_TextChanged);
            // 
            // grpb_QP
            // 
            this.grpb_QP.BackColor = System.Drawing.SystemColors.ControlText;
            this.grpb_QP.Controls.Add(this.rb_price);
            this.grpb_QP.Controls.Add(this.rb_quantity);
            this.grpb_QP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpb_QP.Location = new System.Drawing.Point(11, 121);
            this.grpb_QP.Name = "grpb_QP";
            this.grpb_QP.Size = new System.Drawing.Size(100, 67);
            this.grpb_QP.TabIndex = 5;
            this.grpb_QP.TabStop = false;
            // 
            // rb_price
            // 
            this.rb_price.AutoSize = true;
            this.rb_price.Font = new System.Drawing.Font("Sitka Text", 8.25F);
            this.rb_price.ForeColor = System.Drawing.Color.White;
            this.rb_price.Location = new System.Drawing.Point(7, 41);
            this.rb_price.Name = "rb_price";
            this.rb_price.Size = new System.Drawing.Size(51, 20);
            this.rb_price.TabIndex = 1;
            this.rb_price.TabStop = true;
            this.rb_price.Text = "Price";
            this.rb_price.UseVisualStyleBackColor = true;
            this.rb_price.CheckedChanged += new System.EventHandler(this.rb_price_CheckedChanged);
            // 
            // rb_quantity
            // 
            this.rb_quantity.AutoSize = true;
            this.rb_quantity.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_quantity.ForeColor = System.Drawing.Color.White;
            this.rb_quantity.Location = new System.Drawing.Point(7, 13);
            this.rb_quantity.Name = "rb_quantity";
            this.rb_quantity.Size = new System.Drawing.Size(71, 20);
            this.rb_quantity.TabIndex = 0;
            this.rb_quantity.TabStop = true;
            this.rb_quantity.Text = "Quantity";
            this.rb_quantity.UseVisualStyleBackColor = false;
            this.rb_quantity.CheckedChanged += new System.EventHandler(this.rb_quantity_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "man.";
            // 
            // txtb_priceGS
            // 
            this.txtb_priceGS.Enabled = false;
            this.txtb_priceGS.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_priceGS.Location = new System.Drawing.Point(68, 81);
            this.txtb_priceGS.Name = "txtb_priceGS";
            this.txtb_priceGS.Size = new System.Drawing.Size(109, 21);
            this.txtb_priceGS.TabIndex = 3;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Sitka Text", 9F);
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(8, 82);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(36, 18);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Price";
            // 
            // cmbb_gasoline
            // 
            this.cmbb_gasoline.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbb_gasoline.FormattingEnabled = true;
            this.cmbb_gasoline.Items.AddRange(new object[] {
            "AI-76",
            "AI-95",
            "AI-98",
            "Dizel"});
            this.cmbb_gasoline.Location = new System.Drawing.Point(68, 29);
            this.cmbb_gasoline.Name = "cmbb_gasoline";
            this.cmbb_gasoline.Size = new System.Drawing.Size(109, 27);
            this.cmbb_gasoline.TabIndex = 1;
            this.cmbb_gasoline.SelectedIndexChanged += new System.EventHandler(this.cmbb_gasoline_SelectedIndexChanged);
            // 
            // lbl_gasoline
            // 
            this.lbl_gasoline.AutoSize = true;
            this.lbl_gasoline.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_gasoline.ForeColor = System.Drawing.Color.White;
            this.lbl_gasoline.Location = new System.Drawing.Point(8, 30);
            this.lbl_gasoline.Name = "lbl_gasoline";
            this.lbl_gasoline.Size = new System.Drawing.Size(56, 18);
            this.lbl_gasoline.TabIndex = 0;
            this.lbl_gasoline.Text = "Gasoline";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(510, 444);
            this.Controls.Add(this.grpb_TotalPay);
            this.Controls.Add(this.grpb_cafe);
            this.Controls.Add(this.grpb_gasST);
            this.MaximumSize = new System.Drawing.Size(526, 483);
            this.MinimumSize = new System.Drawing.Size(526, 483);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.grpb_TotalPay.ResumeLayout(false);
            this.grpb_TotalPay.PerformLayout();
            this.grpb_cafe.ResumeLayout(false);
            this.grpb_cafe.PerformLayout();
            this.grpb_topay2.ResumeLayout(false);
            this.grpb_topay2.PerformLayout();
            this.grpb_gasST.ResumeLayout(false);
            this.grpb_gasST.PerformLayout();
            this.grpb_topay1.ResumeLayout(false);
            this.grpb_topay1.PerformLayout();
            this.grpb_QP.ResumeLayout(false);
            this.grpb_QP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpb_TotalPay;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_pay3;
        private System.Windows.Forms.GroupBox grpb_cafe;
        private System.Windows.Forms.CheckBox ckb_cocacola;
        private System.Windows.Forms.CheckBox ckb_potFree;
        private System.Windows.Forms.CheckBox ckb_hamburger;
        private System.Windows.Forms.CheckBox ckb_hotdog;
        private System.Windows.Forms.GroupBox grpb_topay2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_pay2;
        private System.Windows.Forms.TextBox txtb_colaCount;
        private System.Windows.Forms.TextBox txtb_colaPrice;
        private System.Windows.Forms.TextBox txtb_pttCount;
        private System.Windows.Forms.TextBox txtb_pttPrice;
        private System.Windows.Forms.TextBox txtb_hambCount;
        private System.Windows.Forms.TextBox txtb_hambPrice;
        private System.Windows.Forms.TextBox txtb_hotdogcount;
        private System.Windows.Forms.TextBox txtb_hotdogPrice;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_priceMC;
        private System.Windows.Forms.GroupBox grpb_gasST;
        private System.Windows.Forms.GroupBox grpb_topay1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_pay1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_priceG;
        private System.Windows.Forms.TextBox txtb_quantity;
        private System.Windows.Forms.GroupBox grpb_QP;
        private System.Windows.Forms.RadioButton rb_price;
        private System.Windows.Forms.RadioButton rb_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_priceGS;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.ComboBox cmbb_gasoline;
        private System.Windows.Forms.Label lbl_gasoline;
    }
}