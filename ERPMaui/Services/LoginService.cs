using ERPMaui.Models;
using Newtonsoft.Json;
using System.Text;

namespace ERPMaui.Services
{
    public static class LoginService
    {

        public static async Task<bool> Login(string userName, string password)
        {
            var login = new Login()
            {
                UserName = userName,
                Password = password
            };
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(login);
            var content = new StringContent(json, Encoding.UTF8, "appliation/json");
            var response = await httpClient.PostAsync(AppSettings.ApiUrl + "master-setup/auth/login", content);
            if (!response.IsSuccessStatusCode)
                return false;
            var jsonResult = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<JwtToken>(jsonResult);
            Preferences.Set("token", result.Token);
            return true;
        }
    }
}
