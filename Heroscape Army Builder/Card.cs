using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroscape_Army_Builder
{
    enum cardType
    {
        Small,
        Medium,
        Large,
        Huge
    }
    enum cardGeneral
    {
        Jandar,
        Utgar,
        Einar,
        Ullar,
        Vydar,
        Aquilla,
        Valkrill,
        Revna,
        Volarak
    }

    internal class Card
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private cardGeneral general;
        public cardGeneral General
        {
            get { return general; }
            set { general = value; }
        }

        private string species;
        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        private string cardClass;
        public string CardClass
        {
            get { return cardClass; }
            set { cardClass = value; }
        }

        private string personality;
        public string Personality
        {
            get { return personality; }
            set { personality = value; }
        }

        private cardType sizeType;
        public cardType SizeType
        {
            get { return sizeType; }
            set { sizeType = value; }
        }

        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        private int cost;
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        private LinkedList<Card> synergiesGiven = new LinkedList<Card>();
        private LinkedList<Card> synergiesReceived = new LinkedList<Card>();

        public Card(string name, cardGeneral general, string species, string cardClass, string personality, cardType sizeType, int size, int cost)
        {
            this.name = name;
            this.general = general;
            this.species = species;
            this.cardClass = cardClass;
            this.personality = personality;
            this.sizeType = sizeType;
            this.size = size;
            this.cost = cost;
        }

        //Methods to add synergies to a card

        /// <summary>
        /// Adds a synergy recieved to the card's list
        /// </summary>
        /// <param name="card"></param>
        /// <returns>
        /// Returns true if the synergy is not yet present in the card list
        /// </returns>
        public bool addSynergyReceived(Card card)
        {
            if (synergiesReceived.Contains(card))
                return false;
            synergiesReceived.AddFirst(card);
            return true;

        }

        /// <summary>
        /// Adds a synergy given to the card's list
        /// </summary>
        /// <param name="card"></param>
        /// <returns>
        /// Returns true if the synergy is not yet present in the card list
        /// </returns>
        public bool addSynergyGiven(Card card)
        {
            if (synergiesGiven.Contains(card))
                return false;
            synergiesGiven.AddFirst(card);
            return true;

        }
    }
}
