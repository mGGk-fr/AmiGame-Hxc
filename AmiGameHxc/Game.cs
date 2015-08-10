using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmiGameHxc
{
    class Game
    {
        private ArrayList fileList = new ArrayList();
        private int numberOfDisks = 1;
        private string gameName;

        public Game(string rGameName, string firstFileName)
        {
            this.gameName = rGameName;
            this.fileList.Add(firstFileName);
        }

        public void addDiskFile(string fileName)
        {
            this.fileList.Add(fileName);
            this.numberOfDisks++;
        }

        public string getGameName()
        {
            return this.gameName;
        }

        public int getNumberOfDisk()
        {
            return this.numberOfDisks;
        }

        public ArrayList getFileDiskList()
        {
            return this.fileList;
        }

    }
}
