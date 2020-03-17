using System;

class Program {
  static void Main(){
    Console.WriteLine("Witaj w wyliczaniu dni tygodnia!");

    string[] arrayOfDays = {
      "Poniedziałek",
      "Wtorek",
      "Środa",
      "Czwartek",
      "Piątek",
      "Sobota",
      "Niedziela"
      };

    for(int day = 1; day <= arrayOfDays.Length; day++){
      Console.WriteLine(day + ". " + arrayOfDays[day-1]);
    }
  }
} 