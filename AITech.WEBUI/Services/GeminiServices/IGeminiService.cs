namespace AITech.WEBUI.Services.GeminiServices
{
    public interface IGeminiService
    {
        Task<string> GetGeminiDataAsync(string prompt);
    }
}
