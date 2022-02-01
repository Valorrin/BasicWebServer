using BasicWebServer.Server.Common;

namespace BasicWebServer.Server.HTTP
{
    public class Header
    {
        public Header(string name, string value)
        {
            Guard.AgainstNull(name, nameof(name));
            Guard.AgainstNull(value, nameof(value));

            this.Name = name;
            this.Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }

        public const string ContentType = "Content-Type";
        public const string ContentLeghth = "Content-Lenght";
        public const string Date = "Date";
        public const string Location = "Location";
        public const string Server = "Server";
    }
}
