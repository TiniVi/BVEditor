namespace BVEditor
{
    partial class BVEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bgList = new System.Windows.Forms.ComboBox();
            this.bgLabel = new System.Windows.Forms.Label();
            this.saveBV = new System.Windows.Forms.Button();
            this.bgmLabel = new System.Windows.Forms.Label();
            this.bgmList = new System.Windows.Forms.ComboBox();
            this.weatherList = new System.Windows.Forms.ComboBox();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bgList
            // 
            this.bgList.FormattingEnabled = true;
            this.bgList.Items.AddRange(new object[] {
            "00 00 00 00 - Nothing",
            "01 00 01 01 - Trees and Mountain (Broken Sky)",
            "02 00 02 02 - Mechanical Room",
            "03 00 03 03 - Generic Cave",
            "04 00 04 04 - Forest",
            "05 00 05 05 - Beach (Broken Sky)",
            "06 00 06 06 - Rocky Terrain (Broken Sky)",
            "07 00 07 07 - Generic",
            "08 00 08 08 - City (Broken Sky)",
            "09 00 09 09 - Fence and House (Broken Sky)",
            "0A 00 0A 0A - Battle Maison",
            "0B 00 00 0B - PSS Colosseum",
            "0C 00 0C 0C - River (Broken Sky)",
            "0D 00 0D 0D - Ocean (Broken Sky)",
            "0E 00 0E 0E - Ice Cavern",
            "0F 00 0F 0F - Cavern",
            "10 00 10 10 - White Tiled Room with Tan Ring and Gym Symbol on Floor",
            "11 00 11 11 - White Tiled Room with Red-Orange Ring and Gym Symbol on Floor",
            "12 00 12 12 - White Tiled Room with Yellow Ring and Gym Symbol on Floor",
            "13 00 13 13 - White Tiled Room with Orange Ring and Gym Symbol on Floor",
            "14 00 14 14 - White Tiled Room with Grey Ring and Gym Symbol on Floor",
            "15 00 15 15 - White Tiled Room with Blue Ring and Gym Symbol on Floor",
            "16 00 16 16 - White Tiled Room with Red Ring and Gym Symbol on Floor",
            "17 00 17 17 - White Tiled Room with Light Blue Ring and Gym Symbol on Floor",
            "18 00 00 18 - Elite Four Sidney",
            "19 00 00 19 - Elite Four Glacia",
            "1A 00 00 1A - Elite Four Phoebe",
            "1B 00 00 1B - Elite Four Drake",
            "1C 00 00 1C - Champion Battle",
            "1D 00 1D 1D - White Tiled Room with Grey Ring on Floor",
            "1E 00 00 1E - Special PSS Colosseum (Worlds? Nationals? Regionals?)",
            "1F 00 00 1F - PSS Colesseum, Battle at Worlds! (Final Battle?)",
            "20 00 00 20 - Gym Leader Roxanne",
            "21 00 00 21 - Gym Leader Brawly",
            "22 00 00 22 - Gym Leader Watson",
            "23 00 00 23 - Gym Leader Flannery",
            "24 00 00 24 - Gym Leader Norman",
            "25 00 00 25 - Gym Leader Winona",
            "26 00 00 26 - Gym Leader Tate and Liza",
            "27 00 00 27 - Gym Leader Wallace",
            "28 00 28 28 - Soaring Over Hoenn (Broken Sky)",
            "29 00 29 29 - Cave with Water Rings",
            "2A 00 2A 2A - Falling Soot (Broken Sky)",
            "2B 00 2B 2B - Desert (Broken Sky)",
            "2C 00 2C 2C - Rocky Terrain (Broken Sky)",
            "2D 00 2D 2D - Slateport Beach (Broken Sky)",
            "2E 00 2E 2E - Swamp (Broken Sky)",
            "2F 00 2F 2F - Under Water",
            "30 00 30 30 - Large Cave",
            "31 00 31 31 - Cave with Waterfalls",
            "32 00 32 32 - Blue Cave",
            "33 00 33 33 - Cave with Waterfalls with Water Rings",
            "34 00 34 34 - Blue Cave with Water Rings",
            "35 00 35 35 - Blue Cave with Water Rings",
            "36 00 00 36 - Cycling Road",
            "37 00 00 37 - Basement",
            "38 00 38 38 - Mt. Pyre",
            "39 00 39 39 - Sky Pillar",
            "3A 00 00 3A - Groudon Cave of Origin",
            "3B 00 00 3B - Kyogre Cave of Origin",
            "3C 00 3C 3C - Atop Sky Pillar (Broken Sky)",
            "3D 00 00 3D - Mirage Battle",
            "3E 00 00 3E - Contest Hall 1",
            "3F 00 00 3F - Contest Hall 2",
            "40 00 00 40 - Contest Hall 3",
            "41 00 00 41 - Contest Hall 4",
            "42 00 00 42 - Contest Hall 5",
            "43 00 00 43 - Contest Hall 6",
            "44 00 00 44 - Contest Hall 7",
            "45 00 00 45 - Contest Hall 8",
            "46 00 00 46 - Contest Hall 9",
            "47 00 00 47 - Contest Hall 10",
            "48 00 00 48 - Contest Hall 11",
            "49 00 00 49 - Contest Hall 12",
            "4A 00 00 4A - Contest Hall 13",
            "4B 00 00 4B - Contest Hall 14",
            "4C 00 00 4C - Contest Hall 15",
            "4D 00 00 4D - Contest Hall 16",
            "4E 00 00 4E - Contest Hall 17",
            "4F 00 00 4F - Contest Hall 18",
            "50 00 00 50 - Contest Hall 19",
            "51 00 00 51 - Contest Hall 20",
            "52 00 00 52 - Contest Hall 21",
            "53 00 00 53 - Contest Hall 22",
            "54 00 00 54 - Blue Vortex, Archie Battle",
            "55 00 00 55 - Surface of Lava, Maxie Battle",
            "56 00 56 56 - Atop Sky Pillar (Broken Sky)",
            "57 00 00 57 - Outer Space",
            "58 00 58 58 - Volcanic",
            "59 00 00 59 - Final Wally Battle",
            "5A 00 5A 5A - Final Rival Battle",
            "5B 00 00 5B - Cave"});
            this.bgList.Location = new System.Drawing.Point(12, 34);
            this.bgList.Name = "bgList";
            this.bgList.Size = new System.Drawing.Size(432, 21);
            this.bgList.TabIndex = 0;
            this.bgList.Text = "00 00 00 00 - Nothing";
            // 
            // bgLabel
            // 
            this.bgLabel.AutoSize = true;
            this.bgLabel.Location = new System.Drawing.Point(13, 13);
            this.bgLabel.Name = "bgLabel";
            this.bgLabel.Size = new System.Drawing.Size(95, 13);
            this.bgLabel.TabIndex = 1;
            this.bgLabel.Text = "Battle Background";
            // 
            // saveBV
            // 
            this.saveBV.Location = new System.Drawing.Point(369, 141);
            this.saveBV.Name = "saveBV";
            this.saveBV.Size = new System.Drawing.Size(75, 23);
            this.saveBV.TabIndex = 3;
            this.saveBV.Text = "Apply";
            this.saveBV.UseVisualStyleBackColor = true;
            this.saveBV.Click += new System.EventHandler(this.saveBV_Click);
            // 
            // bgmLabel
            // 
            this.bgmLabel.AutoSize = true;
            this.bgmLabel.Location = new System.Drawing.Point(13, 58);
            this.bgmLabel.Name = "bgmLabel";
            this.bgmLabel.Size = new System.Drawing.Size(96, 13);
            this.bgmLabel.TabIndex = 4;
            this.bgmLabel.Text = "Background Music";
            // 
            // bgmList
            // 
            this.bgmList.FormattingEnabled = true;
            this.bgmList.Items.AddRange(new object[] {
            "00 - Title Screen Theme",
            "01 - Evolution Start",
            "02 - Evolution",
            "03 - Bike",
            "04 - Surfing",
            "05 - Littleroot town",
            "06 - Oldale Town",
            "07",
            "08",
            "09 - Mauville City",
            "0A - Slateport City",
            "0B - Route 101",
            "0C - Route 104",
            "0D",
            "0E - Cave",
            "0F - Mt. Chimney",
            "10 - Pokemon Center",
            "11 - Pokemon Gym",
            "12 - Proffesor\'s Lab",
            "13 - Super Training Clear",
            "14",
            "15",
            "16",
            "17",
            "18 - XY Trainer Battle",
            "19 - XY Trainer Battle",
            "1A - XY Trainer Battle",
            "1B - Wild Pokemon Victory",
            "1C - Trainer Battle Victory",
            "1D - Gym Leader Victory",
            "1E - Come Along!",
            "1F - No Sound",
            "20 - No Sound",
            "21 - VS Primal Legends",
            "22 - No Sound",
            "23 - H-Help Me!",
            "24 - SS Tidal",
            "25 - Reporter Theme",
            "26 - No Sound",
            "27 - No Sound",
            "28 - Drought",
            "29 - Heavy Rainfall",
            "2A",
            "2B",
            "2C - No Sound",
            "2D - No Sound",
            "2E - Introduction Movie",
            "2F",
            "30 - Ruby/Sapphire Welcome to Pokemon!",
            "31 - No Sound",
            "32 - No Sound",
            "33 - Hall of Fame",
            "34 - Credits",
            "35",
            "36",
            "37 - Fortree City",
            "38",
            "39 - Fallabor Town",
            "3A",
            "3B - Route 113",
            "3C - Route 118",
            "3D",
            "3E - Meteor Falls",
            "3F - Southern Island",
            "40 - Sealed Chamber",
            "41 - Mirage Island",
            "42 - Victory Road",
            "43 - Pokemon Center Birthday",
            "44 - Happy Birthday To You",
            "45 - Poke Mart",
            "46 - No Sound",
            "47 - No Sound",
            "48 - Battle Maison",
            "49 - Hex Girl Encounter",
            "4A",
            "4B",
            "4C - Ace Trainer Encounter",
            "4D - Pokefan Encounter",
            "4E - Athlete Encounter",
            "4F - Delinquent Encounter",
            "50 - Diver Encounter",
            "51 - Zinnia Encounter",
            "52",
            "53 - AZ Theme ORAS Rendition",
            "54 - No Sound",
            "55 - Super Training Start",
            "56 - XY Trainer Battle",
            "57 - XY Trainer Battle",
            "58 - XY Trainer Battle",
            "59 - XY Trainer Battle",
            "5A",
            "5B - Game Sync",
            "5C - Waves",
            "5D - X/Y Trainer Battle",
            "5E - Lizia Theme",
            "5F - WCS Final Theme!",
            "60 - Antagonist Admin Encounter",
            "61 - No Sound",
            "62 - No Sound",
            "63 - Safari Zone",
            "64 - Beat Antagonist",
            "65 - Beat Champion",
            "66 - X/Y Trainer Battle",
            "67 - It\'s been 3000 Years!",
            "68 - Champion Encounter",
            "69 - No Sound",
            "6A - Wally Theme",
            "6B - VS Wally",
            "6C - Waves Crashing",
            "6D - X/Y Trainer Battle",
            "6E - Green Lazer Being Shot",
            "6F - Delta Episode Theme",
            "70 - On the Lift",
            "71 - Groudon\'s Awakening",
            "72 - VS Frontier Brain",
            "73 - Platinum VS Giratina",
            "74 - D/P/PT Battle at Spear Pillar",
            "75 - D/P/PT VS Sinnoh Legends",
            "76 - Kyogre\'s Awakening",
            "77 - Soaring with Steven",
            "78 - Internet Theme",
            "79 - Mystery Gift Theme",
            "7A - Wind",
            "7B - GTS",
            "7C - Battle Spot",
            "7D - Soaring at Night",
            "7E - Rain",
            "7F - No Sound",
            "80 - No Sound",
            "81 - End of Delta Episode",
            "82 - Quadruplets",
            "83 - Sootopolis",
            "84 - Delta Episode Issue",
            "85 - Antagonist Base",
            "86 - No Sound",
            "87 - No Sound",
            "88 - Low Tone",
            "89 - Explosion with Sparkles",
            "8A - VS Primal Legends",
            "8B - No Sound",
            "8C - No Sound",
            "8D - No Sound",
            "8E - No Sound",
            "8F - No Sound",
            "90 - Team Magma Encounter",
            "91 - Team Aqua Encounter",
            "92 - Battle Resort",
            "93 - Secret Base",
            "94 - Southern Island",
            "95 - AZ Theme ORAS Rendition",
            "96 - Delta Episode Theme",
            "97 - VS Deoxys",
            "98 - Introduction Theme",
            "99 - Test Track",
            "9A - Water",
            "9B - G/S/C VS Suicune/Entei/Raikou",
            "9C - No Sound",
            "9D - VS Zinnia",
            "9E - Contest Theme",
            "9F - HG/SS VS Ho-Oh",
            "A0 - HG/SS VS Lugia",
            "A1 - D/P/PT VS Lake Trio",
            "A2 - B/W/B2/W2 VS Unova Legends",
            "A3 - B/W/B2/W2 VS Tao Trio",
            "A4 - X/Y VS Trainer",
            "A5 - Super Training Menu",
            "A6 - Super Training Minigame",
            "A7 - No Sound",
            "A8 - Looking Back",
            "A9 - Delta Episode Ambiance",
            "AA - Delta Episode Ambiance",
            "AB - Rival Encounter (Piano)",
            "AC - Investigate",
            "AD - Into Space!",
            "AE - Looker Upset Theme",
            "AF - Super Training Intense Minigame",
            "B0 - X/Y VS Trainer",
            "B1 - X/Y VS Trainer",
            "B2 - Wonder Trade",
            "B3 - Ending Music Box",
            "B4 - Pokemon School",
            "B5 - Museum",
            "B6 - Art Gallery",
            "B7 - Contest Hall",
            "B8 - Trick House",
            "B9 - Cave of Origin\'s Legendary Room",
            "BA - Rival May Encounter",
            "BB - Rival Brendan Encounter",
            "BC - No Sound",
            "BD - No Sound",
            "BE - Elite Four Encounter",
            "BF - Main Contest Theme",
            "C0 - End contest Result",
            "C1 - Contest Win",
            "C2 - Diving",
            "C3 - Soaring During the Day",
            "C4 - Route Theme G",
            "C5 - Wild Battle",
            "C6 - Trainer Battle",
            "C7 - Gym Leader",
            "C8 - Rival Battle",
            "C9 - Antagonist Grunt",
            "CA - Antagonist Grunt",
            "CB - Antagonist Leader",
            "CC - Antagonist Leader",
            "CD - Elite 4 Battle",
            "CE - Champion Battle",
            "CF - VS Rayquaza",
            "D0 - Break Music Entirely"});
            this.bgmList.Location = new System.Drawing.Point(12, 74);
            this.bgmList.Name = "bgmList";
            this.bgmList.Size = new System.Drawing.Size(432, 21);
            this.bgmList.TabIndex = 5;
            this.bgmList.Text = "00 - Title Screen Theme";
            // 
            // weatherList
            // 
            this.weatherList.FormattingEnabled = true;
            this.weatherList.Items.AddRange(new object[] {
            "00 - Nothing",
            "01 - Sunny",
            "02 - Rain",
            "03 - Hail",
            "04 - Sandstorm",
            "05 - Heavy Rain",
            "06 - Drought",
            "07 - Delta Stream"});
            this.weatherList.Location = new System.Drawing.Point(12, 114);
            this.weatherList.Name = "weatherList";
            this.weatherList.Size = new System.Drawing.Size(432, 21);
            this.weatherList.TabIndex = 6;
            this.weatherList.Text = "00 - Nothing";
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.Location = new System.Drawing.Point(13, 98);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(48, 13);
            this.weatherLabel.TabIndex = 7;
            this.weatherLabel.Text = "Weather";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Credits: TiniVi (Research/Developement), EpicLolz53 (Research), Hallowpape (Weath" +
    "er) ";
            // 
            // BVEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.weatherList);
            this.Controls.Add(this.bgmList);
            this.Controls.Add(this.bgmLabel);
            this.Controls.Add(this.saveBV);
            this.Controls.Add(this.bgLabel);
            this.Controls.Add(this.bgList);
            this.Name = "BVEditor";
            this.Text = "BVEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bgList;
        private System.Windows.Forms.Label bgLabel;
        private System.Windows.Forms.Button saveBV;
        private System.Windows.Forms.Label bgmLabel;
        private System.Windows.Forms.ComboBox bgmList;
        private System.Windows.Forms.ComboBox weatherList;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Label label1;
    }
}

