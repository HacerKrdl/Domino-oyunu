using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoÖdev
{
    class Class1
    {
    }
    interface IYetenek
    {

    }
    public class Dominoes
    {
        public string oyuncu1;
        public string oyuncu2;
        private int tasDegeri;
        private string Tas;

        public Dominoes()
        {
            List<Dominoes> dominoes = new List<Dominoes>();
            string[] tasDegeri = {
            "0,1","0,2","0,3","0,4","0,5","0,6",
            "1,2","1,3","1,4","1,5","1,6",
            "2,3","2,4","2,5","2,6",
            "3,4","3,5","3,6",
            "4,5","4,6",
            "5,6",
            "0,0","1,1","2,2", "3,3", "4,4","5,5","6,6"
            };

        }
        
    }
}
