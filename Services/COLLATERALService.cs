using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace ProjectGetPost.Services
{
    public class COLLATERALService : ICOLLATERAL
    {
        private DbContex _context;

        public COLLATERALService(DbContex context)
        {
            _context = context;
        }

        public COLLATERAL Create(COLLATERAL collateral)
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@COL_ID";
            param1.SqlValue = collateral.COL_ID;

            var param2 = new SqlParameter();
            param2.ParameterName = "@AP_REGNO";
            param2.SqlValue = collateral.AP_REGNO;

            var param3 = new SqlParameter();
            param3.ParameterName = "@COL_SEQ";
            param3.SqlValue = collateral.COL_SEQ;

            var param4 = new SqlParameter();
            param4.ParameterName = "@COLLATERALTYPE";
            param4.SqlValue = collateral.COLLATERALTYPE;

            var param5 = new SqlParameter();
            param5.ParameterName = "@COLLATERALOBJECT";
            param5.SqlValue = collateral.COLLATERALOBJECT;

            var param6 = new SqlParameter();
            param6.ParameterName = "@OWNERSHIPDOCUMENT";
            param6.SqlValue = collateral.OWNERSHIPDOCUMENT;

            var param7 = new SqlParameter();
            param2.ParameterName = "@MARKETPRICE";
            param2.SqlValue = collateral.MARKETPRICE;

            var param8 = new SqlParameter();
            param8.ParameterName = "@OWNERNAME";
            param8.SqlValue = collateral.OWNERNAME;

            var param9 = new SqlParameter();
            param9.ParameterName = "@OWNERSHIPDOCUMENTNUMBER";
            param9.SqlValue = collateral.OWNERSHIPDOCUMENTNUMBER;

            var param10 = new SqlParameter();
            param10.ParameterName = "@COLLATERAL_STAT";
            param10.SqlValue = collateral.COLLATERAL_STAT;

            var param11 = new SqlParameter();
            param11.ParameterName = "@PARIPASU";
            param11.SqlValue = collateral.PARIPASU;

            var param12 = new SqlParameter();
            param12.ParameterName = "@COL_DESC";
            param12.SqlValue = collateral.COL_DESC;

            var param13 = new SqlParameter();
            param13.ParameterName = "@ADDRESS";
            param13.SqlValue = collateral.ADDRESS;

            var param14 = new SqlParameter();
            param14.ParameterName = "@IDRT";
            param14.SqlValue = collateral.IDRT;

            var param15 = new SqlParameter();
            param15.ParameterName = "@IDRW";
            param15.SqlValue = collateral.IDRW;

            var param16 = new SqlParameter();
            param16.ParameterName = "@IDPROVINCE";
            param16.SqlValue = collateral.IDPROVINCE;

            var param17 = new SqlParameter();
            param17.ParameterName = "@IDCITY";
            param17.SqlValue = collateral.IDCITY;

            var param18 = new SqlParameter();
            param18.ParameterName = "@IDKECAMATAN";
            param18.SqlValue = collateral.IDKECAMATAN;

            var param19 = new SqlParameter();
            param19.ParameterName = "@IDKELURAHAN";
            param19.SqlValue = collateral.IDKELURAHAN;

            var param20 = new SqlParameter();
            param20.ParameterName = "@IDZIPCODE";
            param20.SqlValue = collateral.IDZIPCODE;

            var param21 = new SqlParameter();
            param21.ParameterName = "@LINKDETAIL";
            param21.SqlValue = collateral.LINKDETAIL;

            var param22 = new SqlParameter();
            param22.ParameterName = "@LINKDETAIL";
            param22.SqlValue = collateral.LINKDETAIL;

            var param23 = new SqlParameter();
            param23.ParameterName = "@TABLEDETAIL";
            param23.SqlValue = collateral.TABLEDETAIL;

            var sql = $"EXEC INSERT_COLLATERAL @COL_ID,@AP_REGNO,@COL_SEQ,@COLLATERALTYPE,@COLLATERALOBJECT,@OWNERSHIPDOCUMENT,@MARKETPRICE,@OWNERNAME,@OWNERSHIPDOCUMENTNUMBER,@COLLATERAL_STAT,@PARIPASU,@COL_DESC,@ADDRESS,@IDRT,@IDRW,@IDPROVINCE,@IDCITY,@IDKECAMATAN,@IDKELURAHAN,@IDZIPCODE,@LINKDETAIL,@TABLEDETAIL";
            var data = _context.collateral.FromSql(sql,param1, param2,param3,param4,param5,param6,param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19,param20,param21,param22,param23);
            return collateral;
        }

        public async Task<IEnumerable<COLLATERAL>> GetAll()
        {
            var data = await _context.collateral.FromSql("EXEC GET_ALLCOLLATERAL").ToListAsync();
            return data;
        }
    }
}
