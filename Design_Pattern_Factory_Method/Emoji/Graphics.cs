using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_Method
{
    class Graphics
    {
        private EmojiCreator creator;

        private Chat chat;

        public Graphics(Chat chat)
        {
            this.chat = chat;
        }

        public void UserSelectedSurprisedEmoji(int surprise_level)
        {
            creator = new SurprisedCreator(surprise_level);
        }

        public void UserSelectedAngryEmoji(string red_strength)
        {
            creator = new AngryCreator(red_strength);
        }

        public void UserSelectedCoolEmoji(string glasses_color)
        {
            creator = new CoolCreator(glasses_color);
        }

        public void UserAddEmojiToChat(int position)
        {
            if (creator == null)
            {
                // prompt message: pleased select an emoji first
                return;
            }

            Emoji emoji = creator.CreateEmoji(position);
            chat.AddEmoji(emoji);
        }
    }
}
