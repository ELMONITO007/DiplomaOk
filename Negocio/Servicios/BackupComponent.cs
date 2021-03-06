﻿using Data;
using Entities;
using Entities.Servicios;
using Entities.Usuario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace Negocio.Servicios
{
    public class BackupComponent : IRepository<Backups>
    {


        public void VerificarBackupEnCarpeta()
        {
            List<Backups> backupsBase = new List<Backups>();
            backupsBase = this.Read();
            string miDirectorio = @"c:/Backup/";
            string[] listaFicheros;
            listaFicheros = Directory.GetFiles(miDirectorio);
            foreach (var item in backupsBase)
            {
                int a = 0;
                foreach (string fichero in listaFicheros)
                {
                    string nombre = fichero.Substring(10, 26);
                    if (nombre == item.Nombre)
                    {
                        a = 1;
                    }

                }
                if (a == 0)
                {
                    BackupDAC backupDAC = new BackupDAC();
                    backupDAC.Delete(item.Id);
                }
            }



        }
        public static void BackupDatabase(Backups backup)
        {
          
          
           
            //Genero la bitacora
            UsuariosComponent usuarios = new UsuariosComponent();
            EventoBitacora eventoBitacora = new EventoBitacora();
            Usuarios unUsuario = new Usuarios();
            unUsuario = usuarios.ReadBy(backup.usuarios.Id);
            eventoBitacora.Id = 9;
          
            BitacoraComponent bitacoraComponent = new BitacoraComponent();
            Bitacora bitacora = new Bitacora(unUsuario,eventoBitacora);
       
            bitacora.fecha = DateTime.Now.ToString("dd-MM-yyyy");
            bitacora.hora = DateTime.Now.ToString("hh mm ss");


            //Realizo el backup
            Backups backupRestore = new Backups(unUsuario);
            BackupDAC backupDAC = new BackupDAC();
            backupRestore = backup;
            backupRestore.Path = "c:/Backup/" + @backup.Nombre + ".bak";
            backupDAC.CreateBackup(backupRestore);
            bitacoraComponent.Create(bitacora);
        }
        public void VerificarSiexistePath()
        {
            string ruta = @"C:\\Backup";
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

        }
        public void RestaurarBase()
        {



            List<Backups> ListabackupRestore = new List<Backups>();
            BackupDAC backupDAC = new BackupDAC();
            ListabackupRestore = backupDAC.Read();
            Backups backupRestore = new Backups();
            int t = ListabackupRestore.Count() - 1;


            backupRestore.Path = @"C:\Backup\" + ListabackupRestore[t].Nombre + ".bak";
            backupRestore.Nombre = ListabackupRestore[t].Nombre;
            backupRestore.Id = ListabackupRestore[t].Id;

            UsuariosComponent usuariosComponent = new UsuariosComponent();

            RestoreDatabase(backupRestore);


        }


        public void RestoreDatabase(Backups backup)
        {
            //Genero la bitacora
            UsuariosComponent usuarios = new UsuariosComponent();
            EventoBitacora eventoBitacora = new EventoBitacora();
            Usuarios unUsuario = new Usuarios();
            unUsuario = usuarios.ReadBy(backup.usuarios.Id);
            eventoBitacora.Id = 9;

            BitacoraComponent bitacoraComponent = new BitacoraComponent();
            Bitacora bitacora = new Bitacora(unUsuario, eventoBitacora);

            bitacora.fecha = DateTime.Now.ToString("dd-MM-yyyy");
            bitacora.hora = DateTime.Now.ToString("hh mm ss");

            Backups backupRestore = new Backups(unUsuario);
            BackupDAC backupDAC = new BackupDAC();
            backupRestore = backupDAC.ReadBy(backup.Id);
            backupRestore.Path = @"C:\\Backup\" + backupRestore.Nombre + ".bak";
            backupDAC.Restore(backupRestore);
           
        }

        public Backups Create(int legajo)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Id = legajo;
            Backups entity = new Backups(usuarios);
            entity.Fecha = DateTime.Now.ToString("dd-MM-yyyy hh mm ss");
            entity.Nombre = "Backup-" + entity.Fecha;
  

            BackupDAC backupDAC = new BackupDAC();
            Backups backups = new Backups();
            backups = backupDAC.Create(entity);
            BackupDatabase(entity);

            return backups;
        }

        public void Delete(int id)
        {
            BackupDAC backupDAC = new BackupDAC();
            Backups backups = new Backups();
            backups = backupDAC.ReadBy(id);
            backups.Path = @"C:\\Backup\" + backups.Nombre + ".bak";
            File.Delete(backups.Path);
            backupDAC.Delete(id);
        }

        public List<Backups> Read()
        {

            BackupDAC backupDAC = new BackupDAC();
            return backupDAC.Read();
        }

        public Backups ReadBy(int id)
        {
            BackupDAC backupDAC = new BackupDAC();
            return backupDAC.ReadBy(id);
        }

        public void Update(Backups entity)
        {
            throw new NotImplementedException();
        }

        public Backups Create(Backups entity)
        {
            throw new NotImplementedException();
        }
        public BackupComponent()
        {
            VerificarSiexistePath();
            VerificarBackupEnCarpeta();
           
        }
    }
}
