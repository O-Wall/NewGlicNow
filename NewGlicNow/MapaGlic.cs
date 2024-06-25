using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGlicNow
{
    public  class MapaGlic
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int PreCafe {  get; set; }
        public int PosCafe { get; set;}
        public int PreAlmoco { get; set; }
        public int PosAlmoco { get; set; }
        public int PreJantar { get; set; }
        public int PosJantar { get; set; }
        public int BasalMatutino { get; set; }
        public int BasalNoturno { get; set; }
        public string Observacao { get; set; }
        public int UsuarioId { get; set; }

        public MapaGlic()
        {
            Id = 0;
            Data = DateTime.MinValue;
            PreCafe = 0;
            PosCafe = 0;
            PreAlmoco = 0;
            PosAlmoco = 0;
            PreJantar = 0;
            PosJantar = 0;
            BasalMatutino = 0;
            BasalNoturno = 0;
            Observacao = string.Empty;
            UsuarioId = 0;
        }
    }
}
