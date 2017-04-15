using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_Service.Model;

namespace web_Service.CL
{
    public class FORD
    {
        private DB_EF db = new DB_EF();

        public List<tb_bom_ford1> show_bom()
        {
            var ds = (from c in db.tb_bom_ford1 orderby c.bom_id select c).ToList();
            return ds;
        }

        public List<tb_bom_ford1> find_bom(string id)
        {
            var ds = (from c in db.tb_bom_ford1 where c.bom_id.Contains(id) select c).ToList();
            return ds;
        }
    }
}