using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2
{
    class Phones
    {
        public List<MobilePhone> mobilePhones = new List<MobilePhone>();
        public List<PhoneModify> phonesModifie = new List<PhoneModify>();


        public void AddMobilePhone(MobilePhone mobilePhone, PhoneModify phoneModifie)
        {
            if (phoneModifie == null) 
                mobilePhones.Add(mobilePhone);
            if (mobilePhone == null)
                phonesModifie.Add(phoneModifie);
        }

        public string[] PrintInfo()
        {
            string[] inf = new string[mobilePhones.Count + phonesModifie.Count];

            if (mobilePhones == null && phonesModifie == null)
                return null;

            for (int i = 0; i < mobilePhones.Count; i++)
            {
                string quality = Convert.ToString(mobilePhones[i].Quality());
                inf[i] = Convert.ToString(i + 1) + ") " + mobilePhones[i].Mark + "   " + mobilePhones[i].Model + "; Цена - " + Convert.ToString(mobilePhones[i].Price) + "руб.  " + "Память - " + Convert.ToString(mobilePhones[i].Memory) + "Гб  " + "Качество = " + quality;
                inf[i] += Environment.NewLine;
            }

            for (int i = mobilePhones.Count, j = 0; i < inf.Length; i++, j++)
            {
                string quality = Convert.ToString(phonesModifie[j].Quality());
                inf[i] = Convert.ToString(i + 1) + ") " + phonesModifie[j].Mark + "   " + phonesModifie[j].Model + "; Цена - " + Convert.ToString(phonesModifie[j].Price) + "руб.  " + "Память - " + Convert.ToString(phonesModifie[j].Memory) + "Гб  " + "Кол-во симкарт - " + Convert.ToString(phonesModifie[j].CountSIM) + "  Качество = " + quality;
                inf[i] += Environment.NewLine;
            }

            return inf;
        }
    }
}
