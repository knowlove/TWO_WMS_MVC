using MVC.Dh_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Dh_Dal
{
    public class DhDal
    {

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<DhTable> GetDhTables() {

            string sql = string.Format("select * from DhTable");
            return DBHelper.GetList<DhTable>(sql);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelDhTable(int id) {

            string sql = string.Format("delete * from DBTable where DhId = {0}",id);
            return DBHelper.ExecuteNonQuery(sql);
        }

    }
}