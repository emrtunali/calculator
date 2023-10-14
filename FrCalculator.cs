using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;


namespace calculator
{
    public partial class Calculator : Form
    {
        Process pro = new Process();


        TextSettings txt = new TextSettings();




        string[] processSeries = new string[2];
        public Calculator()
        {
            InitializeComponent();
        }
        // Yüzde düğmesi tıklaması için olay işleyicisi
        private void PercentBtn_Click(object sender, EventArgs e)
        {
            processSeries = txt.processText(LbProcces.Text, LbValue.Text, "%", 5);
            LbValue.Text = processSeries[0];
            LbProcces.Text = processSeries[1];
        }
        // Sayı düğmeleri için olay işleyicileri
        private void OneBtn_Click(object sender, EventArgs e)
        {
            LbValue.Text = txt.LabelText("1", LbValue.Text, BtComma);
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            LbValue.Text = txt.LabelText("2", LbValue.Text, BtComma);
        }
        // (Diğer sayı düğmeleri için benzer olay işleyicileri...)

        // Artı düğmesi tıklaması için olay işleyici
        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            LbValue.Text = txt.LabelText("3", LbValue.Text, BtComma);
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            LbValue.Text = txt.LabelText("4", LbValue.Text, BtComma);
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            LbValue.Text = txt.LabelText("5", LbValue.Text, BtComma);
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            LbValue.Text = txt.LabelText("6", LbValue.Text, BtComma);
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            LbValue.Text = txt.LabelText("7", LbValue.Text, BtComma);
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            LbValue.Text = txt.LabelText("8", LbValue.Text, BtComma);
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            LbValue.Text = txt.LabelText("9", LbValue.Text, BtComma);
        }
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            LbValue.Text = txt.LabelText("0", LbValue.Text, BtComma);

        }
        private void PlusBtn_Click(object sender, EventArgs e)
        {
            processSeries = txt.processText(LbProcces.Text, LbValue.Text, "+", 1);
            LbValue.Text = processSeries[0];
            LbProcces.Text = processSeries[1];
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txt.LabelSonis = txt.btDel_Click(LbValue.Text, LbValue.Text, BtComma);
            LbValue.Text = txt.LabelSonis[0];
            LbProcces.Text = txt.LabelSonis[1];
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            processSeries = txt.processText(LbProcces.Text, LbValue.Text, "-", 2);
            LbValue.Text = processSeries[0];
            LbProcces.Text = processSeries[1];
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            processSeries = txt.processText(LbProcces.Text, LbValue.Text, "*", 3);
            LbValue.Text = processSeries[0];
            LbProcces.Text = processSeries[1];
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            processSeries = txt.processText(LbProcces.Text, LbValue.Text, "/", 4);
            LbValue.Text = processSeries[0];
            LbProcces.Text = processSeries[1];
        }

        private void BtComma_Click(object sender, EventArgs e)
        {
            LbValue.Text = txt.btComma_Click(LbValue.Text, BtComma);

        }


        private void EqualBtn_Click(object sender, EventArgs e)
        {
            string[] equalarray = txt.processFonk(LbProcces.Text, LbValue.Text);
            LbValue.Text = equalarray[0];
            LbProcces.Text = equalarray[1];
            txt.SaveDatas(LbValue.Text, LbProcces.Text);

            // Sonucu hesaplayın, kullanıcı arayüzünü güncelleyin ve hesaplamayı veritabanına kaydedin
        }
        // Tuşa basma için olay işleyicisi
        private void Key_Press(object sender, KeyPressEventArgs e)
        {

            txt.Key_Press(sender, e, LbValue, LbProcces, BtComma);
        }
        private void SaveCalculation(string operationtype, decimal firstvalue, decimal secondvalue /*decimal result*/)
        {
            // Veritabanı bağlantısı oluşturur (veritabanı türünü ve bağlantı bilgilerini ayarlayın)
            string connectionString = "Data Source=TUNALI;Initial Catalog=Calculator;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Veritabanı bağlantısını açın
                connection.Open();

                // Hesaplama verilerini veritabanına eklemek için bir SQL sorgusu oluşturur
                string insertQuery = "INSERT INTO Calculations (OperationType, FirstValue, SecondValue ) VALUES (@OperationType, @FirstValue, @SecondValue)";

                // SQL komutunu oluşturun ve parametreleri ekleyi
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@OperationType", operationtype);
                    command.Parameters.AddWithValue("@FirstValue", firstvalue);
                    command.Parameters.AddWithValue("@SecondValue", secondvalue);
                    //command.Parameters.AddWithValue("@Result", result);

                    // Komutu çalıştırır
                    command.ExecuteNonQuery();
                }

                // Veritabanı bağlantısını kapatır
                connection.Close();
            }
        }

        private void BtHistory_Click(object sender, EventArgs e)
        {
            FrHistory f = new FrHistory();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BtExponentiation_Click(object sender, EventArgs e)
        {
            processSeries = txt.processText(LbProcces.Text, LbValue.Text, "^", 6);
            LbValue.Text = processSeries[0];
            LbProcces.Text = processSeries[1];
        }

        private void BtComma_Click_1(object sender, EventArgs e)
        {
            LbValue.Text = txt.btComma_Click(LbValue.Text, BtComma);
        }
    }
}
