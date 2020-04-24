using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Ladybug.SceneManagement
{
	public enum SceneState {
		/// <summary>Active Scenes will have both <c>Update()</c> and <c>Draw</c> called each frame.</summary>
		ACTIVE, 
		/// <summary>Paused Scenes will only have <c>Draw()</c> called each frame</summary>
		PAUSED,
		/// <summary>Suspended Scenes will have neither <c>Update()</c> nor <c>Draw()</c> called each frame.</summary>
		SUSPENDED
		}
	
	/// <summary>
	/// A Scene represents a single game Update/Render loop.
	/// </summary>
	
	public class Scene
	{
		protected SpriteBatch spriteBatch;

		public Scene(SceneManager sceneManager) // Is there any way to make this not have to consume a sceneManager to work?
		{
			SceneManager = sceneManager;
			Content = new ContentManager(sceneManager.Content.ServiceProvider);
			Content.RootDirectory = "Content";
		}

		/// <summary>
		/// Reference to the Scene's ContentManager
		/// 
		/// Each Scene contains its own separate ContentManager so its assets can be
		/// individually loaded and unloaded along with the Scene
		/// </summary>
		/// <value></value>
		public ContentManager Content { get; private set; }

		/// <summary>
		/// Reference to the SceneManager that is handling this scene
		/// </summary>
		public SceneManager SceneManager { get; protected set; }

		public SceneState State { get; set; } = SceneState.ACTIVE;

		public virtual void LoadContent()
		{

		}

		public virtual void Initialize()
		{

		}

		public virtual void Update(GameTime gameTime)
		{

		}

		public virtual void Draw(GameTime gameTime)
		{

		}

		public virtual void Unload()
		{

		}

		public virtual void Pause()
		{

		}

		public virtual void Unpause()
		{
			
		}

		public virtual void Suspend()
		{

		}

		public virtual void Unsuspend()
		{

		}
	}
}