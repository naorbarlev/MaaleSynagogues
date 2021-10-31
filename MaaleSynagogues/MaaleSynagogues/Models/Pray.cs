using System;


namespace MaaleSynagogues.Models
{
    public class Pray
    {

        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String prayHour;
        public String PrayHour
        {
            get { return prayHour; }
            set { prayHour = value; }
        }

        public Pray(string name, string prayHour)
        {
            this.name = name;
            this.prayHour = prayHour;
        }

    }
}
