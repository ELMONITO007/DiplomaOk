using Data.Gestion_de_Boletin;
using Entities;
using Negocio.Gestion_de_Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion_de_boletin
{
    public class BoletinComponent : IRepository2<Boletin>
    {
        public List<Boletin> buscar(string palabra)
        {
            throw new NotImplementedException();
        }



        public Boletin Create(Boletin entity)

        {

            if (Verificar(entity))
            {

                DateTime ff = new DateTime(entity.año, entity.cutrimeste + 4, 30);

                if (DateTime.Now >= ff)
                {
                    return null;
                }
                else
                {
                    BoletinDAC asistenciaDAC = new BoletinDAC();

                    PDFboletinComponent pDFboletinComponent = new PDFboletinComponent();
                    pDFboletinComponent.GenerarPDF(entity);

                    return asistenciaDAC.Create(entity);
                }

            }
            else
            {
                return null;
            }
        }

        public void Delete(int id)
        {
            BoletinDAC asistenciaDAC = new BoletinDAC();
            PDFboletinComponent pDFboletinComponent = new PDFboletinComponent();
            BoletinComponent boletinComponent = new BoletinComponent();
            pDFboletinComponent.BorroaPDF(boletinComponent.ReadBy(id));
            asistenciaDAC.Delete(id);
        }

        public List<Boletin> Read()
        {
            BoletinDAC asistenciaDAC = new BoletinDAC();
            List<Boletin> result = new List<Boletin>();
            foreach (Boletin item in asistenciaDAC.Read())
            {
                AlumnoComponent personaComponent = new AlumnoComponent();
                Boletin asistencia = new Boletin();

                asistencia = item;
                asistencia.persona = personaComponent.ReadBy(item.persona.Id);

                result.Add(asistencia);


            }
            return result;
        }
        public List<Boletin> ReadByAlumnoYAño(Boletin entity)
        {
            BoletinDAC asistenciaDAC = new BoletinDAC();
            List<Boletin> result = new List<Boletin>();
            foreach (Boletin item in asistenciaDAC.ReadByAlumnoYAño(entity))
            {
                AlumnoComponent personaComponent = new AlumnoComponent();
                Boletin asistencia = new Boletin();

                asistencia = item;
                asistencia.persona = personaComponent.ReadBy(item.persona.Id);

                result.Add(asistencia);


            }
            return result;
        }
        public Boletin ReadBy(int id)
        {

            BoletinDAC asistenciaDAC = new BoletinDAC();
            Boletin result = null;

            AlumnoComponent personaComponent = new AlumnoComponent();
            result = asistenciaDAC.ReadBy(id);


            result.persona = personaComponent.ReadBy(result.persona.Id);


            return result;
        }
        public Boletin ReadBy(string id)
        {
            throw new NotImplementedException();
        }
        public Boletin ReadBy(Boletin entity)
        {
            BoletinDAC asistenciaDAC = new BoletinDAC();
            Boletin result = null;

            PersonaComponent personaComponent = new PersonaComponent();
            result = asistenciaDAC.ReadBy(entity);




            return result;
        }

        public bool Update(Boletin entity)
        {
            throw new NotImplementedException();
        }

        public bool Verificar(Boletin entity)
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
    }
}
