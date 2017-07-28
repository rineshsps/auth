var client = new RestClient("http://localhost:55670/api/Values");
var request = new RestRequest(Method.GET);
request.AddHeader("postman-token", "26832818-dd43-48f2-c7c0-d0af5c85e4f3");
request.AddHeader("cache-control", "no-cache");
request.AddHeader("authorization", "Basic dXNlci1uYW1lOnBhc3N3b3JkIzEyMw==");
IRestResponse response = client.Execute(request);
