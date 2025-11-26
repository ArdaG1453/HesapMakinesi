namespace HesapMakinesi
{
    public partial class Form1 : Form
    {

        bool optDurum = false;// iþlem durumu deðiþkeni(yani iþlem yapýlýp yapýlmadýðýný kontrol eder)
        double Sonuc = 0;// sonuç deðiþkeni(hesaplama sonucu tutar)
        string opt = "";// iþlem türü deðiþkeni(örn: +, -, x, ÷)


        public Form1()
        {
            InitializeComponent();
        }

        private void RakamOlay(object sender, EventArgs e)// rakam butonlarýna týklama olayý
        {
            if (txtSonuc.Text == "0" || optDurum)
                txtSonuc.Clear(); //txtSonux text boxunu temizler

            optDurum = false;// iþlem durumu false yapýlýr
            Button btn = (Button)sender;// butonun özelliklerini btn deðiþkenine atar
            txtSonuc.Text += btn.Text;// txtSonuc text boxuna butonun textini ekler

        }
        private void OptHesap(object sender, EventArgs e)// iþlem butonlarýna týklama olayý
        {
            optDurum = true;// iþlem durumu true yapýlýr
            Button btn = (Button)sender;// butonun özelliklerini btn deðiþkenine atar
            string yeniOpt = btn.Text;// yeniOpt deðiþkenine butonun textini atar

            lblSonuc.Text = lblSonuc.Text + " " + txtSonuc.Text + " " + yeniOpt;// lblSonuc labelýna mevcut iþlemi ekler
            switch (opt)// mevcut iþlem türüne göre iþlem yapar
            {
                case "+":
                    txtSonuc.Text = (Sonuc + double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "-":
                    txtSonuc.Text = (Sonuc - double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "x":
                    txtSonuc.Text = (Sonuc * double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "÷":
                    txtSonuc.Text = (Sonuc / double.Parse(txtSonuc.Text)).ToString();
                    break;
                default:
                    break;
            }
            Sonuc = double.Parse(txtSonuc.Text);// Sonuc deðiþkenine txtSonuc text boxundaki deðeri atar
            txtSonuc.Text = (Sonuc).ToString();// txtSonuc text boxuna Sonuc deðiþkenini yazar
            opt = yeniOpt;// opt deðiþkenine yeniOpt deðiþkenini atar



        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lblSonuc.Text = "";
            Sonuc = 0;
            opt = "";

        }
        private void BtnCe_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }
        private void BtnEsittir_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+":
                    txtSonuc.Text = (Sonuc + double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "-":
                    txtSonuc.Text = (Sonuc - double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "x":
                    txtSonuc.Text = (Sonuc * double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "÷":
                    txtSonuc.Text = (Sonuc / double.Parse(txtSonuc.Text)).ToString();
                    break;
                default:
                    break;
            }
            Sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = (Sonuc).ToString();
            opt = "";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if(txtSonuc.Text=="0")
            {
                txtSonuc.Text = "0,";
            }
            else if (optDurum)
            {
                txtSonuc.Text = "0,";
            }
            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }
            optDurum = false;
        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
