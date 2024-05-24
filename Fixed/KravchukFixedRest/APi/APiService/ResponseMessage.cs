using Newtonsoft.Json;

namespace APiService
{
    public class ResponseMessage
    {
        [JsonProperty("Message")]
        public string Message { get; set; }
    }
}
