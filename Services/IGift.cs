namespace White_Elephant.Services
{
    public interface IGift
    {
        int AssignedPlayerID { get; set; }
        string GiftDescription { get; set; }
        int GiftID { get; set; }
        string GiftImageAddress { get; set; }
        string GiftWrapImageID { get; set; }
        bool OpenStatus { get; set; }
    }
}