using RestSharp;

var apiUrl = new RestClient("https://api.pagar.me/core/v5");
var request = new RestRequest("plans", Method.Post);

request.AddHeader("accept", "application/json");
request.AddHeader("content-type", "application/json");
request.AddHeader("authorization", "Basic c2tfdGVzdF83ekpBR3JqU0dpMkdvNnhPOg==");

var requestBody = new
{
    name = "Test Plan",
    description = "",
    statement_descriptor = "",
    interval = "month",
    interval_count = 1,
    billing_type = "postpaid", // prepaid, postpaid ou exact_day
    // billing_days = new int[] {10, 15, 25}, // only if billing_type is exact_day
    pricing_scheme = new
    {
        scheme_type = "Unit",
        price = 10
    },
    quantity = 1
};

request.AddJsonBody(requestBody);

var response = apiUrl.Post(request);

Console.WriteLine("StatusCode: " + response.StatusCode);
