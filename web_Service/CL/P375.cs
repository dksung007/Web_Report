using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_Service.Model;

namespace web_Service.CL
{
    public class P375
    {
        private DB_EF db = new DB_EF();
        public List<tb_bom_t6> show_bom()
        {
            var ds = (from c in db.tb_bom_t6 orderby c.part_id select c).ToList();
            return ds;
        }

       
    }
}