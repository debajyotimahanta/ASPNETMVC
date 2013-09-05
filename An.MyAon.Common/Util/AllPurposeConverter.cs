using System;

namespace An.MyAon.Common.Util
{
    public static class AllPurposeConverter
    {
        public static Language? ConvertStringToLanuage(string lang)
        {
            return ParseEnum<Language>(lang);
        }

        private static T? ParseEnum<T>(string value)where T : struct, IConvertible
        {
            T resultInputType;
            if (Enum.TryParse<T>(value, true, out resultInputType))
            {
                return resultInputType;
            }
            else
            {
                return null;
            }
            
        }
    }
}