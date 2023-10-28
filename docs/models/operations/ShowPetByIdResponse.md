# ShowPetByIdResponse


## Fields

| Field                                                                                                                | Type                                                                                                                 | Required                                                                                                             | Description                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| `ContentType`                                                                                                        | *string*                                                                                                             | :heavy_check_mark:                                                                                                   | HTTP response content type for this operation                                                                        |
| `Error`                                                                                                              | [Error](../../models/shared/Error.md)                                                                                | :heavy_minus_sign:                                                                                                   | unexpected error                                                                                                     |
| `Pet`                                                                                                                | [Pet](../../models/shared/Pet.md)                                                                                    | :heavy_minus_sign:                                                                                                   | Expected response to a valid request                                                                                 |
| `StatusCode`                                                                                                         | *int*                                                                                                                | :heavy_check_mark:                                                                                                   | HTTP response status code for this operation                                                                         |
| `RawResponse`                                                                                                        | [HttpResponseMessage](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpresponsemessage?view=net-5.0) | :heavy_minus_sign:                                                                                                   | Raw HTTP response; suitable for custom response parsing                                                              |