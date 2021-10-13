using Entities;
using Entitites;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaFinal
{
 public static   class Obsever
    {
        public static List<MetroForm> listaForms = new List<MetroForm>();
        

        public static void AgregarForm(MetroForm metroForm)

        {
            listaForms.Add(metroForm);

            RecorridoForm.CambiarIdioma(metroForm);

        }
        public static void QuitarForm(MetroForm metroForm)

        {
            listaForms.Remove(metroForm);


        }
        public static void update(Idioma idioma)
        {
            SingletonIdioma.intance.CambiarIdioma(idioma);
            foreach (var item in listaForms)
            {
                RecorridoForm.CambiarIdioma(item);
            } 
        
        
        
        }


    }
}
