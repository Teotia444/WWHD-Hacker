using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWHDHacker
{
    class Memfile
    {
        public int health;
        public int magic;
        public int rupees;
        public int arrows;
        public int bombs;
        public List<int> inventory;
        public string stage;
        public int roomId;
        public int spawnId;
        public int layerId;
        public List<int> globalFlags;
        public List<int> sceneFlags;
        public List<float> position;
        public int angle;
        
        public void Load()
        {

        }
    }
}
