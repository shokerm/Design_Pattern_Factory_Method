using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_Method
{
    abstract class Emoji
    {
        public int Position { get; set; }

        public Emoji(int position)
        {
            this.Position = position;
        }
    }

    class Surprised : Emoji
    {
        private int Surprise_Level { get; set; }
        public Surprised(int position, int surprise_level) : base(position)
        {
            this.Surprise_Level = surprise_level;
        }
    }

    class Angry : Emoji
    {
        private string Red_Strenght { get; set; }
        public Angry(int position, string red_strenght) : base(position)
        {
            this.Red_Strenght = red_strenght;
        }
    }

    class Cool : Emoji
    {
        private string Glasses_Color { get; set; }
        public Cool(int position, string glasses_color) : base(position)
        {
            this.Glasses_Color = glasses_color;

        }
    }
}
