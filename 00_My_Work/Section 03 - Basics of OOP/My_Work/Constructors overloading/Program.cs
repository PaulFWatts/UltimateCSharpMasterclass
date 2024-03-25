
Console.ReadKey();

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public MedicalAppointment(string patientName) : // Constructor overloading, must have a different signature
        this(patientName, 7)                        // Call the other constructor, matches using the signature
    {
    }
    public MedicalAppointment(string patientname, int daysfromnow) // constructor overloading, must have a different signature
    {
        _patientName = patientname;
        _date = DateTime.Now.AddDays(daysfromnow);
    }
    public void Reschedule(DateTime date)
    {
        _date = date;
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
