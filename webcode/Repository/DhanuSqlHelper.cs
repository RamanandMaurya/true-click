using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace webcode.Repository
{
    public class DhanuSqlHelper

    {
        private const int COMMAND_TIMEOUT = 30;
        private string mstrCN;
        private SqlConnection mCn;
        private SqlCommand mCmd;
        private SqlTransaction mTrans;

        public IConfiguration _configration { get; }


        #region Public Properties
        public string ConnectionString
        {
            get { return mstrCN; }
            set { mstrCN = value; }
        }

        public SqlConnection SQLConnection
        {
            get { return mCn; }
            set { mCn = value; }
        }

        public SqlCommand SQLCommand
        {
            get { return mCmd; }
            set { mCmd = value; }
        }

        public SqlTransaction SQLTransaction
        {
            get { return mTrans; }
            set { mTrans = value; }
        }
        #endregion

        #region Private Functions

        private void InitCommandForSP(string spName)
        {
            OpenConnection();
            mCmd = mCn.CreateCommand();
            mCmd.CommandTimeout = COMMAND_TIMEOUT;
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.CommandText = spName;
        }

        private void InitCommandForFun(string spName)
        {
            OpenConnection();
            mCmd = mCn.CreateCommand();
            mCmd.CommandTimeout = COMMAND_TIMEOUT;
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.CommandText = spName;
        }

        private void InitCommandForSQL(string sqlText)
        {
            OpenConnection();
            mCmd = mCn.CreateCommand();
            mCmd.CommandTimeout = COMMAND_TIMEOUT;
            mCmd.CommandType = CommandType.Text;
            mCmd.CommandText = sqlText;
        }

        #endregion

        public void OpenTransConnection()
        {
            CloseConnection();
            mCn = new SqlConnection(mstrCN);
            mCn.Open();
            mTrans = SQLConnection.BeginTransaction();
        }

        private void OpenConnection()
        {
            CloseConnection();
            mCn = new SqlConnection(mstrCN);
            mCn.ConnectionString = ReturnConnectionString();
            try
            {
                mCn.Open();
            }
            catch (Exception ex)
            {
            }

        }

        private void CloseConnection()
        {
            if (mCn != null && mCn.State != ConnectionState.Closed) // If the connection has already been set to a value
            {
                mCn.Close();
            }
        }

        public void PrepareTransCommand(string spName, SqlParameter[] parms)
        {
            mCmd = mCn.CreateCommand();
            mCmd.Transaction = mTrans;
            mCmd.CommandTimeout = COMMAND_TIMEOUT;
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.CommandText = spName;
            mCmd.Prepare();
            foreach (SqlParameter pr in parms)
                if (pr != null)
                    mCmd.Parameters.Add(pr);
        }

        public void PrepareCommand(string spName, SqlParameter[] parms)
        {
            OpenConnection();
            mCmd = mCn.CreateCommand();
            mCmd.CommandTimeout = COMMAND_TIMEOUT;
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.CommandText = spName;
            mCmd.Prepare();
            foreach (SqlParameter pr in parms)
                if (pr != null)
                    mCmd.Parameters.Add(pr);
        }

        public void ExecutePrepared()
        {
            mCmd.ExecuteNonQuery();
        }

        public SqlDataReader RunSpReturnDr(string spName)
        {
            SqlDataReader dr = null;
            InitCommandForSP(spName);

            using (dr)
            {
                dr = mCmd.ExecuteReader(CommandBehavior.CloseConnection);
                mCmd.Dispose();
                return dr;
            }
        }

        public SqlDataReader RunSpReturnDr(string spName, SqlParameter[] parms)
        {
            SqlDataReader DR = null;
            InitCommandForSP(spName);

            foreach (SqlParameter pr in parms)
                if (pr != null)
                    mCmd.Parameters.Add(pr);

            using (DR)
            {
                DR = mCmd.ExecuteReader(CommandBehavior.CloseConnection);
                return DR;
            }
        }

        public DataSet RunSpReturnDs(string spName)
        {
            DataSet ds = new DataSet();
            InitCommandForSP(spName);

            using (mCmd)
            {
                SqlDataAdapter da = new SqlDataAdapter(mCmd);
                da.Fill(ds);
                mCmd.Connection.Close();
                da.Dispose();
            }

            return ds;
        }

        public DataSet RunSpReturnDs(string spName, SqlParameter[] parms)
        {
            DataSet ds = new DataSet();
            InitCommandForSP(spName);

            using (mCmd)
            {
                SqlDataAdapter da = new SqlDataAdapter(mCmd);
                foreach (SqlParameter pr in parms)
                    if (pr != null)
                        mCmd.Parameters.Add(pr);

                da.Fill(ds);
                mCmd.Connection.Close();
                da.Dispose();
            }

            return ds;
        }

        public DataSet RunFunReturnDs(string spName, SqlParameter[] parms)
        {
            DataSet ds = new DataSet();
            InitCommandForSP(spName);

            using (mCmd)
            {
                SqlDataAdapter da = new SqlDataAdapter(mCmd);
                foreach (SqlParameter pr in parms)
                    if (pr != null)
                        mCmd.Parameters.Add(pr);

                da.Fill(ds);
                mCmd.Connection.Close();
                da.Dispose();
            }

            return ds;
        }

        public SqlDataReader RunSqlReturnDr(string Sql)
        {
            SqlDataReader DR = null;
            InitCommandForSQL(Sql);

            using (mCmd)
            {
                DR = mCmd.ExecuteReader(CommandBehavior.CloseConnection);
                return DR;
            }
        }

        public object RunSqlReturnScalar(string Sql)
        {
            InitCommandForSQL(Sql);
            object obj;
            using (mCmd)
            {
                obj = mCmd.ExecuteScalar();
                mCmd.Connection.Close();
                mCmd.Dispose();
            }
            return obj;
        }

        public int RunSql(string Sql)
        {
            InitCommandForSQL(Sql);
            int iRtnVal;
            using (mCmd)
            {
                iRtnVal = mCmd.ExecuteNonQuery();
                mCmd.Connection.Close();
                mCmd.Dispose();
            }
            return iRtnVal;

        }

        public DataSet RunSqlReturnDs(string Sql)
        {
            DataSet ds = new DataSet();
            InitCommandForSQL(Sql);

            using (mCmd)
            {
                SqlDataAdapter da = new SqlDataAdapter(mCmd);
                da.Fill(ds);
                mCmd.Connection.Close();
                da.Dispose();
            }
            return ds;
        }

        public DataSet RunSqlReturnDs(string Sql, int CurrentIndex, int PageSize, string SourceTable)
        {
            DataSet ds = new DataSet();
            InitCommandForSQL(Sql);

            using (mCmd)
            {
                SqlDataAdapter da = new SqlDataAdapter(mCmd);
                da.Fill(ds, CurrentIndex, PageSize, SourceTable);
                mCmd.Connection.Close();
                da.Dispose();
            }

            return ds;
        }

        public int RunSp(string spName, SqlParameter[] parms)
        {
            InitCommandForSP(spName);
            int rtnVal = 0;

            using (mCmd)
            {
                foreach (SqlParameter pr in parms)
                    if (pr != null)
                        mCmd.Parameters.Add(pr);

                rtnVal = mCmd.ExecuteNonQuery();
                mCmd.Connection.Close();
            }
            return rtnVal;
        }
        public async Task<int> RunSpReturnAsync(string spName, SqlParameter[] parms)
        {
            InitCommandForSP(spName);
            int rtnVal = 0;
            mCmd.Connection.Close();
            mCmd.Connection.Open();
            using (mCmd)
            {
                foreach (SqlParameter pr in parms)
                    if (pr != null)
                        mCmd.Parameters.Add(pr);

                await mCmd.ExecuteNonQueryAsync();
                rtnVal = Int32.Parse(mCmd.Parameters["@intResult"].Value.ToString());
                mCmd.Connection.Close();
            }
            return rtnVal;
        }
        public int RunSpReturn(string spName, SqlParameter[] parms)
        {
            InitCommandForSP(spName);
            int rtnVal = 0;
            mCmd.Connection.Close();
            mCmd.Connection.Open();
            using (mCmd)
            {
                foreach (SqlParameter pr in parms)
                    if (pr != null)
                        mCmd.Parameters.Add(pr);

                mCmd.ExecuteNonQuery();
                rtnVal = Int32.Parse(mCmd.Parameters["@intResult"].Value.ToString());
                mCmd.Connection.Close();
            }
            return rtnVal;
        }
        public int RunSp(string spName)
        {
            InitCommandForSP(spName);
            int rtnVal = 0;

            using (mCmd)
            {
                rtnVal = mCmd.ExecuteNonQuery();
                mCmd.Connection.Close();
            }

            return rtnVal;
        }

        public object RunSpReturnScalar(string spName, SqlParameter[] parms)
        {
            DataSet ds = new DataSet();
            InitCommandForSP(spName);

            using (mCmd)
            {
                SqlDataAdapter da = new SqlDataAdapter(mCmd);
                foreach (SqlParameter pr in parms)
                    if (pr != null)
                        mCmd.Parameters.Add(pr);

                da.Fill(ds);
                mCmd.Connection.Close();
                da.Dispose();
            }
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0][0].ToString().Trim();
                }
                else
                    return "";
            }
            else
                return "";
        }

        public int RunSql(string Sql, SqlParameter[] parms)
        {
            InitCommandForSQL(Sql);
            int rtnVal = 0;

            using (mCmd)
            {
                foreach (SqlParameter pr in parms)
                    if (pr != null)
                        mCmd.Parameters.Add(pr);

                rtnVal = mCmd.ExecuteNonQuery();
                mCmd.Connection.Close();
            }
            return rtnVal;
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (mCmd != null)
                mCmd.Dispose();
            CloseConnection();
        }

        #endregion

        public string ReturnConnectionString()
        {
            return ConfigurationManager.AppSetting["DhnauConnectionStrings"];
        }

        public string ReturnSecondaryConnectionString()
        {
            return null;
        }
        public DataTable RunSpReturnDataTable(string spName, SqlParameter[] parms)
        {
            DataTable dt = new DataTable();
            InitCommandForSP(spName);

            using (mCmd)
            {
                SqlDataAdapter da = new SqlDataAdapter(mCmd);
                foreach (SqlParameter pr in parms)
                    if (pr != null)
                        mCmd.Parameters.Add(pr);

                da.Fill(dt);
                mCmd.Connection.Close();
                da.Dispose();
            }

            return dt;
        }


    }
}
