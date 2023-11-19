
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Example.Models.Operations
{
    using Example.Models.Shared;
    using System.Collections.Generic;
    using System.Net.Http;
    using System;
    
    public class ListPetsResponse
    {

        /// <summary>
        /// HTTP response content type for this operation
        /// </summary>
        public string? ContentType { get; set; } = default!;

        /// <summary>
        /// unexpected error
        /// </summary>
        public Error? Error { get; set; }

        public Dictionary<string, List<string>> Headers { get; set; } = default!;

        /// <summary>
        /// A paged array of pets
        /// </summary>
        public List<Pet>? Pets { get; set; }

        /// <summary>
        /// HTTP response status code for this operation
        /// </summary>
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        public HttpResponseMessage RawResponse { get; set; } = default!;
    }
}