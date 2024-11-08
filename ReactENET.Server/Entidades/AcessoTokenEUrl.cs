namespace ReactENET.Entidades
{
    public class AcessoTokenEUrl
    {
        public static string? Url { get; set; }


        public static string? Password { get; set; }

        public static string URl()
        {
            Url = "https://xjwtshjrajflumotjyuf.supabase.co/rest";
            return Url;
        }

        public static string PASSWORD()
        {
            Password = "";
            return Password;
        }


    }
}

