using AITech.WEBUI.DTOs.CategoryDtos;

namespace AITech.WEBUI.DTOs.ProjectDtos
{
    public class UpdateProjectDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
       
    }
}
