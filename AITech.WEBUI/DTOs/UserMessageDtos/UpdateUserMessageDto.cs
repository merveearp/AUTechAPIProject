namespace AITech.WEBUI.DTOs.UserMessageDtos
{
    public class UpdateUserMessageDto
    {
        public int Id { get; set; }
        // Admin arandığında set edilecek
        public DateTime? UpdatedDate { get; set; }
        public bool IsCalled { get; set; }
    }
}
