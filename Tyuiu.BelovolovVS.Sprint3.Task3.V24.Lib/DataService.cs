using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BelovolovVS.Sprint3.Task3.V24.Lib
{
    public class DataService : ISprint3Task3V24
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    result.Append(replacement);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}