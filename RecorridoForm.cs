using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Entitites;
using MetroFramework;
using Negocio;

namespace DiplomaFinal
{
    public static class RecorridoForm
    {

        public static void LimpiarTXT(MetroFramework.Forms.MetroForm metroForm)

        {

            foreach (Control item in metroForm.Controls)
            {
                string test = item.ToString();
                if (item.ToString().Contains("TextBox"))
                {
                    item.Text = "";

                }
                if (item.ToString().Contains("TabControl"))
                {
                    foreach (Control subItem in item.Controls)
                    {

                        foreach (Control tab in subItem.Controls)
                        {
                            if (tab.ToString().Contains("TextBox"))
                            {
                                tab.Text = "";

                            }
                        }

                    }
                }
            }


        }

        public static void ObtenerTag(MetroFramework.Forms.MetroForm metroForm)

        {
            String cadena = "";
            foreach (Control item in metroForm.Controls)
            {
                string test = item.ToString();
                if (item.ToString().Contains("Label") || item.ToString().Contains("Button"))
                {

                    cadena = cadena + Environment.NewLine + item.Tag.ToString();

                }
                if (item.ToString().Contains("TabControl"))
                {
                    foreach (Control subItem in item.Controls)
                    {
                        cadena = cadena + Environment.NewLine + subItem.Tag.ToString();
                        foreach (Control tab in subItem.Controls)
                        {
                            if (tab.ToString().Contains("Label") || tab.ToString().Contains("Button"))
                            {

                                cadena = cadena + Environment.NewLine + tab.Tag.ToString();

                            }
                        }

                    }
                }
            }

            string rutaCompleta = @" C:\temp\tag.txt";
            string texto = cadena;
            using (StreamWriter file = new StreamWriter(rutaCompleta, true))
            {
                file.WriteLine(texto); //se agrega información al documento

                file.Close();
            }




        }
        public static void CambiarIdioma(MetroFramework.Forms.MetroForm metroForm)

        {
            TraduccionComponent traduccionComponent = new TraduccionComponent();
            List<Traduccion> traduccions = new List<Traduccion>();
            if (SingletonIdioma.intance.getUsuario() != null)
            {
                traduccions = traduccionComponent.ReadByIdioma(SingletonIdioma.intance.getUsuario().Id);





                foreach (var traduccion in traduccions)
                {
                    foreach (Control item in metroForm.Controls)
                    {

                        if (item.ToString().Contains("Label") || item.ToString().Contains("Button") || item.ToString().Contains("Tile"))
                        {


                            if (traduccion.palabra.palabra == item.Tag.ToString())
                            {
                                item.Text = traduccion.traduccion;
                            }

                        }
                        if (item.ToString().Contains("TabControl"))
                        {


                            foreach (Control subItem in item.Controls)
                            {
                                if (traduccion.palabra.palabra == subItem.Tag.ToString())
                                {
                                    subItem.Text = traduccion.traduccion;
                                }

                                foreach (Control tab in subItem.Controls)
                                {
                                    if (tab.ToString().Contains("Label") || tab.ToString().Contains("Button") || tab.ToString().Contains("Tile"))
                                    {
                                        if (tab.Tag != null)
                                        {
                                            if (traduccion.palabra.palabra == tab.Tag.ToString())
                                            {
                                                tab.Text = traduccion.traduccion;
                                            }
                                        }


                                    }
                                }

                            }
                        }
                    }
                }


            }




        }





   
    }



}
