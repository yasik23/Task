using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComaxTask.DAL
{
    public class Database
    {
        public static string SqlConnectionString = @"Data Source = NEW-STATIONARY-; Initial Catalog = ComaxTaskDB; Integrated Security = True";
       

        /// <summary>
        /// Method for getting result of SQL Query and adding to Data Set  
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataSet GetDataset(string query)
        {
            SqlConnection connection = new SqlConnection(SqlConnectionString);
            connection.Open();
            try
            {
                DataSet ds = new DataSet();
                //SqlCommand dAdapter = new SqlCommand(query, connection);
                SqlDataAdapter dAdapter = new SqlDataAdapter(query, connection);                 
                dAdapter.SelectCommand.CommandTimeout = 180;
                dAdapter.Fill(ds);
                dAdapter.Dispose();
                return ds;
            }
            catch (Exception ex)
            {

                throw;

            }

            finally
            {
                CloseConnection(ref connection);
            }
        }


        public static DataSet GetDataSet_WithParameters(string query,List<SqlParameter> parameters)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(SqlConnectionString);
            con.Open();
            try
            {
                using (SqlCommand cmd=new SqlCommand(query,con))
                {
                    if(parameters!=null)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }
                    
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(cmd))
                    {
                        Adapter.Fill(ds);
                    }
                    return ds;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection(ref con);
            }
        }


        /// <summary>
        /// Command without Parametrs
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static Boolean CmdWithoutParameters(string query)
        {
            SqlConnection connection = new SqlConnection(SqlConnectionString);
            connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

            finally
            {
                CloseConnection(ref connection);
            }
        }

        /// <summary>
        /// Command with parameters
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>

        public static int ParametersCommand(string query, List<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection(SqlConnectionString);
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    connection.Open();
                    var result = cmd.ExecuteNonQuery();
                    return result;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("קיימת בעיית התחברות לבסיס נתונים." + "\n" + "להלן פרטי השגיאה:" + "\n" + ex.Message);
                return 0;
                throw;
            }

            finally
            {
                CloseConnection(ref connection);
            }
        }

        /// <summary>
        /// ExecuteScalar Method
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static int ExecuteScalar(string query)
        {

            SqlConnection connection = new SqlConnection(SqlConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                // return (int)cmd.ExecuteScalar();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {

                CloseConnection(ref connection);
                throw ex;

            }
            finally
            {
                CloseConnection(ref connection);
            }
        }

        /// <summary>
        /// Excute Scalar with Anonymous Type
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static object ExecuteScalarWithAnonymousType(string query)
        {
            SqlConnection connection = new SqlConnection(SqlConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                CloseConnection(ref connection);
            }
        }


        /// <summary>
        /// Method for getting List of T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public static List<T> GetList<T>(string query)
        {
            SqlConnection connection = new SqlConnection(SqlConnectionString);
            connection.Open();
            try
            {
                List<T> result = new List<T>();
                SqlCommand cmd = null;
                using (cmd = new SqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add((T)reader[0]);
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }



        /// <summary>
        /// Closing Connection method
        /// </summary>
        /// <param name="conn"></param>

        private static void CloseConnection(ref SqlConnection conn)
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

            if (conn != null)
            {
                conn.Dispose();
            }
        }
    }

    
}
