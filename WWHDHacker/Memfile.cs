using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TCPGeckoAromaLibrary;

namespace WWHDHacker
{
    class Memfile
    {
        public static int gsflagStart = 0x1506B880;
        public static int gsflagEnd = 0x1506B8A4;
        public static int ffflagStart = 0x1506B8C8;
        public static int ffflagEnd = 0x1506B8EC;
        public static int drcflagStart = 0x1506B8EC;
        public static int drcflagEnd = 0x1506B914;
        public static int fwflagStart = 0x1506B914;
        public static int fwflagEnd = 0x1506B934;
        public static int totgflagStart = 0x1506B934;
        public static int totgflagEnd = 0x1506B958;
        public static int etflagStart = 0x1506B958;
        public static int etflagEnd = 0x1506B980;
        public static int wtflagStart = 0x1506B980;
        public static int wtflagEnd = 0x1506B9A0;
        public static int gtflagStart = 0x1506B9A0;
        public static int gtflagEnd = 0x1506B9C2;
        public static int hyruleflagStart = 0x1506B9C2;
        public static int hyruleflagEnd = 0x1506B9E6;
        public static int interiorflagStart = 0x1506BA0C;
        public static int interiorflagEnd = 0x1506BA2E;

        public uint health;
        public uint magic;
        public uint rupees;
        public uint arrows;
        public uint bombs;

        public Dictionary<int, int> inventory;

        public string stage;
        public uint roomId;
        public uint spawnId;
        public uint layer;

        public List<uint> globalFlags;
        public List<uint> sceneFlags;
        public List<uint> seaFlags;
        public List<uint> ffFlags;
        public List<uint> drcFlags;
        public List<uint> fwFlags;
        public List<uint> totgFlags;
        public List<uint> etFlags;
        public List<uint> wtFlags;
        public List<uint> gtFlags;
        public List<uint> hyruleFlags;
        public List<uint> interiorFlags;

        public List<float> position;
        public uint angle;

        public Memfile(uint health, uint magic, uint rupees, uint arrows, uint bombs, Dictionary<int, int> inventory, string stage, uint roomId, uint spawnId, uint layer, 
            List<uint> globalFlags, List<uint> sceneFlags, List<uint> seaFlags, List<uint> ffFlags, List<uint> drcFlags, List<uint> fwFlags, List<uint> totgFlags, List<uint> etFlags, List<uint> wtFlags, List<uint> gtFlags, List<uint> hyruleFlags, List<uint> interiorFlags, List<float> position, uint angle)
        {
            this.health = health;
            this.magic = magic;
            this.rupees = rupees;
            this.arrows = arrows;
            this.bombs = bombs;
            
            this.stage = stage;
            this.roomId = roomId;
            this.spawnId = spawnId;
            this.layer = layer;

            this.position = position;
            this.angle = angle;

            this.globalFlags = globalFlags;
            this.sceneFlags = sceneFlags;
            this.seaFlags = seaFlags;
            this.ffFlags = ffFlags;
            this.drcFlags = drcFlags;
            this.fwFlags = fwFlags;
            this.totgFlags = totgFlags;
            this.etFlags = etFlags;
            this.wtFlags = wtFlags;
            this.gtFlags = gtFlags;
            this.hyruleFlags = hyruleFlags;
            this.interiorFlags = interiorFlags;
            this.inventory = inventory;

        }

        public static Memfile Create(TCPGecko tcpGecko)
        {
            List<int> everythingToWatch = new List<int>
            {
                0x1506b503, // health
                0x1506b514, // magic
                0x1506b504, // rupees
                0x1506b569, // arrows
                0x1506b56a, // bombs
                0x109763E4, // stage 1st half
                0x109763E8, // stage 2nd half
                0x109763EC, // layer
                0x10978CF8, // room id
                0x109763ED, // spawn id
                0x1096ef48, // x
                0x1096ef4c, // y
                0x1096ef50, // z
                0x1096ef12, // angle
            };

            //scene flags
            for (int i = 0x1506bc78; i < 0x1506bcb7; i += 4) everythingToWatch.Add(i);
            // global flags
            for (int i = 0x1506bb24; i < 0x1506BB63; i += 4) everythingToWatch.Add(i);

            for (int i = gsflagStart; i < gsflagEnd; i+=4) everythingToWatch.Add(i);
            for (int i = ffflagStart; i < ffflagEnd; i+=4) everythingToWatch.Add(i);
            for (int i = drcflagStart; i < drcflagEnd; i+=4) everythingToWatch.Add(i);
            for (int i = fwflagStart; i < fwflagEnd; i+=4) everythingToWatch.Add(i);
            for (int i = totgflagStart; i < totgflagEnd; i+=4) everythingToWatch.Add(i);
            for (int i = etflagStart; i < etflagEnd; i+=4) everythingToWatch.Add(i);
            for (int i = wtflagStart; i < wtflagEnd; i+=4) everythingToWatch.Add(i);
            for (int i = gtflagStart; i < gtflagEnd; i+=4) everythingToWatch.Add(i);
            for (int i = hyruleflagStart; i < hyruleflagEnd; i+=4) everythingToWatch.Add(i);
            for (int i = interiorflagStart; i < interiorflagEnd; i+=4) everythingToWatch.Add(i);

            FieldInfo[] staticFields = typeof(Slots).GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (FieldInfo field in staticFields)
            {
                Slot current = (Slot)field.GetValue(null);
                everythingToWatch.Add(current.address);
            }

            List<List<int>> packed =  everythingToWatch.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / 20)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();

            Console.WriteLine(everythingToWatch.Count);

