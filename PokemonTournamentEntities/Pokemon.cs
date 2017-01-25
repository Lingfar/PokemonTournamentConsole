﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTournamentEntities
{
    public enum ETypeElement
    {
        Eau, Feu, Sol, Insecte, Plante, Dragon
    }

    [Serializable]
    public class Pokemon : EntityObject
    {
        private static Random rand = new Random(42);
        public static int[,] TableFaiblesses = new int[,] { {-1, 1, 1, 0, -1, -1}, {-1, -1, 1, 1, 1, -1},
            {0, 1, 0, -1, -1, 0}, {0, -1, 0, 0, 1, 0}, {1, -1, 1, -1, -1, -1}, {0, 0, 0, 0, 0, 1} };

        public string Nom { get; set; }
        public ETypeElement Type { get; set; }
        public Caracteristique Caracteristiques { get; set; }

        public Pokemon() { }

        public Pokemon(int id) : base(id)
        {
            Caracteristiques = new Caracteristique();
        }

        public override string ToString()
        {
            return "Pokemon : " + base.ToString() + " Nom =" + Nom + " Caracteristiques : " + Caracteristiques.ToString()
                + " Type = " + Type.ToString();
        }
    }
}
