using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_Service.Model;
using web_Service.DATA;

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

        public int finish_good()
        {
            string _date = DateTime.Now.ToString("dd/MM/yyyy");
            int ds = (from c in db.tb_cf_part
                      where c.date_cf.Contains(_date)
                        && c.s_cf == 1
                      select c).Count();
            return ds;
        }

        public List<CL_FORD_Order> show_order(string _date)
        {
            var db = new FORD_Entities();
            {
                var ds = (from c in db.tblFordTrans
                          join d in db.tblParts on c.VIN equals d.F_PN into d
                          from f in d.DefaultIfEmpty()
                          where c.Footer1.Contains(_date)
                          orderby c.Footer1
                          select new CL_FORD_Order
                          {
                              PLANT = c.Header,
                              SUPPL = c.Suppliers,
                              LINE = c.Model,
                              SCH_OFF = c.EcssDate,
                              TRIM_ON = c.TrmRotation,
                              NHKA_CODE = f.N_PN,
                              PART_NUMBER = c.VIN,
                              PAINT = c.PntName,
                              INTERIOR = c.InitColor,
                              BRAND = c.IpColor,
                              BASE = c.Base,
                              VIN_NUMBER = c.PartNo,
                              DATE_TIME = c.Footer1,
                              STATUS = c.bcPrint
                          }).ToList();
                return ds;
            }
        }

    }
}