namespace Time_Class_Case_Study;

public class Time1
{
    public int Hour { get; set; }
    public int Min { get; set; }
    public int Sec { get; set; }

    public void SetTime(int h, int m, int s) {
        if ((h < 0 || h > 23) || (m < 0 || m > 59) || (s < 0 || s > 59))
        {
            throw new ArgumentOutOfRangeException();
        }
        Hour = h;
        Min = m;
        Sec = s;
    }

    public string ToUniversalString() => $"{Hour:D2}:{Min:D2}.{Sec:D2}";
    public override string ToString() => 
        $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" + $"{Min:D2}:{Sec:D2} {(Hour < 12 ? "AM" : "PM")}";
}