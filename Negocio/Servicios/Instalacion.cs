using Data.Servicios;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class Instalacion
    {
        bool VerificarProgramas()
        {
            String sRegKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            RegistryKey Keys = Registry.LocalMachine.OpenSubKey(sRegKey);
            bool framework = false;
            bool sql = false;
            bool visual = false;
            foreach (String sNombreKey in Keys.GetSubKeyNames())
            {
                RegistryKey Key = Keys.OpenSubKey(sNombreKey);
                if (Key.GetValue("DisplayName") != null)
                {


                    if (Key.GetValue("DisplayName").ToString().Contains("Microsoft .NET Framework 4.5"))
                    {
                        framework = true;
                    }
                    if (Key.GetValue("DisplayName").ToString().Contains("Microsoft SQL Server"))
                    {
                        sql = true;
                    }
                    if (Key.GetValue("DisplayName").ToString().Contains("Microsoft Visual C++"))
                    {
                        visual = true;
                    }
                }





            }


            if (!framework)
            {
                Process.Start(@"C:\Program Files (x86)\Crear y Ser\Framework.exe");
                return false;
            }


            else if (!sql)
            {
                Process.Start(@"C:\Program Files (x86)\Crear y Ser\SQL.exe"); return true;
            }

            else if (!visual)
            {
                Process.Start(@"C:\Program Files (x86)\Crear y Ser\Visual.exe"); return false;
            }
            else
            {
                return false;
            }
        }
        String ObtenerIntancia()
        {
            string result = "";
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {

                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        result = Environment.MachineName + @"\" + instanceName;

                    }
                }
            }

            return result;

        }
        void VerificarBases()
        {
            InstalacionDAC instalacionDAC = new InstalacionDAC();
            bool aux = false;
            bool principal = false;
            List<string> lista = new List<string>();
            lista = instalacionDAC.Read();
            foreach (var item in instalacionDAC.Read())
            {
                if (item == "Diploma")
                {
                    principal = true;
                }
                if (item == "DiplomaAUX")
                {
                    aux = true;
                }
            }

            if (!aux)
            {
                instalacionDAC.EjecutarScriptAux(ObtenerIntancia());

            }
            if (!principal)
            {
                instalacionDAC.EjecutarScriptPrincipal(ObtenerIntancia());

            }
        }

        void AgregarAPPAux()

        {

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["DefaultConnection"].ConnectionString = string.Concat("Data Source=", ObtenerIntancia(), ";Initial Catalog=Master;Integrated Security=True");
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

        }
        void AgregarAPPPrincipal()

        {

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["DefaultConnectionAux"].ConnectionString = string.Concat("Data Source=", ObtenerIntancia(), ";Initial Catalog=DiplomaAux;Integrated Security=True");
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

        }
        void AgregarAPPBk()

        {

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["Restore"].ConnectionString = string.Concat("Data Source=", ObtenerIntancia(), ";Initial Catalog=master;Integrated Security=True");
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

        }




        public void VerificarPrimeraVez()

        {
            bool verificarProgamas = VerificarProgramas();
      
            if (verificarProgamas)
            {
                System.Threading.Thread.Sleep(3000000);
                VerificarBases();
                AgregarAPPAux();
                AgregarAPPPrincipal();
                AgregarAPPBk();
            }
            else
            {
                VerificarBases();
            }




        }
    }
}
