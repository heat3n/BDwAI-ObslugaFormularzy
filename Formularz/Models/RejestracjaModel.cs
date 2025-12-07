using System.ComponentModel.DataAnnotations;

public class RejestracjaModel
{
    [Display(Name = "Imię")]
    [Required(ErrorMessage = "Pole Imię jest wymagane")]
    [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
    public string Imie { get; set; }

    [Display(Name = "Nazwisko")]
    [Required(ErrorMessage = "Pole Nazwisko jest wymagane")]
    [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
    public string Nazwisko { get; set; }

    [Display(Name = "Adres e-mail")]
    [Required(ErrorMessage = "Adres e-mail jest wymagany")]
    [EmailAddress(ErrorMessage = "Podaj poprawny adres e-mail")]
    public string Email { get; set; }

    [Display(Name = "Hasło")]
    [Required(ErrorMessage = "Hasło jest wymagane")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$",
        ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę")]
    public string Haslo { get; set; }

    [Display(Name = "Potwierdzenie hasła")]
    [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane")]
    [DataType(DataType.Password)]
    [Compare("Haslo", ErrorMessage = "Hasła muszą być identyczne")]
    public string PotwierdzenieHasla { get; set; }

    [Display(Name = "Nr telefonu")]
    [Phone(ErrorMessage = "Niepoprawny numer telefonu")]
    public string Telefon { get; set; }

    [Display(Name = "Wiek")]
    [Range(11, 80, ErrorMessage = "Wiek musi wynosić od 11 do 80 lat")]
    public int Wiek { get; set; }

    [Display(Name = "Miasto")]
    public Miasto Miasto { get; set; }
}

public enum Miasto
{
    Warszawa = 1,
    Krakow = 2,
    Gdansk = 3,
    Wroclaw = 4,
    Poznan = 5
}