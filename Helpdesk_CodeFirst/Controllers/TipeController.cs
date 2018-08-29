using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpdesk_CodeFirst.Model;

namespace Helpdesk_CodeFirst.Controllers
{
    class TipeController
    {
        HelpdeskContext hld_context = new HelpdeskContext();

        // =========================================== INSERT =============================================
        public void InsertDueDate()
        {
            Console.Clear();
            System.Console.Write("Tipe               : ");
            string Tipe = System.Console.ReadLine();
            System.Console.Write("Interval Type      : ");
            int interval = Convert.ToInt32(System.Console.ReadLine());

            TipeCls call = new TipeCls();
            {
                call.Tipe = Tipe;
                call.Interval = interval;

            };
            try
            {
                hld_context.Tipe_s.Add(call);
                var result = hld_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<TipeCls> GetAllTipe()
        {
            var getalls = hld_context.Tipe_s.ToList();
            foreach (TipeCls duedate in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("Type                  : " + duedate.Tipe);
                System.Console.WriteLine("Interval              : " + duedate.Interval);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public TipeCls GetBytype(string input)
        {
            var duedate = hld_context.Tipe_s.Find(input);
            if (duedate == null)
            {
                System.Console.WriteLine("type tersebut tidak ada");
            }
            return duedate;
        }
        public string UpdateDuedate(string input)
        {
            System.Console.Write("MASUKKAN Interval           : ");
            int interval = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("MASUKKAN ULANG Type         : ");
            string id_type = System.Console.ReadLine();

            var getmhs = hld_context.Tipe_s.Find(id_type);
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA Type DueDate  : " + id_type);
            }
            else
            {
                TipeCls dd = GetBytype(input);
                dd.Tipe = id_type;
                dd.Interval = interval;

                hld_context.Entry(dd).State = System.Data.Entity.EntityState.Modified;
                hld_context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void DeleteDueDate(string input)
        {
            var x = (from y in hld_context.Tipe_s where y.Tipe == input select y).FirstOrDefault();
            hld_context.Tipe_s.Remove(x);
            hld_context.SaveChanges();
        }
    }
}
