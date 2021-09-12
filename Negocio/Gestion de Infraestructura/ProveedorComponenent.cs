using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using Data.Gestion_de_Infraestructura;
using Negocio.Gestion_de_Personas;
using Entitites.Negocio.Personas;

namespace Negocio.Gestion_de_Infraestructura
{
    public class ProveedorComponenent : IRepository2<Proveedor>
    {
        #region Proveedor
        public List<Proveedor> buscar(string palabra)
        {

            List<Proveedor> entity = new List<Proveedor>();

            entity = Read();
            List<Proveedor> result = new List<Proveedor>();
            foreach (Proveedor item in entity)
            {
                if (item.nombre.Contains(palabra) || item.contacto.Contains(palabra) || item.listaTelefono[0].numero.ToString().Contains(palabra) || item.tipoProveedor.Contains(palabra))
                {
                    result.Add(item);
                }
            }
            return entity;

        }

        public Proveedor Create(Proveedor entity)
        {
            if (Verificar(entity))
            {
                ProveedorDAC idiomaDAC = new ProveedorDAC();
                Proveedor persona = new Proveedor();
                persona = idiomaDAC.Create(entity);


                return persona;
            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            ProveedorDAC idiomaDAC = new ProveedorDAC();

            idiomaDAC.Delete(id);

        }
        public List<Proveedor> ReadByTipo(int tipo)
        {
            ProveedorDAC personaDAC = new ProveedorDAC();

            return personaDAC.ReadByTipo(tipo);

        }
        public List<Proveedor> Read()
        {
            ProveedorDAC personaDAC = new ProveedorDAC();
            return personaDAC.Read();

            
        }

        public Proveedor ReadBy(int id)
        {
            ProveedorDAC personaDAC = new ProveedorDAC();
        return personaDAC.ReadBy(id);
    }

        public Proveedor ReadBy(string id)
        {
        ProveedorDAC personaDAC = new ProveedorDAC();
        return personaDAC.ReadBy(id);
    }

        public bool Update(Proveedor entity)
        {
            ProveedorDAC personaDAC = new ProveedorDAC();
            personaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Proveedor entity)
        {
            if (ReadBy(entity.cuit) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region TipoProveedor
        public List<Proveedor> buscarTipoProveedor(string palabra)
        {
            List<Proveedor> entity = new List<Proveedor>();

            entity = ReadTipoProveedor();
            List<Proveedor> result = new List<Proveedor>();
            foreach (Proveedor item in entity)
            {
                if (item.tipoProveedor.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }


        public Proveedor CreateTipoProveedor(Proveedor entity)
        {
            if (Verificar(entity))
            {
                ProveedorDAC idiomaDAC = new ProveedorDAC();
                Proveedor proveedor = new Proveedor();
                proveedor = idiomaDAC.CreateTipoProveedor(entity);


                return proveedor;
            }
            else
            {
                return null;
            }
        }

        public void DeleteTipoProveedor(int id)
        {
            ProveedorDAC idiomaDAC = new ProveedorDAC();
            idiomaDAC.DeleteTipoProveedor(id);
        }
        public List<Proveedor> ReadTipoProveedor()
        {
            ProveedorDAC idiomaDAC = new ProveedorDAC();
            return idiomaDAC.ReadTipoProveedor();
        }

        public Proveedor ReadByTipoProveedor(string id)
        {
            ProveedorDAC idiomaDAC = new ProveedorDAC();
            return idiomaDAC.ReadByTipoProveedor(id);
        }
        public Proveedor ReadByTipoProveedor(int id)
        {
            ProveedorDAC idiomaDAC = new ProveedorDAC();
            return idiomaDAC.ReadByTipoProveedor(id);
        }
        public bool UpdateTipoProveedor(Proveedor entity)
        {
            ProveedorDAC idiomaDAC = new ProveedorDAC();
            idiomaDAC.Update(entity);
            return true;
        }


        public bool VerificarTipoProveedor(Proveedor entity)
        {
            if (ReadByTipoProveedor(entity.tipoProveedor) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
