using System.Text.Json;

namespace TelefonDefteriUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kişi> _kisiler = new List<Kişi>();

        private void btnResimEkleDegisitr_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Resim Seç";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dialog.RestoreDirectory = true;
            dialog.Filter = "Resim Dosyaları(*.jpg;*.jpeg;*.bmp)|*.jpg;*.jpeg;*.bmp";

            DialogResult sonuc = dialog.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                picResim.ImageLocation = dialog.FileName;

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kişi kisi = new Kişi();
            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.Telefon = txtTelefon.Text;
            kisi.Eposta = txtEposta.Text;

            string resimyolu = picResim.ImageLocation; // c:users/murat/mypictures/user.jpg
            string dosyaadı = Path.GetFileName(resimyolu); //user.jpg
            string resimlerKlasorYolu = Path.Combine(Application.StartupPath, "resimler"); // c:users/murat/project/teldef/bin/debug/resimler
            string yeniResimYolu = Path.Combine(resimlerKlasorYolu, dosyaadı);       // c:users/murat/project/teldef/bin/debug/resimler/user.jpg
            if (Directory.Exists(resimlerKlasorYolu) == false)
            {
                Directory.CreateDirectory(resimlerKlasorYolu);
            }
            File.Copy(resimyolu, yeniResimYolu, true);

            kisi.Resim = yeniResimYolu;

            _kisiler.Add(kisi);

            YükleKisiler();
            DosyayaYaz();

            MessageBox.Show("Kişi Kaydı Yapıldı.", "Kişi Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void DosyayaYaz()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;
            options.IncludeFields = true;

            string Json = JsonSerializer.Serialize(_kisiler, options);
            string dosyaYolu = Path.Combine(Application.StartupPath, "kisiler.json");
            File.WriteAllText(dosyaYolu, Json);
        }

        private void YükleKisiler()
        {
            listKisiler.Items.Clear();

            foreach (Kişi k in _kisiler)
            {
                listKisiler.Items.Add($"{k.Ad} {k.Soyad} ( {k.Telefon} ) - {k.Eposta}");
            }

            lblAdet.Text = $"{_kisiler.Count} adet kişi bulunmaktadır .";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dosyaYolu = Path.Combine(Application.StartupPath, "kisiler.json");

            if (File.Exists(dosyaYolu))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                options.PropertyNameCaseInsensitive = true;
                options.WriteIndented = true;
                options.IncludeFields = true;

                string json = File.ReadAllText(dosyaYolu);
                _kisiler = JsonSerializer.Deserialize<List<Kişi>>(json, options);

                YükleKisiler();
            }

        }

        private void listKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listKisiler.SelectedIndex > -1)
            {
                Kişi seciilikisi = _kisiler[listKisiler.SelectedIndex];

                txtAd.Text = seciilikisi.Ad;
                txtSoyad.Text = seciilikisi.Soyad;
                txtTelefon.Text = seciilikisi.Telefon;
                txtEposta.Text = seciilikisi.Eposta;
                picResim.ImageLocation = seciilikisi.Resim;

            }
        }

        private void btnKAydet_Click(object sender, EventArgs e)
        {
            if (listKisiler.SelectedIndex == -1)
            {
                MessageBox.Show("Kaydetme İşlemi için bir kişi seçmediniz ", "kişi seçmelisiniz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            Kişi seciliKisi = _kisiler[listKisiler.SelectedIndex];
            seciliKisi.Ad = txtAd.Text;
            seciliKisi.Soyad = txtSoyad.Text;
            seciliKisi.Telefon = txtTelefon.Text;
            seciliKisi.Eposta = txtEposta.Text;

            string resimyolu = picResim.ImageLocation; // c:users/murat/mypictures/user.jpg
            string dosyaadı = Path.GetFileName(resimyolu); //user.jpg
            string resimlerKlasorYolu = Path.Combine(Application.StartupPath, "resimler"); // c:users/murat/project/teldef/bin/debug/resimler
            string yeniResimYolu = Path.Combine(resimlerKlasorYolu, dosyaadı);       // c:users/murat/project/teldef/bin/debug/resimler/user.jpg
            if (Directory.Exists(resimlerKlasorYolu) == false)
            {
                Directory.CreateDirectory(resimlerKlasorYolu);
            }
            File.Copy(resimyolu, yeniResimYolu, true);

            seciliKisi.Resim = yeniResimYolu;

            YükleKisiler();
            DosyayaYaz();

            MessageBox.Show("Kişi kaydı güncellendi", "Kişi Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listKisiler.SelectedIndex == -1)
            {
                MessageBox.Show("Silme İşlemi için bir kişi seçmediniz ", "kişi seçmelisiniz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            Kişi seciliKisi = _kisiler[listKisiler.SelectedIndex];
            DialogResult sonuc = MessageBox.Show($"{seciliKisi.Ad} {seciliKisi.Soyad} isimli kisiyi silmek istediğinize emin misiniz ? ", "Silme onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (sonuc == DialogResult.Yes)
            {
                _kisiler.RemoveAt(listKisiler.SelectedIndex);
                YükleKisiler();
                DosyayaYaz();
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();

        }

        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = string.Empty; // eşittirden sonrası yukarıdaki ile aynı anlama geliyor .
            txtEposta.Text = string.Empty;
            picResim.Image = picResim.InitialImage;
        }
    }
}