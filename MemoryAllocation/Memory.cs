using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryAllocation
{
    public class Memory
    {
        LinkedList<Hole> holes = new LinkedList<Hole>();
        LinkedList<Process> processes = new LinkedList<Process>();
        LinkedList<Process> waitingProcesses = new LinkedList<Process>();
        Boolean compaction = false;
        String algorithm = "First Fit";
        public Memory(){ }
        public Memory(String alg){algorithm = alg;}
        public void setAlgorithm(String alg){algorithm = alg;}
        public void setCompaction(Boolean x){compaction = x;}
        public Boolean getCompaction(){return compaction;}
        public LinkedList<Process> getProcesses(){return processes;}
        public String getAlgorithm(){return algorithm;}
        public void addHole(Hole h){holes.AddFirst(h);}
        public void addProcess(Process p){processes.AddFirst(p);}
        public void clear(){holes.Clear();processes.Clear();}
        public LinkedList<Hole> getHoles(){return holes;}
        public Hole checkAdjacency(Hole h)
        {
            for (LinkedListNode<Hole> it = holes.First; it != null; it = it.Next)
            {
                if (it.Value.getSize() + it.Value.getStarting() == h.getStarting())
                {
                    it.Value.setSize(it.Value.getSize() + h.getSize());
                    it.Value.setFreeSpace(it.Value.getSize());
                    it.Value.setSamllestSpace(it.Value.getSize());
                    it.Value.setFreeProcess(it.Value.getSize());
                    return it.Value;
                }
                else if (h.getStarting() + h.getSize() == it.Value.getStarting())
                {
                    it.Value.setSize(it.Value.getSize() + h.getSize());
                    it.Value.setStarting(h.getStarting());
                    it.Value.setFreeSpace(it.Value.getSize());
                    it.Value.setSamllestSpace(it.Value.getSize());
                    return it.Value;
                }
            }
            return null;
        }
        public bool noHoles()
        {
            if (!holes.Any())
                return true;
            else
                return false;
        }
        public bool checkValidity(Hole h)
        {
            bool ok = true;
            for (LinkedListNode<Hole> it = holes.First; it != null; it = it.Next)
            {
                if (h.getStarting() < it.Value.getStarting())
                {
                    if (h.getSize() + h.getStarting() > it.Value.getStarting())
                    {
                        ok = false;
                    }
                }
                else
                {
                    if (it.Value.getSize() + it.Value.getStarting() > h.getStarting())
                    {
                        ok = false;
                    }
                }
            }
            return ok;
        }
        public bool firstFit(Process p)
        {
            List<Hole> SortedList = holes.OrderBy(o => o.getStarting()).ToList();
            int allocatedSize = p.getSize();
            foreach (var hole in SortedList)
            {
                if (allocatedSize <= hole.getSpace() && hole.getNumber() >= 0)
                {
                    bool valid = hole.placeFirstFit(p);
                    if (valid)
                    {
                        return true;
                    }
                }
            }
            waitingProcesses.AddFirst(p);
            return false;
        }
        public bool bestFit(Process p)
        {
            List<Hole> SortedList = holes.OrderBy(o => o.getSmallestSpace()).ToList();
            SortedList.Sort(delegate (Hole c1, Hole c2) {
                if (c1.getSmallestSpace() == c2.getSmallestSpace())
                    return c1.getStarting().CompareTo(c2.getStarting());
                return c1.getSmallestSpace().CompareTo(c2.getSmallestSpace());
            });
            int allocatedSize = p.getSize();
            foreach (var hole in SortedList)
            {
                if (allocatedSize <= hole.getSpace()&& hole.getNumber()>=0)
                {
                    bool valid = hole.placeBestFit(p);
                    if (valid)
                    {
                        return true;
                    }
                }
            }
            waitingProcesses.AddFirst(p);
            return false;
        }
        public bool worstFit(Process p)
        {
            List<Hole> SortedList = holes.OrderBy(o => o.getSmallestSpace()).ToList();
            SortedList.Sort(delegate (Hole c1, Hole c2) {
                if (c1.getSmallestSpace() == c2.getSmallestSpace())
                    return c2.getStarting().CompareTo(c1.getStarting());
                return c1.getSmallestSpace().CompareTo(c2.getSmallestSpace());
            });
            SortedList.Reverse();
            int allocatedSize = p.getSize();
            foreach (var hole in SortedList)
            {
                if (allocatedSize <= hole.getSpace() && hole.getNumber() >= 0)
                {
                    bool valid = hole.placeWorstFit(p);
                    if (valid)
                    {
                        return true;
                    }
                }
            }
            waitingProcesses.AddFirst(p);
            return false;
        }
        public void fillGaps()
        {
            int lastchecked = 0;
            List<Hole> SortedList = holes.OrderBy(o => o.getStarting()).ToList();
            foreach(var hole in SortedList)
            {
                if (hole.getStarting()>lastchecked)
                {
                    Hole temp = new Hole(-1,lastchecked,hole.getStarting()-lastchecked);
                    holes.AddFirst(temp);
                }
                lastchecked = hole.getStarting() + hole.getSize();
            }
        }
        public void deallocate(int n)
        {
            var process = processes.FirstOrDefault(x => x.getNumber().Equals(n.ToString()));
            Hole h = process.getHole();
            process.setNumber("free");
            h.removeAdjacent();
            processes.Remove(process);
        }
        public void compact()
        {
            int totalfree = 0;
            int shifting = 0;
            int finish = 0;
            List<Hole> SortedList = holes.OrderBy(o => o.getStarting()).ToList();
            foreach (var hole in SortedList)
            {
                if(hole.getNumber()>=0)
                {
                    hole.setStarting(hole.getStarting() - shifting);
                    shifting += hole.compactHole(shifting);
                    totalfree = shifting;
                    finish = hole.getStarting() + hole.getSize();
                }
                else
                {
                    hole.setStarting(hole.getStarting() - shifting);
                    hole.updateReserved(shifting);
                    finish = hole.getStarting() + hole.getSize();
                }
                if (hole.getSize() == 0)
                    holes.Remove(hole);
            }
            Hole free = new Hole(0,finish,totalfree);
            holes.AddLast(free);
        }
    }
}
