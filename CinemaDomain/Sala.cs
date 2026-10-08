
using CinemaDomain.Base;

namespace CinemaDomain
{
    public class Sala : BaseEntity
    {
        public int Capacidade { get; set; }

        public int Numero { get; set; }
        
        public int Fileira { get; set; }

        public int Assentos { get; set; }

    }
}