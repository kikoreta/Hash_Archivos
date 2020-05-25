namespace Hash_Archivos.Codigo {

    public class Entidades {

        public class Archivo {

            public string Ruta   { get; set; }

            public  byte[] StreamArchivo { get; set; }
            public string Md5    { get; set; }
            public string Sha1   { get; set; }
            public string Sha256 { get; set; }

        }

    }

}