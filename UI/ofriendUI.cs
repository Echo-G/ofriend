using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace ofriend.UI
{
    public class ofriendUI : UIState
    {
        public PowerUI Powerbar;
        public static bool Visible = false;

        public override void OnInitialize()
        {
            Powerbar = new PowerUI(Power.MaxPower, Power.NowPower);
            Powerbar.Width.Set(100f, 0f);
            Powerbar.Height.Set(30f, 0f);
            Powerbar.Left.Set(20f, 0f);
            Powerbar.Top.Set(20f, 0f);
            Append(Powerbar);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Powerbar.SetValue(Power.MaxPower, Power.NowPower);
            base.Draw(spriteBatch);
        }
    }
    [Autoload(Side = ModSide.Client)]
    public class MenuBarSystem : ModSystem
    {
        internal ofriendUI menubar;
        private UserInterface _menuBar;
        public override void Load()
        {
            menubar = new ofriendUI();
            menubar.Activate();
            _menuBar = new UserInterface();
            _menuBar.SetState(menubar);
        }
        //来自https://github.com/tModLoader/tModLoader/wiki/Basic-UI-Element
        //不知道干什么用就对了（）
        public override void UpdateUI(GameTime gameTime)
        {
            if (ofriendUI.Visible)
            {
                _menuBar?.Update(gameTime);
            }
        }
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "ofriend : 这是一个Power值",
                    delegate
                    {
                        if (ofriendUI.Visible)
                            _menuBar.Draw(Main.spriteBatch, new GameTime());
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }
    }
}
