using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Configuration;
using System.Net;

namespace Negocio
{
    public class NewsLetter
    {

        String emailorigin;
        String emaildestino;
        String titulomsg;
        String corpomsg;


        public void enviarEmail(String emailorigin, String emaildestino, String titulomsg, String corpomsg)
        {
            //cria uma mensagem
            MailMessage mail = new MailMessage();

            //define os endereços
            mail.From = new MailAddress(emailorigin);
            mail.To.Add(emaildestino);

            //define o conteúdo
            mail.Subject = titulomsg;
            mail.Body = corpomsg;

            //envia a mensagem
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Send(mail);
        }

        public void adicionar(String email)
        {
            pNewsLetter objNewsLetter = new pNewsLetter();
            objNewsLetter.adicionar(email);
        }
        public void deletar(String idEmail)
        {
            pNewsLetter objNewsLetter = new pNewsLetter();
            objNewsLetter.deletar(idEmail);
        }
        public void alterar(String idEmail, String email)
        {
            pNewsLetter objNewsLetter = new pNewsLetter();
            objNewsLetter.alterar(idEmail, email);
        }
        public DataSet consultar()
        {
            pNewsLetter objNewsLetter = new pNewsLetter();
            return objNewsLetter.consultar();
        }
    }
}
