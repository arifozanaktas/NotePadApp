namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            string metin = MetinGiris.Text;
            if (!string.IsNullOrEmpty(metin))
            {
                KayitListesi.Items.Add(metin);
                MetinGiris.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen bir metin girin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
}