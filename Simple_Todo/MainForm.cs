using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Simple_Todo
{
    public partial class MainForm : Form
    {
        private readonly string path = Path.Combine(Directory.GetCurrentDirectory(), "tasks.json");
        public MainForm()
        {
            InitializeComponent();
            LoadSaves(path);
        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            AddItemForms forms = new AddItemForms(this);
            forms.Show();
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.SelectedObjectCollection items = _CheckBox.SelectedItems;

                foreach (object item in items)
                {
                    _CheckBox.Items.Remove(item);
                }
            }
            catch { Remove_Button_Click(sender, e); };
            SaveTasks(path);
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            try
            {
                CheckedListBox.CheckedItemCollection items = _CheckBox.CheckedItems;

                foreach (object item in items)
                {
                    _CheckBox.Items.Remove(item);
                }
            }
            catch
            {
                Clear_Button_Click(sender, e);
            }

            SaveTasks(path);

        }


        private void LoadSaves(string path)
        {

            if (File.Exists(path) == false) { return; }
            using (StreamReader file = File.OpenText(path))
            {
                _CheckBox.Items.Clear();
                JsonSerializer serializer = new JsonSerializer();
                _CheckBox.Items.AddRange((string[])serializer.Deserialize(file, typeof(string[])));
            }
        }
        private void SaveTasks(string path)
        {
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, _CheckBox.Items);
            }
        }

        public void AddWithEvent(string item)
        {
            _CheckBox.Items.Add(item);
            SaveTasks(path);
        }
    }
}
