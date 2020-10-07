using System;
using System.Windows.Forms;

namespace Simple_Todo
{
    public partial class AddItemForms : Form
    {
        private readonly MainForm mainForm;
        public AddItemForms(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            //save tasks and update ui in parent
            string text = _TextBox.Text;
            mainForm.AddWithEvent(text);
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
