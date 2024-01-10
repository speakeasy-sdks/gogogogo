<!-- Start SDK Example Usage [usage] -->
```csharp
using Example;
using Example.Models.Shared;

var sdk = new ExampleSDK();

Pet req = new Pet() {
    Id = 596804,
    Name = "string",
};

var res = await sdk.Pets.CreatePetsAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->