using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution
{
    public partial class chk : Form
    {
        public chk()
        {
            InitializeComponent();
        }

        private void chk_Load(object sender, EventArgs e)
        {
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@Session", CommonFunctions.GetCurrentSession);
            SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "StudentInfoAutoComplete", m);
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                MyCollection.Add(dr.GetString(0));
            }
            txtStudent.AutoCompleteMode = AutoCompleteMode.Suggest;

            txtStudent.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtStudent.AutoCompleteCustomSource = MyCollection;
        }
    }
}
