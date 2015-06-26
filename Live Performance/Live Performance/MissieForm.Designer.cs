namespace Live_Performance
{
    partial class MissieForm
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
            this.cb_typemissie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_searchClosestBoot = new System.Windows.Forms.Button();
            this.cb_Ships = new System.Windows.Forms.ComboBox();
            this.lb_MatrialenOpBoot = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_aanmaken = new System.Windows.Forms.Button();
            this.btn_wijzigen = new System.Windows.Forms.Button();
            this.tb_MissieNaam = new System.Windows.Forms.TextBox();
            this.nud_X = new System.Windows.Forms.NumericUpDown();
            this.nud_Y = new System.Windows.Forms.NumericUpDown();
            this.lbl_closestboot = new System.Windows.Forms.Label();
            this.cb_profile = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Profiel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_datumvertrek = new System.Windows.Forms.TextBox();
            this.tb_datumterug = new System.Windows.Forms.TextBox();
            this.lbl_vertrek = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_typemissie
            // 
            this.cb_typemissie.FormattingEnabled = true;
            this.cb_typemissie.Items.AddRange(new object[] {
            "SIN",
            "HOPE"});
            this.cb_typemissie.Location = new System.Drawing.Point(448, 19);
            this.cb_typemissie.Name = "cb_typemissie";
            this.cb_typemissie.Size = new System.Drawing.Size(334, 21);
            this.cb_typemissie.TabIndex = 0;
            this.cb_typemissie.Text = "Select Type";
            this.cb_typemissie.SelectedIndexChanged += new System.EventHandler(this.cb_typemissie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Locatie X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Locatie Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dichtbijzijnste Boot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 6;
            // 
            // btn_searchClosestBoot
            // 
            this.btn_searchClosestBoot.Location = new System.Drawing.Point(494, 193);
            this.btn_searchClosestBoot.Name = "btn_searchClosestBoot";
            this.btn_searchClosestBoot.Size = new System.Drawing.Size(75, 23);
            this.btn_searchClosestBoot.TabIndex = 7;
            this.btn_searchClosestBoot.Text = "Search";
            this.btn_searchClosestBoot.UseVisualStyleBackColor = true;
            this.btn_searchClosestBoot.Click += new System.EventHandler(this.btn_searchClosestBoot_Click);
            // 
            // cb_Ships
            // 
            this.cb_Ships.FormattingEnabled = true;
            this.cb_Ships.Location = new System.Drawing.Point(589, 194);
            this.cb_Ships.Name = "cb_Ships";
            this.cb_Ships.Size = new System.Drawing.Size(193, 21);
            this.cb_Ships.TabIndex = 8;
            // 
            // lb_MatrialenOpBoot
            // 
            this.lb_MatrialenOpBoot.FormattingEnabled = true;
            this.lb_MatrialenOpBoot.Location = new System.Drawing.Point(494, 246);
            this.lb_MatrialenOpBoot.Name = "lb_MatrialenOpBoot";
            this.lb_MatrialenOpBoot.Size = new System.Drawing.Size(288, 95);
            this.lb_MatrialenOpBoot.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Matrialen voor op boot";
            // 
            // btn_aanmaken
            // 
            this.btn_aanmaken.Location = new System.Drawing.Point(689, 523);
            this.btn_aanmaken.Name = "btn_aanmaken";
            this.btn_aanmaken.Size = new System.Drawing.Size(93, 46);
            this.btn_aanmaken.TabIndex = 11;
            this.btn_aanmaken.Text = "Aanmaken";
            this.btn_aanmaken.UseVisualStyleBackColor = true;
            this.btn_aanmaken.Click += new System.EventHandler(this.btn_aanmaken_Click);
            // 
            // btn_wijzigen
            // 
            this.btn_wijzigen.Location = new System.Drawing.Point(578, 523);
            this.btn_wijzigen.Name = "btn_wijzigen";
            this.btn_wijzigen.Size = new System.Drawing.Size(93, 46);
            this.btn_wijzigen.TabIndex = 12;
            this.btn_wijzigen.Text = "Wijzigen";
            this.btn_wijzigen.UseVisualStyleBackColor = true;
            // 
            // tb_MissieNaam
            // 
            this.tb_MissieNaam.Location = new System.Drawing.Point(448, 46);
            this.tb_MissieNaam.Name = "tb_MissieNaam";
            this.tb_MissieNaam.Size = new System.Drawing.Size(334, 20);
            this.tb_MissieNaam.TabIndex = 13;
            // 
            // nud_X
            // 
            this.nud_X.Location = new System.Drawing.Point(448, 72);
            this.nud_X.Name = "nud_X";
            this.nud_X.Size = new System.Drawing.Size(334, 20);
            this.nud_X.TabIndex = 14;
            // 
            // nud_Y
            // 
            this.nud_Y.Location = new System.Drawing.Point(448, 98);
            this.nud_Y.Name = "nud_Y";
            this.nud_Y.Size = new System.Drawing.Size(334, 20);
            this.nud_Y.TabIndex = 15;
            // 
            // lbl_closestboot
            // 
            this.lbl_closestboot.AutoSize = true;
            this.lbl_closestboot.Location = new System.Drawing.Point(705, 218);
            this.lbl_closestboot.Name = "lbl_closestboot";
            this.lbl_closestboot.Size = new System.Drawing.Size(10, 13);
            this.lbl_closestboot.TabIndex = 16;
            this.lbl_closestboot.Text = " ";
            this.lbl_closestboot.Click += new System.EventHandler(this.label8_Click);
            // 
            // cb_profile
            // 
            this.cb_profile.FormattingEnabled = true;
            this.cb_profile.Items.AddRange(new object[] {
            "Profiel Groot HOPE\', \'Kapitein(3),Bioloog(53),\',\'Verrekijker(2), Meetapparatuur(2" +
                "0)\',\'Groot\'",
            "\'Profiel Groot SIN\', \'Kapitein(3),Politie(53),\',\'Wapens(20), Handboeien(20)\',\'Gro" +
                "ot\'"});
            this.cb_profile.Location = new System.Drawing.Point(21, 54);
            this.cb_profile.Name = "cb_profile";
            this.cb_profile.Size = new System.Drawing.Size(337, 21);
            this.cb_profile.TabIndex = 18;
            this.cb_profile.SelectedIndexChanged += new System.EventHandler(this.cb_profile_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Personeel op de Boot";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(494, 402);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 95);
            this.listBox1.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(589, 359);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Vrij Personeel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "MissieProfiel";
            // 
            // tb_Profiel
            // 
            this.tb_Profiel.Enabled = false;
            this.tb_Profiel.Location = new System.Drawing.Point(24, 108);
            this.tb_Profiel.Multiline = true;
            this.tb_Profiel.Name = "tb_Profiel";
            this.tb_Profiel.Size = new System.Drawing.Size(334, 233);
            this.tb_Profiel.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Voor die Profiel moeten er minimaal dit in zitten:";
            // 
            // tb_datumvertrek
            // 
            this.tb_datumvertrek.Location = new System.Drawing.Point(448, 125);
            this.tb_datumvertrek.Name = "tb_datumvertrek";
            this.tb_datumvertrek.Size = new System.Drawing.Size(334, 20);
            this.tb_datumvertrek.TabIndex = 28;
            // 
            // tb_datumterug
            // 
            this.tb_datumterug.Location = new System.Drawing.Point(448, 151);
            this.tb_datumterug.Name = "tb_datumterug";
            this.tb_datumterug.Size = new System.Drawing.Size(334, 20);
            this.tb_datumterug.TabIndex = 29;
            // 
            // lbl_vertrek
            // 
            this.lbl_vertrek.AutoSize = true;
            this.lbl_vertrek.Location = new System.Drawing.Point(386, 131);
            this.lbl_vertrek.Name = "lbl_vertrek";
            this.lbl_vertrek.Size = new System.Drawing.Size(40, 13);
            this.lbl_vertrek.TabIndex = 30;
            this.lbl_vertrek.Text = "vertrek";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(386, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Terug";
            // 
            // Missie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 581);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_vertrek);
            this.Controls.Add(this.tb_datumterug);
            this.Controls.Add(this.tb_datumvertrek);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_Profiel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cb_profile);
            this.Controls.Add(this.lbl_closestboot);
            this.Controls.Add(this.nud_Y);
            this.Controls.Add(this.nud_X);
            this.Controls.Add(this.tb_MissieNaam);
            this.Controls.Add(this.btn_wijzigen);
            this.Controls.Add(this.btn_aanmaken);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_MatrialenOpBoot);
            this.Controls.Add(this.cb_Ships);
            this.Controls.Add(this.btn_searchClosestBoot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_typemissie);
            this.Name = "Missie";
            this.Text = "Missie";
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_typemissie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_searchClosestBoot;
        private System.Windows.Forms.ComboBox cb_Ships;
        private System.Windows.Forms.ListBox lb_MatrialenOpBoot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_aanmaken;
        private System.Windows.Forms.Button btn_wijzigen;
        private System.Windows.Forms.TextBox tb_MissieNaam;
        private System.Windows.Forms.NumericUpDown nud_X;
        private System.Windows.Forms.NumericUpDown nud_Y;
        private System.Windows.Forms.Label lbl_closestboot;
        private System.Windows.Forms.ComboBox cb_profile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Profiel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_datumvertrek;
        private System.Windows.Forms.TextBox tb_datumterug;
        private System.Windows.Forms.Label lbl_vertrek;
        private System.Windows.Forms.Label label12;
    }
}