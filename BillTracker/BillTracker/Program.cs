using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BillTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
 
            //db.EmptyBillTable();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database db = new Database();
            AddBillForm abf = new AddBillForm(db);
            ViewBillsForm vbf = new ViewBillsForm(abf, db);
            Homepage hp = new Homepage(db, abf, vbf);
            Application.Run(hp);
        }
    }
}
