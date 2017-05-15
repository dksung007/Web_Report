using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using web_Service.Model;
using web_Service.DATA;

namespace web_Service.CL
{
    public class AAT
    {
        private AAT_Entities db;

        public List<CL_AAT_Order> show_order(string _date)
        {
            db = new AAT_Entities();
            {
                var ds = (from c in db.tblOrders
                          join d in db.Part_List on c.PartNo equals d.A_PN into d
                          from f in d.DefaultIfEmpty()
                          where c.Footer1.Contains(_date)
                          orderby c.Footer1
                          select new CL_AAT_Order
                          {
                              PLANT = c.Header,
                              SUPPL = c.Suppliers,
                              LINE = c.Model,
                              SCH_OFF = c.EcssDate,
                              TRIM_ON = c.TrmRotation,
                              NHKA_CODE = f.N_PN,
                              PART_NUMBER = c.PartNo,
                              PAINT = c.PntName,
                              INTERIOR = c.InitColor,
                              BRAND = c.IpColor,
                              BASE = c.Base,
                              VIN_NUMBER = c.VIN,
                              DATE_TIME = c.Footer1,
                              STATUS = c.bcPrint
                          }).ToList();
                return ds;
            }          
        }
    }
}