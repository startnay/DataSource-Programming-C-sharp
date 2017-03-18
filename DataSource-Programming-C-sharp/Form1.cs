using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSource_Programming_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string connectionString = "Data Source=(local);" +
                                        "Initial Catalog=MMABooks;" + 
                                        "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
        }
    }
}
