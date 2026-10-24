namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        int tutulan_sayi;
        int TahminSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            string kullaniciSayi = txtTahmin.Text;
            int girilen_sayi;


            if (!int.TryParse(kullaniciSayi, out girilen_sayi) || girilen_sayi > 100 || girilen_sayi < 1)
            {
                lblSonuc.Text = "Gecerli bir sayi giriniz.";
                return;
            }
            else
            {
                TahminSayisi += 1;
                if (girilen_sayi == tutulan_sayi)
                {
                    lblSonuc.Text = " Tebrikler! Sayiyi " + TahminSayisi + ". tahminde buldunuz.";
                    btnTahminEt.Enabled = false;

                }
                else if (girilen_sayi > tutulan_sayi)
                {
                    lblSonuc.Text = "Daha kucuk bir sayi giriniz";
                }
                else
                {
                    lblSonuc.Text = "Daha buyuk bir sayi giriniz.";
                }
                lblTahminSayi.Text = TahminSayisi.ToString();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            tutulan_sayi = rastgele.Next(1, 101);
            TahminSayisi = 0;
        }
    }
}
