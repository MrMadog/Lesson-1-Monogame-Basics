using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Basics
{
    public class Game1 : Game
    {
        Texture2D manTexture;
        Texture2D cloudsTexture;
        Texture2D groundTexture;
        Texture2D UFOTexture;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 1280; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 720; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions
            this.Window.Title = "My First Monogame Project";
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            manTexture = Content.Load<Texture2D>("man");
            cloudsTexture = Content.Load<Texture2D>("clouds");
            groundTexture = Content.Load<Texture2D>("ground");
            UFOTexture = Content.Load<Texture2D>("UFO");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightBlue);

            // TODO: Add your drawing code here 
            _spriteBatch.Begin();
            _spriteBatch.Draw(groundTexture, new Vector2(0,155), Color.White);
            _spriteBatch.Draw(cloudsTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(UFOTexture, new Vector2(450, 100), Color.White);
            for (int i = 300; i < 900; i += 200)
                _spriteBatch.Draw(manTexture, new Vector2(i, 250), Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}