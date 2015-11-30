using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace HojaPersonaje2._0
{
    class Album
    {
        private ArrayList pjList;
        private int showIndex;

        public Album()
        {
            pjList = new ArrayList();
            showIndex = 0;
        }
        public Album(ArrayList pjList)
        {
            this.pjList=pjList;
            showIndex = 0;
        }

        public ArrayList getpjList()
        {
            return pjList;
        }

        public void setpjList(ArrayList pjList)
        {
            if (pjList != null)
            {
                this.pjList = pjList; 
            }
        }

        public void addpj(Personaje pj)
        {
            if (pj != null && !pjList.Contains(pj))
            {
                pjList.Add(pj); 
            }
        }

        public void addPjList(ArrayList pjList)
        {
            foreach (Personaje pj in pjList)
            {
                addpj(pj);
            }
        }


    }
}
