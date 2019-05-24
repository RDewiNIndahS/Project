using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProjectGetPost.Models;
using Microsoft.EntityFrameworkCore;
using ProjectGetPost.Helper;

namespace ProjectGetPost.Services
{
    public class APP_OTHERCOLDETAILService : IAPP_OTHERCOLDETAILS
    {
        private DbContex _context;

        public APP_OTHERCOLDETAILService(DbContex context)
        {
            _context = context;
        }

        public APP_OTHERCOLDETAILS Create(APP_OTHERCOLDETAILS app_othercoldetails)
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@OTHERCOLDETAILS_ID";
            param1.DbType = DbType.Guid;
            param1.SqlValue = app_othercoldetails.OTHERCOLDETAILS_ID.Value as Guid?;

            var param2 = new SqlParameter();
            param2.ParameterName = "@SEQ";
            //param2.SqlDbType = SqlDbType.Int;
            param2.SqlValue = app_othercoldetails.SEQ;

            var param3 = new SqlParameter();
            param3.ParameterName = "@AP_REGNO";
            //param3.SqlDbType = SqlDbType.VarChar;
            param3.SqlValue = app_othercoldetails.AP_REGNO;

            var param4 = new SqlParameter();
            param4.ParameterName = "@COL_NAMEORMERK";
            //param4.SqlDbType = SqlDbType.VarChar;
            param4.SqlValue = app_othercoldetails.COL_NAMEORMERK;

            var param5 = new SqlParameter();
            param5.ParameterName = "@COL_TOTAL";
            //param5.SqlDbType = SqlDbType.Int;
            param5.SqlValue = app_othercoldetails.COL_TOTAL;

            var param6 = new SqlParameter();
            param6.ParameterName = "@COL_MARKETVALUE";
            //param6.SqlDbType = SqlDbType.Float;
            param6.SqlValue = app_othercoldetails.COL_MARKETVALUE;

            var param7 = new SqlParameter();
            param7.ParameterName = "@COL_LTV";
            //param7.SqlDbType = SqlDbType.;
            param7.SqlValue = app_othercoldetails.COL_LTV;

            var param8 = new SqlParameter();
            param8.ParameterName = "@COL_VALUELIQUIDATION";
            //param8.SqlDbType = SqlDbType.Float;
            param8.SqlValue = app_othercoldetails.COL_VALUELIQUIDATION;

            var param9 = new SqlParameter();
            param9.ParameterName = "@COL_DESC";
            //param9.SqlDbType = SqlDbType.VarChar;
            param9.SqlValue = app_othercoldetails.COL_DESC;

            var param10 = new SqlParameter();
            param10.ParameterName = "@COLIND_ID";
            //param10.SqlDbType = SqlDbType.VarChar;
            param10.SqlValue = app_othercoldetails.COLIND_ID;

            //var param11 = new SqlParameter();
            //param11.ParameterName = "@POTENSIESKALASI";
            ////param11.SqlDbType = SqlDbType.VarChar;
            //param11.SqlValue = app_othercoldetails.POTENSIESKALASI;

            //var param12 = new SqlParameter();
            //param12.ParameterName = "@STATUSKEPEMILIKANJAMINAN";
            ////param12.SqlDbType = SqlDbType.VarChar;
            //param12.SqlValue = app_othercoldetails.STATUSKEPEMILIKANJAMINAN;

            //var param13 = new SqlParameter();
            //param13.ParameterName = "@LEVELNILAIJAMINAN";
            ////param13.SqlDbType = SqlDbType.VarChar;
            //param13.SqlValue = app_othercoldetails.LEVELNILAIJAMINAN;

            var sql = $"EXEC stp_InsertMember @OTHERCOLDETAILS_ID, @SEQ, @AP_REGNO, @COL_NAMEORMERK, @COL_TOTAL, @COL_MARKETVALUE,@COL_LTV ,@COL_VALUELIQUIDATION,@COL_DESC,@COLIND_ID";
            var createData = _context.app_othercoldetails.FromSql(sql, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10).ToList();
            return app_othercoldetails;
        }

        public async Task<IEnumerable<APP_OTHERCOLDETAILS>> GetAll()
        {
            var data = await _context.app_othercoldetails.FromSql("EXEC stpGetALL").ToListAsync();
            return data;
        }

        public APP_OTHERCOLDETAILS Insert(APP_OTHERCOLDETAILS app_othercoldetails)
        {
            _context.app_othercoldetails.Add(app_othercoldetails);
            _context.SaveChanges();
            return app_othercoldetails;
        }
    }
}
