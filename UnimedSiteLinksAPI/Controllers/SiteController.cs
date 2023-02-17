using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteModels.DTOS;
using UnimedSiteLinksAPI.InterfaceRepository;
using UnimedSiteLinksAPI.Mappings;
using UnimedSiteLinksAPI.Moldes;

namespace UnimedSiteLinksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteController : ControllerBase
    {
        public readonly InterfaceUnimedLinks _interfaceUnimedLinks;

        public SiteController(InterfaceUnimedLinks interfaceUnimedLinks)
        {
            _interfaceUnimedLinks = interfaceUnimedLinks;
        }

        [HttpPost]
        public async Task<ActionResult<UnimedLinksModel>> Cadastrar([FromBody] UnimedLinksModel unimedLinksModel)
        {
            UnimedLinksModel site = await _interfaceUnimedLinks.AdicionarSite(unimedLinksModel);
            return Ok(site);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SiteDTO>>> BuscarTodos()
        {
            try
            {
                var sites = await _interfaceUnimedLinks.VisualizarSites();
                if(sites == null)
                {
                    return NotFound("Nenhum site foi encontrado");
                }
                else
                {
                    var sitesDTO = sites.ConverterSiteParaDto();
                    return Ok(sitesDTO);    
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }
    }
}
