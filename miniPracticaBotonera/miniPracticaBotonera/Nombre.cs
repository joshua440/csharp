using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPracticaBotonera
{
    class Alumno
    {
        private String name;

        public Alumno(String name)
        {
            this.name = name;
        }

        public String getName() { return name; }

        public void setName(String name) { this.name=name; }
    }
}
