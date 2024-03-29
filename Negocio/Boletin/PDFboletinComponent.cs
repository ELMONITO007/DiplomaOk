﻿using Entities;
using Entitites;
using Entitites.Negocio.Personas;
using Entitites.Negocio.Salas;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Negocio.Gestion_de_Alumnos;
using Negocio.Gestion_de_Personas;
using Negocio.Gestion_de_Salas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Gestion_de_boletin
{
    public class PDFboletinComponent
    {


        public void VericarPath(PDFBoletin pDFBoletin)

        {
            if (!Directory.Exists(pDFBoletin.path))
            {

                DirectoryInfo di = Directory.CreateDirectory(@pDFBoletin.path);
            }


        }
        public void AbrirPDF(Boletin boletin)


        {

            string path = @"c:\Boletin\" + boletin.persona.DNI + @"\" + boletin.año + @"\" + boletin.cutrimeste + @"\" + boletin.persona.nombre + " " + boletin.persona.apellido + ".pdf";

            if (File.Exists(path))
            {
                string pdfPath = Path.Combine(Application.StartupPath, path);
                Process.Start(pdfPath);
            }

        }
        public void BorroaPDF(Boletin boletin)


        {

            string path = @"c:\Boletin\" + boletin.persona.DNI + @"\" + boletin.año + @"\" + boletin.cutrimeste + @"\" + boletin.persona.nombre + " " + boletin.persona.apellido + ".pdf";

            if (File.Exists(path))
            {
                string pdfPath = Path.Combine(Application.StartupPath, path);
                File.Delete(path);
            }

        }

        public PDFBoletin ObtenerDatos(Boletin boletin)


        {
            //obtengo el alumno
            Alumno alumno = new Alumno();
            AlumnoComponent alumnoComponent = new AlumnoComponent();
            alumno = alumnoComponent.ReadBy(boletin.persona.Id);
            Boletin unBoletin = new Boletin(alumno);
            unBoletin.año = boletin.año;
            unBoletin.cutrimeste = boletin.cutrimeste;
            unBoletin.notas = boletin.notas;
                       
            //Obtengo las asistencias
            AsistenciaComponent asistenciaComponent = new AsistenciaComponent();
            List<Asistencia> listaAsitencia = new List<Asistencia>();
            Asistencia asistencia = new Asistencia(alumno);
            asistencia.año = boletin.año;
            listaAsitencia = asistenciaComponent.ReadByAlumno(asistencia);

            //Obtengo las notas
            ExamenComponent examenComponent = new ExamenComponent();
            Examen examen = new Examen(alumno,null);
            DateTime fi = new DateTime(boletin.año, boletin.cutrimeste *2 + 2, 1);
            DateTime ff = new DateTime(boletin.año, boletin.cutrimeste *2 +4, 30);
            List<Examen> listaExamen = new List<Examen>();
            listaExamen= examenComponent.ReadByAlumnoYAñoUnique(examen, fi, ff);

            //Obtengo el curso
            CursoComponent cursoComponent = new CursoComponent();
            Curso curso = new Curso();
            curso = cursoComponent.ReadByPersona(alumno.Id);

            //Obtengo los maestros

            MaestroComponent maestroComponent = new MaestroComponent();
            List<Maestro> listaMaestro = new List<Maestro>();
            listaMaestro = maestroComponent.ObtenerAlumnodeCunCurso(curso.Id);

            PDFBoletin PDF = new PDFBoletin(unBoletin,listaAsitencia,listaExamen,curso,listaMaestro);
            PDF.boletin = boletin;

            PDF.asistencia = 0;
            PDF.inAsistencia = 0;
            foreach (var item in PDF.listaAsitencia)
            {
                if (item.asistio)
                {
                    PDF.asistencia++;
                }
                else
                {
                    PDF.inAsistencia++;
                }
            }


            //Obtengo las notas
         
         
       

            MateriaExamen materiaExamen = new MateriaExamen();


            PDF.listaPromedio = materiaExamen.obtenerPromedio(PDF.listaExamen, examenComponent.ReadByAlumnoYMateria(boletin.persona.Id, fi, ff));
            PDF.promediogeneral = Math.Round(materiaExamen.obtenerPromedioGeneral(PDF.listaExamen).promedio);

                


            //genero el patch


            PDF.path = @"c:\Boletin\" + boletin.persona.DNI + @"\" + boletin.año + @"\" + boletin.cutrimeste + @"\";

            VericarPath(PDF);

            return PDF;


        }


        public void GenerarPDF(Boletin boletin)

        {


            PDFBoletin PDF = new PDFBoletin();
            PDF = ObtenerDatos(boletin);

            //creamos el pdf

            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@PDF.path + boletin.persona.nombre + " " + boletin.persona.apellido + ".pdf", FileMode.Create));
            doc.Open();


            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //agrego el logo
            string imagePath = @"C:\Imagenes\logo.png";
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePath);
            img.Alignment = Element.ALIGN_CENTER;
            img.ScaleToFit(180f, 250f);

            doc.Add(img);
            Paragraph titulo = new Paragraph("Jardin de infantes Crear y Ser");
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);


            Paragraph nombre = new Paragraph("Nombre: " + boletin.persona.nombre + " " + boletin.persona.apellido);
            titulo.Alignment = Element.ALIGN_LEFT;
            doc.Add(nombre);
            doc.Add(Chunk.NEWLINE);

            Paragraph sala = new Paragraph("Sala: " + PDF.curso.nombre + "                   Año: " + boletin.año + "                   Cutrimestre: " + boletin.cutrimeste );
            doc.Add(sala);
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            foreach (var item in PDF.maestro)
            {

                EspecialidadComponent especialidadComponent = new EspecialidadComponent();

                Paragraph maestro = new Paragraph("Maestro: " + item.nombre + " " + item.apellido + " " +   "    Especialidad:"+ especialidadComponent.ReadByPersona(item.Id)[0].especialidad) ;
                titulo.Alignment = Element.ALIGN_LEFT;
                doc.Add(maestro);
                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);
            }
           

            //obtener Asistencias


            Paragraph asistencia = new Paragraph("Total Asistencias: " + PDF.asistencia + "                      Total de Inasistencias: " + PDF.inAsistencia);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(asistencia);
            doc.Add(Chunk.NEWLINE);


            PdfPTable tabla = new PdfPTable(3);
            tabla.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("Materia", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clApellido = new PdfPCell(new Phrase("Nota", _standardFont));
            clApellido.BorderWidth = 0;
            clApellido.BorderWidthBottom = 0.75f;

            PdfPCell clPais = new PdfPCell(new Phrase("Fecha", _standardFont));
            clPais.BorderWidth = 0;
            clPais.BorderWidthBottom = 0.75f;


            // Añadimos las celdas a la tabla
            foreach (var item in PDF.listaPromedio)
            {
                tabla.AddCell(clNombre);
                tabla.AddCell(clApellido);
                tabla.AddCell(clPais);

                clNombre = new PdfPCell(new Phrase(item.materia.materia, _standardFont));
                clNombre.BorderWidth = 0;

                clApellido = new PdfPCell(new Phrase(item.promedio.ToString(), _standardFont));
                clApellido.BorderWidth = 0;

                clPais = new PdfPCell(new Phrase(item.examen.fecha.ToString("dd-MM-yyyy"), _standardFont));
                clPais.BorderWidth = 0;

                // Añadimos las celdas a la tabla
                tabla.AddCell(clNombre);
                tabla.AddCell(clApellido);
                tabla.AddCell(clPais);


            }



            doc.Add(tabla);
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            Paragraph general = new Paragraph("Promedio general: " + PDF.promediogeneral);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(general);
            doc.Add(Chunk.NEWLINE);


            Paragraph Observaciones = new Paragraph("Observaciones: " + boletin.notas);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(Observaciones);



            doc.Close();


        }


    }
}
