using System.Reflection.PortableExecutable;
using IronPdf;

namespace PdfMinifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string sourceFolder;
        private static string targetFolder;
        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Pencere başlığını ayarla
                folderBrowserDialog.Description = "Bir klasör seçin";

                // Kullanıcı bir klasör seçti mi kontrol et
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen klasör yolunu al
                    sourceFolder = folderBrowserDialog.SelectedPath;

                    // Yol ile bir işlem yap (örneğin, bir MessageBox göster)
                    MessageBox.Show("Seçilen kaynak klasör yolu: " + sourceFolder, "Bilgi");
                }
            }
        }
        private void btnTargetFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Pencere başlığını ayarla
                folderBrowserDialog.Description = "Bir klasör seçin";

                // Kullanıcı bir klasör seçti mi kontrol et
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen klasör yolunu al
                    targetFolder = folderBrowserDialog.SelectedPath;

                    // Yol ile bir işlem yap (örneğin, bir MessageBox göster)
                    MessageBox.Show("Seçilen hedef klasör yolu: " + targetFolder, "Bilgi");
                }
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceFolder) || string.IsNullOrEmpty(targetFolder))
            {
                MessageBox.Show("Hedef ve kaynak klasörler seçilmelidir");
                return;
            }
            PdfCompressor compressor = new PdfCompressor(sourceFolder, targetFolder);
            var quality = Convert.ToInt32(txtQuality.Text);
            if (quality > 90)
            {
                MessageBox.Show("Max quality is 90");
                return;
            }
            compressor.CompressPdfFiles(quality);

            MessageBox.Show("İşlem tamamlandı, klasörü kontrol edin.");
        }

        private void txtQuality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
