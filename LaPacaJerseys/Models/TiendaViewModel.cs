using Microsoft.AspNetCore.Mvc;

namespace LaPacaJerseys.Models
{
    public class TiendaViewModel
    {
        public List<Jersey> Jerseys { get; set; }

        public TiendaViewModel()
        {
            Jerseys = new List<Jersey>();
        }
    }
}
