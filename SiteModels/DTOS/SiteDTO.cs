using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteModels.DTOS
{
    public class SiteDTO
    {
        public int Id { get; set; }
        public string? NomeDoSite { get; set; }
        public string? ImagemDoSite { get; set; }
        public string? DescricaoDoSite { get; set; }
        public string? UrlDoSite { get; set; }
    }
}
