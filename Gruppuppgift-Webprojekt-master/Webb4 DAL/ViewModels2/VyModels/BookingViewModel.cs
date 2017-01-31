using Webb4_DAL.ModelsV2;

namespace ViewModels2.VyModels
{
    public class BookingViewModel
    {
        public int Id { get; set; }
        public virtual User booker { get; set; }
        public virtual Appartment Appartment { get; set; }
    }
}