namespace Class_library
{
    public class Date
    {
        #region Atributos

        private int _year;  // atributos
        private int _month;
        private int _day;

        #endregion Atributos

        #region Constructores

        public Date()  // constructores
        {
            _year = 1900;
            _month = 1;
            _day = 1;
        }

        public Date(int year, int month, int day)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day);
        }

        #endregion Constructores

        #region Propiedades

        public int Year { get => _year; set => _year = ValidateYear(value); } //propiedades
        public int Mont { get => _month; set => _month = ValidateMonth(value); }
        public int Day { get => _day; set => _day = ValidateDay(value); }

        #endregion Propiedades

        // metodos
        public override string ToString()
        {
            return $"{Year,4:0000}/{Mont,2:00}/{Day,2:00}";
        }

        private int ValidateYear(int year)
        {
            if (year < 0)
            {
                throw new ArgumentException("El año no es invalido");
            }
            return year;
        }

        private int ValidateMonth(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentException("El mes no es invalido");
            }
            return month;
        }

        private int ValidateDay(int day)
        {
            if (day == 29 && _month == 2 && DateUtilities.IsLeapYear(_year))
            {
                return day;
            }

            if ((day >= 1 && day <= 28 && _month == 2) ||
                (day >= 1 && day <= 30 && (_month == 4 || _month == 6 || _month == 9 || _month == 11)) ||
                (day >= 1 && day <= 31 && (_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 10 || _month == 12)))
            {
                return day;
            }
            throw new ArgumentException("El dia no es invalido");
        }
    }
}