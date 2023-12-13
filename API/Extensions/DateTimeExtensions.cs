using System;

namespace API.Extensions
{
    /// <summary>
    /// Extends the DateTime class with a CalculateAge method to get a person's age in years based on their birth date.
    /// </summary>
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime birthDate)
        {
            if (birthDate == DateTime.MinValue)
                throw new ArgumentException("Invalid date of birth");

            TimeSpan ageSpan = DateTime.Today - birthDate;
            int age = ageSpan.Days / 365;
            if (ageSpan.Days % 365 > 0)
            {
                age++;
            }

            return age;
        }
    }
}