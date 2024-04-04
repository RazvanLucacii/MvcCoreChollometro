using MvcCoreChollometro.Data;
using MvcCoreChollometro.Models;

namespace MvcCoreChollometro.Repositories
{
    public class RepositoryChollometro
    {
        private ChollometroContext context;

        public RepositoryChollometro(ChollometroContext context)
        {
            this.context = context;
        }

        public List<Chollo> GetChollos()
        {
            return this.context.Chollos.ToList();
        }
    }
}
