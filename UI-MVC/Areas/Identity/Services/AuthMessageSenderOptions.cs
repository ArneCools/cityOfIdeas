namespace COI.UI_MVC.Areas.Identity.Services
{
    public class AuthMessageSenderOptions
    {
        //TODO usersecrets uit deze klasse en in userSecrets.json
        public string SendGridUser { get; set; }

        public string SendGridKey { get; set; } 
    }
}