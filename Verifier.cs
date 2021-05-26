using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectII
{
    class Verifier
    {
        #region Verificare CNP
        public  bool CheckNIN(string NIN)
        {
            int a;

            if (int.TryParse(NIN, out a) || NIN.Length != 13)
            {
                return false;
            }
            else
            {
                int[] NINArray = IntToArray(NIN);

                if (CheckSex(NINArray[0]) && CheckBirthYear(BindTwoNumbers(NINArray[1], NINArray[2])) && CheckMonth(BindTwoNumbers(NINArray[3], NINArray[4])) && CheckDay(BindTwoNumbers(NINArray[5], NINArray[6])) && CheckCounty(BindTwoNumbers(NINArray[7], NINArray[8])) && CheckOrderNumber(BindThreeNumbers(NINArray[9], NINArray[10], NINArray[11])) && CheckControlNumber(NINArray[12]))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        public int[] IntToArray(string CNP)
        {
            char[] CharCNP = CNP.ToCharArray();
            int[] NIN = new int[13];

            for (int i = 0; i < CharCNP.Length; i++)
            {
                NIN[i] = CharCNP[i] - '0';
            }

            return NIN;
        }
        public bool CheckSex(int num)
        {
            if (num == 1 || num == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int BindTwoNumbers(int num1, int num2)
        {
            return num1 * 10 + num2;
        }
        public bool CheckBirthYear(int num)
        {
            if (num > 50 && num < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckMonth(int num)
        {
            if (num >= 1 && num < 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckDay(int num)
        {
            if (num >= 1 && num <= 31)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckCounty(int num)
        {
            if (num >= 1 && num < 53)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int BindThreeNumbers(int num1, int num2, int num3)
        {
            return num1 * 100 + num2 * 10 + num3;
        }

        public bool CheckOrderNumber(int num)
        {
            if (num >= 1 && num < 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckControlNumber(int num)
        {
            if (num >= 1 && num < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        #region Verificare Nume/Prenume       
        public bool CheckName(string Name)
        {
            string specialChar = @"\|!#$%&/^*[]()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (Name.Contains(item))
                {
                    return false;
                }
            }

            char[] ArrayName = Name.ToCharArray();
            if (Char.IsDigit(ArrayName[0]) || Char.IsLower(ArrayName[0]))
            {
                return false;
            }
            else
            {
                for (int i = 1; i < ArrayName.Length; i++)
                {
                    if (Char.IsDigit(ArrayName[i]) || Char.IsUpper(ArrayName[i]))
                    {
                        return false;
                    }
                }
            }
            return true;

        }
        #endregion

        #region Verificare Numar de Telefon Mobil
        public bool CheckPhoneNumber(string PhoneNr)
        {
            if (PhoneNr.Length != 9)
            {
                return false;
            }
            if (PhoneNr.Substring(0, 1) != "7")
            {
                return false;
            }
            foreach (var item in PhoneNr)
            {
                if (!Char.IsDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Verifica Varsta
        public bool CheckAge(string Age)
        {
            if (Age.Length != 2)
            {
                return false;
            }

            foreach (var item in Age)
            {
                if (!Char.IsDigit(item))
                {
                    return false;
                }
            }
            if (Age.Substring(0, 1) == "0")
            {
                return false;
            }

            int age = Int32.Parse(Age);
            if (age < 18 || age > 70)
            {
                return false;
            }

            return true;
        }
        #endregion
    }
}
