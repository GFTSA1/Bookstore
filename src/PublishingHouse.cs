using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    class PublishingHouse // видавництво
    {
        public String Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("Ви не вказали назву видавництва.");
                else Name = value;
            }
        }

        public String Сountry
        {
            get
            {
                return Сountry;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("Ви не країну видавництва.");
                else Сountry = value;
            }
        }

        public PublishingHouse(String name, String country)
        {
            this.Name = name;
            this.Сountry = country;
        }
    }
}
