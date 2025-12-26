namespace AITech.WEBUI.DTOs.GeminiDtos
{
    public class GeminiResponseDto
    {
        public List<Candidate>? candidates { get; set; }
    }
    
    public class Candidate
    {
        public Content? content { get; set; }
        public string? finishReason { get; set; }
        public int? index { get; set; }
    }
}
