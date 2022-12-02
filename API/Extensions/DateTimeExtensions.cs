namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CaculateAge(this DateTime date)
        {
            var today = DateTime.Today;
            var age = today.Year - date.Year;
            if (date.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}
