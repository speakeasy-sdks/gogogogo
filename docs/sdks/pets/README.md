# Pets
(*Pets*)

### Available Operations

* [CreatePets](#createpets) - Create a pet
* [ListPets](#listpets) - List all pets
* [ShowPetById](#showpetbyid) - Info for a specific pet

## CreatePets

Create a pet

### Example Usage

```csharp
using Example;
using Example.Models.Shared;

var sdk = new ExampleSDK();

Pet req = new Pet() {
    Id = 596804,
    Name = "<value>",
};

var res = await sdk.Pets.CreatePetsAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | [Pet](../../Models/Shared/Pet.md)          | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[CreatePetsResponse](../../Models/Operations/CreatePetsResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Example.Models.Errors.SDKException | 4xx-5xx                            | */*                                |

## ListPets

List all pets

### Example Usage

```csharp
using Example;
using Example.Models.Operations;

var sdk = new ExampleSDK();

var res = await sdk.Pets.ListPetsAsync(limit: 21453);

// handle response
```

### Parameters

| Parameter                                      | Type                                           | Required                                       | Description                                    |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| `Limit`                                        | *int*                                          | :heavy_minus_sign:                             | How many items to return at one time (max 100) |


### Response

**[ListPetsResponse](../../Models/Operations/ListPetsResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Example.Models.Errors.SDKException | 4xx-5xx                            | */*                                |

## ShowPetById

Info for a specific pet

### Example Usage

```csharp
using Example;
using Example.Models.Operations;

var sdk = new ExampleSDK();

var res = await sdk.Pets.ShowPetByIdAsync(petId: "<value>");

// handle response
```

### Parameters

| Parameter                     | Type                          | Required                      | Description                   |
| ----------------------------- | ----------------------------- | ----------------------------- | ----------------------------- |
| `PetId`                       | *string*                      | :heavy_check_mark:            | The id of the pet to retrieve |


### Response

**[ShowPetByIdResponse](../../Models/Operations/ShowPetByIdResponse.md)**
### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Example.Models.Errors.SDKException | 4xx-5xx                            | */*                                |
