using CaroOverview.Model;
using DataLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroOverview.Helpers
{
    public static class DataProcessor
    {
        public static List<Rmledg> GetRmledgs() 
        {
            string query = @"SELECT 
                                [id],
                                IsActive
                                FROM [asbstaging].[mri].[Rmledg]
                                WHERE [IsActive] = 'Y';";

            return SqlDataAccess.LoadData<Rmledg>(query);
                
        }

        public static int SaveRmledgRecord(Rmledg rmledgObject)
        {
            string query = "Uo";

            //Rmledg rmledgData = new Rmledg();

            //rmledgData.CHGCODE = "dksjhfkjsd";


            //SaveData<T>(string query, T data)
            return SqlDataAccess.SaveData(query, rmledgObject);
        }

        public static int UpdateRmledgRecord(Rmledg rmledgObject, int id)
        {
            string query = "Uo";


            //SaveData<T>(string query, T data)
            return SqlDataAccess.SaveData(query, rmledgObject);
        }

    }
}
