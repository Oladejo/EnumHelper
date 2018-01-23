using System;
using System.ComponentModel;
using System.Reflection;

namespace EnumDescription
{
    public static class EnumHelper
    {
        /// <summary>
        /// Retrieve the description on the enum, e.g.
        /// [Description("He is a boy")]
        /// Boy,
        /// Then when you pass in the enum, it will retrieve the description
        /// </summary>
        /// 
        public static string GetDescription(Enum en)
        {
            Type type = en.GetType();

            MemberInfo[] memberInfo = type.GetMember(en.ToString());

            if(memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return en.ToString();
        }

    }
}
