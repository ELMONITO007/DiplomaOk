using Data.Gestion_de_Infraestructura;
using Entities;
using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion_de_Infraestructura
{
    public class MantenimientoComponent : IRepository2<Mantenimiento>
    {
        public List<Mantenimiento> buscar(string palabra)
        {
            List<Mantenimiento> entity = new List<Mantenimiento>();

            entity = Read();
            List<Mantenimiento> result = new List<Mantenimiento>();
            foreach (Mantenimiento item in entity)
            {
                if (item.tipoMantenimiento.tipoMantenimiento.Contains(palabra) || item.fecha.ToString().Contains(palabra) || item.proveedor.nombre.Contains(palabra) || item.proveedor.DNI.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        public Mantenimiento Create(Mantenimiento entity)
        {
            if (Verificar(entity))
            {
                MantenimientoDAC idiomaDAC = new MantenimientoDAC();
                Mantenimiento persona = new Mantenimiento();
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
            MantenimientoDAC idiomaDAC = new MantenimientoDAC();
            idiomaDAC.Delete(id);
        }

        public List<Mantenimiento> Read()
        {
            MantenimientoDAC personaDAC = new MantenimientoDAC();
            List<Mantenimiento> result = new List<Mantenimiento>();
            foreach (Mantenimiento item in personaDAC.Read())
            {

                ProveedorComponenent personaComponent = new ProveedorComponenent();
                ProveedorComponenent proveedorComponent = new ProveedorComponenent();
              GestionMantenimientoComponent tipoMantenimiento = new GestionMantenimientoComponent();

                Proveedor proveedor = new Proveedor();
                proveedor = proveedorComponent.ReadBy(item.proveedor.Id);
                GestionMantenimiento gestionMantenimiento = new GestionMantenimiento();
                gestionMantenimiento = tipoMantenimiento.ReadBy(item.tipoMantenimiento.Id);

                Mantenimiento mantenimiento = new Mantenimiento(proveedor,gestionMantenimiento);
                mantenimiento.fecha = item.fecha;
                mantenimiento.fechaRealizado = item.fechaRealizado;
                mantenimiento.Realizado = item.Realizado;


                result.Add(mantenimiento);


            }
            return result;
        }

        public Mantenimiento ReadBy(int id)
        {
            MantenimientoDAC mantenimientoDAC = new MantenimientoDAC();
            Mantenimiento result = new Mantenimiento();
            result = mantenimientoDAC.ReadBy(id);

                ProveedorComponenent personaComponent = new ProveedorComponenent();
                ProveedorComponenent proveedorComponent = new ProveedorComponenent();
                GestionMantenimientoComponent tipoMantenimiento = new GestionMantenimientoComponent();

                Proveedor proveedor = new Proveedor();
                proveedor = proveedorComponent.ReadBy(result.proveedor.Id);
                GestionMantenimiento gestionMantenimiento = new GestionMantenimiento();
                gestionMantenimiento = tipoMantenimiento.ReadBy(result.tipoMantenimiento.Id);

                Mantenimiento mantenimiento = new Mantenimiento(proveedor, gestionMantenimiento);
                mantenimiento.fecha = result.fecha;
                mantenimiento.fechaRealizado = result.fechaRealizado;
                mantenimiento.Realizado = result.Realizado;


            return mantenimiento;
        }

        public Mantenimiento ReadBy(string id)
        {
            MantenimientoDAC mantenimientoDAC = new MantenimientoDAC();
            Mantenimiento result = new Mantenimiento();
            result = mantenimientoDAC.ReadBy(id);

            ProveedorComponenent personaComponent = new ProveedorComponenent();
            ProveedorComponenent proveedorComponent = new ProveedorComponenent();
            GestionMantenimientoComponent tipoMantenimiento = new GestionMantenimientoComponent();

            Proveedor proveedor = new Proveedor();
            proveedor = proveedorComponent.ReadBy(result.proveedor.Id);
            GestionMantenimiento gestionMantenimiento = new GestionMantenimiento();
            gestionMantenimiento = tipoMantenimiento.ReadBy(result.tipoMantenimiento.Id);

            Mantenimiento mantenimiento = new Mantenimiento(proveedor, gestionMantenimiento);
            mantenimiento.fecha = result.fecha;
            mantenimiento.fechaRealizado = result.fechaRealizado;
            mantenimiento.Realizado = result.Realizado;


            return mantenimiento;
        }
        public List<Mantenimiento> ReadBySinRealizar()
        {
            MantenimientoDAC personaDAC = new MantenimientoDAC();
            List<Mantenimiento> result = new List<Mantenimiento>();
            foreach (Mantenimiento item in personaDAC.ReadBySinRealizar())
            {

                ProveedorComponenent personaComponent = new ProveedorComponenent();
                ProveedorComponenent proveedorComponent = new ProveedorComponenent();
                GestionMantenimientoComponent tipoMantenimiento = new GestionMantenimientoComponent();

                Proveedor proveedor = new Proveedor();
                proveedor = proveedorComponent.ReadBy(item.proveedor.Id);
                GestionMantenimiento gestionMantenimiento = new GestionMantenimiento();
                gestionMantenimiento = tipoMantenimiento.ReadBy(item.tipoMantenimiento.Id);

                Mantenimiento mantenimiento = new Mantenimiento(proveedor, gestionMantenimiento);
                mantenimiento.fecha = item.fecha;
                mantenimiento.fechaRealizado = item.fechaRealizado;
                mantenimiento.Realizado = item.Realizado;


                result.Add(mantenimiento);


            }
            return result;
        }
        public bool Update(Mantenimiento entity)
        {
            MantenimientoDAC personaDAC = new MantenimientoDAC();
            entity.fechaRealizado = DateTime.Now;
            personaDAC.Update(entity);
            return true;
        }

        public bool Verificar(Mantenimiento entity)
        {
            return true;
        }
    }
}
