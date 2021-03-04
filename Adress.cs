using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Newtonsoft.Json;


namespace s4_oop_2
{
    public class Adress
    {
        [Serializable]
        public class AdressValidationException : Exception
        {
            public List<int> ControlsIndexex;
            public AdressValidationException() { }
            public AdressValidationException(string message) : base(message) { }
            public AdressValidationException(string message, List<int> erInd) : base(message)
            {
                ControlsIndexex = erInd;
            }
            public AdressValidationException(string message, Exception inner) : base(message, inner) { }
            protected AdressValidationException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        public class FlatNumberAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                if (value != null)
                {
                    int buff = int.Parse(value.ToString());
                    if (buff != 314)
                    {
                        return true;
                    }
                    else
                        this.ErrorMessage = "5: Номер квартиры не должен быть равен 314";
                }
                else
                    this.ErrorMessage = "5: Номер не может быть null";

                return false;
            }
        }

        static int nextId = 0;
        //0
        [Required(ErrorMessage = "0: Напишите страну")]
        public string Country { get; set; }
        //1
        [Required(ErrorMessage = "1: Напишите город")]
        public string City { get; set; }
        //2
        [Required(ErrorMessage = "2: Напишите район")]
        public string District { get; set; }
        //3
        [Required(ErrorMessage = "3: Напишите улицу")]
        [RegularExpression(@"^[у,п][л,р]\.\s\w*", ErrorMessage = "3: Название улицы должно начинаться с 'ул.' или 'пр.'")]
        public string Street { get; set; }
        //4
        [Required(ErrorMessage = "4: Напишите номер дома")]
        public string HouseNumber { get; set; }
        //5
        [Required(ErrorMessage = "5: Напишите номер квартиры")]
        [FlatNumberAttribute]
        public int FlatNumber { get; set; }
        public int Id { get; }

        // свойство для отображения в листбоксе на MainForm
        public string MyToString
        {
            get => ToString();
        }

        [NonSerialized]
        Adress self;
        [JsonIgnore]
        public Adress Self { get => self;}

        Adress(string country, string city, string district, string street, string houseNum, int flatNum)
        {
            Country = country;
            City = city;
            District = district;
            Street = street;
            HouseNumber = houseNum;
            FlatNumber = flatNum;

            Id = nextId++;
            self = this;
        }
        Adress() : this("country", "city", "district", "ул. Street", "61A", 13)
        {

        }

        public override string ToString()
        {
            return $"{Country}, {City}, район {District}, {Street}, {HouseNumber}-{FlatNumber}";
        }

        // Создание и валидация адресов 
        public static Adress CreateAdress(string country, string city, string district, string street, string houseNum, int flatNum)
        {
            var adress = new Adress(country, city, district, street, houseNum, flatNum);
            var results = new List<ValidationResult> { };
            var context = new ValidationContext(adress);

            if (!Validator.TryValidateObject(adress, context, results, true))
            {
                StringBuilder message = new StringBuilder("");
                List<int> indexes = new List<int> { };

                foreach (var error in results)
                {
                    message.Append(error.ErrorMessage);
                    message.Append('\n');

                    string substr = error.ErrorMessage.Substring(0, 1);
                    indexes.Add(int.Parse(substr));
                }
                throw new AdressValidationException(message.ToString(), indexes);
            }
            else
                return adress;
        }
        public static Adress CreateAdress()
        {
            return CreateAdress("country", "city", "district", "ул. Street", "61A", 13);
        }
    }
}
