using System.Runtime.Serialization;

namespace TournamentOrganizer
{
    /// <summary>
    /// A helper class used to retrieve custom attributes from enums.
    /// </summary>
    internal static class EnumCustomAttributeConverter
    {
        #region Public Methods

        /// <summary>
        /// Retrieves the custom name attributes from an an Enum type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Returns a List object containing all of the custom
        /// name attribute strings from the parameter Enum type.</returns>
        public static List<string> GetEnumMemberNames<T>() where T : Enum
        {
            var enumType = typeof(T);
            var names = new List<string>();

            foreach (var value in Enum.GetValues(enumType))
            {
                var memberInfo = enumType.GetMember(value.ToString())[0];
                var enumMemberAttribute = memberInfo.GetCustomAttributes(typeof(EnumMemberAttribute), false).FirstOrDefault() as EnumMemberAttribute;

                // If there is a custom name attribute, add it to the return list.
                // Otherwise, use the default defined name.
                if (enumMemberAttribute != null)
                {
                    names.Add(enumMemberAttribute.Value);
                }
                else 
                {
                    names.Add(value.ToString());
                }
            }

            return names;
        }

        #endregion
    }
}
