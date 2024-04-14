using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;


namespace ofriend.UI
{
    public class PowerUI:UIElement
    {
        private float _maxValue, _value;
        public PowerUI(int maxValue, int value)
        {
            _maxValue = maxValue;
            _value = value;
        }
        public void SetValue(int maxValue, int value)
        {
            _maxValue = maxValue;
            _value = value;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Vector2 position = new Vector2(GetInnerDimensions().X,GetInnerDimensions().Y);
            float progress = _value / _maxValue;
            spriteBatch.Draw((Texture2D)ModContent.Request<Texture2D>("ofriend/UI/Images/bar"), new Rectangle((int)position.X, (int)position.Y, 400, 30), Color.White);
            spriteBatch.Draw((Texture2D)ModContent.Request<Texture2D>("ofriend/UI/Images/box"), new Rectangle((int)(position.X + 2), (int)(position.Y + 2), (int)(392 * progress), 22), Color.White);
        }
    }
}
