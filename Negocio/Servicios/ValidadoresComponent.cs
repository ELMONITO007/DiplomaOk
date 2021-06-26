using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MetroFramework;
using System.Windows.Forms;

namespace Negocio.Servicios.REGEX
{
    public static class ValidadoresComponent
    {

        public static string VerificarTemañoNumero(string numero, int max, int min)
        {
            if (Regex.IsMatch(numero, "^([0-9]){" + max + "," + min + "}$"))
            {
                return "";
            }
            else
            {
                return "El tamaño es incorrecto debe estar entre " + min + " y " + max;

            }

        }

        public static string VerificarCodigoPais(string codigo)
        {
            if (Regex.IsMatch(codigo, "^([a-z]){2}[-]([A-Z]){2}"))
            {
                return "";
            }
            else
            {
                return "El Codigo es incorrecto debe tener formato aa-AA";

            }

        }
        public static string VerificarTemañoTelefono(string telefono)
        {
            if (Regex.IsMatch(telefono, "^([0-9]){11,11}$"))
            {
                return "";
            }
            else
            {
                return "El telefono debe contener 11 número, ha ingresado: " + telefono.Length + " número";
            }


        }


        public static string VerificarNumeros(string numeros)
        {
            if (Regex.IsMatch(numeros, "^[0-9]+$"))
            {
                return "";
            }
            else
            {
                return "El campo esta vacio o tiene caracteres invalidos,solo acepta numeros sin espacios";
            }

        }

        public static string VerificarTamaño(string palabra, int maximo, int minimo)


        {
            if (palabra.Length <= maximo && palabra.Length >= minimo)
            {

                return "";
            }
            else
            {
                return "Cantidad de carcateres invalidas, debe tener un minimo de " + minimo + " y una maximo de " + maximo;
            }



        }
        public static string VerificarContraseña(string contraseña)
        {
            {
                if (Regex.IsMatch(contraseña, "^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$"))
                {


                    return "";
                }
                else
                {
                    return "El password debe cumplir el siguiente formato:Mayuscula, miniscula, numeros y caracteres especiales (Ej !@#$%^&*)";
                }

            }

        }
        public static string VerificarLetras(string Letras)
        {
            if (Regex.IsMatch(Letras, @"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$"))
            {
                return "";
            }
            else
            {
                return "El campo esta vacio o tiene caracteres invalidos,solo acepta una palabra sin espacios";
            }

        }
        public static string VerificarAlfaNumerico(string Letras)
        {
            if (Regex.IsMatch(Letras, "^[A-Za-z0-9 :]+$"))
            {
                return "";
            }
            else
            {
                return "El campo esta vacio o tiene caracteres invalidos";
            }
        }
        public static string VerificarEmail(string Letras)
        {
            if (Regex.IsMatch(Letras, @"^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"))
            {
                return "";
            }
            else
            {
                return "El formato del Email no es correcto";
            }
        }
        public static string VerificarFecha(string Letras)
        {
            if (Regex.IsMatch(Letras, @"^([0][1-9]|[12][0-9]|3[01])(\/|-)([0][1-9]|[1][0-2])\2(\d{4})$"))
            {
                return "";
            }
            else
            {
                return "El formato de la fecha no es correcto, coloque en formaro dd/mm/aaaa";
            }
        }
        public static string VerificarRangoFechas(DateTime fechaInicio, DateTime fechafinal, DateTime fecha)
        {

            if (fechaInicio >= fecha && fechafinal <= fecha)
            {

                return "";
            }
            else
            {
                return "La fecha debe estar entre: " + fechaInicio + " y " + fechafinal;
            }

        }
        public static string VerificarNumerosIntervalo(string numeros, int numeroInicio, int numeroFinal)
        {
            if (VerificarNumeros(numeros) == "")
            {
                int elNumero = int.Parse(numeros);
                if (elNumero <= numeroFinal && elNumero >= numeroInicio)
                {

                    return "";
                }
                else
                {
                    return "El numero debe estar entre: " + numeroInicio + " y " + numeroFinal;
                }
            }
            else
            {
                return numeros + " no es un numero";
            }

        }

        public static void Alta(string componente, MetroFramework.Forms.MetroForm form)
        {
            MetroMessageBox.Show(form, "Se ha dado de alta un/a nuevo/a " + componente, componente, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void Baja(string componente, MetroFramework.Forms.MetroForm form)
        {
            MetroMessageBox.Show(form, "Se ha dado de baja un/a nuevo/a " + componente, componente, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void Modificado(string componente, MetroFramework.Forms.MetroForm form)
        {
            MetroMessageBox.Show(form, "Se ha modificado un/a nuevo/a " + componente, componente, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void ErrorAltaModificacado(string componente, MetroFramework.Forms.MetroForm form)
        {
            MetroMessageBox.Show(form, "No ha dado de alta o modificado un/a nuevo/a " + componente + ", ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public static void ErrorGeneral(string componente, MetroFramework.Forms.MetroForm form)
        {
            MetroMessageBox.Show(form, componente, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
