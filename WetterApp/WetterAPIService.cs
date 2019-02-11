using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WetterApp
{
    public class WetterAPIService
    {
        public static async void ErmittleWetter(WetterEintrag eintrag)
        {
            try
            {
                eintrag.Aktualisiert = false;
                HttpClient client = new HttpClient();
                await Task.Delay(2000);
                string json = await client.GetStringAsync($"https://api.openweathermap.org/data/2.5/weather?q={eintrag.Stadtname}&units=metric&appid=84d84c7b399d88e7f4e4688facc2498e");
                WetterAPIResult apiResult = JsonConvert.DeserializeObject<WetterAPIResult>(json);
                eintrag.Temperatur = apiResult.main.temp;
                eintrag.IconURL = $"http://openweathermap.org/img/w/{apiResult.weather[0].icon}.png";
                eintrag.Aktualisiert = true;
            }
            catch (Exception exp)
            {
                eintrag.Aktualisiert = true;
                eintrag.ErrorMessage = exp.Message;
            }
           
        }
    }
}
