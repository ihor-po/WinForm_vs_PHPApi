using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public static class Common
    {
        public static WebRequest SendData(string method, string data)
        {
            //request = WebRequest.Create("http://localhost:777/travel_agancy.loc/apiExem/api.php");              
            WebRequest request = WebRequest.Create("http://192.168.88.217/apiExem/api.php");     
            //WebRequest request = WebRequest.Create("http://178.213.0.182:11080/apiExem/api.php");
            request.Method = method;

            // преобразуем данные в массив байтов
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
            // устанавливаем тип содержимого - параметр ContentType
            request.ContentType = "application/x-www-form-urlencoded";
            // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
            request.ContentLength = byteArray.Length;

            //записываем данные в поток запроса
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            return request;
        }

        /// <summary>
        /// Show error message
        /// </summary>
        /// <param name="msg"></param>
        public static void ShowErrorMessage(string msg)
        {
            MessageBox.Show(msg, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Show success message
        /// </summary>
        /// <param name="msg"></param>
        public static void ShowSuccessMessage(string msg)
        {
            MessageBox.Show(msg, "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
