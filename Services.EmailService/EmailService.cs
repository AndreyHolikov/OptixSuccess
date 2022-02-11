//Install - Package MailKit - Version 3.1.1
//using MimeKit;
//using MailKit.Net.Smtp;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Services
{
    public class EmailService
    {
        /* Вариант 1
            Работа с электронной почтой
            Отправка почты.SmtpClient
            https://docs.microsoft.com/ru-ru/dotnet/api/system.net.mail.smtpclient.send?view=netcore-3.1
        */

        public void SendEmailWay1(String mailToaddress = "seo.motivby@gmail.com")
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("somemail@gmail.com", "Optix");
            // кому отправляем
            MailAddress to = new MailAddress(mailToaddress);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Ваш заказ";
            // текст письма
            m.Body = "<h2>Ваш заказ в Excel</h2>";
            // Добавление вложений
            m.Attachments.Add(new Attachment("template.xlsx"));
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("somemail@gmail.com", "mypassword");
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();
        }



        /// Вариант 2: Отправка email в ASP.NET Core
        /// https://metanit.com/sharp/aspnet5/21.1.php

        /* пример использования     
         public async Task<IActionResult> SendMessage()
         {
             EmailService emailService = new EmailService();
             await emailService.SendEmailAsync("somemail@mail.ru", "Тема письма", "Тест письма: тест!");
             return RedirectToAction("Index");
         }
        */

        /*public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "login@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 25, false);
                await client.AuthenticateAsync("login@yandex.ru", "password");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
        */



        // Вариант 3: https://metanit.com/sharp/net/8.1.php
        // +Настройки ящика https://alekseev74.ru/lessons/show/aspnet-core-mvc/email-sending

        /*public async Task SendEmailWay2Async(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "login@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 25, false);
                await client.AuthenticateAsync("login@yandex.ru", "password");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
        */
    }
}
