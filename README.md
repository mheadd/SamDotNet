# SamDotNet

A C# port of the [samwise Ruby gem](https://github.com/18F/samwise) for the SAM.gov API.


## Run tests

```bash
~$ dotnet test SamDotNet.Tests/SamDotNet.Tests.csproj
```

## Usage

Requires [.NET Core](https://www.microsoft.com/net/download/core).

Example

```csharp
using System;
using SamDotNet;
using Newtonsoft.Json;

namespace SamDotNet.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = args[0];
            string duns_number = args[1];

            Sam sam = new Sam(key);
            var result = sam.GetDunsInfo(duns_number);
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }
    }
}
```

Invoke thusly: ```~$ dotnet run "DEMO_KEY" "1459697830000" ```

Result

```json
{
  "sam_data": {
    "registration": {
      "govtBusinessPoc": {
        "lastName": "YOUTZY",
        "fax": "7032277477",
        "address": {
          "zip": "22033",
          "countryCode": "USA",
          "line1": "12601 FAIR LAKES CIRCLE",
          "stateorProvince": "VA",
          "city": "FAIRFAX"
        },
        "email": "SAM.CGIFEDERAL@CGIFEDERAL.COM",
        "usPhone": "7032276000",
        "firstName": "KIM"
      },
      "qualifications": {
        "acass": {
          "id": "SF330",
          "answers": {
            "answerText": "Vendor will provide information with specific offers to the Government",
            "section": "SF330.1"
          }
        }
      },
      "dunsPlus4": "0000",
      "activationDate": "2017-06-02 12:15:02.0",
      "fiscalYearEndCloseDate": "09/30",
      "businessTypes": [
        "20",
        "2X"
      ],
      "pastPerformancePoc": {
        "lastName": "CARLSON",
        "fax": "7032277477",
        "address": {
          "zip": "22033",
          "countryCode": "USA",
          "line1": "12601 FAIR LAKES CIRCLE",
          "stateorProvince": "VA",
          "city": "FAIRFAX"
        },
        "email": "SAM.CGIFEDERAL@CGIFEDERAL.COM",
        "usPhone": "7032276000",
        "firstName": "PEGGY"
      },
      "registrationDate": "2004-07-29 00:00:00.0",
      "certificationsURL": {
        "pdfUrl": "https://www.sam.gov/SAMPortal/filedownload?reportType=2&orgId=R34U8OcyVG70umqH8%2F9UnvkBfnChb3Ib2WLgdjIK0vYdDcQTD96OE8d6zgxSvmHh&pitId=xp%2BbR0PDwxAbFu%2FhB9SqS1hNC2PZPr25YlQtX65DgLyKZ7OpJGLa8GsC2zL%2BU0uu&requestId=wxC3KQ8d316W3yG"
      },
      "hasDelinquentFederalDebt": false,
      "duns": "145969783",
      "altElectronicBusinessPoc": {
        "lastName": "CARLSON",
        "fax": "7032277477",
        "address": {
          "zip": "22030",
          "countryCode": "USA",
          "line1": "12601 FAIR LAKES CIRCLE",
          "stateorProvince": "VA",
          "city": "Fairfax"
        },
        "email": "SAM.CGIFEDERAL@CGIFEDERAL.COM",
        "usPhone": "7032276000",
        "firstName": "PEGGY"
      },
      "cage": "3YVK7",
      "hasKnownExclusion": false,
      "publicDisplay": true,
      "expirationDate": "2018-06-02 11:58:32.0",
      "status": "ACTIVE",
      "corporateStructureCode": "2L",
      "stateOfIncorporation": "DE",
      "corporateStructureName": "Corporate Entity (Not Tax Exempt)",
      "legalBusinessName": "CGI FEDERAL INC.",
      "congressionalDistrict": "VA 11",
      "companyDivision": "SUBSIDIARY OF CGI TECHNOLOGIES AND SOLUTIONS INC.",
      "bondingInformation": {},
      "businessStartDate": "2004-05-01",
      "lastUpdateDate": "2017-06-02 12:15:02.0",
      "statusMessage": "Active",
      "samAddress": {
        "zipPlus4": "4902",
        "zip": "22033",
        "countryCode": "USA",
        "line1": "12601 FAIR LAKES CIR",
        "stateorProvince": "VA",
        "city": "FAIRFAX"
      },
      "submissionDate": "2017-06-02 11:58:32.0",
      "naics": [
        {
          "isPrimary": true,
          "naicsCode": "541519",
          "naicsName": "OTHER COMPUTER RELATED SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "541513",
          "naicsName": "COMPUTER FACILITIES MANAGEMENT SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "925110",
          "naicsName": "ADMINISTRATION OF HOUSING PROGRAMS"
        },
        {
          "isPrimary": false,
          "naicsCode": "624310",
          "naicsName": "VOCATIONAL REHABILITATION SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "541614",
          "naicsName": "PROCESS, PHYSICAL DISTRIBUTION, AND LOGISTICS CONSULTING SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "511210",
          "naicsName": "SOFTWARE PUBLISHERS"
        },
        {
          "isPrimary": false,
          "naicsCode": "561611",
          "naicsName": "INVESTIGATION SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "541712",
          "naicsName": "RESEARCH AND DEVELOPMENT IN THE PHYSICAL, ENGINEERING, AND LIFE SCIENCES (EXCEPT BIOTECHNOLOGY)"
        },
        {
          "isPrimary": false,
          "naicsCode": "541350",
          "naicsName": "BUILDING INSPECTION SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "541511",
          "naicsName": "CUSTOM COMPUTER PROGRAMMING SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "519190",
          "naicsName": "ALL OTHER INFORMATION SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "541990",
          "naicsName": "ALL OTHER PROFESSIONAL, SCIENTIFIC, AND TECHNICAL SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "541618",
          "naicsName": "OTHER MANAGEMENT CONSULTING SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "541512",
          "naicsName": "COMPUTER SYSTEMS DESIGN SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "611699",
          "naicsName": "ALL OTHER MISCELLANEOUS SCHOOLS AND INSTRUCTION"
        },
        {
          "isPrimary": false,
          "naicsCode": "561110",
          "naicsName": "OFFICE ADMINISTRATIVE SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "611420",
          "naicsName": "COMPUTER TRAINING"
        },
        {
          "isPrimary": false,
          "naicsCode": "518210",
          "naicsName": "DATA PROCESSING, HOSTING, AND RELATED SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "561210",
          "naicsName": "FACILITIES SUPPORT SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "541611",
          "naicsName": "ADMINISTRATIVE MANAGEMENT AND GENERAL MANAGEMENT CONSULTING SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "561440",
          "naicsName": "COLLECTION AGENCIES"
        },
        {
          "isPrimary": false,
          "naicsCode": "811111",
          "naicsName": "GENERAL AUTOMOTIVE REPAIR"
        },
        {
          "isPrimary": false,
          "naicsCode": "541690",
          "naicsName": "OTHER SCIENTIFIC AND TECHNICAL CONSULTING SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "334111",
          "naicsName": "ELECTRONIC COMPUTER MANUFACTURING"
        },
        {
          "isPrimary": false,
          "naicsCode": "611430",
          "naicsName": "PROFESSIONAL AND MANAGEMENT DEVELOPMENT TRAINING"
        },
        {
          "isPrimary": false,
          "naicsCode": "541330",
          "naicsName": "ENGINEERING SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "541219",
          "naicsName": "OTHER ACCOUNTING SERVICES"
        },
        {
          "isPrimary": false,
          "naicsCode": "334511",
          "naicsName": "SEARCH, DETECTION, NAVIGATION, GUIDANCE, AERONAUTICAL, AND NAUTICAL SYSTEM AND INSTRUMENT MANUFACTURING"
        }
      ],
      ...
      "corporateUrl": "http://www.cgifederal.com",
      "creditCardUsage": true,
      "countryOfIncorporation": "USA",
      "electronicBusinessPoc": {
        "lastName": "YOUTZY",
        "fax": "7032277477",
        "address": {
          "zip": "22033",
          "countryCode": "USA",
          "line1": "12601 FAIR LAKES CIRCLE",
          "stateorProvince": "VA",
          "city": "FAIRFAX"
        },
        "email": "SAM.CGIFEDERAL@CGIFEDERAL.COM",
        "usPhone": "7032276000",
        "firstName": "KIM"
      },
      "mailingAddress": {
        "zipPlus4": "4902",
        "zip": "22033",
        "countryCode": "USA",
        "line1": "12601 FAIR LAKES CIRCLE",
        "stateorProvince": "VA",
        "line2": "GWAC SOLUTIONS CENTER",
        "city": "FAIRFAX"
      },
      "purposeOfRegistration": "ALL_AWARDS"
    }
  }
}

```