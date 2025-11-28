using AITech.WEBUI.DTOs.CategoryDtos;

namespace AITech.WEBUI.DTOs.ProjectDtos
{
    public class ResultProjectDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public ResultCategoryDto Category { get; set; }
    }
}
