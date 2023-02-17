using SiteModels.DTOS;

namespace UnimedLinksWEB.Services
{
    public interface InterfaceSite
    {
        Task<IEnumerable<SiteDTO>> VisualizarSites();
    }
}
