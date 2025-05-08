using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPGeckoAromaLibrary;

namespace WWHDHacker
{
    class Cheats
    {

        public static void RandomizeItemContent(TCPGecko tcpGecko, bool change, int duration, int delay, List<Item> allitems, List<Slot> allslots)
        {
            Random rand = new Random();
            int stop = 0;
            List<Item> currentInv = new List<Item>();
            //x, y, r
            int x;
            int y;
            int r;
            Slot[] currentButtons = new Slot[3];
            DateTime end = DateTime.Now + TimeSpan.FromMilliseconds(duration);
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, Equips.x.address), out x);
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, Equips.y.address), out y);
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, Equips.r.address), out r);
            while ((change == true && end > DateTime.Now) || stop == 0)
            {
                //Store all items we have in a list       
                foreach (Item item in allitems)
                {
                    if (item.name == "Bottle")
                    {
                        continue;
                    }

                    Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, item.slot.address), out int value);

                    if (value == item.value && stop == 0)
                    {
                        Console.WriteLine(item.name);
                        currentInv.Add(item);
                    }
                    if (value == x)
                    {
                        Console.WriteLine(item.name + " in x");
                        currentButtons[0] = item.slot;
                    }
                    if (value == y)
                    {
                        Console.WriteLine(item.name + " in y");
                        currentButtons[1] = item.slot;
                    }
                    if (value == r)
                    {
                        Console.WriteLine(item.name + " in r");
                        currentButtons[2] = item.slot;
                    }
                }
                List<int> listNumbers = new List<int>();
                int number;

                for (int i = 0; i < currentInv.Count; i++)
                {
                    do
                    {
                        number = rand.Next(0, currentInv.Count);
                        Console.WriteLine("try");
                    } while (listNumbers.Contains(number));
                    Console.WriteLine(currentInv[i].name + " gets into " + currentInv[number].name);
                    tcpGecko.Poke(TCPGecko.Datatype.u8, currentInv[number].slot.address, currentInv[i].value);
                    listNumbers.Add(number);
                }

                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, currentButtons[0].address), out x);
                tcpGecko.Poke(TCPGecko.Datatype.u8, Equips.x.address, x);
                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, currentButtons[1].address), out y);
                tcpGecko.Poke(TCPGecko.Datatype.u8, Equips.y.address, y);
                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, currentButtons[2].address), out r);
                tcpGecko.Poke(TCPGecko.Datatype.u8, Equips.r.address, r);
                if (change)
                {
                    System.Threading.Thread.Sleep(delay);
                }
                else
                {
                    System.Threading.Thread.Sleep(duration);
                }
                stop++;
            }

            for (int i = 0; i < currentInv.Count; i++)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, currentInv[i].slot.address, currentInv[i].value);
            }

            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, currentButtons[0].address), out x);
            tcpGecko.Poke(TCPGecko.Datatype.u8, Equips.x.address, x);
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, currentButtons[1].address), out y);
            tcpGecko.Poke(TCPGecko.Datatype.u8, Equips.y.address, y);
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, currentButtons[2].address), out r);
            tcpGecko.Poke(TCPGecko.Datatype.u8, Equips.r.address, r);
        }


        public static void DoorCancel(TCPGecko tcpGecko, bool enabled)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u32, 0x10976de4), out int link_ptr);
            if (link_ptr < 0x10000000)
            {
                return;
            }

            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u32, link_ptr + 2060 + 40), out int door_cancel);
            
            if (enabled)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u32, link_ptr + 2060 + 40, door_cancel | 0x4004);
            }
            else
            {
                tcpGecko.Poke(TCPGecko.Datatype.u32, link_ptr + 2060 + 40, door_cancel & ~0x4004);
            }
            
        }
        public static void ChestStorage(TCPGecko tcpGecko, bool enabled)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u32, 0x10976de4), out int link_ptr);
            if (link_ptr < 0x10000000)
            {
                return;
            }
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u32, link_ptr + 2060 + 40), out int chest_storage);

            if (enabled)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u32, link_ptr + 2060 + 40, chest_storage | 0x4);
            }
            else
            {
                tcpGecko.Poke(TCPGecko.Datatype.u32, link_ptr + 2060 + 40, chest_storage & ~0x4);
            }

        }
        public static void RestoreCollision(TCPGecko tcpGecko)
        {
            DoorCancel(tcpGecko, false);

        }
    }
}
