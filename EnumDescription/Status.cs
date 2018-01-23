using System.ComponentModel;

namespace EnumDescription
{
    public enum Status
    {
        [Description("He is a boy")]
        Boy,

        [Description("She is a girl")]
        Girl,

        [Description("He is an adult")]
        Man,

        [Description("she is an adult")]
        Woman
    }
}
