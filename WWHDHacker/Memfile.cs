using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
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
        public static int gtflagEnd = 0x1506B9C4;
        public static int hyruleflagStart = 0x1506B9C4;
        public static int hyruleflagEnd = 0x1506B9E8;
        public static int interiorflagStart = 0x1506BA0C;
        public static int interiorflagEnd = 0x1506BA30;

        public uint health;
        public uint magic;
        public uint rupees;
        public uint arrows;
        public uint bombs;
        public uint maxhealth;
        public uint maxmagic;
        public uint maxarrows;
        public uint maxbombs;

        public Dictionary<int, uint> inventory;

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

        public Memfile(uint health, uint magic, uint rupees, uint arrows, uint bombs, uint maxhealth, uint maxmagic, uint maxarrows, uint maxbombs, Dictionary<int, uint> inventory, string stage, uint roomId, uint spawnId, uint layer, 
            List<uint> globalFlags, List<uint> sceneFlags, List<uint> seaFlags, List<uint> ffFlags, List<uint> drcFlags, List<uint> fwFlags, List<uint> totgFlags, List<uint> etFlags, List<uint> wtFlags, List<uint> gtFlags, List<uint> hyruleFlags, List<uint> interiorFlags, List<float> position, uint angle)
        {
            this.health = health;
            this.magic = magic;
            this.rupees = rupees;
            this.arrows = arrows;
            this.bombs = bombs;

            this.maxhealth = maxhealth;
            this.maxmagic = maxmagic;
            this.maxarrows = maxarrows;
            this.maxbombs = maxbombs;

            
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
                0x1506b501, // max health
                0x1506b513, // max magic
                0x1506b56f, // max arrows
                0x1506b570, // max bombs
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
            for (int i = 0x1506bc78; i < 0x1506bcb8; i += 4) everythingToWatch.Add(i);
            // global flags
            for (int i = 0x1506bb24; i < 0x1506BB64; i += 4) everythingToWatch.Add(i);

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
                if(field.Name != "bomb_bag_slot" &&
                    field.Name != "quiver_slot" &&
                    field.Name != "wallet_slot" &&
                    field.Name != "magic_meter_slot")
                {
                    Slot current = (Slot)field.GetValue(null);
                    everythingToWatch.Add(current.address);
                }
            }

            //equips
            everythingToWatch.Add(0x10976e6b);
            everythingToWatch.Add(0x10976e6c);
            everythingToWatch.Add(0x10976e6d);

            List<List<int>> packed =  everythingToWatch.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / 20)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();

            List<string> raw = new List<string>();
            foreach (List<int> toSend in packed) {
                raw.AddRange(tcpGecko.PeekMultiple(TCPGecko.Datatype.u32, toSend.ToArray())); 
            }

            

            uint health = unchecked((UInt32.Parse(raw[0]) >> 24));
            uint magic = unchecked((UInt32.Parse(raw[1]) >> 24));
            uint rupees = unchecked((UInt32.Parse(raw[2]) >> 16));
            uint arrows = unchecked((UInt32.Parse(raw[3]) >> 24));
            uint bombs = unchecked((UInt32.Parse(raw[4]) >> 24));
            uint maxhealth = unchecked((UInt32.Parse(raw[5]) >> 24));
            uint maxmagic = unchecked((UInt32.Parse(raw[6]) >> 24));
            uint maxarrows = unchecked((UInt32.Parse(raw[7]) >> 24));
            uint maxbombs = unchecked((UInt32.Parse(raw[8]) >> 24));


            string stage = Encoding.ASCII.GetString(BitConverter.GetBytes(UInt32.Parse(raw[9])).Reverse().ToArray()) + Encoding.ASCII.GetString(BitConverter.GetBytes(UInt32.Parse(raw[10])).Reverse().ToArray());
            uint roomId = uint.Parse(raw[12]) >> 24;
            uint spawnId = uint.Parse(raw[13]) >> 24;
            uint layer = uint.Parse(raw[11]) >> 24;

            List<float> position = new List<float>{
                BitConverter.ToSingle(BitConverter.GetBytes(UInt32.Parse(raw[14])), 0),
                BitConverter.ToSingle(BitConverter.GetBytes(UInt32.Parse(raw[15])), 0),
                BitConverter.ToSingle(BitConverter.GetBytes(UInt32.Parse(raw[16])), 0)
            };
            uint angle = unchecked((uint)(UInt32.Parse(raw[17]) >> 16)); ;

            int currentIndex = 18;

            List<uint> sceneFlags = new List<uint>();
            for (int i = 0; i < (0x1506bcb8 - 0x1506bc78) / 4; i++)
            {
                sceneFlags.Add(uint.Parse(raw[currentIndex]));
                currentIndex++;
            }


            List<uint> globalFlags = new List<uint>();
            for (int i = 0; i < (0x1506BB64 - 0x1506bb24) / 4; i++)
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



            Dictionary<int, uint> inventory = new Dictionary<int, uint>();
            for(int i = currentIndex; i < raw.Count; i++)
            {
                inventory[everythingToWatch[i]] = UInt32.Parse(raw[i]) >> 24;
            }

            

            return new Memfile(health, magic, rupees, arrows, bombs, maxhealth, maxmagic, maxarrows, maxbombs, inventory, stage, roomId, spawnId, layer,
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
                0x1506b501, // maxhealth
                0x1506b513, // maxmagic
                0x1506b56f, // maxarrows
                0x1506b570, // maxbombs
                /*0x109763EC, // layer
                0x10978CF8, // room id
                0x109763ED, // spawn id*/
            };

            tcpGecko.PokeMultiple(TCPGecko.Datatype.u8, everythingToWatch.ToArray(), new List<uint> { this.health, this.magic, this.arrows, this.bombs, this.maxhealth, this.maxmagic, this.maxarrows, this.maxbombs}.ToArray());
            tcpGecko.Poke(TCPGecko.Datatype.u16, 0x1506b504, rupees);

            everythingToWatch.Clear();
            List<uint> inv = new List<uint>();

            foreach (var item in inventory.Keys)
            {
                everythingToWatch.Add(item);
                inv.Add(inventory[item]);
            }

            tcpGecko.PokeMultiple(TCPGecko.Datatype.u8, everythingToWatch.ToArray(), inv.ToArray());

            byte[] array = new byte[stage.Length];
            array = Encoding.ASCII.GetBytes(stage);
            byte b = byte.Parse(roomId.ToString());
            byte b2 = Convert.ToByte(spawnId.ToString());
            byte b3 = Convert.ToByte(layer.ToString());

            for (int i = 0; i < stage.Length; i++)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763F0 + i, array[i]);
            }
            tcpGecko.PokeMultiple(TCPGecko.Datatype.u8, new int[] { 0x109763F0 + stage.Length, 0x109763FA, 0x109763F9, 0x109763FB, 0x109763FC }, new uint[] { 0x0, b, b2, b3, 1 });


            everythingToWatch.Clear();
            // global flags
            //for (int i = 0x1506bb24; i < 0x1506BB64; i += 4) everythingToWatch.Add(i);

            for (int i = gsflagStart; i < gsflagEnd; i += 4) everythingToWatch.Add(i);
            for (int i = ffflagStart; i < ffflagEnd; i += 4) everythingToWatch.Add(i);
            for (int i = drcflagStart; i < drcflagEnd; i += 4) everythingToWatch.Add(i);
            for (int i = fwflagStart; i < fwflagEnd; i += 4) everythingToWatch.Add(i);
            for (int i = totgflagStart; i < totgflagEnd; i += 4) everythingToWatch.Add(i);
            for (int i = etflagStart; i < etflagEnd; i += 4) everythingToWatch.Add(i);
            for (int i = wtflagStart; i < wtflagEnd; i += 4) everythingToWatch.Add(i);
            for (int i = gtflagStart; i < gtflagEnd; i += 4) everythingToWatch.Add(i);
            for (int i = hyruleflagStart; i < hyruleflagEnd; i += 4) everythingToWatch.Add(i);
            for (int i = interiorflagStart; i < interiorflagEnd; i += 4) everythingToWatch.Add(i);



            List<uint> allFlags = new List<uint>();
            //allFlags.AddRange(globalFlags);
            allFlags.AddRange(seaFlags);
            allFlags.AddRange(ffFlags);
            allFlags.AddRange(drcFlags);
            allFlags.AddRange(fwFlags);
            allFlags.AddRange(totgFlags);
            allFlags.AddRange(etFlags);
            allFlags.AddRange(wtFlags);
            allFlags.AddRange(gtFlags);
            allFlags.AddRange(hyruleFlags);
            allFlags.AddRange(interiorFlags);

            List<List<int>> packedAddress = everythingToWatch.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / 20)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();

            List<List<uint>> packedValues = allFlags.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / 20)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();

            for (int i = 0; i < packedAddress.Count; i++)
            {
                tcpGecko.PokeMultiple(TCPGecko.Datatype.u32, packedAddress[i].ToArray(), packedValues[i].ToArray());
            }


            everythingToWatch.Clear();

            //scene flags
            for (int i = 0x1506bc78; i < 0x1506bcb8; i += 4) everythingToWatch.Add(i);
            tcpGecko.PokeMultiple(TCPGecko.Datatype.u32, everythingToWatch.ToArray(), sceneFlags.ToArray());
            
            everythingToWatch.Clear();

            //global flags
            for (int i = 0x1506bb24; i < 0x1506BB64; i += 4) everythingToWatch.Add(i);
            tcpGecko.PokeMultiple(TCPGecko.Datatype.u32, everythingToWatch.ToArray(), globalFlags.ToArray());
            
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763FC, 1);


            Thread.Sleep(2000);

            if (tcpGecko.Peek(TCPGecko.Datatype.u32, 0x109763E4) == tcpGecko.Peek(TCPGecko.Datatype.u32, 0x109763F0))//Check if a loading transition is in progress (prevents crash)
            {
                Cheats.DoorCancel(tcpGecko, true);
                tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef48, Form1.FloatToHex(position[0]));
                tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef4c, Form1.FloatToHex(position[1]));
                tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef50, Form1.FloatToHex(position[2]));
                tcpGecko.Poke(TCPGecko.Datatype.u16, 0x1096ef12, angle);
                Cheats.DoorCancel(tcpGecko, false);
            }

            
        }

        public static void Upload(string remoteFile, string localFile)
        {
            try
            {
                /* Create an FTP Request */
                FtpWebRequest ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + ConfigObject.config.wiiuIP + ":21/" + remoteFile);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential("anonymous", "whatever");
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                /* Establish Return Communication with the FTP Server */
                Stream ftpStream = ftpRequest.GetRequestStream();
                /* Open a File Stream to Read the File for Upload */
                FileStream localFileStream = new FileStream(localFile, FileMode.Open);
                /* Buffer for the Downloaded Data */
                byte[] byteBuffer = new byte[2048];
                int bytesSent = localFileStream.Read(byteBuffer, 0, 2048);
                /* Upload the File by Sending the Buffered Data Until the Transfer is Complete */
                try
                {
                    while (bytesSent != 0)
                    {
                        ftpStream.Write(byteBuffer, 0, bytesSent);
                        bytesSent = localFileStream.Read(byteBuffer, 0, 2048);
                    }
                }
                catch (WebException ex) { Console.WriteLine(((FtpWebResponse)ex.Response).StatusDescription); }
                /* Resource Cleanup */
                localFileStream.Close();
                ftpStream.Close();
                ftpRequest = null;
            }
            catch (WebException ex) { Console.WriteLine(((FtpWebResponse)ex.Response).StatusDescription); }
            return;
        }

        public static string ListFolders(string path, int timeout)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + ConfigObject.config.wiiuIP + ":21/" + path);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Timeout = timeout;
            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("anonymous", "whatever");

            FtpWebResponse response = null;
            try
            {
                response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                var items = reader.ReadToEnd();
                reader.Close();
                response.Close();
                return items;

            }
            catch (System.Net.WebException e)
            {

                response = (FtpWebResponse)e.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    return "DirNotFound";
                }
                else
                {
                    return "ServerUnk";
                }
            }
        }

        public static void Download(string remoteFile, string localFile)
        {
            try { 
            /* Create an FTP Request */
                FtpWebRequest ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://" + ConfigObject.config.wiiuIP + ":21/" + remoteFile);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential("anonymous", "whatever");
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                /* Establish Return Communication with the FTP Server */
                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Get the FTP Server's Response Stream */
                Stream ftpStream = ftpResponse.GetResponseStream();
                /* Open a File Stream to Write the Downloaded File */
                FileStream localFileStream = new FileStream(localFile, FileMode.Create);
                /* Buffer for the Downloaded Data */
                byte[] byteBuffer = new byte[2048];
                int bytesRead = ftpStream.Read(byteBuffer, 0, 2048);
                /* Download the File by Writing the Buffered Data Until the Transfer is Complete */
                try
                {
                    while (bytesRead > 0)
                    {
                        localFileStream.Write(byteBuffer, 0, bytesRead);
                        bytesRead = ftpStream.Read(byteBuffer, 0, 2048);
                    }
                }
                catch (WebException ex)
                {
                    var a = ex.Response as FtpWebResponse;
                    Console.WriteLine(a.StatusCode);
                    return;

                }

                /* Resource Cleanup */
                localFileStream.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch
            {
                return;
            }
            return;
        }

        public static Memfile FromSaveFile()
        {
            //file 1 start : 0x0
            //file 2 start : 0xA94
            //file 3 start : 0x1528

            //stage offset : 0x30 

            //items offset : 0x3C
            //address : 0x1506b53c + item

            //global flag offset : 0x610
            //sea : 0x370 + 0x24 for next flags




            return null;
        }
    }
}
