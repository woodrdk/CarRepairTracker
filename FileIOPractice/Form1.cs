using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIOTester
{
    public partial class FrmLibraryTracker : Form
    {
        public FrmLibraryTracker()
        {
            InitializeComponent();
        }

        private void FrmLibraryTracker_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            lstBooks.Items.Add(txtTitle.Text);
            txtTitle.Clear();
            txtTitle.Focus();
        }

        private void BtnSaveLibrary_Click(object sender, EventArgs e)
        {
            SaveLibrary();
            MessageBox.Show("Data was saved");
        }

        private void SaveLibrary()
        {
            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "Text File|*.txt",
                RestoreDirectory = true
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                if (path == string.Empty)
                {
                    return;
                }
                StringBuilder bookList = GetBooksFromListBox();
                File.WriteAllText(path, bookList.ToString());
            }
        }

        private StringBuilder GetBooksFromListBox()
        {
            StringBuilder data = new StringBuilder();

            for (int i = 0; i < lstBooks.Items.Count; i++)
            {
                data.AppendLine(lstBooks.Items[i].ToString());
            }
            return data;
        }

        private void BtnLoadLibrary_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = GetMyDocumentsPath(),
                Filter = "Text File|*.txt"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> library = File.ReadLines(fileDialog.FileName).ToList();
                library.Sort();
                lstBooks.Items.Clear();
                foreach (string books in library)
                {
                    lstBooks.Items.Add(books);
                }
            }
        }

        private string GetMyDocumentsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
