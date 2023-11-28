using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Quirks
{
    public static class StringExtensions
    {
        public static bool AreEqual(this string input1, string input2) => string.Equals(input1, input2, StringComparison.InvariantCultureIgnoreCase);
        public static bool AreNotEqual(this string input1, string input2) => !AreEqual(input1, input2);

        public static bool AreTrimEqual(this string input1, string input2) => string.Equals(input1?.Trim(), input2?.Trim(), StringComparison.InvariantCultureIgnoreCase);
        public static bool AreNotTrimEqual(this string input1, string input2) => !AreTrimEqual(input1, input2);

        public static bool IsNull(this string input) => null == input;
        public static bool IsNotNull(this string input) => !IsNull(input);

        public static bool IsNullOrEmpty(this string input) => string.IsNullOrEmpty(input);
        public static bool IsNotNullOrEmpty(this string input) => !IsNullOrEmpty(input);

        public static bool IsNullOrWhiteSpace(this string input) => string.IsNullOrWhiteSpace(input);
        public static bool IsNotNullOrWhiteSpace(this string input) => !IsNullOrWhiteSpace(input);

        public static string Trim(this string input) => input.Trim();
        public static string TrimStart(this string input) => input.TrimStart();
        public static string TrimEnd(this string input) => input.TrimEnd();

        public static string ToUpper(this string input) => input.ToUpper();
        public static string ToLower(this string input) => input.ToLower();

        public static string ToTitleCase(this string input) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);

        public static int ToInt(this string value, int defaultValue = 0)
        {
            int.TryParse(value, out defaultValue);
            return defaultValue;
        }
        public static long ToLong(this string value, long defaultValue = 0)
        {
            long.TryParse(value, out defaultValue);
            return defaultValue;
        }
        public static float ToFloat(this string value, float defaultValue = 0)
        {
            float.TryParse(value, out defaultValue);
            return defaultValue;
        }
        public static double ToDouble(this string value, double defaultValue = 0)
        {
            double.TryParse(value, out defaultValue);
            return defaultValue;
        }

        public static int ToHexDec(this string hexString) => Mathq.HexDec(hexString);

        /// <summary>Find the position of the searchString inside the masterString.</summary>
        public static int FindStringPositionWithinString(this string masterString, string searchString)
        {
            return IsNull(masterString) || IsNull(searchString)
                ? -1 
                : masterString.IndexOf(searchString, StringComparison.Ordinal);
        }

        /// <summary>Replaces the badString with goodString inside the masterString.</summary>
        public static string ReplaceString(this string masterString, string goodString, string badString) => IsNullOrEmpty(masterString) ? masterString : masterString.Replace(badString, goodString);

        /// <summary>Replaces the first occurrence of a specified substring with another string.</summary>
        public static string ReplaceFirstOccurrence(this string input, string oldValue, string newValue)
        {
            int startIndex = input.IndexOf(oldValue);
            if (startIndex == -1)
                return input;

            return input.Remove(startIndex, oldValue.Length).Insert(startIndex, newValue);
        }

        /// <summary>Reverse the string [World -> dlroW]</summary>
        public static string Reverse(this string input)
        {
            StringBuilder ret = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                ret.Append(input.Substring(i, 1));
            }
            return ret.ToString();
        }

        /// <summary>Capitalize the string [hey there -> Hey there]</summary>
        public static string Capitalize(this string input)
        {
            if (input.Length == 0) return string.Empty;
            if (input.Length == 1) return input.ToUpper();

            return input.Substring(0, 1).ToUpper() + input.Substring(1);
        }

        /// <summary>Checks if the input string starts capitalized.</summary>
        public static bool IsCapitalized(this string input)
        {
            if (input.Length == 0) return false;
            return string.CompareOrdinal(input.Substring(0, 1), input.Substring(0, 1).ToUpper()) == 0;
        }

        /// <summary>Checks if the input input string is fully upper case.</summary>
        public static bool IsUpperCase(this string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (string.CompareOrdinal(input.Substring(i, 1), input.Substring(i, 1).ToUpper()) != 0)
                    return false;
            }
            return true;
        }

        /// <summary>Checks if the input string is fully lower case.</summary>
        public static bool IsLowerCase(this string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (string.CompareOrdinal(input.Substring(i, 1), input.Substring(i, 1).ToLower()) != 0)
                    return false;
            }
            return true;
        }

        /// <summary>Returns the total count of chars found in the input string.</summary>
        public static int CountTotal(this string input, string chars, bool ignoreCases)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!(i + chars.Length > input.Length) &&
                    string.Compare(input.Substring(i, chars.Length), chars, ignoreCases) == 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>Checks if the input string contains vowels.</summary>
        public static bool HasVowels(this string input, bool ignoreY = true)
        {
            string currentLetter;
            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input.Substring(i, 1);
                if (ignoreY)
                {
                    if (string.Compare(currentLetter, "a", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "e", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "i", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "o", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "u", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        return true;
                    }
                }
                else
                {
                    if (string.Compare(currentLetter, "a", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "e", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "i", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "o", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "u", StringComparison.OrdinalIgnoreCase) == 0 ||
                        string.Compare(currentLetter, "y", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>Checks if the input string is only made of spaces.</summary>
        public static bool IsSpaces(this string input)
        {
            if (input.Length == 0) return false;
            return input.Replace(" ", "").Length == 0;
        }

        /// <summary>Checks if the input string is only made of the same letter or number.</summary>
        public static bool IsRepeatedChar(this string input)
        {
            if (input.Length == 0) return false;
            return input.Replace(input.Substring(0, 1), "").Length == 0;
        }

        /// <summary>Checks if the input string is only made of numbers.</summary>
        public static bool IsNumeric(this string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!(Convert.ToInt32(input[i]) >= 48 && Convert.ToInt32(input[i]) <= 57))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>Checks if the input string contains numbers.</summary>
        public static bool HasNumbers(this string input) => Regex.IsMatch(input, "\\d+");

        /// <summary>Checks if the input string is only made of letters and numbers.</summary>
        public static bool IsAlphaNumeric(this string input)
        {
            char currentLetter;
            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input[i];

                if (!(Convert.ToInt32(currentLetter) >= 48 && Convert.ToInt32(currentLetter) <= 57) &&
                    !(Convert.ToInt32(currentLetter) >= 65 && Convert.ToInt32(currentLetter) <= 90) &&
                    !(Convert.ToInt32(currentLetter) >= 97 && Convert.ToInt32(currentLetter) <= 122))
                {
                    // Not a number or a letter
                    return false;
                }
            }
            return true;
        }

        /// <summary>Checks if the input string is only made of letters.</summary>
        public static bool IsLetters(this string input)
        {
            char currentLetter;
            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input[i];

                if (!(Convert.ToInt32(currentLetter) >= 65 && Convert.ToInt32(currentLetter) <= 90) &&
                    !(Convert.ToInt32(currentLetter) >= 97 && Convert.ToInt32(currentLetter) <= 122))
                {
                    // Not a letter
                    return false;
                }
            }
            return true;
        }

        /// <summary>Checks if the input string contains spaces.</summary>
        public static bool HasSpaces(this string input) => input.Contains(" ");

        /// <summary>Removes all spaces from the input string.</summary>
        public static string RemoveWhitespaces(this string input) => new string(input.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());

        /// <summary>Truncates the input to a specified length and adds an ellipsis at the end if the string was to long.</summary>
        public static string Truncate(this string input, int maxLength)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input.Length <= maxLength ? input : input.Substring(0, maxLength) + "...";
        }

        /// <summary>Checks if the input is a valid Email address.</summary>
        public static bool IsEmail(this string input)
        {
            if (input.IsNullOrWhiteSpace())
                return false;

            if (input.HasSpaces())
                return false;

            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(input);
        }

        #region Split

        public static string[] SplitInPartsArray(this string input, int partLength = 2)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (partLength <= 0)
            {
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));
            }

            string[] temp = new string[input.Length / partLength];
            int c = 0;

            for (int i = 0; i < input.Length; i += partLength)
            {
                temp[c] = input.Substring(i, Math.Min(partLength, input.Length - i));
                c++;
            }

            return temp;
        }

        public static IEnumerable<string> SplitInParts(this string input, int partLength)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (partLength <= 0)
            {
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));
            }

            for (int i = 0; i < input.Length; i += partLength)
            {
                yield return input.Substring(i, Math.Min(partLength, input.Length - i));
            }
        }

        // Alloc Free Method
        public static IEnumerable<ReadOnlyMemory<char>> SplitInPartsFree(this string input, int partLength)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (partLength <= 0)
            {
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));
            }

            for (int i = 0; i < input.Length; i += partLength)
            {
                yield return input.AsMemory().Slice(i, Math.Min(partLength, input.Length - i));
            }
        }

        #endregion

        static Regex lastNountRegEx = new Regex(@"([A-Z][a-z]*)");
        public static string ParseLastNoun(string text)
        {
            MatchCollection matches = lastNountRegEx.Matches(text);
            return matches.Count > 0 ? matches[matches.Count - 1].Value : "";
        }

        #region StableHash

        // Uses fnv1a as hash function for more uniform distribution http://www.isthe.com/chongo/tech/comp/fnv/

        const uint hash32 = 0x811c9dc5;
        const uint prime32 = 0x1000193;
        const ulong hash64 = 0xcbf29ce484222325;
        const ulong prime64 = 0x00000100000001B3;

        public static ushort GetStableHashU16(this string text)
        {
            uint hash32 = GetStableHashU32(text);

            return (ushort)((hash32 >> 16) ^ hash32);
        }

        public static int GetStableHash(this string text)
        {
            unchecked
            {
                uint hash = hash32;

                for (int i = 0; i < text.Length; ++i)
                {
                    byte value = (byte)text[i];
                    hash *= prime32;
                    hash = hash ^ value;
                }

                return (int)hash;
            }
        }

        public static uint GetStableHashU32(this string text)
        {
            unchecked
            {
                uint hash = hash32;

                for (int i = 0; i < text.Length; ++i)
                {
                    uint value = text[i];
                    hash *= prime32;
                    hash = hash ^ value;
                }

                return hash;
            }
        }

        public static ulong GetStableHashU64(this string text)
        {
            unchecked
            {
                ulong hash = hash64;

                for (int i = 0; i < text.Length; ++i)
                {
                    ulong value = text[i];
                    hash *= prime64;
                    hash = hash ^ value;
                }

                return hash;
            }
        }

        #endregion
    }
}
