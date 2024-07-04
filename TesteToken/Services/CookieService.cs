namespace TesteToken.Services
{
    public class CookieService
    {
        public void CreateCookie(HttpResponse response)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Secure = true, // Define como true se estiver usando HTTPS
                Expires = DateTimeOffset.Now.AddDays(1) // Define o tempo de expiração do cookie
            };

            response.Cookies.Append("token", "LALALA-LELELE-LILILI", cookieOptions);
        }

        public string GetCookie(HttpRequest request)
        {
            if (request.Cookies.TryGetValue("token", out var token))
            {
                return token;
            }
            return null;
        }
    }
}
