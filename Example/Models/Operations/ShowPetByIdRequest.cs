
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
    using Example.Utils;
    
    public class ShowPetByIdRequest
    {

        /// <summary>
        /// The id of the pet to retrieve
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=petId")]
        public string PetId { get; set; } = default!;
    }
}