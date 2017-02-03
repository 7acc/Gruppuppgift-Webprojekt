

namespace ViewModels2.VyModels
{
    public class BookingViewModel
    {
        public int Id { get; set; }
        public  UserViewModel booker { get; set; }
        public virtual AppartmentViewModel Appartment { get; set; }
    }
}