using UnimedSiteLinksAPI.Moldes;

namespace UnimedSiteLinksAPI.InterfaceRepository
{
    public interface InterfaceUnimedLinks
    {
      
        //Adicionar Site
        Task<UnimedLinksModel> AdicionarSite(UnimedLinksModel unimedLinksModel);

        //Visualizar todos os sites
        Task<List<UnimedLinksModel>> VisualizarSites();

        //Pesquisar um site por Id
        Task<UnimedLinksModel> VisualizarSitesPorId(int id);

        //Editar alguma informação de um site
        Task<UnimedLinksModel> EditarInformacao(UnimedLinksModel unimedLinksModel, int id);

        //Excluir Site
        Task<bool> ApagarSite(int id);



    }
}
