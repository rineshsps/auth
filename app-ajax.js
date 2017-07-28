var settings = {
  "async": true,
  "crossDomain": true,
  "url": "http://localhost:55670/api/Values",
  "method": "GET",
  "headers": {
    "authorization": "Basic dXNlci1uYW1lOnBhc3N3b3JkIzEyMw==",
    "cache-control": "no-cache",
    "postman-token": "be02c905-adc8-9de2-0624-ee596732d0da"
  }
}

$.ajax(settings).done(function (response) {
  console.log(response);
});
