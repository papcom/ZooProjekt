using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProjekt
{
    public class Djur
    {
        protected string namn;
        protected int ålder;
        protected Skötare skötare;

        public Djur(string namn, int ålder)
        {
            this.namn = namn;
            this.ålder = ålder;
        }

        public string GetNamn()
        {
            return namn;
        }

        public int GetÅlder()
        {
            return ålder;
        }

        public Skötare GetSkötare()
        {
            return skötare;
        }

        public void SättSkötare(Skötare skötare)
        {
            this.skötare = skötare;
        }
    }
}
