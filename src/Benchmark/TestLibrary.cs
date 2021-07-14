using System;
using EncTypes;
using Benchmark.OldTypes;

static public class TestLibrary
{
    /// A test is a while-loop.
    /// A test performs a certain amout of changes to a variable.
    /// There's a while-loop for each variable type you can compare.

    #region Int/Long Tests

    public static void WL_Int(int amount)
    {
        int number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncInt(int amount)
    {
        EncInt number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncInt_0_3_0(int amount)
    {
        EncInt_0_3_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncInt_0_7_0(int amount)
    {
        EncInt_0_7_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncInt_0_8_0(int amount)
    {
        EncInt_0_8_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncInt_0_9_0(int amount)
    {
        EncInt_0_9_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncInt_1_1_0(int amount)
    {
        EncInt_1_1_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_Long(int amount)
    {
        long number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncLong(int amount)
    {
        EncLong number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncLong_0_3_0(int amount)
    {
        EncLong_0_3_0 number1 = 0;
        while (number1 < (long)amount)
        {
            number1++;
        }
    }

    public static void WL_EncLong_0_7_0(int amount)
    {
        EncLong_0_7_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncLong_0_8_0(int amount)
    {
        EncLong_0_8_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncLong_0_9_0(int amount)
    {
        EncLong_0_9_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncLong_1_1_0(int amount)
    {
        EncLong_1_1_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    #endregion

    #region Float/Double/Decimal Tests

    public static void WL_Float(int amount)
    {
        float number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncFloat(int amount)
    {
        EncFloat number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncFloat_0_5_0(int amount)
    {
        EncFloat_0_5_0 number1 = 0;
        while (number1 < (float)amount)
        {
            number1++;
        }
    }

    public static void WL_EncFloat_0_8_0(int amount)
    {
        EncFloat_0_8_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncFloat_0_9_0(int amount)
    {
        EncFloat_0_9_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_Double(int amount)
    {
        double number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }
    
    public static void WL_EncDouble(int amount)
    {
        EncDouble number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncDouble_0_5_0(int amount)
    {
        EncDouble_0_5_0 number1 = 0;
        while (number1 < (double)amount)
        {
            number1++;
        }
    }

    public static void WL_EncDouble_0_8_0(int amount)
    {
        EncDouble_0_8_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncDouble_0_9_0(int amount)
    {
        EncDouble_0_9_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_Decimal(int amount)
    {
        decimal number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncDecimal(int amount)
    {
        EncDecimal number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncDecimal_0_5_0(int amount)
    {
        EncDecimal_0_5_0 number1 = 0;
        while (number1 < (decimal)amount)
        {
            number1++;
        }
    }

    public static void WL_EncDecimal_0_8_0(int amount)
    {
        EncDecimal_0_8_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    public static void WL_EncDecimal_0_9_0(int amount)
    {
        EncDecimal_0_9_0 number1 = 0;
        while (number1 < amount)
        {
            number1++;
        }
    }

    #endregion

    #region String Tests

    public static void WL_String(int amount)
    {
        string stringVar = RandomString();
        int currentPos = 0;
        int timesIncremented = 0;
        while (timesIncremented < amount)
        {
            timesIncremented++;
            stringVar = StringReplaceAt(stringVar, currentPos, RandomCharNormal());
            currentPos++;
            if (currentPos >= stringVar.Length)
            {
                currentPos = 0;
            }
        }
    }

    public static void WL_EncString(int amount)
    {
        EncString stringVar = RandomString();
        int currentPos = 0;
        int timesIncremented = 0;
        while (timesIncremented < amount)
        {
            timesIncremented++;
            stringVar = StringReplaceAt(stringVar, currentPos, RandomCharNormal());
            currentPos++;
            if (currentPos >= stringVar.Length)
            {
                currentPos = 0;
            }
        }
    }

    public static void WL_EncString_0_5_0(int amount)
    {
        EncString_0_5_0 stringVar = RandomString();
        int currentPos = 0;
        int timesIncremented = 0;
        while (timesIncremented < amount)
        {
            timesIncremented++;
            stringVar = StringReplaceAt(stringVar, currentPos, RandomCharNormal());
            currentPos++;
            if (currentPos >= stringVar.Length)
            {
                currentPos = 0;
            }
        }
    }

    public static void WL_EncString_0_7_0(int amount)
    {
        EncString_0_7_0 stringVar = RandomString();
        int currentPos = 0;
        int timesIncremented = 0;
        while (timesIncremented < amount)
        {
            timesIncremented++;
            stringVar = StringReplaceAt(stringVar, currentPos, RandomCharNormal());
            currentPos++;
            if (currentPos >= stringVar.Length)
            {
                currentPos = 0;
            }
        }
    }

    public static void WL_EncString_0_8_0(int amount)
    {
        EncString_0_8_0 stringVar = RandomString();
        int currentPos = 0;
        int timesIncremented = 0;
        while (timesIncremented < amount)
        {
            timesIncremented++;
            stringVar = StringReplaceAt(stringVar, currentPos, RandomCharNormal());
            currentPos++;
            if (currentPos >= stringVar.Length)
            {
                currentPos = 0;
            }
        }
    }

    public static void WL_EncString_0_9_0(int amount)
    {
        EncString_0_9_0 stringVar = RandomString();
        int currentPos = 0;
        int timesIncremented = 0;
        while (timesIncremented < amount)
        {
            timesIncremented++;
            stringVar = StringReplaceAt(stringVar, currentPos, RandomCharNormal());
            currentPos++;
            if (currentPos >= stringVar.Length)
            {
                currentPos = 0;
            }
        }
    }

    public static void WL_EncString_1_1_0(int amount)
    {
        EncString_1_1_0 stringVar = RandomString();
        int currentPos = 0;
        int timesIncremented = 0;
        while (timesIncremented < amount)
        {
            timesIncremented++;
            stringVar = StringReplaceAt(stringVar, currentPos, RandomCharNormal());
            currentPos++;
            if (currentPos >= stringVar.Length)
            {
                currentPos = 0;
            }
        }
    }

    #endregion

    #region Utils For Class

    static Random random = new Random();

    public static char RandomChar(int min = char.MinValue, int max = (char.MaxValue - 1))
    {
        return (char)(random.Next(min, max));
    }

    public static char RandomCharNormal() => RandomChar(48, 125);

    public static string RandomString()
    {
        char[] chars = new char[25];
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = RandomCharNormal();
        }
        return new string(chars);
    }

    public static string StringReplaceAt(string input, int index, char newChar)
    {
        if (input != null)
        {
            char[] chars = input.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }
        else return null;
    }

    #endregion
}
