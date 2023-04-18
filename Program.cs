using RestSharp;

var client = new RestClient("https://api.pagar.me/core/v5");
var request = new RestRequest("plans", Method.Post);

request.AddHeader("accept", "application/json");
request.AddHeader("content-type", "application/json");
request.AddHeader("authorization", "Basic c2tfdGVzdF83ekpBR3JqU0dpMkdvNnhPOg==");

var requestBody = new
{
    interval = "month",
    interval_count = 1,
    pricing_scheme = new
    {
        scheme_type = "Unit",
        price = 10
    },
    quantity = 1,
    name = "Plano Teste"
};

request.AddJsonBody(requestBody);

var response = client.Post(request);

Console.WriteLine("StatusCode: " + response.StatusCode);
