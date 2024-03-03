using Microsoft.Data.SqlClient;
using System.Data;

namespace Lab1
{
    public partial class Course : Form
    {
        SqlConnection con;
        int courseId;
        public Course()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=ABDELWAHAB;Initial Catalog=ITI;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCoursesGrid();
            FillCombox();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
        }

        public void FillCoursesGrid()
        {
            SqlCommand cmd = new SqlCommand("select C.Crs_Id, C.Crs_Name, C.Crs_Duration, T.Top_Name  from Course C, Topic T where C.Top_Id = T.Top_Id", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DGView.DataSource = dt;
            dr.Close();
            con.Close();
        }
        public void FillCombox()
        {
            SqlCommand cmd = new SqlCommand("select * from Topic", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbox_topic.DataSource = dt;
            cmbox_topic.DisplayMember = "Top_Name";
            cmbox_topic.ValueMember = "Top_Id";
            dr.Close();
            con.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Course values(@Crs_Name, @Crs_Duration, @Top_Id)", con);
            cmd.Parameters.AddWithValue("@Crs_Name", txt_name.Text);
            cmd.Parameters.AddWithValue("@Crs_Duration", txt_duration.Text);
            cmd.Parameters.AddWithValue("@Top_Id", cmbox_topic.SelectedValue);
            int rowEffect = cmd.ExecuteNonQuery();
            con.Close();
            if (rowEffect > 0)
            {
                MessageBox.Show("Course Created Successfully");
                btn_create.Enabled = true;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                FillCoursesGrid();
            }
        }

        private void DGView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = DGView.Rows[e.RowIndex];
            courseId = (int)row.Cells[0].Value;
            SqlCommand cmd = new SqlCommand("select * from Course where Crs_Id = @Crs_Id", con);
            cmd.Parameters.AddWithValue("@Crs_Id", courseId);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txt_name.Text = dr["Crs_Name"].ToString();
            txt_duration.Text = dr["Crs_Duration"].ToString();
            cmbox_topic.SelectedValue = dr["Top_Id"];
            dr.Close();
            con.Close();
            btn_create.Enabled = false;
            btn_delete.Enabled = true;
            btn_update.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Course set Crs_Name = @Crs_Name, Crs_Duration = @Crs_Duration, Top_Id = @Top_Id where Crs_Id = @Crs_Id", con);
            cmd.Parameters.AddWithValue("@Crs_Name", txt_name.Text);
            cmd.Parameters.AddWithValue("@Crs_Duration", txt_duration.Text);
            cmd.Parameters.AddWithValue("@Top_Id", cmbox_topic.SelectedValue);
            cmd.Parameters.AddWithValue("@Crs_Id", courseId);
            con.Open();
            int rowEffect = cmd.ExecuteNonQuery();
            con.Close();
            if (rowEffect > 0)
            {
                MessageBox.Show("Course Updated Successfully");
                btn_create.Enabled = true;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                FillCoursesGrid();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Course where Crs_Id = @Crs_Id", con);
            cmd.Parameters.AddWithValue("@Crs_Id", courseId);
            con.Open();
            int rowEffect = cmd.ExecuteNonQuery();
            con.Close();
            if (rowEffect > 0)
            {
                MessageBox.Show("Course Deleted Successfully");
                btn_create.Enabled = true;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                FillCoursesGrid();
            }

        }
    }
}
