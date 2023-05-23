using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProjekt
{
    public class Skötare
    {
        protected string namn;
        protected List<Djur> ansvarigaDjur;

        public Skötare(string namn)
        {
            this.namn = namn;
            ansvarigaDjur = new List<Djur>();
        }

        public string GetNamn()
        {
            return namn;
        }

        public void LäggTillDjur(Djur djur)
        {
            ansvarigaDjur.Add(djur);
            djur.SättSkötare(this);
        }

        public List<Djur> GetAnsvarigaDjur()
        {
            return ansvarigaDjur;
        }
    }
}
