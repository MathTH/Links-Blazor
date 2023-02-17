using Microsoft.EntityFrameworkCore;
using UnimedSiteLinksAPI.Data;
using UnimedSiteLinksAPI.InterfaceRepository;
using UnimedSiteLinksAPI.Moldes;

namespace UnimedSiteLinksAPI.ContratosRepository
{
    public class UnimedLinksRepository : InterfaceUnimedLinks
    {

        private readonly BancoContext _bancoContext;

        public UnimedLinksRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }



        public async Task<UnimedLinksModel> AdicionarSite(UnimedLinksModel unimedLinksModel)
        {
            try
            {
                if(unimedLinksModel == null)
                {
                    throw new ArgumentNullException(nameof(unimedLinksModel));
                }

                if (SiteExiste(unimedLinksModel.NomeDoSite))
                {
                    throw new InvalidOperationException("Já existe um site cadastrado com esse nome.");
                }

                await _bancoContext.Sites.AddAsync(unimedLinksModel);
                await _bancoContext.SaveChangesAsync();

                return unimedLinksModel;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool SiteExiste(string nome)
        {
            return _bancoContext.Sites.Any(s => s.NomeDoSite == nome);
        }

        public Task<UnimedLinksModel> EditarInformacao(UnimedLinksModel unimedLinksModel, int id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<UnimedLinksModel>> VisualizarSites()
        {
            return await _bancoContext.Sites.ToListAsync();
        }

        public Task<UnimedLinksModel> VisualizarSitesPorId(int id)
        {
            throw new NotImplementedException();
        }


        public Task<bool> ApagarSite(int id)
        {
            throw new NotImplementedException();
        }
    }
}
