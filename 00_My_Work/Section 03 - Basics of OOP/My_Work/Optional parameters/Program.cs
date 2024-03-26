﻿var medicalAppointment = new MedicalAppointment(
    "John Smith", new DateTime(2023, 4, 3));

//simply reschedule
medicalAppointment.Reschedule(new DateTime(2023, 4, 4));

Console.ReadKey();

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine(
            "Appointment will take place on " + medicalAppointment.GetDate());
    }

}
class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public DateTime GetDate() => _date;

    // Will use a constructor with a default value for the daysfromnow parameter to replace this
    //public MedicalAppointment(string patientName) : // Constructor overloading, must have a different signature
    //    this(patientName, 7)                        // Call the other constructor, matches using the signature
    //{
    //}

    // Defaults must be able to evaluate at compile time, and optional parameters must be at the end of the parameter list (see below)
public MedicalAppointment(string patientname, int daysfromnow = 7) // Use a default value for the daysfromnow parameter
    {
        _patientName = patientname;
        _date = DateTime.Now.AddDays(daysfromnow);
    }
    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);                    // Pass the current instance of the class
    }

    public void Reschedule(int month, int day) // Method overloading, must have a different signature
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void NoveByMonthAndDays(int monthsToAdd, int daysToAdd) // Can't overload this one as it has the same signature
    {
        _date = new DateTime(
                            _date.Year,
                            _date.Month + monthsToAdd,
                            _date.Day + daysToAdd);
    }
}
