using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RandomOrder
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent ();
        }

        private void FillList ()
        {
            clbFileList.Items.Clear ();
            string[] fileNames = Directory.GetFiles (folderBrowserDialog.SelectedPath);
            foreach (string fileName in fileNames)
            {
                clbFileList.Items.Add (Path.GetFileName (fileName), true);
            }
        }

        private void btnBrowse_Click (object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog ();
            lblPath.Text = folderBrowserDialog.SelectedPath;

            FillList ();

            btnOpenDir.Enabled = true;
            btnRandomize.Enabled = true;
            btnRemoveDigits.Enabled = true;
        }

        private void buttonCheckAll_Click (object sender, EventArgs e)
        {
            for (int i = 0; i < clbFileList.Items.Count; ++i)
            {
                clbFileList.SetItemChecked (i, true);
            }
        }

        private void btnUncheckAll_Click (object sender, EventArgs e)
        {
            for (int i = 0; i < clbFileList.Items.Count; ++i)
            {
                clbFileList.SetItemChecked (i, false);
            }
        }

        private void btnInvert_Click (object sender, EventArgs e)
        {
            for (int i = 0; i < clbFileList.Items.Count; ++i)
            {
                clbFileList.SetItemChecked (i, !clbFileList.GetItemChecked (i));
            }
        }

        private void btnRandomize_Click (object sender, EventArgs e)
        {
            IList checkedItems = clbFileList.CheckedItems;

            List<int> numberList = new List<int> (checkedItems.Count);
            for (int i = 0; i < checkedItems.Count; ++i)
            {
                numberList.Add (i + 1);
            }
            ShuffleList (numberList);

            string path = folderBrowserDialog.SelectedPath;
            int digits = Math.Max ((int) minDigitsUpDown.Value, numberList.Count.ToString ().Length);

            string format = formatTextBox.Text; //TODO validate format / create own formating (%n, %t)

            for (int i = 0; i < checkedItems.Count; ++i)
            {
                string file = checkedItems[i].ToString ();
                string oriName = Path.Combine (path, file);
                string nummer = numberList[i].ToString ("D" + digits);
                string newName = Path.Combine (path, string.Format (format, nummer, file));

                SaveRenameFile (oriName, newName);
            }

            FillList ();
        }

        public void ShuffleList<T>(IList<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider ();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do
                    provider.GetBytes (box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                --n;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void btnRemoveDigits_Click (object sender, EventArgs e)
        {
            int charsToRemove = (int) charsToRemoveUpDown.Value;
            if (MessageBox.Show ("Are you sure you want to delete the first " + charsToRemove.ToString () + " chars of every file name?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                IList checkedItems = clbFileList.CheckedItems;
                string path = folderBrowserDialog.SelectedPath;

                for (int i = 0; i < checkedItems.Count; i++)
                {
                    string file = checkedItems[i].ToString ();
                    string oriName = Path.Combine (path, file);
                    string newName = Path.Combine (path, file.Remove (0, charsToRemove)); //TODO check if file is long enough

                    SaveRenameFile (oriName, newName);
                }

                FillList ();
            }
        }

        private void btnOpenDir_Click (object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start (folderBrowserDialog.SelectedPath);
        }

        private void linkLabel_Click (object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start ("http://lukas.ck-servers.de");
        }

        private void SaveRenameFile (string oriName, string newName)
        {
            try
            {
                File.Move (oriName, newName);
            }
            catch (Exception ex)
            {
                string title = string.Format ("Failed to rename {0}", oriName);
                string text = ex.Message;
                MessageBox.Show (text, title);
            }
        }
    }
}
