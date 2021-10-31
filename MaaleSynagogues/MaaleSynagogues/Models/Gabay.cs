using System;

namespace MaaleSynagogues.Models
{
    public class Gabay
    {
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }


        private String phoneNumber;
        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        public Gabay(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }   
    }
}