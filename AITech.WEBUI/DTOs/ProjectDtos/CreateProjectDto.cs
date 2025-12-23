namespace AITech.WEBUI.DTOs.ProjectDtos
{
    public class CreateProjectDto
    {     
        public string? Title { get; set; }
        public string? Description { get; set; }

        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
    
    }
}
