using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _0._8HTTPRequest.helpers
{
    public static class HttpSolicitudes
    {
        /// <summary>
        /// aqui desserealizo mi respuesta y la retorno como un objeto,
        /// para ejecutar esta linea hay que instalar un paquete llamado Newtonsoft.Json
        /// no funcoina para generarlo con genericos asi que hay que hacerlo al realizar una peticion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="URL"></param>
        /// <returns></returns>

        //public static List<T> ObtenerLista<T>(string URL) where T : class, new()
        //{
        //    List<T> Lista = new List<T>();

        //    string Respuesta = GetHTTP(URL);
        //    //Lista = JsonConvert.DeserializeObject<T>(Respuesta);

        //    return Lista;
        //} 
            
            

    /// <summary>
    /// aqui obtengo mi respuesta y lo devuelven en un string de tipo JSON hay que desealizarlo en el momento en que obtengo la respuesta
    /// </summary>
    /// <param name="URL"></param>
    /// <returns></returns>



        public static string GetHTTP(string URL)
        {
            try
            {
                WebRequest peticion = WebRequest.Create(URL);
                WebResponse respuesta = peticion.GetResponse();
                StreamReader Lector = new StreamReader(respuesta.GetResponseStream());

                return Lector.ReadToEnd().Trim();
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// aqui generamois nuestro valor por medio de unn póst
        /// debe de´pasarse el estrig ya serialiazdo
        ///  var json = JsonConvert.SerializeObject(T);
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="URL"></param>
        /// <param name="insert"></param>
        /// <returns></returns>
        public static string PostHTTP<T>(string URL , string insert) where T : class,new()
        {
            string resultado = "";
            WebRequest peticion = WebRequest.Create(URL);
            //en la anterior no se asignoi el metodo pues por defecto es get
            peticion.Method = "post";
            //el infaltable content type
            peticion.ContentType = "application/Json;charset-UTF-8";
            //Generamos un wriiter de stream para editar nuestra informacion
            using(var writer = new StreamWriter(peticion.GetRequestStream()))
            {
                //nota este objeto tiene que venir serializado
                writer.Write(insert);
                writer.Flush();
                writer.Close();
            }

            //ahora trabajamos con la respuesta
            WebResponse repuesta = peticion.GetResponse();
            using(var lector = new StreamReader(repuesta.GetResponseStream()))
            {
                resultado = lector.ReadToEnd().Trim();
            }

            return resultado;
        }

    }
}
