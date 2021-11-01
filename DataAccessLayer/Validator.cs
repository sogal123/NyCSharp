using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class Validator
    {
        //public static void TommaTextFält (string fältNamn, string fältVärde) 
        //{
        //if (string.IsNullOrEmpty(fältVärde))
        //    {
        //        throw new ValidatorException(fältNamn, "-fältet måste fyllas i.");
        //    }
        //}

        public static void TommaCbs(string cbNamn, string cbVärde)
        {
            
            if (string.IsNullOrEmpty(cbVärde))
            {
                throw new ValidatorException(cbNamn, " måste fyllas i.");
            }
        }
        public static bool FörKortInput(string tbNamn, string tbVärde)
        {
            bool inputBool = false;
                if (input.Length)
                return input.Length > 3;

                throw new ValidatorException(cbNamn, " måste fyllas i.");

        }

    }
}