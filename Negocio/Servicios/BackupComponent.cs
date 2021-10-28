using Data;
using Entities;
using Entities.Servicios;
using Entities.Usuario;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
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

            bitacoraComponent.Create(bitacora);
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
            BitacoraComponent bitacoraComponent = new BitacoraComponent();
            EventoBitacora eventoBitacora = new EventoBitacora();
            Usuarios usuarios = new Usuarios();
            usuarios.Id = 2;
            eventoBitacora.Id = 10;
            Bitacora bitacora = new Bitacora(usuarios, eventoBitacora);
            bitacoraComponent.Create(bitacora);
          
         

        }


        public void RestoreDatabase(Backups backup)
        {
            //Genero la bitacora
            UsuariosComponent usuarios = new UsuariosComponent();
            EventoBitacora eventoBitacora = new EventoBitacora();
            Usuarios unUsuario = new Usuarios();
            unUsuario.Id =2;
            eventoBitacora.Id = 10;

            BitacoraComponent bitacoraComponent = new BitacoraComponent();
            Bitacora bitacora = new Bitacora(backup.usuarios, eventoBitacora);

            bitacora.fecha = DateTime.Now.ToString("dd-MM-yyyy");
            bitacora.hora = DateTime.Now.ToString("hh mm ss");
            bitacoraComponent.Create(bitacora);
            Backups backupRestore = new Backups(backup.usuarios);
            BackupDAC backupDAC = new BackupDAC();
            backupRestore = backupDAC.ReadBy(backup.Id);
            backupRestore.Path = @"C:\\Backup\" + backupRestore.Nombre + ".bak";
            backupDAC.Restore(backupRestore);
            //restauro DVV y Base AUX

            UsuariosComponent usuariosComponent = new UsuariosComponent();
            //usuariosComponent.RestoreBDAUX();
          
            DVVComponent dVVComponent = new DVVComponent();
            dVVComponent.CrearDVV(usuariosComponent.ListaDVH(), "Usuario");

            var bkSerie = new Backups(usuariosComponent.ReadBy(unUsuario.Id))

            { Fecha = bitacora.fecha,
                Path = backupRestore.Path,
                Nombre = backupRestore.Nombre,
                Id = backupRestore.Id,
                
                

            }

                
                ;crearJson(bkSerie);


        }

        public void crearJson(Backups backups)


        { 
        String jsonString= JsonSerializer.Serialize(backups);
            string filename =@"C:\Imagenes\"+ backups.Fecha + ".json";
            if (!File.Exists(filename))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(filename))
                {
                    sw.Write(jsonString);
                   
                }
            }


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
