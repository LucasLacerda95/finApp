namespace finapp.Api.Extensions{


    public class AppSettings{

        public string Secret { get; set; }

        public string ExpirationInHours { get; set; }

        public string Issuer { get; set; }

        public string ValidIn { get; set; }
    }
}