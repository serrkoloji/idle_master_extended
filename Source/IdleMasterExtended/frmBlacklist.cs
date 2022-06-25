using System;
using System.Linq;
using System.Windows.Forms;
using IdleMasterExtended.Properties;
using System.IO;

namespace IdleMasterExtended
{
    public partial class frmBlacklist : Form
    {
        public frmBlacklist()
        {
            InitializeComponent();
        }

        public void SaveBlacklist()
        {
            Settings.Default.blacklist.Clear();
            Settings.Default.blacklist.AddRange(lstBlacklist.Items.Cast<string>().ToArray());
            Settings.Default.Save();
        }


        private void frmBlacklist_Load(object sender, EventArgs e)
        {
            // Localize form
            btnAdd.Text = localization.strings.add;
            btnSave.Text = localization.strings.save;
            this.Text = localization.strings.manage_blacklist;
            grpAdd.Text = localization.strings.add_game_blacklist;
            btnAc.Text = localization.strings.open;
            brnTumunuSil.Text = localization.strings.clear_all;
            btnDisaAktar.Text = localization.strings.export_blacklist;

            lstBlacklist.Items.AddRange(Settings.Default.blacklist.Cast<string>().ToArray());

            if (Settings.Default.customTheme)
            {
                runtimeCustomThemeBlacklist(); // JN: Apply the dark theme
            }
            say(lstBlacklist);
            btnRemove.Enabled = false;
        }

        // Make everything dark to match the dark theme
        private void runtimeCustomThemeBlacklist()
        {
            System.Drawing.Color colorBgd = Settings.Default.colorBgd; // Dark gray (from Steam)
            System.Drawing.Color colorTxt = Settings.Default.colorTxt; // Light gray (from Steam)

            // Form
            this.BackColor = colorBgd;
            this.ForeColor = colorTxt;

            // Button
            btnAdd.FlatStyle = btnSave.FlatStyle = btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.BackColor = btnSave.BackColor = btnRemove.BackColor = colorBgd;
            btnAdd.ForeColor = btnSave.ForeColor = btnRemove.ForeColor = colorTxt;
            btnAc.FlatStyle = btnSave.FlatStyle = btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAc.BackColor = btnSave.BackColor = btnRemove.BackColor = colorBgd;
            btnAc.ForeColor = btnSave.ForeColor = btnRemove.ForeColor = colorTxt;
            brnTumunuSil.FlatStyle = btnSave.FlatStyle = btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            brnTumunuSil.BackColor = btnSave.BackColor = btnRemove.BackColor = colorBgd;
            brnTumunuSil.ForeColor = btnSave.ForeColor = btnRemove.ForeColor = colorTxt;
            btnDisaAktar.FlatStyle = btnSave.FlatStyle = btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDisaAktar.BackColor = btnSave.BackColor = btnRemove.BackColor = colorBgd;
            btnDisaAktar.ForeColor = btnSave.ForeColor = btnRemove.ForeColor = colorTxt;

            // List
            lstBlacklist.BackColor = colorBgd;
            lstBlacklist.ForeColor = colorTxt;

            // Group
            grpAdd.BackColor = colorBgd;
            grpAdd.ForeColor = colorTxt;

            // Textbox Appid
            txtAppid.BackColor = colorBgd;
            txtAppid.ForeColor = colorTxt;

            btnRemove.Image = Settings.Default.whiteIcons ? Resources.imgTrash_w : Resources.imgTrash;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBlacklist();
            Close();
            btnRemove.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(txtAppid.Text, out result))
            {
                if (lstBlacklist.Items.Cast<string>().All(blApp => blApp != txtAppid.Text))
                    lstBlacklist.Items.Add(txtAppid.Text);
            }
            txtAppid.Text = string.Empty;
            txtAppid.Focus();
            btnRemove.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstBlacklist.Items.Remove(lstBlacklist.SelectedItem);
            say(lstBlacklist);
            btnRemove.Enabled = false;
        }
        public void say(ListBox lst)
        {
           lblSay.Text = lst.Items.Count.ToString();
        }


        private void ExportBlackList(ListBox lst)
        {
            var metin = ""; 
            for (int i = 0; i < lst.Items.Count; i++)
            {
                metin += lst.Items[i].ToString()+";";
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Idle Master File Export";
            save.DefaultExt = "txt";
            save.Filter = "Text (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter kayit = new StreamWriter(save.FileName);
                kayit.WriteLine(metin);
                kayit.Close();
            }
        }

        public void yukle(string metin, ListBox list)
        {
            StreamReader sr = new StreamReader(metin);

            char[] ayraclar = { ' ', ',', '.', ':', '\t', ';', '″', '"', '-', '(', ')', '/', '_', '?', '#', '$', '!', '&', '=' };

            string text = sr.ReadToEnd();

            string[] words = text.Split(ayraclar);
            
            foreach (var word in words)
            {
                word.Trim();
                if (!string.IsNullOrEmpty(word))
                {
                    if (!lstBlacklist.Items.Contains(word))
                    {
                        list.Items.Add(word);
                        say(list);
                    }
                    else
                    {

                    }
                }
                else
                {
                   

                }
            }
            
        }


        private void btnAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text (*.txt)|*.txt";

            op.ShowDialog();
            if (op.SafeFileName == "")
            {
                
            }
            else
            {
                yukle(op.FileName, lstBlacklist);
            }
            btnRemove.Enabled = false;

        }

        private void brnTumunuSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(localization.strings.msg_delete_all_text, localization.strings.msg_delete_all_head, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstBlacklist.Items.Clear();
                say(lstBlacklist);
            }
            else
{

            }
            btnRemove.Enabled = false;


        }

        private void lstBlacklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            btnRemove.Enabled = true;
            
        }

        private void grpAdd_Enter(object sender, EventArgs e)
        {

            btnRemove.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

            btnRemove.Enabled = false;
        }

        private void txtAppid_TextChanged(object sender, EventArgs e)
        {

            btnRemove.Enabled = false;
        }

        private void btnDisaAktar_Click(object sender, EventArgs e)
        {
            ExportBlackList(lstBlacklist);
        }
    }
}
