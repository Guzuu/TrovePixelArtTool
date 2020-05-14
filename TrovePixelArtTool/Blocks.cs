using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace TrovePixelArtTool
{
    public class Blocks
    {
        public Blocks()
        {
            BlockID = 0;
            Standard = JsonConvert.DeserializeObject<List<Block>>(File.ReadAllText(@"../../BlockTypes/Standard.json"));
            Metalic = JsonConvert.DeserializeObject<List<Block>>(File.ReadAllText(@"../../BlockTypes/Metalic.json"));
            Glass = JsonConvert.DeserializeObject<List<Block>>(File.ReadAllText(@"../../BlockTypes/Glass.json"));
            Glowing = JsonConvert.DeserializeObject<List<Block>>(File.ReadAllText(@"../../BlockTypes/Glowing.json"));
        }

        public struct Block
        {
            public Block(string Color, byte R, byte G, byte B)
            {
                this.Color = Color;
                this.R = R;
                this.G = G;
                this.B = B;

                this.ID = BlockID;
                BlockID++;
                CL = PixelArt.RGBtoLAB(R, G, B);
            }

            public string Color { get; }
            public byte R { get;}
            public byte G { get;}
            public byte B { get;}

            public int ID { get; set; }
            public PixelArt.CIELab CL { get; }
        }

        public List<Block> Standard { get; set; }
        public List<Block> Metalic { get; set; }
        public List<Block> Glass { get; set; }
        public List<Block> Glowing { get; set; }
        public static int BlockID { get; set; }
}
}
