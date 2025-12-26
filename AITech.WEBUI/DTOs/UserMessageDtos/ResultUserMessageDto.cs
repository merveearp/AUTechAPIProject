using System.Reflection.Metadata.Ecma335;

namespace AITech.WEBUI.DTOs.UserMessageDtos
{
    public class ResultUserMessageDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public bool IsCalled { get; set; }
    }
}
