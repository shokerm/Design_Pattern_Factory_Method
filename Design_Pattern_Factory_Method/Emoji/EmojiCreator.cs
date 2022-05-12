using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_Method
{
    abstract class EmojiCreator
    {
        public abstract Emoji CreateEmoji(int position);
    }


    class SurprisedCreator : EmojiCreator
    {
        private int Surprise_Level { get; set; }
        public SurprisedCreator(int surprise_Level)
        {
            this.Surprise_Level = surprise_Level;
        }
        public override Emoji CreateEmoji(int position)
        {
            return new Surprised(position, this.Surprise_Level);
        }
    }

    class AngryCreator : EmojiCreator
    {
        private string Red_Strenght { get; set; }

        public AngryCreator(string red_Strenght)
        {
            Red_Strenght = red_Strenght;
        }

        public override Emoji CreateEmoji(int position)
        {
            return new Angry(position, this.Red_Strenght);
        }
    }
    class CoolCreator : EmojiCreator
    {
        private string Glasses_Color { get; set; }

        public CoolCreator(string glasses_Color)
        {
            Glasses_Color = glasses_Color;
        }

        public override Emoji CreateEmoji(int position)
        {
            return new Cool(position, this.Glasses_Color);
        }
    }


}
