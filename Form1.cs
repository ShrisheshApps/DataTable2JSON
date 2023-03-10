using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTable2JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetJSONButton_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            DataTable dt = new DataTable("MyData");
            using (SqlConnection con = new SqlConnection(cs))
            {
                string cmdText = "Select * from Orders";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 60;
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    // use NewtonSoft
                    string jsonString = JsonConvert.SerializeObject(dt,Formatting.Indented);
                    string bd = AppDomain.CurrentDomain.BaseDirectory;
                    string filepath = Path.Combine(bd, "myJson.txt");
                    if (File.Exists(filepath))
                    {
                        File.Delete(filepath);
                    }
                    WriteToFile(jsonString, filepath);

                }
            }
            MessageBox.Show("Done", "JSON Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WriteToFile(string jsonString, string filepath)
        {
           
            using (StreamWriter sw = new StreamWriter(filepath, true))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
