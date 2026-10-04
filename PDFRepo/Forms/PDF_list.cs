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

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView1.Font, FontStyle.Bold);

            // Define the default style for all rows (e.g., even rows)
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Define the style for alternating rows (e.g., odd rows)
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.Columns["ID"].HeaderText = "ID";
            dataGridView1.Columns["ID"].Visible = true;
            dataGridView1.Columns["ID"].Width = 80;

            dataGridView1.Columns["pdf_name"].HeaderText = "PDF Name";
            dataGridView1.Columns["pdf_name"].Visible = true;
            dataGridView1.Columns["pdf_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns["pdf_name"].Width = 256;

            dataGridView1.Columns["pdf_file"].Visible = false;  // This large binary crashes datagrid

            dataGridView1.Columns["pdf_created"].HeaderText = "Created";
            dataGridView1.Columns["pdf_created"].Visible = true;
            dataGridView1.Columns["pdf_created"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns["pdf_created"].Width = 256;

            dataGridView1.Columns["pdf_size"].HeaderText = "Size";
            dataGridView1.Columns["pdf_size"].Visible = true;
            dataGridView1.Columns["pdf_size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns["pdf_size"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["pdf_size"].Width = 160;

            dataGridView1.Columns["pdf_category"].HeaderText = "Category";
            dataGridView1.Columns["pdf_category"].Visible = true;
            dataGridView1.Columns["pdf_category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns["pdf_description"].HeaderText = "Description";
            dataGridView1.Columns["pdf_description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["pdf_description"].Visible = true;


        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}
