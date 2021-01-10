using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto6
{
    class Libro
    {
        private string ISBN;
        private string Titulo;
        private string Autor;
        private int NumPag;

        #region cons
        public Libro()
        {
            this.ISBN = "";
            this.Titulo = "";
            this.Autor = "";
            this.NumPag = 0;
        }

        public Libro(string iSBN)
        {
            ISBN = iSBN;
            this.Titulo = "";
            this.Autor = "";
            this.NumPag = 0;
        }

        public Libro(string iSBN, string titulo) : this(iSBN)
        {
            Titulo = titulo;
            this.Autor = "";
            this.NumPag = 0;
        }

        public Libro(string iSBN, string titulo, string autor) : this(iSBN, titulo)
        {
            Autor = autor;
            this.NumPag = 0;
        }

        public Libro(string iSBN, string titulo, string autor, int numPag)
        {
            ISBN = iSBN;
            Titulo = titulo;
            Autor = autor;
            NumPag = numPag;
        }
        #endregion

        #region getters and setters
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string Titulo1 { get => Titulo; set => Titulo = value; }
        public string Autor1 { get => Autor; set => Autor = value; }
        public int NumPag1 { get => NumPag; set => NumPag = value; }
        #endregion

        public void toString()
        {
            Console.WriteLine("El libro con ISBN {0} creado por {1} tiene {2} páginas", this.ISBN, this.Autor, this.NumPag);
        }
    }
}
