using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.ComponentModel;

namespace DXApplication1
{
    static class Program
    {
      public  static System.Runtime.Caching.MemoryCache KeyValuePairs = new System.Runtime.Caching.MemoryCache("缓存一号");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            KeyValuePairs.Add(new System.Runtime.Caching.CacheItem("key1", "value1"), new System.Runtime.Caching.CacheItemPolicy());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new MainForm());



        }
    }

    public interface Iddfa
    {
        void ddd();
    }
    public enum Dd : int
    {
        [Description]
        dfasdf = 0,






    }

}
