using Microsoft.Dexterity.Applications;
using System.Data;
using System.Data.SqlClient;

namespace DyncSolutions.PersonalizedReports
{
    class SqlDbConnect
    {
        private SqlConnection _con;
        public SqlCommand Cmd;
        private SqlDataAdapter _da;
        private DataTable _dt;

        public SqlDbConnect(string connectionstring = null)
        {
            string dbname = Dynamics.Globals.SystemDatabaseName.Value;
            string UserName = Dynamics.Globals.SqlLoginId.Value;
            string UserPassword = Dynamics.Globals.SqlPassword.Value;
            string datasource = Dynamics.Globals.SqlDataSourceName;

            //Conexion UNEV
            //_con = new SqlConnection(connectionstring ?? @"Data Source=DYNCSERVER01\GP2018;Initial Catalog=DEVELOPMENT;Persist Security Info=True;User ID=dyncuser;Password=mrV$oeyNqofP");
            // Conexion de Testing
            _con = new SqlConnection(connectionstring ?? @"Data Source=ECUEVAS;Initial Catalog=DEVELOPMENT;Persist Security Info=True;User ID=sa;Password=sa");
            //string SqlUser = "dyncuser";
            //string SqlPass = "mrV$oeyNqofP";
            //string SqlServer = Dynamics.Globals.SqlDboUser.Value;
            _con = new SqlConnection(connectionstring ?? "Data Source=" + Dynamics.Functions.SqlGetServerName.Invoke() + ";Initial Catalog=DEVELOPMENT;User Id=" + UserName + ";Password=" + UserPassword + "");
            _con.Open();
        }
        public void SqlQuery(string queryText)
        {
            Cmd = new SqlCommand(queryText, _con);
        }
        public DataTable QueryEx()
        {
            _da = new SqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;
        }
        public void NonQueryEx()
        {
            Cmd.ExecuteNonQuery();
        }
    }
}
