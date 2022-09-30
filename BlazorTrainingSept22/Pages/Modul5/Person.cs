using System.ComponentModel.DataAnnotations;

namespace BlazorTrainingSept22.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Da muss was rein")]
        [StringLength(10,ErrorMessage ="max 10")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        [Range(140,190,ErrorMessage ="zwischen 140 und 190")]
        public int Gross { get; set; }
        public DateTime GebDat { get; set; }
    }
}
