using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QLNS
{
    /*
     * Lớp này nhằm sữ lý việc tạo SqlCommand. 
     */
    class HandleCMD
    {
        /*proc : hàm sữ dụng dể tạo ra cmd sữ lý proc cho DB
         * con : Kết nối với DB
         * strPCommand : proc được sữ dụng
         */
        static public SqlCommand proc(string strPCommand, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand(strPCommand, con);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
    }
}
