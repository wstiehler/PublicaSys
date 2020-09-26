using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicaSys.Domain.Entities
{
    public class Tabela : Base
    {
        public short Jogo { get; set; }
        public short Placar { get; set; }

        public byte MinimoTemp { get; set; }

        public short MaximoTemp { get; set; }

        public byte QuebraRecordeMin { get; set; }

        public short QuebraRecordeMax { get; set; }

        public override string ToString()
        {
            return $"{this.Id} {this.Jogo} {this.Placar} {this.MinimoTemp} {this.MaximoTemp} {this.QuebraRecordeMin} {this.QuebraRecordeMax}";
        }
    }
}
