using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MobileRH.Models;
using SQLite;
using MobileRH.Droid.Models;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(ConexaoBancoDadosAndroid))]
namespace MobileRH.Droid.Models
{
    public class ConexaoBancoDadosAndroid : IConexaoBancoDados
    {
        public SQLiteConnection Conexao()
        {
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Metadados.db3");
            return new SQLiteConnection(path);
        }
    }
}