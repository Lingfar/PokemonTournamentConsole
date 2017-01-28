﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTournamentEntities
{
    public class Match : EntityObject
    {
        public int IdPokemonVainqueur { get; set; }
        public EPhaseTournoi PhaseTournoi { get; set; }
        public Pokemon Pokemon1 { get; set; }
        public Pokemon Pokemon2 { get; set; }
        public Stade Stade { get; set; }

        public Match()
        {

        }

        public Match(int id, EPhaseTournoi phase, Pokemon p1, Pokemon p2) : base(id)
        {
            PhaseTournoi = phase;
            Pokemon1 = p1;
            Pokemon2 = p2;
        }

        public Match(EPhaseTournoi phase, Pokemon p1, Pokemon p2)
        {
            PhaseTournoi = phase;
            Pokemon1 = p1;
            Pokemon2 = p2;
        }

        public override string ToString()
        {
            return "Match : " + base.ToString() + "\n\tPhase = " + PhaseTournoi + "\n\t" + Pokemon1
            + "\n\t" + Pokemon2 + "\n\tVainqueur = " + IdPokemonVainqueur+ "\n\tStade = " + Stade;
        }
    }
}
