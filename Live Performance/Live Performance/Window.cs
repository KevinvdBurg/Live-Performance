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
        Administrator administrator = new Administrator();
        public Window()
        {
            InitializeComponent();
            
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            administrator.Connect();
        }
    }
}
