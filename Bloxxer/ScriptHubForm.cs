using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Bloxxer
{
    public partial class ScriptHubForm : Form
    {
        private readonly MainForm MainForm;

        public ScriptHubForm(MainForm oldForm)
        {
            InitializeComponent();
            MainForm = oldForm;
        }

        private void ScriptHubForm_Load(object sender, EventArgs e)
        {
            InitScripts();
            TopMost = true;
        }

        private void InitScripts()
        {
            scriptList.Clear();

            foreach (string pack in Directory.GetDirectories(Directory.GetCurrentDirectory() + @"\scripts\"))
            {
                string image = Directory.GetCurrentDirectory() + @"\resources\blank.png";
                string script = String.Empty;
                JObject json = new JObject { new JProperty("empty", true) };

                foreach (string file in Directory.GetFiles(pack))
                {
                    string trimmed = file.Substring(file.LastIndexOf(@"\") + 1);

                    switch (trimmed)
                    {
                        case "info.json":
                            json = JObject.Parse(File.ReadAllText(file));
                            break;
                        case "script.lua":
                            script = File.ReadAllText(file);
                            break;
                        case "image.png":
                            image = file;
                            break;
                        default:
                            return;
                    }
                }

                /* 
                 * if ((json["empty"] as JToken) == null)
                 * {
                 *     return;
                 * }
                 */

                ListViewItem item = new ListViewItem
                {
                    Text = json["name"].ToString()
                };
                item.SubItems.Add(json["description"].ToString()); // SubItems[1]
                item.SubItems.Add(json["author"].ToString()); // SubItems[2]
                item.SubItems.Add(json["version"].ToString()); // SubItems[3]
                item.SubItems.Add(image); // SubItems[4]
                item.SubItems.Add(script); // SubItems[5]

                scriptList.Items.Add(item);
            }

            if (scriptList.Items.Count >= 1)
            {
                scriptList.Items[0].Selected = true;
                scriptList.Select();
            }
        }

        private void ScriptList_SelectedIndexChanged(object sender, EventArgs ev)
        {
            try
            {
                ListViewItem selected = scriptList.SelectedItems[0];

                descriptionTextBox.Text = selected.SubItems[1].Text;
                authorLabel.Text = "Author(s): " + selected.SubItems[2].Text;
                versionLabel.Text = "Version: " + selected.SubItems[3].Text;
                imagePanel.BackgroundImage = Image.FromFile(selected.SubItems[4].Text);
            }
            catch (Exception) { }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            MainForm.SetMonacoText(scriptList.SelectedItems[0].SubItems[5].Text);
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            MainForm.ExecuteScript(scriptList.SelectedItems[0].SubItems[5].Text, true);
        }

        private void DescriptionTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void ScriptList_DoubleClick(object sender, EventArgs e)
        {
            if (scriptList.Items.Count >= 1)
            {
                MainForm.SetMonacoText(scriptList.SelectedItems[0].SubItems[5].Text);
            }
        }
    }
}
