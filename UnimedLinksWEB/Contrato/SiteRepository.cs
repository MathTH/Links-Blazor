using SiteModels.DTOS;
using System.Net.Http.Json;
using UnimedLinksWEB.Services;

namespace UnimedLinksWEB.Contrato
{
    public class SiteRepository : InterfaceSite
    {
        public HttpClient _httpClient;
        public ILogger <SiteRepository> _logger;

        public SiteRepository(HttpClient httpClient, ILogger<SiteRepository> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IEnumerable<SiteDTO>> VisualizarSites()
        {
            try
            {
                var siteDTO = await _httpClient.GetFromJsonAsync<IEnumerable<SiteDTO>>("api/Site");
                return siteDTO;
            }
            catch (Exception)
            {

                _logger.LogError("Erro ao acessar produtos : api/produtos");
                throw;
            }
        }
    }
}
