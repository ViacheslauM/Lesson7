namespace Lesson6
{
    class PassportChecker
    {
        public bool CheckPassportNumber(string passportNumber)
        {
            var result = false;
            foreach (var letter in passportNumber)
            {
                if (letter == '1') //check Employees with the "1" letter in passport
                {
                    result = true;
                    break;
                }
            }
           
            return result;
        }

    }
}