            List<string> raw = new List<string>();
            foreach (List<int> toSend in packed) {
                raw.AddRange(tcpGecko.PeekMultiple(TCPGecko.Datatype.u32, toSend.ToArray())); 
            }

            uint health = unchecked((UInt32.Parse(raw[0]) >> 24));
            uint magic = unchecked((UInt32.Parse(raw[1]) >> 24));
            uint rupees = unchecked((UInt32.Parse(raw[2]) >> 16));
            uint arrows = unchecked((UInt32.Parse(raw[3]) >> 24));
            uint bombs = unchecked((UInt32.Parse(raw[4]) >> 24));



            string stage = Encoding.ASCII.GetString(BitConverter.GetBytes(UInt32.Parse(raw[5])).Reverse().ToArray()) + Encoding.ASCII.GetString(BitConverter.GetBytes(UInt32.Parse(raw[6])).Reverse().ToArray());
            uint roomId = uint.Parse(raw[8]) >> 24;
            uint spawnId = uint.Parse(raw[9]) >> 24;
            uint layer = uint.Parse(raw[7]) >> 24;

            List<float> position = new List<float>{
                BitConverter.ToSingle(BitConverter.GetBytes(UInt32.Parse(raw[10])), 0),
                BitConverter.ToSingle(BitConverter.GetBytes(UInt32.Parse(raw[11])), 0),
                BitConverter.ToSingle(BitConverter.GetBytes(UInt32.Parse(raw[12])), 0)
            };
            uint angle = unchecked((uint)(UInt32.Parse(raw[13]) >> 16)); ;

            int currentIndex = 14;

            List<uint> sceneFlags = new List<uint>();
            for (int i = 0; i < (0x1506bcb7 - 0x1506bc78) / 4; i++)
            {
                sceneFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }


            List<uint> globalFlags = new List<uint>();
            for (int i = 0; i < (0x1506BB63 - 0x1506bb24) / 4; i++)
            {
                globalFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }
            List<uint> seaFlags = new List<uint>();
            for (int i = 0; i < (gsflagEnd - gsflagStart) / 4; i++)
            {
                seaFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }
            List<uint> ffFlags = new List<uint>();
            for (int i = 0; i < (ffflagEnd - ffflagStart) / 4; i++)
            {
                ffFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }
            List<uint> drcFlags = new List<uint>();
            for (int i = 0; i < (drcflagEnd - drcflagStart) / 4; i++)
            {
                drcFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }
            List<uint> fwFlags = new List<uint>();
            for (int i = 0; i < (fwflagEnd - fwflagStart) / 4; i++)
            {
                fwFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }

            List<uint> totgFlags = new List<uint>();
            for (int i = 0; i < (totgflagEnd - totgflagStart) / 4; i++)
            {
                totgFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }
            List<uint> etFlags = new List<uint>();
            for (int i = 0; i < (etflagEnd - etflagStart) / 4; i++)
            {
                etFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }
            List<uint> wtFlags = new List<uint>();
            for (int i = 0; i < (wtflagEnd - wtflagStart) / 4; i++)
            {
                wtFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }
            List<uint> gtFlags = new List<uint>();
            for (int i = 0; i < (gtflagEnd - gtflagStart) / 4; i++)
            {
                gtFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }
            List<uint> hyruleFlags = new List<uint>();
            for (int i = 0; i < (hyruleflagEnd - hyruleflagStart) / 4; i++)
            {
                hyruleFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }
            List<uint> interiorFlags = new List<uint>();
            for (int i = 0; i < (interiorflagEnd - interiorflagStart) / 4; i++)
            {
                interiorFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }

            
            Dictionary<int, int> inventory = new Dictionary<int, int>();
            for(int i = currentIndex; i < raw.Count; i++)
            {
                inventory[everythingToWatch[i]] = unchecked((int)UInt32.Parse(raw[i]) >> 24);
            }


            return new Memfile(health, magic, rupees, arrows, bombs, inventory, stage, roomId, spawnId, layer, 
                globalFlags, sceneFlags, seaFlags, ffFlags, drcFlags, fwFlags, totgFlags, etFlags, wtFlags, gtFlags, hyruleFlags, interiorFlags,
                position, angle);



        }

        public void Load(TCPGecko tcpGecko)
        {
            List<int> everythingToWatch = new List<int>
            {
                0x1506b503, // health
                0x1506b514, // magic
                0x1506b569, // arrows
                0x1506b56a, // bombs
                0x109763EC, // layer
                0x10978CF8, // room id
                0x109763ED, // spawn id
            };

            tcpGecko.PokeMultiple(TCPGecko.Datatype.u8, everythingToWatch.ToArray(), new List<uint> { this.health, this.magic, this.arrows, this.bombs, this.layer, this.roomId, this.spawnId}.ToArray());
            everythingToWatch = new List<int>
            {              
                0x1506b504, // rupees
                0x1096ef12, // angle
            };
            tcpGecko.PokeMultiple(TCPGecko.Datatype.u16, everythingToWatch.ToArray(), new List<uint> { this.rupees, this.angle }.ToArray());


            everythingToWatch = new List<int> {
                0x1096ef48, // x
                0x1096ef4c, // y
                0x1096ef50, // z
            };

            byte[] array = new byte[stage.Length];
            array = Encoding.ASCII.GetBytes(stage);

            for (int i = 0; i < stage.Length; i++)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763F0 + i, array[i]);
            }
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763F0 + stage.Length, 0x0);

            tcpGecko.PokeMultiple(TCPGecko.Datatype.f32, everythingToWatch.ToArray(), new List<uint> { (uint)Form1.FloatToHex(position[0]), (uint)Form1.FloatToHex(position[1]), (uint)Form1.FloatToHex(position[2]) }.ToArray());
        }
    }
}
