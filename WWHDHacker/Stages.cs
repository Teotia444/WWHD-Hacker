using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWHDHacker
{
    class Stage
    {
        public string usingName;
        public string stage;
        public int dungeonId;
        public bool dungeon;
        public Stage(string usingName, string stage, int dungeonId, bool dungeon = false)
        {
            this.usingName = usingName;
            this.stage = stage;
            this.dungeonId = dungeonId;
            this.dungeon = dungeon;
        }
    }

    class Room
    {
        public Stage stage;
        public int roomId;
        public Room(Stage stage, int roomId)
        {
            this.stage = stage;
            this.roomId = roomId;
        }
    }

    class Spawn
    {
        public Room room;
        public int spawnId;
        public int layer;
        public Spawn(Room room, int spawnId, int layer)
        {
            this.room = room;
            this.spawnId = spawnId;
            this.layer = layer;
        }
    }

    class Stages
    {
        public static List<Stage> islands = new List<Stage>(){
            new Stage("Forsaken Fortress", "sea", 4),
            new Stage("Star Island", "sea", 0),
            new Stage("Northern Fairy Island", "sea", 0),
            new Stage("Gale Isle", "sea", 6),
            new Stage("Cresent Moon Island", "sea", 0),
            new Stage("Seven Star Isles", "sea", 0),
            new Stage("Overlook Island", "sea", 0),
            new Stage("Four-Eye Reef", "sea", 0),
            new Stage("Mother and Child Isles", "sea", 0),
            new Stage("Spectacle Island", "sea", 0),
            new Stage("Windfall Island", "sea", 0),
            new Stage("Pawprint Isle", "sea", 0),
            new Stage("Dragon Roost Island", "sea", 1),
            new Stage("Flight Control Platform", "sea", 0),
            new Stage("Western Fairy Island", "sea", 0),
            new Stage("Rock Spire Isle", "sea", 0),
            new Stage("Tingle Island", "sea", 0),
            new Stage("Northern Triangle Isle", "sea", 0),
            new Stage("Eastern Fairy Island", "sea", 0),
            new Stage("Fire Mountain", "sea", 0),
            new Stage("Star Belt Archipelago", "sea", 0),
            new Stage("Three-Eye Reef", "sea", 0),
            new Stage("Greatfish Isle", "sea", 0),
            new Stage("Cyclops Reef", "sea", 0),
            new Stage("Six-Eye Reef", "sea", 0),
            new Stage("Tower of the Gods", "sea", 3),
            new Stage("Eastern Triangle Isle", "sea", 0),
            new Stage("Thorned Fairy Island", "sea", 0),
            new Stage("Needle Rock Isle", "sea", 0),
            new Stage("Islet of Steel", "sea", 0),
            new Stage("Stonewatcher Island", "sea", 0),
            new Stage("Southern Triangle Isle", "sea", 0),
            new Stage("Link's Oasis", "sea", 0),
            new Stage("Bomb Island", "sea", 0),
            new Stage("Bird's Peak Rock", "sea", 0),
            new Stage("Diamond Steppe Island", "sea", 0),
            new Stage("Five-Eye Reef", "sea", 0),
            new Stage("Shark Island", "sea", 0),
            new Stage("Southern Fairy Island", "sea", 0),
            new Stage("Ice Ring Isle", "sea", 0),
            new Stage("Forest Haven", "sea", 2),
            new Stage("Cliff Plateau Isles", "sea", 0),
            new Stage("Horseshoe Island", "sea", 0),
            new Stage("Outset Island", "sea", 0),
            new Stage("Headstone Island", "sea", 5),
            new Stage("Two-Eye Reef", "sea", 0),
            new Stage("Angular Isles", "sea", 0),
            new Stage("Boating Course", "sea", 0),
            new Stage("Five-Star Isles", "sea", 0),
            new Stage("Hyrule", "Hyroom", 7)
        };


    }




}
