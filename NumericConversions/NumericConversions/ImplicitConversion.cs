using System;

namespace NumericConversions
{
    public static class ImplicitConversion
    {
        public static long IntToLong(int intValue)
        {
            return (long)intValue;
        }

        // TODO #1: Add a static method here with name "IntToFloat" that gets "intValue" parameter ("int" type) and returns the parameter value that is implicitly converted to "float" type.
        public static float IntToFloat(int intValue)
        {
            return (float)intValue;
        }

        // TODO #2: Add a static method here with name "IntToDouble" that gets "intValue" parameter ("int" type) and returns the parameter value that is implicitly converted to "double" type.
        public static double IntToDouble(int intValue)
        {
            return (double)intValue;
        }

        // TODO #3: Add a static method here with name "IntToDecimal" that gets "intValue" parameter ("int" type) and returns the parameter value that is implicitly converted to "decimal" type.
        public static decimal IntToDecimal(int intValue)
        {
            return (decimal)intValue;
        }

        // TODO #4: Add a static method here with name "LongToFloat" that gets "longValue" parameter ("long" type) and returns the parameter value that is implicitly converted to "float" type.
        public static float LongToFloat(long longValue)
        {
            return (float)longValue;
        }

        // TODO #5: Add a static method here with name "LongToDouble" that gets "longValue" parameter ("long" type) and returns the parameter value that is implicitly converted to "double" type.
        public static double LongToDouble(long longValue)
        {
            return (double)longValue;
        }

        // TODO #6: Add a static method here with name "LongToDecimal" that gets "longValue" parameter ("long" type) and returns the parameter value that is implicitly converted to "decimal" type.
        public static decimal LongToDecimal(long longValue)
        {
            return (decimal)longValue;
        }

        // TODO #7: Add a static method here with name "ByteToShort" that gets "byteValue" parameter ("byte" type) and returns the parameter value that is implicitly converted to "short" type.
        public static short ByteToShort(byte byteValue)
        {
            return (short)byteValue;
        }

        // TODO #8: Add a static method here with name "ByteToInt" that gets "byteValue" parameter ("byte" type) and returns the parameter value that is implicitly converted to "int" type.
        public static int ByteToInt(byte byteValue)
        {
            return (int)byteValue;
        }
    }
}
