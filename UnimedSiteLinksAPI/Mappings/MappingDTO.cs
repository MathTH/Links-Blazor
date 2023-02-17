using SiteModels.DTOS;
using UnimedSiteLinksAPI.Moldes;

namespace UnimedSiteLinksAPI.Mappings
{
    public static class MappingDTO
    {

        public static IEnumerable<SiteDTO> ConverterSiteParaDto(this IEnumerable <UnimedLinksModel> sites)
        {
            return (from site in sites
                    select new SiteDTO
                    { 
                            Id  = site.Id,
                            NomeDoSite = site.NomeDoSite,
                            ImagemDoSite = site.ImagemDoSite,
                            DescricaoDoSite = site.DescricaoDoSite,
                            UrlDoSite = site.UrlDoSite,
                    
                    }).ToList();

        }


     


    }
}
