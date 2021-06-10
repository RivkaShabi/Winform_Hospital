using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class validation
    {
        public static bool CheckID(string id)
        {
            if (id.Length < 9)
            {
                for (int i = 1; i <= 9; i++)
                    id += "0";
            }
            int sum = 0;
            int temp = 0;
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                    sum += Convert.ToInt32(id[i].ToString());
                else
                {
                    temp = Convert.ToInt32(id[i].ToString()) * 2;
                    if (temp > 9)
                        temp = temp % 10 + temp / 10;
                    sum += temp;
                }

            }
            if (sum % 10 == 0)
                return true;
            return false;
        }
        public static bool CheckCell(string cell)
        {
            string st = @"\b05[0 2 3 4 5 7 8 ]-[2-9]\d{6}$";
            Regex m = new Regex(st);
            return m.IsMatch(cell);
        }
        public static bool CheckPhone(string ph)
        {
            string p = @"\b0[77 72 73 79 2 3 4 8 9]-[2-9]\d{7}$";
            Regex m = new Regex(p);
            return m.IsMatch(ph);
        }
        public static bool CheckMail(string e)
        {
            string mail = @"\b[A-Z a-z - _ 0-9]@[A-Z a-z 0-9]\.[A-Z a-z]$";
            //return Regex.Match(e, @"^[A-Z a-z 0-9 _ -] +@[a-z A-Z 0-9]+\.[a-z A-Z]+$").Success;
            Regex m = new Regex(mail);
            return m.IsMatch(e);
        }


    }
}

    }
}
