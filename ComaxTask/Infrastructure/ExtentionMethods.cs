using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ComaxTask.Infrastructure
{
 public static  class ExtentionMethods
    {
        /// <summary>
        /// This method help to get Date in format Year-Month-Day-Hour-Minute-Second
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static DateTime GetDateWithoutMilliseconds(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }



        /// <summary>
        /// This method help to get values from data table without exceptions
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <param name="ColumnName"></param>
        /// <param name="index"></param>
        /// <returns></returns>

        public static object GetValueSafely<T>(this DataTable dt, string ColumnName, int index)
        {
            if (typeof(T) == typeof(int))
            {
                if (dt.Rows[index][ColumnName] != DBNull.Value)
                    return dt.Rows[index][ColumnName];
                else
                    return 0;
            }
            if (typeof(T) == typeof(Int16))
            {
                if (dt.Rows[index][ColumnName] != DBNull.Value)
                    return dt.Rows[index][ColumnName];
                else
                    return 0;
            }
            else if (typeof(T) == typeof(double))
            {
                if (dt.Rows[index][ColumnName] != DBNull.Value)
                    return dt.Rows[index][ColumnName];
                else
                    return 0;
            }
            else if (typeof(T) == typeof(decimal))
            {
                if (dt.Rows[index][ColumnName] != DBNull.Value)
                    return dt.Rows[index][ColumnName];
                else
                    return 0;
            }
            else if (typeof(T) == typeof(float))
            {
                if (dt.Rows[index][ColumnName] != DBNull.Value)
                    return dt.Rows[index][ColumnName];
                else
                    return 0;
            }
            else if (typeof(T) == typeof(string))
            {
                if (dt.Rows[index][ColumnName] != DBNull.Value)
                    return dt.Rows[index][ColumnName];
                else
                    return string.Empty;
            }
            else if (typeof(T) == typeof(byte))
            {
                if (dt.Rows[index][ColumnName] != DBNull.Value)
                    return dt.Rows[index][ColumnName];
                else
                    return 0;
            }
            else if (typeof(T) == typeof(DateTime))
            {
                if (dt.Rows[index][ColumnName] != DBNull.Value)
                    return dt.Rows[index][ColumnName];
                else
                    return DateTime.MinValue;
            }
            else if (typeof(T) == typeof(bool))
            {
                if (dt.Rows[index][ColumnName] != DBNull.Value)
                    return dt.Rows[index][ColumnName];
                else
                    return false;
            }

            if (dt.Rows[index][ColumnName] != DBNull.Value)
                return dt.Rows[index][ColumnName];
            else
                return null;
        }



    }
}
