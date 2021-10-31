using System;
using System.Collections.Generic;
using System.Text;

namespace MaaleSynagogues.Models
{
    public class Synagogue
    {
        private int synagogueID;
        public int SynagogueID
        {
            get { return synagogueID; }
            set { synagogueID = value; }
        }

        private String address;
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String paryFormula;
        public String ParyFormula
        {
            get { return paryFormula; }
            set { paryFormula = value; }
        }

        private Pray[] praysArray;
        public Pray[] PraysArray
        {
            get { return praysArray; }
            set { praysArray = value; }
        }

        private Gabay gabay;
        public Gabay Gabay
        {
            get { return gabay; }
            set { gabay = value; }
        }

        public Synagogue(int synagogueID, string address, string name, string paryFormula, Pray[] praysArray, Gabay gabay)
        {
            this.synagogueID = synagogueID;
            this.address = address;
            this.name = name;
            this.paryFormula = paryFormula;
            this.praysArray = praysArray;
            this.gabay = gabay;
        }
    }
}
