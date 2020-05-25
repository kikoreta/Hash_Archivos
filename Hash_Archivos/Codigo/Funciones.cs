using System.IO;
using System.Linq;
using System.Security.Cryptography;
using static Hash_Archivos.Codigo.Entidades;

namespace Hash_Archivos.Codigo {

    public static class Funciones {

        public static Archivo LlenarArchivo(string ruta) {
            var archivo = new Archivo();

            if (string.IsNullOrWhiteSpace(ruta)) return null;

            if (!File.Exists(ruta)) return null;

            byte[] archivoBytes = File.ReadAllBytes(ruta);

            archivo.Ruta          = ruta;
            archivo.StreamArchivo = archivoBytes;

            return archivo;
        }

        public static Archivo GenerarHash(Archivo archivo) {

            archivo.Md5    = ByteArrayString(MD5.Create().ComputeHash(archivo.StreamArchivo));
            archivo.Sha1   = ByteArrayString(SHA1.Create().ComputeHash(archivo.StreamArchivo));
            archivo.Sha256 = ByteArrayString(SHA256.Create().ComputeHash(archivo.StreamArchivo));

            return archivo;
        }

        public static string ByteArrayString(byte[] bytes) => bytes.Aggregate("", (current, b) => current + b.ToString("X2"));

    }

}