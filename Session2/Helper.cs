using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace Session2
{
    internal class Helper
    {
        private static string _pathBlocked = "blocked.txt";

        internal static bool _blocked
        {
            get
            {
                return IsBlocked();
            }
        }

        public static Regex EmailRegex = new Regex(@"([\.]+)@([\.]+).([\.]+)");

        static Helper()
        {
        }

        private static bool IsBlocked()
        {
            if (File.Exists(_pathBlocked))
            {
                var date = DateTime.ParseExact(File.ReadAllText(_pathBlocked), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                return ((DateTime.Now - date).TotalMinutes < 1);
            }
            else
            {
                return false;
            }
        }

        internal static void LoadImages()
        {
            foreach (var item in Db.db.Driver)
            {
                try
                {
                    item.Photo = Convert(Image.FromFile(@"C:\Users\Admin\Desktop\Resources\Resourses Session 2\drivers\photo\" + item.PhotoString));
                }
                catch (Exception)
                {
                }
            }
            Db.db.SaveChanges();
        }

        internal static Image Convert(byte[] photo)
        {
            return Image.FromStream(new MemoryStream(photo));
        }

        internal static string GetMonth(int key)
        {
            switch (key)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "";
            }
        }

        internal static void Block()
        {
            File.WriteAllText(_pathBlocked, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        public static byte[] Convert(Image image)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal static Bitmap CreateIndicator(string status)
        {
            var bit = new Bitmap(70, 70);

            using (var g = Graphics.FromImage(bit))
            {
                var brush = Brushes.Red;

                if (status == "active")
                    brush = Brushes.Green;
                if (status == "invalidated")
                    brush = Brushes.Gray;
                g.FillRectangle(brush, 0, 0, 70, 70);
            }

            return bit;
        }

    }
}