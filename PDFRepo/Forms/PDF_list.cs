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
            FormatDataGrid();
      //      FormatDataGrid();
      //      dataGridView1.CellContentClick += new DataGridViewCellEventHandler(DataGridView1_CellContentClick);
      //      PersistConfig();
        }

        private void FormatDataGrid()
        {
            dataGridView1.Columns["ID"].HeaderText = "ID";
            dataGridView1.Columns["ID"].Visible = true;

        //    dataGridView1.Columns["FileName"].HeaderText = "PDF Name";
        //    dataGridView1.Columns["FilePath"].Visible = true;

        //    dataGridView1.Columns["FileName"].Width = 300;
         //   dataGridView1.Columns["DateAdded"].HeaderText = "Date Added";
         //   dataGridView1.Columns["DateAdded"].Width = 150;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}
