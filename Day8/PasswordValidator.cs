﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Day8
{
    class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            if (password.Length >= 8)
            {
                bool isDigits = password.Any(symb => char.IsDigit(symb));
                bool isLetters = password.Any(symb => char.IsLetter(symb));

                return isLetters && isDigits;

                /*bool isDigits = false;
                bool isLetters = false;
                foreach (char symbol in password)
                {
                    if (char.IsLetter(symbol))
                    {
                        isLetters = true;
                    }
                    else if (char.IsDigit(symbol))
                    {
                        isDigits = true;
                    }
                    if (isLetters && isDigits)
                    {
                        return true;
                    }
                }*/
            }
            return false;
        }
    }
}
