using Data;
using Entities;
using Entitites.Negocio.Personas;
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
            if (Verificar(entity))
            {
                GestionMantenimientoDAC idiomaDAC = new GestionMantenimientoDAC();
                GestionMantenimiento persona = new GestionMantenimiento();
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
            GestionMantenimientoDAC idiomaDAC = new GestionMantenimientoDAC();
            idiomaDAC.Delete(id);
        }

        public List<GestionMantenimiento> Read()
        {
            GestionMantenimientoDAC personaDAC = new GestionMantenimientoDAC();
            List<GestionMantenimiento> result = new List<GestionMantenimiento>();
            foreach (GestionMantenimiento item in personaDAC.Read())
            {
     
                ProveedorComponenent proveedorComponenent = new ProveedorComponenent();
                Proveedor proveedor = new Proveedor();
                proveedor = proveedorComponenent.ReadByTipoProveedor(item.proveedor.Id);
                GestionMantenimiento tipoMantenimiento = new GestionMantenimiento(proveedor);
                tipoMantenimiento.periocidad = item.periocidad;
                tipoMantenimiento.tipoMantenimiento = item.tipoMantenimiento;
                tipoMantenimiento.Id = item.Id;

                result.Add(tipoMantenimiento);


            }
            return result;
        }

        public GestionMantenimiento ReadBy(int id)
        {
            GestionMantenimientoDAC gestionMantenimientoDAC = new GestionMantenimientoDAC();
            GestionMantenimiento result = new GestionMantenimiento();
            result = gestionMantenimientoDAC.ReadBy(id);

                ProveedorComponenent proveedorComponenent = new ProveedorComponenent();
                Proveedor proveedor = new Proveedor();

                proveedor = proveedorComponenent.ReadByTipoProveedor(result.proveedor.Id);
                GestionMantenimiento tipoMantenimiento = new GestionMantenimiento(proveedor);
                tipoMantenimiento.periocidad = result.periocidad;
                tipoMantenimiento.tipoMantenimiento = result.tipoMantenimiento;
                tipoMantenimiento.Id = result.Id;

        


            
            return tipoMantenimiento;
        }

        public GestionMantenimiento ReadBy(string id)
        {
            GestionMantenimientoDAC gestionMantenimientoDAC = new GestionMantenimientoDAC();
            GestionMantenimiento result = new GestionMantenimiento();
            result = gestionMantenimientoDAC.ReadBy(id);

            ProveedorComponenent proveedorComponenent = new ProveedorComponenent();
            Proveedor proveedor = new Proveedor();

            proveedor = proveedorComponenent.ReadByTipoProveedor(result.proveedor.Id);
            GestionMantenimiento tipoMantenimiento = new GestionMantenimiento(proveedor);
            tipoMantenimiento.periocidad = result.periocidad;
            tipoMantenimiento.tipoMantenimiento = result.tipoMantenimiento;
            tipoMantenimiento.Id = result.Id;


            return tipoMantenimiento;
        }

        public bool Update(GestionMantenimiento entity)
        {
            GestionMantenimientoDAC gestionMantenimientoDAC = new GestionMantenimientoDAC();
            gestionMantenimientoDAC.Update(entity);
            return true;
        }

        public bool Verificar(GestionMantenimiento entity)
        {
            return true;
        }
    }
}
