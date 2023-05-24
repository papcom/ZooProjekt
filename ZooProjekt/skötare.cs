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
        // Skötare-constructor
        public Skötare(string namn)
        {
            this.namn = namn;
            ansvarigaDjur = new List<Djur>();
        }

        public string GetNamn()
        {
            return namn;
        }
        // Funktion som lägger till djur i ansvarigaDjur-listan för skötaren
        public void LäggTillDjur(Djur djur)
        {
            ansvarigaDjur.Add(djur);
            djur.SättSkötare(this);
        }
        // Funktion som hämtar ansvariga djur ur listan ansvarigaDjur för skötaren
        public List<Djur> GetAnsvarigaDjur()
        {
            return ansvarigaDjur;
        }
    }
}
