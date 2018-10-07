using System;
using System.Windows.Forms;

namespace RegEditor
{
    public partial class AboutProduct : Form
    {
        public AboutProduct() => InitializeComponent();

        private void AboutProduct_Click(object sender, EventArgs e) => Close();

        private void AboutProduct_Load(object sender, EventArgs e)
        {
            VersionLabel.Text = Application.ProductVersion;
            Restyler.WindowsReStyle(Handle);
        }
    }
}
