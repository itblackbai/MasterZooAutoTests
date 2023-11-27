
namespace MasterZooAutoTests.TestData
{
    public class RegistrationTestData
    {
        // Possitive
        public string PossitiveFullName { get; set; } = "Test Data";
        public string PossitiveEmail { get; set; } = GenerateRandomValidEmail();
        public string PossitiveEmailForEightSymbol { get; set; } = GenerateRandomValidEmail();
        public string PossitiveEmailForFifteenSymbol { get; set; } = GenerateRandomValidEmail();
        public string PossitivePassword { get; set; } = "masterzoo12345";
        public string ProfileUrl { get; set; } = "https://masterzoo.ua/ua/profile/";

        public string PasswordEight { get; set; } = "11111111";
        public string PasswordFifteen { get; set; } = "111111111111111";



        //Negative

        public string PossitiveEmailForCheckPassError = GenerateRandomValidEmail();
        public string FullNameWithNumbers = "12412 1654";
        public string ErrorMessegeWithFullNameByNumber = "Значение введено некорректно";
        public string FullNameWithSymbols = " %^!*& &*@^*";
        public string ErrorMessegeWithFullNameBySymbol = "Используются недопустимые символы";

        public string ErrorMessegeWithEmptyName = "Вкажіть ім'я";

        public string EmptyEmail = "";
        public string ErrorMessegeWithEmptyEmail = "Некоректна адреса електронної пошти";
        public string ErrorMessegeWithThePassword = "Пароль має бути не менше 8 і не більше 15 символів.";


        public string PasswordLessEight { get; set; } = "1111111";
        public string PasswordMoreTheFifteen { get; set; } = "1111111111111111";

        public string RegistredEmail = "m1asterzootestdata@gmail.com";
        public string NegativeEmailWithOutPoint = "masterzootestdata@gmailcom";
        public string NegativeEmailWithSymbols = "&!&*&@gmail.com";


        public string ErrorMassegeWithTheSameEmail = "Упс! Користувач з такою адресою вже зареєстрований. " +
            "Якщо це ви, будь ласка, зайдіть в свій особистий кабінет або відновіть пароль на сторінці входу.";


        public string ErrorMessegeOnLoginPage = "Невірний логін або пароль. " +
            "Якщо вам потрібно нагадати пароль, скористайтеся функцією відновлення паролю.";


        public string recoverMessege = "На вашу електронну пошту надіслано посилання для відновлення паролю";

        public string recoverMessegeWithUnvalidData = "Немає користувача з такою адресою е-пошти";

        private static string GenerateRandomValidEmail()
        {
            Random random = new Random();
            string login = GenerateRandomString(8);
            string email = $"{login}@gmail.com";
            return email;
        }

        private static string GenerateRandomString(int length)
        {
            Random random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}



