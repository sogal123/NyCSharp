namespace DataAccessLayer
{
    public class Validator
    {
        public static void TommaTextFält(string fältNamn, string fältVärde)
        {
            if (string.IsNullOrEmpty(fältVärde))
            {
                throw new ValidatorException(fältNamn, " Textfälten måste fyllas i.");
            }
        }

        public static void TommaCbs(string cbNamn, object cbVärde)
        {

            if (cbVärde == null)
            {
                throw new ValidatorException(cbNamn, " Vänligen fyll i samtliga rullgardinsmenyer");
            }
        }
    }
}