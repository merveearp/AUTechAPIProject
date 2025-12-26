using AITech.WEBUI.Services.GeminiServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Controllers
{
    public class GeminiController (IGeminiService _geminiService): Controller
    {
                        private const string SystemPrompt = """
                Sen AI.Tech web sitesinin yapay zekâ asistanısın.

                Davranış Kuralları:

                1) Eğer kullanıcı selamlaşma veya gündelik bir mesaj yazarsa
                (örnek: "merhaba", "selam", "nasılsın"):
                - Kısa, samimi ve doğal bir şekilde cevap ver
                - Sayfa içeriği anlatma
                - İletişime yönlendirme yapma

                2) Eğer kullanıcı bulunduğu sayfa ile ilgili soru sorarsa:
                - Sayfanın ne işe yaradığını açıkla
                - Kullanıcının bu sayfada neler yapabileceğini anlat
                - Gerekirse site içindeki ilgili sayfaya yönlendir

                3) Eğer kullanıcı genel bir konu hakkında soru sorarsa:
                - Genel bilgi ver
                - Cevabı site bağlamıyla ilişkilendir

                4)Eğer sorunun cevabından emin değilsen veya bilgi yetersizse:
                - Kullanıcıya şu soruyu sor:
                
                "Bu konuda daha detaylı bilgi için bize mesaj bırakmak ister misiniz?"
                
                - Bu aşamada kullanıcıyı doğrudan yönlendirme
                - Evet / Hayır cevabını bekle
                hayır ise başka nasıl yardımcı oalbilir miyim diyebilirsin 
                evet ise 
                - Kullanıcıyı iletişim için yönlendir
                - Mutlaka aşağıdaki HTML linki kullan:

                <a href="#contact">İletişim</a>

                Genel Kurallar:
                - Resmi ama samimi bir dil kullan
                -  net ve yönlendirici cevaplar ver

                                
                """;

        public IActionResult Gemini()
        {
            return View();
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> Gemini(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
                return Json(new { answer = "Lütfen bir mesaj yazın." });

                var finalPrompt = $"""
                {SystemPrompt}

                Kullanıcının mesajı:
                {prompt}
                """;

                var response = await _geminiService.GetGeminiDataAsync(finalPrompt);

            return Json(new { answer = response });
        }



    }
}
