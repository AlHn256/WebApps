using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Odbc;
using WebApplication.Models;
using System.Data;
using System.Web.Script.Serialization;
using System.Data.SqlClient;

namespace WebApplication.Services
{
    public class ODBCService
    {
        public class Student
            {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Age { get; set; }
            };


        public string ODBCConection(ConnectionQueryString query)
        {
            string responce = "";
            int port = query.Port;
            //OdbcConnection DbConnection = new OdbcConnection("DSN=StudentTrackerDB");

            OdbcConnection DbConnection = new OdbcConnection("DSN=DataBase");
            try
            {
                DbConnection.Open();
                OdbcCommand DbCommand = DbConnection.CreateCommand();
                DbCommand.CommandText = query.QueryString;

                //SqlDataAdapter adapter = new SqlDataAdapter();
                
                //DataSet ds = new DataSet();
                // Заполняем Dataset
                //adapter.Fill(ds);

                using (OdbcDataReader reader = DbCommand.ExecuteReader())
                {
                    //adapter.Fill = reader.F;

                    if (reader.HasRows)
                    {

                        //List<Student> studentsList = new List<Student>();
                        //List<string> studentsList = new List<string>();
                        List<List<string>> myList = new List<List<string>>();

                        //string[] str = new string[3] { "dasds"," dasqwe", "wqweqwe" };
                        //myList.Add(str);
                        //string[] str2 = new string[4] { "dasds", " dasqwe", "wqweqwe", "1234123" };
                        //myList.Add(str2);
                        //string[] str3 = new string[2] { "dasds", " dasqwe" };
                        //myList.Add(str3);
                        //str = new string[5] { "dasds", " dasqwe", "wqweqwe", " dasqwe", "wqweqwe" };
                        //myList.Add(str);

                        //var GE = reader.GetEnumerator();
                        //

                        //DataSet ds = new DataSet();
                        //Заполняем Dataset
                        //reader.Fill(ds);

                        int fieldCount = reader.FieldCount;

                        while (reader.Read())
                        {
                            
                            List<string> strList = new List<string>();
                            for(int i=0; i<fieldCount; i++) 
                            {
                                strList.Add(reader.GetString(i));
                            }
                            myList.Add(strList);


                            //Student elm = new Student
                            //{
                            //    Id = reader.GetString(0),
                            //    Name = reader.GetString(1),
                            //    Age = reader.GetString(2)
                            //};
                            //studentsList.Add(elm);
                        }

                        
                        var data2 = myList.ToArray();
                        JavaScriptSerializer serializer2 = new JavaScriptSerializer();
                        String jsonData2 = serializer2.Serialize(data2);

                        //var data = studentsList.ToArray();
                        //JavaScriptSerializer serializer = new JavaScriptSerializer();
                        //String jsonData = serializer.Serialize(data);
                        
                        responce = serializer2.Serialize(data2);
                    }
                    else
                    {
                        responce += "No rows found.";
                    }
                    reader.Close();
                }


                //foreach (DataRow row in schemaTable.Rows)
                //{
                //    foreach (DataColumn column in schemaTable.Columns)
                //    {
                //        responce += column.ColumnName+ " - "+ row[column];
                //        //Console.WriteLine(String.Format("{0} = {1}",   column.ColumnName, row[column]));
                //    }
                //}

                DbCommand.Dispose();
            }
            catch (Exception ex)
            {
                responce += "An error occurred: " + ex.Message + "\n\r";
            }
            finally
            {
                DbConnection.Close();
            }

            return responce;
        }

    }
}