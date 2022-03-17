// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




public class MyDate {
    int Day, Month, Year;

    public MyDate(int Day, int Month, int Year)
    {
        this.Day = Day; this.Month = Month; this.Year = Year;
    }

    private static bool DivisibleBy(int divided, int dividedBy)
    {
        return (divided % dividedBy == 0);
    }

    private static bool NotDivisibleBy(int divided, int dividedBy)
    {
        return (divided % dividedBy != 0);
    }

    public MyDate GetNext(){
        switch(this.Month)
        {
            case 1:
                if(Day == 31){return new MyDate(1, this.Month+1, this.Year);}
                break;
            case 2:
                switch(this.Day)
                {   case 28:
                        if(DivisibleBy(this.Year, 4) && NotDivisibleBy(this.Year, 100)) break;
                        if(DivisibleBy(this.Year, 400)) break;
                        return new MyDate(1, this.Month+1, this.Year);
                    case 29:
                    default:
                        break;
                }
                break;
            case 3:
                if(Day == 31){return new MyDate(1, this.Month+1, this.Year);}
                break;
            case 4:
                if(Day == 30){return new MyDate(1, this.Month+1, this.Year);}
                break;
            case 5:
                if(Day == 31){return new MyDate(1, this.Month+1, this.Year);}
                break;
            case 6:
                if(Day == 30){return new MyDate(1, this.Month+1, this.Year);}
                break;
            case 7:
                if(Day == 31){return new MyDate(1, this.Month+1, this.Year);}
                break;
            case 8:
                if(Day == 31){return new MyDate(1, this.Month+1, this.Year);}
                break;
            case 9:
                if(Day == 30){return new MyDate(1, this.Month+1, this.Year);}
                break;
            case 10:
                if(Day == 31){return new MyDate(1, this.Month+1, this.Year);}
                break;
            case 11:
                if(Day == 30){return new MyDate(1, this.Month+1, this.Year);}
                break;
            case 12:
                if(Day == 31){return new MyDate(1, 1, this.Year + 1);}
                break;
            default:
                throw new Exception("Month not set.");
        }
        return new MyDate(this.Day + 1, this.Month, this.Year);
    }
}

public class DateProcessor{
    MyDate[] theDates;

    public DateProcessor()
    {
        
    }
}