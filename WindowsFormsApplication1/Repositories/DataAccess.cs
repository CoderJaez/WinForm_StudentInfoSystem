using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Repositories
{
    public static class DataAccess
    {

        public static void SaveToTextFile<T>( List<T> data, string path)
        {
            List<string> lines = new List<string>();
            StringBuilder line = new StringBuilder();
            var cols = data[0].GetType().GetProperties();
            foreach(var row in data)
            {
                line = new StringBuilder();
                foreach(var col in cols)
                {
                    line.Append(col.GetValue(row));
                    line.Append(",");
                } //fname, lname, address,

                lines.Add(line.ToString().Substring(0, line.Length - 1));
            }

            File.WriteAllLines(path, lines);
           
        }

        public static List<T> Get<T>(string filename) where T : class, new()
        {
            var list = new List<T>();
            T obj = new T();
            int index = 0;
            var lines = File.ReadAllLines(filename).ToList();


            foreach (var line in lines)
            {
                var vals = line.Split(',');
                index = 0;
                obj = new T();
                foreach (var col in obj.GetType().GetProperties())
                {
                    col.SetValue(obj, vals[index]);
                    index++;
                }
                list.Add(obj);
            }
            //lines.ForEach(line =>
            //{
            //    var vals = line.Split(',');
            //    index = 0;
            //    obj = new T();
            //    foreach (var col in obj.GetType().GetProperties())
            //    {
            //        col.SetValue(obj, vals[index]);
            //        index++;
            //    }
            //    list.Add(obj);
            //});

            return list;
        }

    }
}
