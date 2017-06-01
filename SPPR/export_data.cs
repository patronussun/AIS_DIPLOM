using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using LinqToExcel;

namespace AIS_DIBLOM
{
    class export_data
    {
        public static List<Indicators> list = new List<Indicators>();

        public static void OpenSheet(string patch)
        {
            var book = new ExcelQueryFactory(patch);
            book.AddMapping<Indicators>(x => x.Profile, "Profile");
            book.AddMapping<Indicators>(x => x.Sessions, "Sessions");
            book.AddMapping<Indicators>(x => x.Users, "Users");
            book.AddMapping<Indicators>(x => x.NewUsers, "NewUsers");
            book.AddMapping<Indicators>(x => x.Avg_session_length, "Avg_session_length");
            book.AddMapping<Indicators>(x => x.Pageviews, "Pageviews");
            book.AddMapping<Indicators>(x => x.Bounces, "Bounces");
            book.AddMapping<Indicators>(x => x.TotalEvents, "TotalEvents");

            var tab = from x in book.Worksheet<Indicators>("report2") select x;
            foreach (var item in tab)
            { list.Add(item); }
        }

    }
 }
