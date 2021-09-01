using Data.Gestion_de_Personas;
using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion_de_Personas
{
    public class TelefonoComponent : IRepository2<Telefono>
    {
        #region Telefono
        public List<Telefono> buscar(string palabra)
        {

            List<Telefono> entity = new List<Telefono>();
            TelefonoComponent idiomaComponent = new TelefonoComponent();
            entity = idiomaComponent.Read();
            List<Telefono> result = new List<Telefono>();
            foreach (Telefono item in entity)
            {
                if (item.numero.ToString().Contains(palabra) || item.descripcion.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Telefono Create(Telefono entity)
        {
            if (Verificar(entity))
            {
                TelefonoDAC telefonoDAC = new TelefonoDAC();
                Telefono telefono = new Telefono();
                telefono = telefonoDAC.Create(entity);
                telefono = telefonoDAC.ReadBy(telefono);

                return telefono;
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            TelefonoDAC telefonoDAC = new TelefonoDAC();
            telefonoDAC.Delete(id);
        }

        public List<Telefono> Read()
        {

            TelefonoDAC telefonoDAC = new TelefonoDAC();
            return telefonoDAC.Read();
        }

        public Telefono ReadBy(int id)
        {
            TelefonoDAC telefonoDAC = new TelefonoDAC();
            return telefonoDAC.ReadBy(id);
        }


        public Telefono ReadBy(string id)
        {
            throw new NotImplementedException();
        }
        public Telefono ReadBy(Telefono telefono)
        {
            TelefonoDAC telefonoDAC = new TelefonoDAC();
            return telefonoDAC.ReadBy(telefono);
        }
        public bool Update(Telefono entity)
        {
            TelefonoDAC telefonoDAC = new TelefonoDAC();
            telefonoDAC.Update(entity);
            return true;
        }

        public bool Verificar(Telefono entity)
        {
            if (ReadBy(entity) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion


        #region TelefonoPErsona
        public Telefono AgregarTelefonoAUnaPersona(Telefono telefono, Persona persona)

        {
            if (Verificar(telefono))
            {
                Create(telefono);

            }

            Telefono telefonoCreado = ReadBy(telefono);


            TelefonoDAC telefonoDAC = new TelefonoDAC();
           return telefonoDAC.AgregarTelefonoAUnaPersona(telefonoCreado, persona);
        }

        public void QuitarTelefonoAUnaPersona(Telefono telefono, Persona persona)
        {
            TelefonoDAC telefonoDAC = new TelefonoDAC();
             telefonoDAC.QuitarTelefonoAUnaPersona(telefono, persona);
        }
        public List<Telefono> ReadByPersona(int legajo)
        {
            TelefonoDAC telefonoDAC = new TelefonoDAC();
         return   telefonoDAC.ReadByPersona(legajo);

        }

        public Telefono ReadByPersonaYTelefono(Telefono telefono, Persona persona)
        {
            TelefonoDAC telefonoDAC = new TelefonoDAC();
            return telefonoDAC.ReadByPersonaYTelefono(telefono, persona);

        }


            #endregion
        }
    }
