﻿using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace PortalNomina.Controllers
{
    public class ReportsController : Controller
    {
        private readonly static DateTime fecha_h = DateTime.Now;
        private readonly static DateTime fecha_d = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

        RepReciboPagoTipo2_2KDoce report = new RepReciboPagoTipo2_2KDoce();
        public ActionResult RepReciboPagoTipo2_2KDocePartial()
        {
            report.Parameters["fechaDesde"].Value = fecha_d;
            report.Parameters["fechaHasta"].Value = fecha_h;
            report.Parameters["DB"].Value = "DEMON";

            return PartialView("~/Views/Home/_RepReciboPagoTipo2_2KDocePartial.cshtml", report);
        }
        public ActionResult RepReciboPagoTipo2_2KDocePartialExport(string param = "")
        {
            string message;
            bool error = false;

            try
            {
                string[] values = param.Split('-');

                // Generar el reporte utilizando DevExpress Reporting
                RepReciboPagoTipo2_2KDoce report = new RepReciboPagoTipo2_2KDoce();
                report.Parameters["fechaDesde"].Value = DateTime.ParseExact(values[0], "yyyyMMddTHH:mm:ss", null); // new DateTime(2005, 1, 1);
                report.Parameters["fechaHasta"].Value = DateTime.ParseExact(values[1], "yyyyMMddTHH:mm:ss", null); // new DateTime(2005, 1, 31);
                report.Parameters["codEmpleado"].Value = values[2]; // new DateTime(2005, 1, 31);

                // Exportar el reporte a PDF
                MemoryStream stream = new MemoryStream();
                report.ExportToPdf(stream);
                stream.Seek(0, SeekOrigin.Begin);

                // Adjuntar el archivo PDF al correo electrónico
                Attachment attachment = new Attachment(stream, "Report.pdf", "application/pdf");

                // Crear el correo electrónico
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("operadoradeserviciosrrhhac3@gmail.com", "Operadora de Servicios");
                mail.To.Add(values[3]);
                mail.Subject = "Recibo de Pago";
                mail.Body = "Adjunto encontrarás el recibo correspondiente.";
                mail.Attachments.Add(attachment);

                // Configurar el servidor SMTP saliente
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("operadoradeserviciosrrhhac3@gmail.com", "jsyb qnmq pwsf nwar");
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 10000;

                // Enviar el correo electrónico
                smtpClient.Send(mail);

                message = "El informe ha sido enviado por correo electrónico correctamente.";
            }
            catch (Exception ex)
            {
                message = "Ha ocurrido un error: " + ex.Message;
                error = true;
            }

            return RedirectToAction("Dashboard", "Home", new { message, error });
        }
    }
}