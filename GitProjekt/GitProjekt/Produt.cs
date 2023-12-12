﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GitProjekt
{
    public class Produt
    {
        public string Nazwa {  get; set; }

        public decimal Cena {  get; set; }

        public int Ilosc {  get; set; }

        public Produt(string Nazwa, decimal Cena, int Ilosc)
        {
            this.Nazwa = Nazwa;
            this.Cena = Cena;
            this.Ilosc = Ilosc;
        }

        public Produt() { }
    }
}
