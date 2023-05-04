using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace pet_hotel
{
    public class PetOwner
    {
        // constructor
        public PetOwner()
        {
            Pets = new HashSet<Pet>();
        }
        public int id {get; set;}
        [Required]
        public string name {get; set;}
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string emailAddress { get; set; }
        [NotMapped]
        public int PetCount => Pets.Count;
        [JsonIgnore]
        public ICollection<Pet> Pets {get; set;}
        
    }
}
