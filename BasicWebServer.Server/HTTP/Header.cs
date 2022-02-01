using BasicWebServer.Server.Common;

namespace BasicWebServer.Server.HTTP
{
    public class Header
    {
        public const string ContentType = "Content-Type";
        public const string ContentLeghth = "Content-Lenght";
        public const string Date = "Date";
        public const string Location = "Location";
        public const string Server = "Server";


        public Header(string name, string value)
        {
            Guard.AgainstNull(name, nameof(name));
            Guard.AgainstNull(value, nameof(value));

            this.Name = name;
            this.Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
            => $"{this.Name}: {this.Value}";


    }
}
