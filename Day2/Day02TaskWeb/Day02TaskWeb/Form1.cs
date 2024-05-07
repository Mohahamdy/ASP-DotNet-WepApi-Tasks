using Day02TaskWeb.Schema;

namespace Day02TaskWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgv_Depts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage res = client.GetAsync("https://localhost:7148/api/departments").Result;

            if (res.IsSuccessStatusCode)
            {
                List<Department> departments = res.Content.ReadAsAsync<List<Department>>().Result;

                dgv_Depts.DataSource = departments;
            }
        }
    }
}
