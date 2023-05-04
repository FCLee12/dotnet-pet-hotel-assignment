using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType
    // use index not string
    {
        Shepard,
        Poodle,
        Beagle,
        Bulldog,
        Terrier,
        Boxer,
        Labrador,
        Retriever
    }
    public enum PetColorType
    // use index not string
    {
        White,
        Black,
        Golden,
        Tricolor,
        Spotted
    }
    public class Pet
    {
        public int id {get; set;}
        [Required]
        public string name {get; set;}
        [Required]
        [JsonConverter (typeof(JsonStringEnumConverter))]
        public PetBreedType breed {get; set;}
        [Required]
        [JsonConverter (typeof(JsonStringEnumConverter))]
        public PetColorType color {get; set;}
        public DateTime? checkedInAt {get; set;}
        [Required]
        public int petOwnerid {get; set;}
        [JsonIgnore]
        [ForeignKey("petOwnerid")]
        public PetOwner PetOwner {get; set;}
    }
}
