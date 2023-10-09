using System.IO;

namespace CreatingMethods
{
    public static class MethodsWithRefParameters
    {
        public static bool ReturnParameterValueAndSetParameterToDefaultValue(ref bool boolValue)
        {
            bool value = boolValue;
            boolValue = default(bool);
            return value;
        }

        // TODO #17. Add a static method here with name "ReturnParameterValueAndSetParameterToDefaultValue"
        // that gets "charValue" parameter ("char" type) with ref keyword. The method should return value of "charValue"
        // parameter and set the "charValue" parameter to default value (use "default" operator).
        public static char ReturnParameterValueAndSetParameterToDefaultValue(ref char charValue)
        {
            char defaultValue = default;
            char returnValue = charValue;
            charValue = defaultValue;
            return returnValue;
        }

        // TODO #18. Add a static method here with name "ReturnParameterValueAndSetParameterToDefaultValue"
        // that gets "floatValue" parameter ("float" type) with ref keyword. The method should return value of
        // "floatValue" parameter and set the "floatValue" parameter to default value (use "default" operator).
        public static float ReturnParameterValueAndSetParameterToDefaultValue(ref float floatValue)
        {
            float defaultValue = default;
            float returnValue = floatValue;
            floatValue = defaultValue;
            return returnValue;
        }

        // TODO #19. Add a static method here with name "ReturnParameterValueAndSetParameterToDefaultValue" that gets
        // "intValue" parameter ("int" type) with ref keyword. The method should return value of "intValue" parameter and
        // set the "intValue" parameter to default value (use "default" operator).
        public static int ReturnParameterValueAndSetParameterToDefaultValue(ref int intValue)
        {
            int defaultValue = default;
            int returnValue = intValue;
            intValue = defaultValue;
            return returnValue;
        }

        // TODO #20. Add a static method here with name "ReturnParameterValueAndSetParameterToDefaultValue"
        // that gets "longValue" parameter ("long" type) with ref keyword. The method should return value of
        // "longValue" parameter and set the "longValue" parameter to default value (use "default" operator).
        public static long ReturnParameterValueAndSetParameterToDefaultValue(ref long longValue)
        {
            long defaultValue = default;
            long returnValue = longValue;
            longValue = defaultValue;
            return returnValue;
        }
    }
}
