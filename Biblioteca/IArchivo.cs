using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Clases
{
    public interface IArchivos<T>
    {
        void Escribir(string path, T miObjeto, string formato, bool agregarTexto);
        T Leer(string path, string formato);
    }
}