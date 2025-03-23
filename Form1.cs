using System.Formats.Tar;
using System.Text;

namespace Streamencryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ByteToBits(byte b)
        {
            return Convert.ToString(b, 2).PadLeft(8, '0');
        }

        private string TruncateBits(string fullBits, int n)
        {
            int totalVisibleBits = 2 * 2 * n;
            if (fullBits.Length <= totalVisibleBits)
                return fullBits;

            string firstPart = fullBits.Substring(0, 2 * n);
            string lastPart = fullBits.Substring(fullBits.Length - 2 * n);
            return $"{firstPart}...{lastPart}";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbDecryption_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog.FileName;
            }
        }

        private void ProcessFile()
        {
            string registerBits = txtRegister.Text;
            if (registerBits.Length != 38 || registerBits.Any(c => c != '0' && c != '1'))
            {
                MessageBox.Show("Регистр должен содержать ровно 38 битов (0 или 1).");
                return;
            }

            if (string.IsNullOrEmpty(txtFile.Text))
            {
                MessageBox.Show("Выберите файл.");
                return;
            }

            byte[] fileBytes;
            try
            {
                fileBytes = File.ReadAllBytes(txtFile.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла.");
                return;
            }

            LFSR lfsr = new LFSR(registerBits);
            List<byte> processedBytes = new List<byte>();
            StringBuilder keyBits = new StringBuilder();
            StringBuilder inputBits = new StringBuilder();
            StringBuilder outputBits = new StringBuilder();

            foreach (byte b in fileBytes)
            {
                byte keyByte = lfsr.NextByte();
                byte processed = (byte)(b ^ keyByte);
                processedBytes.Add(processed);

                keyBits.Append(ByteToBits(keyByte));
                inputBits.Append(ByteToBits(b));
                outputBits.Append(ByteToBits(processed));
            }

            int n = 38;
            txtKeyBits.Text = TruncateBits(keyBits.ToString(), n);
            txtSourceBits.Text = TruncateBits(inputBits.ToString(), n);
            txtEncryptedBits.Text = TruncateBits(outputBits.ToString(), n);

            SaveFileDialog saveDialog = new SaveFileDialog();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(saveDialog.FileName, processedBytes.ToArray());
                    MessageBox.Show("Файл успешно сохранен.");
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения файла.");
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            ProcessFile();
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
