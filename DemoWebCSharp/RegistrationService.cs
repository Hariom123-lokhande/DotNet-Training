using System;

namespace DemoWebCSharp
{
    public class RegistrationService
    {
        public int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;

            if (DateTime.Now.DayOfYear < dob.DayOfYear)
            {
                age--;
            }

            return age;
        }

        public string GenerateSummary(string firstName, string lastName,
                                      string email, string gender,
                                      int age, bool isVaccinated)
        {
            return "<div class='mt-3 p-3 border rounded bg-light'>" +
                   "<h5 class='text-success'>Registration Successful!</h5>" +
                   "<p><b>Name:</b> " + firstName + " " + lastName + "</p>" +
                   "<p><b>Gender:</b> " + gender + "</p>" +
                   "<p><b>Email:</b> " + email + "</p>" +
                   "<p><b>Age:</b> " + age + "</p>" +
                   "<p><b>Vaccinated:</b> " + (isVaccinated ? "Yes" : "No") + "</p>" +
                   "</div>";
        }
    }
}
