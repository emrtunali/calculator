using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace calculator
{
    public partial class FrHistory : Form
    {
        private DataTable calculationDataTable;
        private int selectedRowID;
        string connectionString = "Data Source=TUNALI;Initial Catalog=Calculator;Integrated Security=True";
        public FrHistory()
        {
            InitializeComponent();


            // DataTable'ı oluşturun ve sütunları tanımlayın
            calculationDataTable = new DataTable();
            calculationDataTable.Columns.Add("ID", typeof(int));
            calculationDataTable.Columns.Add("operation", typeof(string));
            calculationDataTable.Columns.Add("result", typeof(string));
           

            // DataGridView'i yapılandırın ve form üzerine ekleyin
            DataGridView dataGridView = new DataGridView();
            dataGridView.Name = "DtCalculatorView";
            dataGridView.AutoGenerateColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(dataGridView);

            // Veritabanındaki hesaplamaları yükleyin
            LoadCalculationsFromDatabase();
        }

        private void LoadCalculationsFromDatabase()
        {
            // Veritabanı bağlantısı oluşturun (veritabanı türünü ve bağlantı bilgilerini ayarlayın)

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Veritabanı bağlantısını açın
                connection.Open();

                // Veritabanından hesaplamaları almak için bir SQL sorgusu oluşturun
                string selectQuery = "SELECT * FROM calculator";

                // SQL komutunu oluşturun
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(calculationDataTable);
                DtCalculatorView.DataSource = calculationDataTable;

                // Veritabanı bağlantısını kapatın
                connection.Close();
            }

            // DataTable'ı DataGridView'e bağlayın
            DataGridView dataGridView1 = new DataGridView();
            // DataGridView'i yapılandırın
            dataGridView1.Name = "DtCalculatorView";
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Form üzerine ekleyin
            this.Controls.Add(dataGridView1);
            // DataSource'i atan
            dataGridView1.DataSource = calculationDataTable;
            dataGridView1.CellClick += DataGridView_CellClick;


        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DtCalculatorView.Rows[e.RowIndex];
                selectedRowID = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }

        private void FrHistory_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'calculatorDataSet4.calculator' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.calculatorTableAdapter.Fill(this.calculatorDataSet4.calculator);
            // TODO: Bu kod satırı 'calculatorDataSet3.calculator' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
          // TODO: Bu kod satırı 'calculatorDataSet2.calculator' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }
        private void BtDelete_Click(object sender, EventArgs e)
        {
            string sorgu_metni = "Delete From calculator Where ID=" + DtCalculatorView.SelectedRows[0].Cells[0].Value.ToString();
            //connectionString.SqlRun(sorgu_metni);
            int secili_indexs = DtCalculatorView.SelectedRows[0].Index;

            if (secili_indexs > 0)
            {
                DtCalculatorView.Rows[secili_indexs - 1].Selected = true;
                DtCalculatorView.CurrentCell = DtCalculatorView.Rows[secili_indexs - 1].Cells[1];
            }
        }

        private void BtDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void DtCalculatorView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtCalculatorView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrHistory_Load_1(object sender, EventArgs e)
        {

        }


        
    }
}
