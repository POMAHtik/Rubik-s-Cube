using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try2
{
    class Verge
    {
        public Square top1;
        public Square top2;
        public Square top3;
        public Square center1;
        public Square center2;
        public Square center3;
        public Square bottom1;
        public Square bottom2;
        public Square bottom3;
        public Verge()
        {

        }

        public void Init()
        {
            
            top1.Init();
            top2.Init();
            top3.Init();
            center1.Init();
            center2.Init();
            center3.Init();
            bottom1.Init();
            bottom2.Init();
            bottom3.Init();
        }
    }
}
