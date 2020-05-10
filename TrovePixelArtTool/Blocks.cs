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

        }

        public void InitializeStandard()
        {
                Standard = JsonConvert.DeserializeObject<List<Block>>(File.ReadAllText(@"../../BlockTypes/Standard.json"));
        }

        public void InitializeMetalic()
        {
            Metalic = JsonConvert.DeserializeObject<List<Block>>(File.ReadAllText(@"../../BlockTypes/Metalic.json"));
        }

        public void InitializeGlass()
        {

            Glass = JsonConvert.DeserializeObject<List<Block>>(File.ReadAllText(@"../../BlockTypes/Glass.json"));
        }

        public void InitializeGlowing()
        {

            Glowing = JsonConvert.DeserializeObject<List<Block>>(File.ReadAllText(@"../../BlockTypes/Glowing.json"));
        }

        public struct Block
        {
            public Block(string Color, UInt16 R, UInt16 G, UInt16 B)
            {
                this.Color = Color;
                this.R = R;
                this.G = G;
                this.B = B;
            }

            public string Color { get;}
            public UInt16 R { get;}
            public UInt16 G { get;}
            public UInt16 B { get;}
        }

        public List<Block> Standard { get; set; }
        public List<Block> Metalic { get; set; }
        public List<Block> Glass { get; set; }
        public List<Block> Glowing { get; set; }
    }
}
