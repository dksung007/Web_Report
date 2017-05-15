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

       public List<tb_bom_t6> find_bom(string id)
        {
            var ds = (from c in db.tb_bom_t6 where c.part_id.Contains(id) orderby c.part_id select c).ToList();
            return ds;
        }

        public List<tb_st_p375> Stock(string _date)
        {
            var ds = (from c in db.tb_st_p375 where c.DT_CF.Contains(_date) select c).ToList();
            return ds;

        }

        public List<tb_st_p375> find_stock(string id)
        {
            var ds = (from c in db.tb_st_p375 where c.SEQ.Contains(id) orderby c.ID_ST_P select c).ToList();
            return ds;
        }

        public List<tb_st_p375> Stock_FG(string _date)
        {
            var ds = (from c in db.tb_st_p375 where c.DT_CF.Contains(_date) && c.S_PD == 1 orderby c.ID_ST_P select c).ToList();
            return ds;
        }

        public int finish_good()
        {
            string _date = DateTime.Now.ToString("dd/MM/yyyy");
            int ds = (from c in db.tb_st_p375
                      where c.DT_FG.Contains(_date)
                        && c.S_PD == 1
                      select c).Count();
            return ds;
        }

    }
}