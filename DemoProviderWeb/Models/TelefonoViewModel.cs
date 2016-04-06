using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using Microsoft.SharePoint.Client;

namespace DemoProviderWeb.Models
{
    public class TelefonoViewModel
    {
        public int id { get; set; }
        public String Nombre { get; set; }
        public String Numero { get; set; }

        public static TelefonoViewModel FromListItem(ListItem item)
        {
            var data=new TelefonoViewModel();
            var id = item["ID"].ToString();
            int idOut = 0;
            int.TryParse(id, out idOut);
            data.id = idOut;
            data.Nombre = item["Title"].ToString();
            data.Numero = item["Numero"].ToString();
            return data;
        }
    }
}