using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryAllocation
{
    public class Process
    {
        private String number;
        private int size;
        private Hole hole;
        private int starting;
        public Process() { }
        public Process(string num,int s){number = num;size = s;}
        public void setNumber(String n){number = n;}
        public int getStarting()
        {return starting;}
        public void setStarting(int s){starting = s;}
        public void setSize(int s){size = s;}
        public void setHole(Hole h){hole = h;}
        public Hole getHole(){return hole;}
        public int getSize(){return size;}
        public String getNumber(){return number;}
    }
}
