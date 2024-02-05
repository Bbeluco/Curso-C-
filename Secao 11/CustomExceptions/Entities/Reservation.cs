namespace CustomExceptions;

public class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) {
        if(checkOut < checkIn) {
            throw new DomainException("Check-out date must be after check-in");
        }
        
        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int Duration() {
        TimeSpan time = CheckOut.Subtract(CheckIn);
        return (int) time.TotalDays;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut) {
        if(checkIn < DateTime.Now || checkOut < DateTime.Now) {
            throw new DomainException("Reservation dates for update must be future dates");
        } else if(checkIn > checkOut) {
            throw new DomainException("Check-out date must be after check-in");
        }

        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public override string ToString()
    {
        return $"Reservation: Room {RoomNumber}, check-in: {CheckIn:dd/MM/yyyy}, check-out: {CheckOut:dd/MM/yyyy}, {Duration()} nights";
    }
}
