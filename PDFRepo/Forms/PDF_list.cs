using Microsoft.Data.Sqlite;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using PDFRepo.DataClasses;
using System.Data;

namespace PDFRepo
{
    public partial class PDF_list : Form
    {
    //    private Config cfg;
    //    private StartForm loginForm;
        public DataTable configDataTable;
        public PDF_list()
        {
            InitializeComponent();
            LoadDataGrid();
        }


        private void LoadDataGrid()
        {
            DataModel dm = new DataModel();
            DataTable dt = dm.GetAllPDFs();
      //      BuildButtonColumn();
            dataGridView1.DataSource = dt;
            
      //      FormatDataGrid();
      //      dataGridView1.CellContentClick += new DataGridViewCellEventHandler(DataGridView1_CellContentClick);
      //      PersistConfig();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}
