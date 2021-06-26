﻿using Data;
using Data.Servicios;
using Entities;

using Entities.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class BitacoraComponent : IRepository<Bitacora>
    {
        public List<Bitacora> Buscar(String palabra)
        {
            List<Bitacora> bitacoras = new List<Bitacora>();
            BitacoraComponent bitacoraComponent = new BitacoraComponent();
            bitacoras = bitacoraComponent.Read();
            List<Bitacora> result = new List<Bitacora>();
            foreach (var item in bitacoras)
            {
                if (item.usuarios.UserName.Contains(palabra) || item.fecha.Contains(palabra) || item.hora.Contains(palabra) || item.eventoBitacora.eventoBitacora.Contains(palabra))
                {
                    result.Add(item);
                }
            }
            return result;

        }
        public Bitacora Create(Bitacora entity)
        {
            Bitacora bitacora = new Bitacora();
            bitacora = entity;
            bitacora.fecha = DateTime.Now.ToString("dd/MM/yyyy");
            bitacora.hora = DateTime.Now.ToString("HH:mm");
            UsuariosComponent usuariosComponent = new UsuariosComponent();
            Usuarios usuarios = new Usuarios();
            usuarios = usuariosComponent.ReadByEmail(entity.usuarios.Email);
            bitacora.usuarios = usuarios;
            BitacoraDAC bitacoraDAC = new BitacoraDAC();

            return bitacoraDAC.Create(bitacora);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bitacora> Read()
        {
            BitacoraDAC bitacoraDAC = new BitacoraDAC();
            List<Bitacora> bitacoras = new List<Bitacora>();
            foreach (Bitacora item in bitacoraDAC.Read())
            {
                EventoBitacora eventoBitacora = new EventoBitacora();
                EventoBitacoraDAC eventoBitacoraDAC = new EventoBitacoraDAC();
                eventoBitacora = eventoBitacoraDAC.ReadBy(item.eventoBitacora.Id);
                item.eventoBitacora = eventoBitacora;
                UsuarioDac usuarioDac = new UsuarioDac();
                Usuarios usuarios = new Usuarios();
                usuarios = usuarioDac.ReadBy(item.usuarios.Id);
                item.usuarios = usuarios;


                bitacoras.Add(item);

            }

            return bitacoras;
        }

        public Bitacora ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Bitacora entity)
        {
            throw new NotImplementedException();
        }
    }
}
