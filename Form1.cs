using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace BVEditor
{
    public partial class BVEditor : Form
    {
        public BVEditor()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();

        void writeBackground(string background, int bytes) //bytes should be little endian
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(sfd.FileName));

            if (bgList.Text == background)
            {
                bw.Seek(0x1BC, SeekOrigin.Begin);
                bw.Write(bytes);
            }

            bw.Close();
        }

        void writeBgm(string bgm, int bgm_value)
        {
            BinaryWriter bw2 = new BinaryWriter(File.OpenWrite(sfd.FileName));

            if (bgmList.Text == bgm)
            {
                bw2.Seek(0x1F0, SeekOrigin.Begin);
                bw2.Write((ushort)bgm_value);
            }

            bw2.Close();
        }

        void writeWeather(string weather, int w_value) //Thanks to Hallowpape on Youtube!
        {
            BinaryWriter bw2 = new BinaryWriter(File.OpenWrite(sfd.FileName));

            if (weatherList.Text == weather)
            {
                bw2.Seek(0x1BA, SeekOrigin.Begin);
                bw2.Write((ushort)w_value);
            }

            bw2.Close();
        }

        private void saveBV_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] battleVideo = System.IO.File.ReadAllBytes(ofd.FileName);

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(sfd.FileName, battleVideo);

                    /*Lots of thanks to EpicLolz53 on youtube!*/

                    writeBackground("00 00 00 00 - Nothing", 0x00000000);
                    writeBackground("01 00 01 01 - Trees and Mountain (Broken Sky)", 0x01010001);
                    writeBackground("02 00 02 02 - Mechanical Room", 0x02020002);
                    writeBackground("03 00 03 03 - Generic Cave", 0x03030003);
                    writeBackground("04 00 04 04 - Forest", 0x04040004);
                    writeBackground("05 00 05 05 - Beach (Broken Sky)", 0x05050005);
                    writeBackground("06 00 06 06 - Rocky Terrain (Broken Sky)", 0x06060006);
                    writeBackground("07 00 07 07 - Generic", 0x07070007);
                    writeBackground("08 00 08 08 - City (Broken Sky)", 0x08080008);
                    writeBackground("09 00 09 09 - Fence and House (Broken Sky)", 0x09090009);
                    writeBackground("0A 00 0A 0A - Battle Maison", 0x0A0A000A);
                    writeBackground("0B 00 00 0B - PSS Colosseum", 0x0B00000B);
                    writeBackground("0C 00 0C 0C - River (Broken Sky)", 0x0C0C000C);
                    writeBackground("0D 00 0D 0D - Ocean (Broken Sky)", 0x0D0D000D);
                    writeBackground("0E 00 0E 0E - Ice Cavern", 0x0E0E000E);
                    writeBackground("0F 00 0F 0F - Cavern", 0x0F0F000F);
                    writeBackground("10 00 10 10 - White Tiled Room with Tan Ring and Gym Symbol on Floor", 0x10100010);
                    writeBackground("11 00 11 11 - White Tiled Room with Red-Orange Ring and Gym Symbol on Floor", 0x11110011);
                    writeBackground("12 00 12 12 - White Tiled Room with Yellow Ring and Gym Symbol on Floor", 0x12120012);
                    writeBackground("13 00 13 13 - White Tiled Room with Orange Ring and Gym Symbol on Floor", 0x13130013);
                    writeBackground("14 00 14 14 - White Tiled Room with Grey Ring and Gym Symbol on Floor", 0x14140014);
                    writeBackground("15 00 15 15 - White Tiled Room with Blue Ring and Gym Symbol on Floor", 0x15150015);
                    writeBackground("16 00 16 16 - White Tiled Room with Red Ring and Gym Symbol on Floor", 0x16160016);
                    writeBackground("17 00 17 17 - White Tiled Room with Light Blue Ring and Gym Symbol on Floor", 0x17170017);
                    writeBackground("18 00 00 18 - Elite Four Sidney", 0x18000018);
                    writeBackground("19 00 00 19 - Elite Four Glacia", 0x19000019);
                    writeBackground("1A 00 00 1A - Elite Four Phoebe", 0x1A00001A);
                    writeBackground("1B 00 00 1B - Elite Four Drake", 0x1B00001B);
                    writeBackground("1C 00 00 1C - Champion Battle", 0x1C00001C);
                    writeBackground("1D 00 1D 1D - White Tiled Room with Grey Ring on Floor", 0x1D1D001D);
                    writeBackground("1E 00 00 1E - Special PSS Colosseum (Worlds? Nationals? Regionals?)", 0x1E00001E);
                    writeBackground("1F 00 00 1F - PSS Colesseum, Battle at Worlds! (Final Battle?)", 0x1F00001F);
                    writeBackground("20 00 00 20 - Gym Leader Roxanne", 0x20000020);
                    writeBackground("21 00 00 21 - Gym Leader Brawly", 0x21000021);
                    writeBackground("22 00 00 22 - Gym Leader Watson", 0x22000022);
                    writeBackground("23 00 00 23 - Gym Leader Flannery", 0x23000023);
                    writeBackground("24 00 00 24 - Gym Leader Norman", 0x24000024);
                    writeBackground("25 00 00 25 - Gym Leader Winona", 0x25000025);
                    writeBackground("26 00 00 26 - Gym Leader Tate and Liza", 0x26000026);
                    writeBackground("27 00 00 27 - Gym Leader Wallace", 0x27000027);
                    writeBackground("28 00 28 28 - Soaring Over Hoenn (Broken Sky)", 0x28280028);
                    writeBackground("29 00 29 29 - Cave with Water Rings", 0x29290029);
                    writeBackground("2A 00 2A 2A - Falling Soot (Broken Sky)", 0x2A2A002A);
                    writeBackground("2B 00 2B 2B - Desert (Broken Sky)", 0x2B2B002B);
                    writeBackground("2C 00 2C 2C - Rocky Terrain (Broken Sky)", 0x2C2C002C);
                    writeBackground("2D 00 2D 2D - Slateport Beach (Broken Sky)", 0x2D2D002D);
                    writeBackground("2E 00 2E 2E - Swamp (Broken Sky)", 0x2E2E002E);
                    writeBackground("2F 00 2F 2F - Under Water", 0x2F2F002F);
                    writeBackground("30 00 30 30 - Large Cave", 0x30300030);
                    writeBackground("31 00 31 31 - Cave with Waterfalls", 0x31310031);
                    writeBackground("32 00 32 32 - Blue Cave", 0x32320032);
                    writeBackground("33 00 33 33 - Cave with Waterfalls with Water Rings", 0x33330033);
                    writeBackground("34 00 34 34 - Blue Cave with Water Rings", 0x34340034);
                    writeBackground("35 00 35 35 - Blue Cave with Water Rings", 0x35350035);
                    writeBackground("36 00 00 36 - Cycling Road", 0x36000036);
                    writeBackground("37 00 00 37 - Basement", 0x37000037);
                    writeBackground("38 00 38 38 - Mt. Pyre", 0x38380038);
                    writeBackground("39 00 39 39 - Sky Pillar", 0x39390039);
                    writeBackground("3A 00 00 3A - Groudon Cave of Origin", 0x3A00003A);
                    writeBackground("3B 00 00 3B - Kyogre Cave of Origin", 0x3B00003B);
                    writeBackground("3C 00 3C 3C - Atop Sky Pillar (Broken Sky)", 0x3C00003C);
                    writeBackground("3D 00 00 3D - Mirage Battle", 0x3D00003D);
                    writeBackground("3E 00 00 3E - Contest Hall 1", 0x3E00003E);
                    writeBackground("3F 00 00 3F - Contest Hall 2", 0x3F00003F);
                    writeBackground("40 00 00 40 - Contest Hall 3", 0x40000040);
                    writeBackground("41 00 00 41 - Contest Hall 4", 0x41000041);
                    writeBackground("42 00 00 42 - Contest Hall 5", 0x42000042);
                    writeBackground("43 00 00 43 - Contest Hall 6", 0x43000043);
                    writeBackground("44 00 00 44 - Contest Hall 7", 0x44000044);
                    writeBackground("45 00 00 45 - Contest Hall 8", 0x45000045);
                    writeBackground("46 00 00 46 - Contest Hall 9", 0x46000046);
                    writeBackground("47 00 00 47 - Contest Hall 10", 0x47000047);
                    writeBackground("48 00 00 48 - Contest Hall 11", 0x48000048);
                    writeBackground("49 00 00 49 - Contest Hall 12", 0x49000049);
                    writeBackground("4A 00 00 4A - Contest Hall 13", 0x4A00004A);
                    writeBackground("4B 00 00 4B - Contest Hall 14", 0x4B00004B);
                    writeBackground("4C 00 00 4C - Contest Hall 15", 0x4C00004C);
                    writeBackground("4D 00 00 4D - Contest Hall 16", 0x4D00004D);
                    writeBackground("4E 00 00 4E - Contest Hall 17", 0x4E00004E);
                    writeBackground("4F 00 00 4F - Contest Hall 18", 0x4F00004F);
                    writeBackground("50 00 00 50 - Contest Hall 19", 0x50000050);
                    writeBackground("51 00 00 51 - Contest Hall 20", 0x51000051);
                    writeBackground("52 00 00 52 - Contest Hall 21", 0x52000052);
                    writeBackground("53 00 00 53 - Contest Hall 22", 0x53000053);
                    writeBackground("54 00 00 54 - Blue Vortex, Archie Battle", 0x54000054);
                    writeBackground("55 00 00 55 - Surface of Lava, Maxie Battle", 0x55000055);
                    writeBackground("56 00 56 56 - Atop Sky Pillar (Broken Sky)", 0x56560056);
                    writeBackground("57 00 00 57 - Outer Space", 0x57000057);
                    writeBackground("58 00 58 58 - Volcanic", 0x58580058);
                    writeBackground("59 00 00 59 - Final Wally Battle", 0x59000059);
                    writeBackground("5A 00 5A 5A - Final Rival Battle", 0x5A5A005A);
                    writeBackground("5B 00 00 5B - Cave", 0x5B00005B);

                    writeBgm("00 - Title Screen Theme", 0);
                    writeBgm("01 - Evolution Start", 1);
                    writeBgm("02 - Evolution", 2);
                    writeBgm("03 - Bike", 3);
                    writeBgm("04 - Surfing", 4);
                    writeBgm("05 - Littleroot town", 5);
                    writeBgm("06 - Oldale Town", 6);
                    writeBgm("07", 7);
                    writeBgm("08", 8);
                    writeBgm("09 - Mauville City", 9);
                    writeBgm("0A - Slateport City", 10);
                    writeBgm("0B - Route 101", 11);
                    writeBgm("0C - Route 104", 12);
                    writeBgm("0D", 13);
                    writeBgm("0E - Cave", 14);
                    writeBgm("0F - Mt. Chimney", 15);
                    writeBgm("10 - Pokemon Center", 16);
                    writeBgm("11 - Pokemon Gym", 17);
                    writeBgm("12 - Proffesor's Lab", 18);
                    writeBgm("13 - Super Training Clear", 19);
                    writeBgm("14", 20);
                    writeBgm("15", 21);
                    writeBgm("16", 22);
                    writeBgm("17", 23);
                    writeBgm("18 - XY Trainer Battle", 24);
                    writeBgm("19 - XY Trainer Battle", 25);
                    writeBgm("1A - XY Trainer Battle", 26);
                    writeBgm("1B - Wild Pokemon Victory", 27);
                    writeBgm("1C - Trainer Battle Victory", 28);
                    writeBgm("1D - Gym Leader Victory", 29);
                    writeBgm("1E - Come Along!", 30);
                    writeBgm("1F - No Sound", 31);
                    writeBgm("20 - No Sound", 32);
                    writeBgm("21 - VS Primal Legends", 33);
                    writeBgm("22 - No Sound", 34);
                    writeBgm("23 - H-Help Me!", 35);
                    writeBgm("24 - SS Tidal", 36);
                    writeBgm("25 - Reporter Theme", 37);
                    writeBgm("26 - No Sound", 38);
                    writeBgm("27 - No Sound", 39);
                    writeBgm("28 - Drought", 40);
                    writeBgm("29 - Heavy Rainfall", 41);
                    writeBgm("2A", 42);
                    writeBgm("2B", 43);
                    writeBgm("2C - No Sound", 44);
                    writeBgm("2D - No Sound", 45);
                    writeBgm("2E - Introduction Movie", 46);
                    writeBgm("2F", 47);
                    writeBgm("30 - Ruby/Sapphire Welcome to Pokemon!", 48);
                    writeBgm("31 - No Sound", 49);
                    writeBgm("32 - No Sound", 50);
                    writeBgm("33 - Hall of Fame", 51);
                    writeBgm("34 - Credits", 52);
                    writeBgm("35", 53);
                    writeBgm("36", 54);
                    writeBgm("37 - Fortree City", 55);
                    writeBgm("38", 56);
                    writeBgm("39 - Fallabor Town", 57);
                    writeBgm("3A", 58);
                    writeBgm("3B - Route 113", 59);
                    writeBgm("3C - Route 118", 60);
                    writeBgm("3D", 61);
                    writeBgm("3E - Meteor Falls", 62);
                    writeBgm("3F - Southern Island", 63);
                    writeBgm("40 - Sealed Chamber", 64);
                    writeBgm("41 - Mirage Island", 65);
                    writeBgm("42 - Victory Road", 66);
                    writeBgm("43 - Pokemon Center Birthday", 67);
                    writeBgm("44 - Happy Birthday To You", 68);
                    writeBgm("45 - Poke Mart", 69);
                    writeBgm("46 - No Sound", 70);
                    writeBgm("47 - No Sound", 71);
                    writeBgm("48 - Battle Maison", 72);
                    writeBgm("49 - Hex Girl Encounter", 73);
                    writeBgm("4A", 74);
                    writeBgm("4B", 75);
                    writeBgm("4C - Ace Trainer Encounter", 76);
                    writeBgm("4D - Pokefan Encounter", 77);
                    writeBgm("4E - Athlete Encounter", 78);
                    writeBgm("4F - Delinquent Encounter", 79);
                    writeBgm("50 - Diver Encounter", 80);
                    writeBgm("51 - Zinnia Encounter", 81);
                    writeBgm("52", 82);
                    writeBgm("53 - AZ Theme ORAS Rendition", 83);
                    writeBgm("54 - No Sound", 84);
                    writeBgm("55 - Super Training Start", 85);
                    writeBgm("56 - XY Trainer Battle", 86);
                    writeBgm("57 - XY Trainer Battle", 87);
                    writeBgm("58 - XY Trainer Battle", 88);
                    writeBgm("59 - XY Trainer Battle", 89);
                    writeBgm("5A", 90);
                    writeBgm("5B - Game Sync", 91);
                    writeBgm("5C - Waves", 92);
                    writeBgm("5D - X/Y Trainer Battle", 93);
                    writeBgm("5E - Lizia Theme", 94);
                    writeBgm("5F - WCS Final Theme!", 95);
                    writeBgm("60 - Antagonist Admin Encounter", 96);
                    writeBgm("61 - No Sound", 97);
                    writeBgm("62 - No Sound", 98);
                    writeBgm("63 - Safari Zone", 99);
                    writeBgm("64 - Beat Antagonist", 100);
                    writeBgm("65 - Beat Champion", 101);
                    writeBgm("66 - X/Y Trainer Battle", 102);
                    writeBgm("67 - It's been 3000 Years!", 103);
                    writeBgm("68 - Champion Encounter", 104);
                    writeBgm("69 - No Sound", 105);
                    writeBgm("6A - Wally Theme", 106);
                    writeBgm("6B - VS Wally", 107);
                    writeBgm("6C - Waves Crashing", 108);
                    writeBgm("6D - X/Y Trainer Battle", 109);
                    writeBgm("6E - Green Lazer Being Shot", 110);
                    writeBgm("6F - Delta Episode Theme", 111);
                    writeBgm("70 - On the Lift", 112);
                    writeBgm("71 - Groudon's Awakening", 113);
                    writeBgm("72 - VS Frontier Brain", 114);
                    writeBgm("73 - Platinum VS Giratina", 115);
                    writeBgm("74 - D/P/PT Battle at Spear Pillar", 116);
                    writeBgm("75 - D/P/PT VS Sinnoh Legends", 117);
                    writeBgm("76 - Kyogre's Awakening", 118);
                    writeBgm("77 - Soaring with Steven", 119);
                    writeBgm("78 - Internet Theme", 120);
                    writeBgm("79 - Mystery Gift Theme", 121);
                    writeBgm("7A - Wind", 122);
                    writeBgm("7B - GTS", 123);
                    writeBgm("7C - Battle Spot", 124);
                    writeBgm("7D - Soaring at Night", 125);
                    writeBgm("7E - Rain", 126);
                    writeBgm("7F - No Sound", 127);
                    writeBgm("80 - No Sound", 128);
                    writeBgm("81 - End of Delta Episode", 129);
                    writeBgm("82 - Quadruplets", 130);
                    writeBgm("83 - Sootopolis", 131);
                    writeBgm("84 - Delta Episode Issue", 132);
                    writeBgm("85 - Antagonist Base", 133);
                    writeBgm("86 - No Sound", 134);
                    writeBgm("87 - No Sound", 135);
                    writeBgm("88 - Low Tone", 136);
                    writeBgm("89 - Explosion with Sparkles", 137);
                    writeBgm("8A - VS Primal Legends", 138);
                    writeBgm("8B - No Sound", 139);
                    writeBgm("8C - No Sound", 140);
                    writeBgm("8D - No Sound", 141);
                    writeBgm("8E - No Sound", 142);
                    writeBgm("8F - No Sound", 143);
                    writeBgm("90 - Team Magma Encounter", 144);
                    writeBgm("91 - Team Aqua Encounter", 145);
                    writeBgm("92 - Battle Resort", 146);
                    writeBgm("93 - Secret Base", 147);
                    writeBgm("94 - Southern Island", 148);
                    writeBgm("95 - AZ Theme ORAS Rendition", 149);
                    writeBgm("96 - Delta Episode Theme", 150);
                    writeBgm("97 - VS Deoxys", 151);
                    writeBgm("98 - Introduction Theme", 152);
                    writeBgm("99 - Test Track", 153);
                    writeBgm("9A - Water", 154);
                    writeBgm("9B - G/S/C VS Suicune/Entei/Raikou", 155);
                    writeBgm("9C - No Sound", 156);
                    writeBgm("9D - VS Zinnia", 157);
                    writeBgm("9E - Contest Theme", 158);
                    writeBgm("9F - HG/SS VS Ho-Oh", 159);
                    writeBgm("A0 - HG/SS VS Lugia", 160);
                    writeBgm("A1 - D/P/PT VS Lake Trio", 161);
                    writeBgm("A2 - B/W/B2/W2 VS Unova Legends", 162);
                    writeBgm("A3 - B/W/B2/W2 VS Tao Trio", 163);
                    writeBgm("A4 - X/Y VS Trainer", 164);
                    writeBgm("A5 - Super Training Menu", 165);
                    writeBgm("A6 - Super Training Minigame", 166);
                    writeBgm("A7 - No Sound", 167);
                    writeBgm("A8 - Looking Back", 168);
                    writeBgm("A9 - Delta Episode Ambiance", 169);
                    writeBgm("AA - Delta Episode Ambiance", 170);
                    writeBgm("AB - Rival Encounter (Piano)", 171);
                    writeBgm("AC - Investigate", 172);
                    writeBgm("AD - Into Space!", 173);
                    writeBgm("AE - Looker Upset Theme", 174);
                    writeBgm("AF - Super Training Intense Minigame", 175);
                    writeBgm("B0 - X/Y VS Trainer", 176);
                    writeBgm("B1 - X/Y VS Trainer", 177);
                    writeBgm("B2 - Wonder Trade", 178);
                    writeBgm("B3 - Ending Music Box", 179);
                    writeBgm("B4 - Pokemon School", 180);
                    writeBgm("B5 - Museum", 181);
                    writeBgm("B6 - Art Gallery",182 );
                    writeBgm("B7 - Contest Hall", 183);
                    writeBgm("B8 - Trick House", 184);
                    writeBgm("B9 - Cave of Origin's Legendary Room", 185);
                    writeBgm("BA - Rival May Encounter", 186);
                    writeBgm("BB - Rival Brendan Encounter", 187);
                    writeBgm("BC - No Sound", 188);
                    writeBgm("BD - No Sound", 189);
                    writeBgm("BE - Elite Four Encounter", 190);
                    writeBgm("BF - Main Contest Theme", 191);
                    writeBgm("C0 - End contest Result", 192);
                    writeBgm("C1 - Contest Win", 193);
                    writeBgm("C2 - Diving", 194);
                    writeBgm("C3 - Soaring During the Day", 195);
                    writeBgm("C4 - Route Theme G", 196);
                    writeBgm("C5 - Wild Battle", 197);
                    writeBgm("C6 - Trainer Battle", 198);
                    writeBgm("C7 - Gym Leader", 199);
                    writeBgm("C8 - Rival Battle", 200);
                    writeBgm("C9 - Antagonist Grunt", 201);
                    writeBgm("CA - Antagonist Grunt", 202);
                    writeBgm("CB - Antagonist Leader", 203);
                    writeBgm("CC - Antagonist Leader", 204);
                    writeBgm("CD - Elite 4 Battle", 205);
                    writeBgm("CE - Champion Battle", 206);
                    writeBgm("CF - VS Rayquaza", 207);
                    writeBgm("D0 - Break Music Entirely", 208);

                    writeWeather("00 - Nothing", 0);
                    writeWeather("01 - Sunny", 1);
                    writeWeather("02 - Rain", 2);
                    writeWeather("03 - Hail", 3);
                    writeWeather("04 - Sandstorm", 4);
                    writeWeather("05 - Heavy Rain", 5);
                    writeWeather("06 - Drought", 6);
                    writeWeather("07 - Delta Stream", 7);
                        
                    MessageBox.Show("Done.");
                }
            }
        }
    }
}
