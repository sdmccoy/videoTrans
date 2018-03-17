using System;
using System.Net.Http;

namespace videoTrans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My video transcribe app!");
            var apiUrl = "https://videobreakdown.azure-api.net/Breakdowns/Api/Partner/Breakdowns";
            var client = new HttpClient();
            string API_KEY;
            API_KEY = Environment.GetEnvironmentVariable("API_KEY_PRIMARY");
            Console.WriteLine(API_KEY);
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "...");
            var content = new MultipartFormDataContent();
            Console.WriteLine("The video is uploading...");
            // hard coded variable, should be dynamically passed in through a front-end input
            var videoUrl = "https://www.youtube.com/watch?v=Fzn_AKN67oI";

        }
    }
}

// var apiUrl = "https://videobreakdown.azure-api.net/Breakdowns/Api/Partner/Breakdowns";
// var client = new HttpClient();
// client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "...");

//     var content = new MultipartFormDataContent();

// Console.WriteLine("Uploading...");
//     var videoUrl = "https:/...";
// var result = client.PostAsync(apiUrl + "?name=some_name&description=some_description&privacy=private&partition=some_partition&videoUrl=" + videoUrl, content).Result;
// var json = result.Content.ReadAsStringAsync().Result;

// Console.WriteLine();
//     Console.WriteLine("Uploaded:");
//     Console.WriteLine(json);

//     var id = JsonConvert.DeserializeObject<string>(json);

//     while (true)
//     {
//         Thread.Sleep(10000);

//         result = client.GetAsync(string.Format(apiUrl + "/{0}/State", id)).Result;
//         json = result.Content.ReadAsStringAsync().Result;

//         Console.WriteLine();
//         Console.WriteLine("State:");
//         Console.WriteLine(json);

//         dynamic state = JsonConvert.DeserializeObject(json);
//         if (state.state != "Uploaded" && state.state != "Processing")
//         {
//             break;
//         }
//     }

//     result = client.GetAsync(string.Format(apiUrl + "/{0}", id)).Result;
//     json = result.Content.ReadAsStringAsync().Result;
//     Console.WriteLine();
//     Console.WriteLine("Full JSON:");
//     Console.WriteLine(json);

//     result = client.GetAsync(string.Format(apiUrl + "/Search?id={0}", id)).Result;
//     json = result.Content.ReadAsStringAsync().Result;
//     Console.WriteLine();
//     Console.WriteLine("Search:");
//     Console.WriteLine(json);

//     result = client.GetAsync(string.Format(apiUrl + "/{0}/InsightsWidgetUrl", id)).Result;
//     json = result.Content.ReadAsStringAsync().Result;
//     Console.WriteLine();
//     Console.WriteLine("Insights Widget url:");
//     Console.WriteLine(json);

//     result = client.GetAsync(string.Format(apiUrl + "/{0}/PlayerWidgetUrl", id)).Result;
//     json = result.Content.ReadAsStringAsync().Result;
//     Console.WriteLine();
//     Console.WriteLine("Player token:");
//     Console.WriteLine(json);


////// OTHER SAMPLE
// using System;
// using System.Net.Http.Headers;
// using System.Text;
// using System.Net.Http;
// using System.Web;

// namespace CSHttpClientSample
// {
//   static class Program
//   {
//     static void Main()
//     {
//       MakeRequest();
//       Console.WriteLine("Hit ENTER to exit...");
//       Console.ReadLine();
//     }

//     static async void MakeRequest()
//     {
//       var client = new HttpClient();
//       var queryString = HttpUtility.ParseQueryString(string.Empty);

//       // Request headers
//       client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "{subscription key}");

//       // Request parameters
//       queryString["description"] = "{string}";
//       queryString["groupName"] = "{string}";
//       var uri = "https://videobreakdown.azure-api.net/Breakdowns/Api/Customization/Language/TrainingData?name={name}&language={language}&" + queryString;

//       HttpResponseMessage response;

//       // Request body
//       byte[] byteData = Encoding.UTF8.GetBytes("{body}");

//       using (var content = new ByteArrayContent(byteData))
//       {
//         content.Headers.ContentType = new MediaTypeHeaderValue("< your content type, i.e. application/json >");
//         response = await client.PostAsync(uri, content);
//       }

//     }
//   }
// }