using Data;
using Entities;
using Entitites.Negocio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion_de_Personas
{
 public   class ParienteComponent : IRepository2<Pariente>
    {

        #region ParentescoPersona
        public List<Pariente> buscar(string palabra)
        {
            List<Pariente> entity = new List<Pariente>();

            entity = ReadParienteAlumno();
            List<Pariente> result = new List<Pariente>();
            foreach (Pariente item in entity)
            {
                if (item.apellido.Contains(palabra) || item.DNI.Contains(palabra) || item.direccion.Contains(palabra))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public Pariente CreateParienteAlumno(Pariente entity)
        {
            if (VerificarParienteAlumno(entity))
            {
                ParienteDAC idiomaDAC = new ParienteDAC();
                Pariente parentesco = new Pariente();
                parentesco = idiomaDAC.CreateParienteAlumno(entity);


                return parentesco;
            }
            else
            {
                return null;
            }
        }

        public void DeleteParienteAlumno(int id)
        {
            ParienteDAC parentescoDac = new ParienteDAC();

            parentescoDac.DeleteParienteAlumno(id);
        }

        public List<Pariente> ReadParienteAlumno()
        {
            ParienteDAC parentescoDac = new ParienteDAC();
            List<Pariente> parentescos = new List<Pariente>();
            List<Pariente> result = new List<Pariente>();
            parentescos = parentescoDac.ReadParienteAlumno();
            foreach (Pariente item in parentescos)
            {
                AlumnoComponent personaComponent = new AlumnoComponent();
                Pariente parentesco = new Pariente();
                parentesco = item;
            
                parentesco.alumno = personaComponent.ReadBy(item.alumno.Id);
                result.Add(parentesco);
            }
            return result;
        }

        public Pariente ReadByParienteAlumno(int id)
        {
            ParienteDAC parentescoDac = new ParienteDAC();
            Pariente parentesco = new Pariente();
            Pariente result = new Pariente();
            parentesco = parentescoDac.ReadByParienteAlumno(id);
            AlumnoComponent personaComponent = new AlumnoComponent();
            result = parentesco;
            result.alumno = personaComponent.ReadBy(parentesco.alumno.Id);
        
            return result;

        }
        public Pariente ReadByParienteAlumno(Pariente entity)
        {
            ParienteDAC parentescoDac = new ParienteDAC();

            Pariente result = new Pariente();
            result = parentescoDac.ReadByParienteAlumno(entity);

            return result;

        }
        public List<Pariente> ReadByAdulto(int id)
        {
            ParienteDAC parentescoDac = new ParienteDAC();
            List<Pariente> parentescos = new List<Pariente>();
            List<Pariente> result = new List<Pariente>();
            parentescos = parentescoDac.ReadByAdulto(id);
            foreach (Pariente item in parentescos)
            {
                AlumnoComponent personaComponent = new AlumnoComponent();
                Pariente parentesco = new Pariente();
      
                parentesco.alumno = personaComponent.ReadBy(item.alumno.Id);
                result.Add(parentesco);
            }
            return result;

        }
        public List<Pariente> ReadByAlumno(int id)
        {
            ParienteDAC parentescoDac = new ParienteDAC();
            List<Pariente> parentescos = new List<Pariente>();
            List<Pariente> result = new List<Pariente>();
            parentescos = parentescoDac.ReadByAlumno(id);
            foreach (Pariente item in parentescos)
            {
                List<Telefono> telefonos = new List<Telefono>();
                TelefonoComponent telefonoComponent = new TelefonoComponent();
                telefonos = telefonoComponent.ReadByPersona(item.Id);
                         AlumnoComponent personaComponent = new AlumnoComponent();
                Pariente parentesco = new Pariente(personaComponent.ReadBy(item.alumno.Id),telefonoComponent.ReadByPersona(item.Id));
                parentesco.Id = item.Id;
                parentesco.apellido = item.apellido;
                parentesco.autorizadoRetirar = item.autorizadoRetirar;
                parentesco.direccion = item.direccion;
                parentesco.DNI = item.DNI;
                parentesco.fechaNacimiento = item.fechaNacimiento;
                parentesco.nombre = item.nombre;
                parentesco.parentesco = item.parentesco;
              
           
                result.Add(parentesco);
            }
            return result;

        }
   
        

        public bool VerificarParienteAlumno(Pariente entity)
        {
            if (ReadByParienteAlumno(entity) == null)
            {
                return true;
            }
            else
            {


                return false;
            }
        }




        #endregion

        #region Pariente

        public Pariente Create(Pariente entity)
        {
            if (Verificar(entity))
            {
                ParienteDAC idiomaDAC = new ParienteDAC();
                Pariente persona = new Pariente();
                persona = idiomaDAC.Create(entity);
                persona = ReadBy(entity.DNI);
                Alumno alumno = new Alumno();
                alumno.Id = entity.alumno.Id;
                Pariente pariente = new Pariente(entity.alumno);
                pariente.Id = persona.Id;
                pariente.parentesco = entity.parentesco;
                pariente.autorizadoRetirar = entity.autorizadoRetirar;
                CreateParienteAlumno(pariente);

                return persona;
            }
            else
            {
                Pariente persona = new Pariente();
                persona = ReadBy(entity.DNI);
                persona.alumno.Id = entity.alumno.Id;

                CreateParienteAlumno(persona);
                return null;
            }
        }



        public void Delete(int id)
        {
            ParienteDAC idiomaDAC = new ParienteDAC();
            idiomaDAC.Delete(id);
        }

       

       


        public Pariente ReadBy(int id)
        {

            ParienteDAC personaDAC = new ParienteDAC();
            Pariente result = new Pariente();
            Pariente persona = new Pariente();
            persona = personaDAC.ReadBy(id);


            return persona;
        }

        public Pariente ReadBy(string id)
        {
            ParienteDAC personaDAC = new ParienteDAC();
            Pariente result = new Pariente();
            Pariente persona = new Pariente();
            persona = personaDAC.ReadBy(id);


            return persona;
        }

        public bool Update(Pariente entity)
        {
            ParienteDAC parentescoDac = new ParienteDAC();
            parentescoDac.Update(entity);

            return true;
        }
        public bool Verificar(Pariente entity)
        {
            if (ReadBy(entity.DNI) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Pariente> Read()
        {
            throw new NotImplementedException();
        }


        #endregion

    }
}
