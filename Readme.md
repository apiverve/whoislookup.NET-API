WHOIS Lookup API
============

Whois Lookup is a simple tool for checking the registration of a domain name. It returns the name and contact information of the domain owner, the domain registrar, and more.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [WHOIS Lookup API](https://apiverve.com/marketplace/api/whoislookup)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.WHOISLookup
```

Using the Package Manager:
```
nuget install APIVerve.API.WHOISLookup
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.WHOISLookup
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.WHOISLookup".
5. Click on the APIVerve.API.WHOISLookup package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the whoislookup API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The WHOIS Lookup API documentation is found here: [https://docs.apiverve.com/api/whoislookup](https://docs.apiverve.com/api/whoislookup).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
WHOIS Lookup API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new WHOISLookupAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new WHOISLookupQueryOptions {
  domain = "myspace.com"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "domainStatus": [
      "clientDeleteProhibited https://icann.org/epp#clientDeleteProhibited",
      "clientRenewProhibited https://icann.org/epp#clientRenewProhibited",
      "clientTransferProhibited https://icann.org/epp#clientTransferProhibited",
      "clientUpdateProhibited https://icann.org/epp#clientUpdateProhibited"
    ],
    "domainName": "MYSPACE.COM",
    "registryDomainID": "3877095_DOMAIN_COM-VRSN",
    "registrarWHOISServer": "whois.godaddy.com",
    "registrarURL": "http://www.godaddy.com",
    "updatedDate": "2023-01-17T00:16:21Z",
    "createdDate": "1996-02-22T05:00:00Z",
    "expiryDate": "2029-02-23T05:00:00Z",
    "registrar": "GoDaddy.com, LLC",
    "registrarIANAID": "146",
    "registrarAbuseContactEmail": "abuse@godaddy.com",
    "registrarAbuseContactPhone": "480-624-2505",
    "dNSSEC": "unsigned"
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.