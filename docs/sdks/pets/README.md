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

var sdk = new ExampleSDK();

var res = await sdk.Pets.CreatePetsAsync();

// handle response
```


### Response

**[CreatePetsResponse](../../Models/Operations/CreatePetsResponse.md)**


## ListPets

List all pets

### Example Usage

```csharp
using Example;
using Example.Models.Operations;

var sdk = new ExampleSDK();

var res = await sdk.Pets.ListPetsAsync(Limit: 21453);

// handle response
```

### Parameters

| Parameter                                      | Type                                           | Required                                       | Description                                    |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| `Limit`                                        | *int*                                          | :heavy_minus_sign:                             | How many items to return at one time (max 100) |


### Response

**[ListPetsResponse](../../Models/Operations/ListPetsResponse.md)**


## ShowPetById

Info for a specific pet

### Example Usage

```csharp
using Example;
using Example.Models.Operations;

var sdk = new ExampleSDK();

var res = await sdk.Pets.ShowPetByIdAsync(PetId: "string");

// handle response
```

### Parameters

| Parameter                     | Type                          | Required                      | Description                   |
| ----------------------------- | ----------------------------- | ----------------------------- | ----------------------------- |
| `PetId`                       | *string*                      | :heavy_check_mark:            | The id of the pet to retrieve |


### Response

**[ShowPetByIdResponse](../../Models/Operations/ShowPetByIdResponse.md)**

