using Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Clases
{
    /// <summary>
    /// Representa una herramienta para manejar archivos
    /// con metodos de lectura y escritura,
    /// </summary>
    /// <typeparam name="T">objeto que retornara con metodos de lectura</typeparam>
    public class Archivos<T> : IArchivos<T>
    {
        /// <summary>
        /// Metodo que seleccionara otro metodo de
        /// escritura dependiento del formato
        /// </summary>
        /// <param name="ruta">la ruta donde se guardara el archivo</param>
        /// <param name="miObjeto">el objeto que se deserializara para
        /// poder pasarlo al formado indicado por el usuario</param>
        /// <param name="formato">tipo de archivo</param>
        /// <param name="agregarTexto">usado para saber si 
        /// agregar texto o pisar el archivo</param>
        public void Escribir(
            string ruta, 
            T miObjeto, 
            string formato, 
            bool agregarTexto
        )
        {
            try
            {
                switch (formato.ToLower())
                {
                    case "txt":
                        Escribir_TXT(ruta, miObjeto.ToString(), agregarTexto);
                        break;
                    case "json":
                        Escribir_JSON(ruta, miObjeto);
                        break;
                    case "xml":
                        Escribir_XML(ruta, miObjeto);
                        break;
                }
            }
            catch (Exception e)
            {
                Archivos<string>.Escribir_TXT(ruta + "archivo.txt", Archivos<string>.LogError(e), true);
                throw;
            }
        }

        /// <summary>
        /// Metodo que seleccionara otro metodo de
        /// lectura dependiento del formato
        /// </summary>
        /// <param name="ruta">la ruta donde se guardara el archivo</param>
        /// <param name="formato">tipo de archivo</param>
        /// <returns>el objeto creado a partir del archivo</returns>
        public T Leer(string ruta, string formato)
        {
            try
            {
                switch (formato.ToLower())
                {
                    case "txt":
                        return Leer_TXT(ruta);
                    case "json":
                        return Leer_JSON(ruta);
                    case "xml":
                        return Leer_XML(ruta);
                    default:
                        return default(T);
                }
            }
            catch (Exception e)
            {
                Archivos<string>.Escribir_TXT(ruta + "archivo.txt", Archivos<string>.LogError(e), true);
                throw;
            }
        }

        /// <summary>
        /// Crea, sobreescribe o agrega texto a un archivo.txt
        /// </summary>
        /// <param name="ruta">ruta donde se guardara el archivo</param>
        /// <param name="texto">texto que se agregara al archivo</param>
        /// <param name="agregarTexto">usado para saber si 
        /// agregar texto o pisar el archivo</param>
        public static void Escribir_TXT(string ruta, string texto, bool agregarTexto = false)
        {
            using (StreamWriter sw = new StreamWriter(ruta, agregarTexto))
            {
                if (agregarTexto)
                {
                    sw.WriteLine();
                }
                sw.WriteLine(texto);
            }
        }

        /// <summary>
        /// Serializa un objeto para poder escribir
        /// un archivo.json
        /// </summary>
        /// <param name="ruta">ruta donde se guardara el archivo</param>
        /// <param name="miObjeto">objeto a serializar</param>
        public static void Escribir_JSON(string path, T miObjeto)
        {
            JsonSerializerOptions identacion = new();
            identacion.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(miObjeto, identacion);

            File.WriteAllText(path, jsonString);
        }


        /// <summary>
        /// Serializa un objeto para poder escribir
        /// un archivo.xml
        /// </summary>
        /// <param name="ruta">ruta donde se guardara el archivo</param>
        /// <param name="miObjeto">objeto a serializar</param>
        public static void Escribir_XML(string path, T miObjeto)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Usuario>), new Type[]
                { typeof(Supervisor), typeof(Operario) });
                xmlSerializer.Serialize(sw, miObjeto);
            }
        }

        /// <summary>
        /// Toma una excepcion, la clase y metodo donde 
        /// se genero para devolver la informacion de esta
        /// </summary>
        /// <param name="e">excepcion a analizar</param>
        /// <param name="metodo">metodo donde se genero la e</param>
        /// <param name="rutaArchivo">ruta del archivo donde se genero
        /// la excepcion</param>
        /// <returns>el mensaje completo con la fecha y hora,
        /// nombre de la excepcion, clase y metodo donde se genero</returns>
        public static string LogError(Exception e, [CallerMemberName] string metodo = "", [CallerFilePath] string rutaArchivo = "")
        {
            string nombreClase = Path.GetFileNameWithoutExtension(rutaArchivo);

            string excepcionMensaje = $"{DateTime.Now} - Error: {e.Message}, Clase: {nombreClase}, Método: {metodo}";

            return excepcionMensaje;
        }

        /// <summary>
        /// Lee un archivo.xml, deserializa un 
        /// objeto a partir de este
        /// </summary>
        /// <param name="path">ruta donde se encuentra el archivo</param>
        /// <returns>el objeto deserializado</returns>
        public static T Leer_XML(string path)
        {
            using (StreamReader sw = new(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Usuario>), new Type[]
                { typeof(Supervisor), typeof(Operario) });
                return (T)xmlSerializer.Deserialize(sw);
            }
        }

        /// <summary>
        /// Lee un archivo.json, deserializa un 
        /// objeto a partir de este
        /// </summary>
        /// <param name="path">ruta donde se encuentra el archivo</param>
        /// <returns>el objeto deserializado</returns>
        public static T Leer_JSON(string path)
        {
            string jsonString = File.ReadAllText(path);

            T miObjeto = JsonSerializer.Deserialize<T>(jsonString);

            return miObjeto;
        }

        /// <summary>
        /// Lee un archivo.txt, deserializa un 
        /// objeto a partir de este
        /// </summary>
        /// <param name="path">ruta donde se encuentra el archivo</param>
        /// <returns>un string del objeto deserializado</returns>
        public static T Leer_TXT(string path)
        {
            string rtn = String.Empty;

            using (StreamReader sr = new(path))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    rtn += linea;
                }
            }

            return (T)(object)rtn.ToString();
        }
    }
}