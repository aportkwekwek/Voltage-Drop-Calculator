
namespace VoltageDropCalculator
{
    partial class VoltageDropCalculatorC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoltageDropCalculatorC));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_KVA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_E = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Z = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mm = new System.Windows.Forms.TextBox();
            this.txt_ft = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_I = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_R = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_transformerfla = new System.Windows.Forms.Label();
            this.lbl_transformerMultiplier = new System.Windows.Forms.Label();
            this.lbl_currentShortCircuit = new System.Windows.Forms.Label();
            this.lbl_factorsinglephase = new System.Windows.Forms.Label();
            this.lbl_multiplier_factor = new System.Windows.Forms.Label();
            this.lbl_ssfault = new System.Windows.Forms.Label();
            this.lbl_voltagedrop = new System.Windows.Forms.Label();
            this.lbl_voltagedropper = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_approx = new System.Windows.Forms.Label();
            this.cbo_sm = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "KVA";
            // 
            // txt_KVA
            // 
            this.txt_KVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_KVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KVA.Location = new System.Drawing.Point(100, 109);
            this.txt_KVA.MaxLength = 15;
            this.txt_KVA.Name = "txt_KVA";
            this.txt_KVA.Size = new System.Drawing.Size(169, 21);
            this.txt_KVA.TabIndex = 1;
            this.txt_KVA.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "E";
            // 
            // txt_E
            // 
            this.txt_E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_E.Location = new System.Drawing.Point(100, 139);
            this.txt_E.MaxLength = 15;
            this.txt_E.Name = "txt_E";
            this.txt_E.Size = new System.Drawing.Size(169, 21);
            this.txt_E.TabIndex = 2;
            this.txt_E.Text = "230";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Z";
            // 
            // txt_Z
            // 
            this.txt_Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Z.Location = new System.Drawing.Point(100, 169);
            this.txt_Z.MaxLength = 15;
            this.txt_Z.Name = "txt_Z";
            this.txt_Z.Size = new System.Drawing.Size(169, 21);
            this.txt_Z.TabIndex = 3;
            this.txt_Z.Text = "2.5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "L";
            // 
            // txt_mm
            // 
            this.txt_mm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mm.Location = new System.Drawing.Point(100, 199);
            this.txt_mm.MaxLength = 15;
            this.txt_mm.Name = "txt_mm";
            this.txt_mm.Size = new System.Drawing.Size(85, 21);
            this.txt_mm.TabIndex = 4;
            this.txt_mm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mm_KeyPress);
            this.txt_mm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_mm_KeyUp);
            // 
            // txt_ft
            // 
            this.txt_ft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ft.Enabled = false;
            this.txt_ft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ft.Location = new System.Drawing.Point(191, 199);
            this.txt_ft.MaxLength = 15;
            this.txt_ft.Name = "txt_ft";
            this.txt_ft.Size = new System.Drawing.Size(78, 21);
            this.txt_ft.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "I";
            // 
            // txt_I
            // 
            this.txt_I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_I.Location = new System.Drawing.Point(100, 229);
            this.txt_I.MaxLength = 15;
            this.txt_I.Name = "txt_I";
            this.txt_I.Size = new System.Drawing.Size(169, 21);
            this.txt_I.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "C";
            // 
            // txt_C
            // 
            this.txt_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C.Location = new System.Drawing.Point(100, 259);
            this.txt_C.MaxLength = 15;
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(169, 21);
            this.txt_C.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "R";
            // 
            // txt_R
            // 
            this.txt_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R.Location = new System.Drawing.Point(100, 289);
            this.txt_R.MaxLength = 15;
            this.txt_R.Name = "txt_R";
            this.txt_R.Size = new System.Drawing.Size(169, 21);
            this.txt_R.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(285, 474);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(89, 32);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "1. Transformer Full Load Ampere";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "2. Transformer Multiplier";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "3. Current Short Circuit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "4. Factor Single  Phase";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "5. Multiplier Factor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(272, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "6. Available Symmetrical  SS Current @ Fault";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "II. Voltage Drop Calculation";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "I. First Phase";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "Data";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 371);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "1. Voltage Drop";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 419);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "2. Voltage Drop %";
            // 
            // lbl_transformerfla
            // 
            this.lbl_transformerfla.AutoSize = true;
            this.lbl_transformerfla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transformerfla.ForeColor = System.Drawing.Color.Blue;
            this.lbl_transformerfla.Location = new System.Drawing.Point(32, 93);
            this.lbl_transformerfla.Name = "lbl_transformerfla";
            this.lbl_transformerfla.Size = new System.Drawing.Size(10, 16);
            this.lbl_transformerfla.TabIndex = 33;
            this.lbl_transformerfla.Text = ".";
            // 
            // lbl_transformerMultiplier
            // 
            this.lbl_transformerMultiplier.AutoSize = true;
            this.lbl_transformerMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transformerMultiplier.ForeColor = System.Drawing.Color.Red;
            this.lbl_transformerMultiplier.Location = new System.Drawing.Point(32, 135);
            this.lbl_transformerMultiplier.Name = "lbl_transformerMultiplier";
            this.lbl_transformerMultiplier.Size = new System.Drawing.Size(10, 16);
            this.lbl_transformerMultiplier.TabIndex = 34;
            this.lbl_transformerMultiplier.Text = ".";
            // 
            // lbl_currentShortCircuit
            // 
            this.lbl_currentShortCircuit.AutoSize = true;
            this.lbl_currentShortCircuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentShortCircuit.ForeColor = System.Drawing.Color.Blue;
            this.lbl_currentShortCircuit.Location = new System.Drawing.Point(32, 171);
            this.lbl_currentShortCircuit.Name = "lbl_currentShortCircuit";
            this.lbl_currentShortCircuit.Size = new System.Drawing.Size(10, 16);
            this.lbl_currentShortCircuit.TabIndex = 35;
            this.lbl_currentShortCircuit.Text = ".";
            // 
            // lbl_factorsinglephase
            // 
            this.lbl_factorsinglephase.AutoSize = true;
            this.lbl_factorsinglephase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factorsinglephase.ForeColor = System.Drawing.Color.Red;
            this.lbl_factorsinglephase.Location = new System.Drawing.Point(32, 213);
            this.lbl_factorsinglephase.Name = "lbl_factorsinglephase";
            this.lbl_factorsinglephase.Size = new System.Drawing.Size(10, 16);
            this.lbl_factorsinglephase.TabIndex = 36;
            this.lbl_factorsinglephase.Text = ".";
            // 
            // lbl_multiplier_factor
            // 
            this.lbl_multiplier_factor.AutoSize = true;
            this.lbl_multiplier_factor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_multiplier_factor.ForeColor = System.Drawing.Color.Blue;
            this.lbl_multiplier_factor.Location = new System.Drawing.Point(32, 249);
            this.lbl_multiplier_factor.Name = "lbl_multiplier_factor";
            this.lbl_multiplier_factor.Size = new System.Drawing.Size(10, 16);
            this.lbl_multiplier_factor.TabIndex = 37;
            this.lbl_multiplier_factor.Text = ".";
            // 
            // lbl_ssfault
            // 
            this.lbl_ssfault.AutoSize = true;
            this.lbl_ssfault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ssfault.ForeColor = System.Drawing.Color.Red;
            this.lbl_ssfault.Location = new System.Drawing.Point(32, 285);
            this.lbl_ssfault.Name = "lbl_ssfault";
            this.lbl_ssfault.Size = new System.Drawing.Size(10, 16);
            this.lbl_ssfault.TabIndex = 38;
            this.lbl_ssfault.Text = ".";
            // 
            // lbl_voltagedrop
            // 
            this.lbl_voltagedrop.AutoSize = true;
            this.lbl_voltagedrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_voltagedrop.ForeColor = System.Drawing.Color.Blue;
            this.lbl_voltagedrop.Location = new System.Drawing.Point(32, 389);
            this.lbl_voltagedrop.Name = "lbl_voltagedrop";
            this.lbl_voltagedrop.Size = new System.Drawing.Size(10, 16);
            this.lbl_voltagedrop.TabIndex = 39;
            this.lbl_voltagedrop.Text = ".";
            // 
            // lbl_voltagedropper
            // 
            this.lbl_voltagedropper.AutoSize = true;
            this.lbl_voltagedropper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_voltagedropper.ForeColor = System.Drawing.Color.Red;
            this.lbl_voltagedropper.Location = new System.Drawing.Point(32, 437);
            this.lbl_voltagedropper.Name = "lbl_voltagedropper";
            this.lbl_voltagedropper.Size = new System.Drawing.Size(10, 16);
            this.lbl_voltagedropper.TabIndex = 40;
            this.lbl_voltagedropper.Text = ".";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_approx);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbl_voltagedropper);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_voltagedrop);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.lbl_ssfault);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbl_multiplier_factor);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbl_factorsinglephase);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lbl_currentShortCircuit);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lbl_transformerMultiplier);
            this.panel1.Controls.Add(this.lbl_transformerfla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(339, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 519);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_approx
            // 
            this.lbl_approx.AutoSize = true;
            this.lbl_approx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_approx.ForeColor = System.Drawing.Color.Red;
            this.lbl_approx.Location = new System.Drawing.Point(32, 311);
            this.lbl_approx.Name = "lbl_approx";
            this.lbl_approx.Size = new System.Drawing.Size(10, 16);
            this.lbl_approx.TabIndex = 41;
            this.lbl_approx.Text = ".";
            // 
            // cbo_sm
            // 
            this.cbo_sm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sm.FormattingEnabled = true;
            this.cbo_sm.Items.AddRange(new object[] {
            "Residential",
            "SM"});
            this.cbo_sm.Location = new System.Drawing.Point(100, 82);
            this.cbo_sm.Name = "cbo_sm";
            this.cbo_sm.Size = new System.Drawing.Size(169, 21);
            this.cbo_sm.TabIndex = 43;
            this.cbo_sm.SelectedIndexChanged += new System.EventHandler(this.cbo_sm_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 16);
            this.label19.TabIndex = 44;
            this.label19.Text = "Type";
            // 
            // Short_Circuit_Current_Calculation
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 519);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbo_sm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_R);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_I);
            this.Controls.Add(this.txt_ft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Z);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_E);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_KVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Short_Circuit_Current_Calculation";
            this.Text = "Short Circuit Current Calculator";
            this.Load += new System.EventHandler(this.Short_Circuit_Current_Calculation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_KVA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_E;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Z;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mm;
        private System.Windows.Forms.TextBox txt_ft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_I;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_R;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_transformerfla;
        private System.Windows.Forms.Label lbl_transformerMultiplier;
        private System.Windows.Forms.Label lbl_currentShortCircuit;
        private System.Windows.Forms.Label lbl_factorsinglephase;
        private System.Windows.Forms.Label lbl_multiplier_factor;
        private System.Windows.Forms.Label lbl_ssfault;
        private System.Windows.Forms.Label lbl_voltagedrop;
        private System.Windows.Forms.Label lbl_voltagedropper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_sm;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_approx;
    }
}