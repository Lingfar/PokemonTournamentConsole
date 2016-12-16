﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTournamentEntities
{
    public class Stade : EntityObject
    {
        public Caracteristiques Caracteristiques { get; set; }
        public int NbPlaces { get; set; }
        public string Nom { get; set; }
        public ETypeElement Type { get; set; }

        public Stade(int id) : base(id)
        {

        }

        public override string ToString()
        {
            return "Stade : Id = " + base.ToString() + " Nom =" + Nom + " Caracteristiques = " + Caracteristiques.ToString()
                + " NbPlaces = " + NbPlaces + " Type = " + Type;
        }
    }
}