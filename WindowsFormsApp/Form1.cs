using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private string currentFilePath;

        public MainForm()
        {
            InitializeComponent();
        }

        // M�todo para abrir un archivo
        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(currentFilePath))
                {
                    textBox.Text = reader.ReadToEnd();
                }
            }
        }

        // M�todo para guardar los cambios en el archivo
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                using (StreamWriter writer = new StreamWriter(currentFilePath))
                {
                    writer.Write(textBox.Text);
                }
            }
        }
    }
}
