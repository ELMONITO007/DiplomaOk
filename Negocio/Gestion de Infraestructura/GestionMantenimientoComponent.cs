using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion_de_Infraestructura
{
    public class GestionMantenimientoComponent : IRepository2<GestionMantenimiento>
    {
        public List<GestionMantenimiento> buscar(string palabra)
        {
            List<GestionMantenimiento> entity = new List<GestionMantenimiento>();

            entity = Read();
            List<GestionMantenimiento> result = new List<GestionMantenimiento>();
            foreach (GestionMantenimiento item in entity)
            {
                if (item.tipoMantenimiento.Contains(palabra) || item.proveedor.tipoProveedor.ToString().Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public GestionMantenimiento Create(GestionMantenimiento entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<GestionMantenimiento> Read()
        {
            throw new NotImplementedException();
        }

        public GestionMantenimiento ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public GestionMantenimiento ReadBy(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(GestionMantenimiento entity)
        {
            throw new NotImplementedException();
        }

        public bool Verificar(GestionMantenimiento entity)
        {
            throw new NotImplementedException();
        }
    }
}
