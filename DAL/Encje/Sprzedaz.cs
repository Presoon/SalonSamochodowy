﻿using MySql.Data.MySqlClient;

namespace Salon_samochodowy.DAL.Encje
{
    public class Sprzedaz
    {
        #region Pola
        public sbyte IdSprzedazy { get; set; }
        public sbyte IdPracownika { get; set; }
        public sbyte IdSamochodu { get; set; }
        public double Cena { get; set; }
        #endregion

        #region Kontruktory

        public Sprzedaz(MySqlDataReader reader)
        {
            IdSprzedazy = sbyte.Parse(reader["idSprzedazy"].ToString());
            IdPracownika = sbyte.Parse(reader["idPracownika"].ToString());
            IdSamochodu = sbyte.Parse(reader["idModelu"].ToString());
            Cena = double.Parse(reader["cena"].ToString());
        }
        #endregion

    }
}