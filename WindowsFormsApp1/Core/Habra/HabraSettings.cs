
namespace Parser.Core.Habra
{
    class HabraSettings : IParserSettings
    {
        public HabraSettings(string url)
        {
            BaseUrl = url;
        }

        public string BaseUrl { get; set; } = "https://habrahabr.ru";

    }
}
