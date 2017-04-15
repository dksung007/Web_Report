using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_Service.Model;

namespace web_Service.CL
{
    public class U375
    {
        private DB_EF db = new DB_EF();

        public List<tb_bom_u375> show_bom()
        {
            var ds = (from c in db.tb_bom_u375 orderby c.bom_id select c).ToList();
            return ds;
        }

        public List<tb_bom_u375> find_bom(string id)
        {
            var ds = (from c in db.tb_bom_u375 where c.bom_id.Contains(id) orderby c.bom_id select c).ToList();
            return ds;
        }

       public List<Log_U375> log(string _date)
        {
            var ds = (from c in db.Log_U375 where c.C_date.Contains(_date) orderby c.Label_ID select c).ToList();

            return ds;
        }

        public List<Log_U375> log_id(int id)
        {
            var ds = (from c in db.Log_U375 where c.Label_ID == id select c).ToList();
            return ds;
        }

        public List<tb_st_u375> Stock(string _date)
        {
            var ds = (from c in db.tb_st_u375 where c.DT_CF.Contains(_date) orderby c.ID_ST_U select c).ToList();
            return ds;
        }

        public List<tb_st_u375> find_Stock(string id)
        {
            var ds = (from c in db.tb_st_u375 where c.SEQ.Contains(id) orderby c.ID_ST_U select c).ToList();
            return ds;
        }

        public List<tb_st_u375> Stock_FG(string _date)
        {
            var ds = (from c in db.tb_st_u375 where c.DT_CF.Contains(_date) && c.S_PD == 1 select c).ToList();
            return ds;
        }


    }
}