namespace Live_Performance
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Live_Performance.Classes;
    public partial class Window : Form
    {
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lbl_missiewijzigen;
        private Button btn_MissieVerwijderen;
        private Button btn_MissieWijzigen;
        private Button btn_MissieToevoegen;
        private DataGridView DataGridForMissies;
        private BindingSource administratorBindingSource;
        private IContainer components;
        Administrator administrator = new Administrator();
        public Window()
        {
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_missiewijzigen = new System.Windows.Forms.Label();
            this.btn_MissieVerwijderen = new System.Windows.Forms.Button();
            this.btn_MissieWijzigen = new System.Windows.Forms.Button();
            this.btn_MissieToevoegen = new System.Windows.Forms.Button();
            this.DataGridForMissies = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.administratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridForMissies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 120);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 552);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_missiewijzigen);
            this.tabPage1.Controls.Add(this.btn_MissieVerwijderen);
            this.tabPage1.Controls.Add(this.btn_MissieWijzigen);
            this.tabPage1.Controls.Add(this.btn_MissieToevoegen);
            this.tabPage1.Controls.Add(this.DataGridForMissies);
            this.tabPage1.Location = new System.Drawing.Point(124, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(928, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Missie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_missiewijzigen
            // 
            this.lbl_missiewijzigen.AutoSize = true;
            this.lbl_missiewijzigen.Location = new System.Drawing.Point(668, 478);
            this.lbl_missiewijzigen.Name = "lbl_missiewijzigen";
            this.lbl_missiewijzigen.Size = new System.Drawing.Size(132, 13);
            this.lbl_missiewijzigen.TabIndex = 5;
            this.lbl_missiewijzigen.Text = "Selecteer een Missie Eerst";
            // 
            // btn_MissieVerwijderen
            // 
            this.btn_MissieVerwijderen.Location = new System.Drawing.Point(806, 488);
            this.btn_MissieVerwijderen.Name = "btn_MissieVerwijderen";
            this.btn_MissieVerwijderen.Size = new System.Drawing.Size(116, 38);
            this.btn_MissieVerwijderen.TabIndex = 4;
            this.btn_MissieVerwijderen.Text = "Missie Verwijderen";
            this.btn_MissieVerwijderen.UseVisualStyleBackColor = true;
            // 
            // btn_MissieWijzigen
            // 
            this.btn_MissieWijzigen.Location = new System.Drawing.Point(806, 444);
            this.btn_MissieWijzigen.Name = "btn_MissieWijzigen";
            this.btn_MissieWijzigen.Size = new System.Drawing.Size(116, 38);
            this.btn_MissieWijzigen.TabIndex = 3;
            this.btn_MissieWijzigen.Text = "Missie Wijzigen";
            this.btn_MissieWijzigen.UseVisualStyleBackColor = true;
            // 
            // btn_MissieToevoegen
            // 
            this.btn_MissieToevoegen.Location = new System.Drawing.Point(16, 465);
            this.btn_MissieToevoegen.Name = "btn_MissieToevoegen";
            this.btn_MissieToevoegen.Size = new System.Drawing.Size(116, 38);
            this.btn_MissieToevoegen.TabIndex = 2;
            this.btn_MissieToevoegen.Text = "Missie Toevoegen";
            this.btn_MissieToevoegen.UseVisualStyleBackColor = true;
            this.btn_MissieToevoegen.Click += new System.EventHandler(this.btn_MissieToevoegen_Click);
            // 
            // DataGridForMissies
            // 
            this.DataGridForMissies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridForMissies.Location = new System.Drawing.Point(6, 6);
            this.DataGridForMissies.Name = "DataGridForMissies";
            this.DataGridForMissies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridForMissies.Size = new System.Drawing.Size(916, 432);
            this.DataGridForMissies.TabIndex = 1;
            this.DataGridForMissies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridForMissies_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(124, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(928, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Meting en incident";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(124, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(928, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // administratorBindingSource
            // 
            this.administratorBindingSource.DataSource = typeof(Live_Performance.Classes.Administrator);
            // 
            // Window
            // 
            this.ClientSize = new System.Drawing.Size(1080, 585);
            this.Controls.Add(this.tabControl1);
            this.Name = "Window";
            this.Load += new System.EventHandler(this.Window_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridForMissies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridForMissies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Window_Load(object sender, EventArgs e)
        {
                DataGridForMissies.DataSource = this.administrator.SelectMissies();
        }

        private void btn_MissieToevoegen_Click(object sender, EventArgs e)
        {
            Missie MissieFrom = new Missie();
            MissieFrom.Show();
        }
    }
}
