using System;
using SDL2;

namespace SDL2.Wrap
{
	/*
	public const uint SDL_INIT_TIMER =		0x00000001;
	public const uint SDL_INIT_AUDIO =		0x00000010;
	public const uint SDL_INIT_VIDEO =		0x00000020;
	public const uint SDL_INIT_JOYSTICK =		0x00000200;
	public const uint SDL_INIT_HAPTIC =		0x00001000;
	public const uint SDL_INIT_GAMECONTROLLER =	0x00002000;
	public const uint SDL_INIT_NOPARACHUTE =	0x00100000;
	public const uint SDL_INIT_EVERYTHING = (
		SDL_INIT_TIMER | SDL_INIT_AUDIO | SDL_INIT_VIDEO |
		SDL_INIT_JOYSTICK | SDL_INIT_HAPTIC |
		SDL_INIT_GAMECONTROLLER
	);
	*/

	public enum InitFlags : uint
	{
		None = 0,
		Timer = SDL2.SDL.SDL_INIT_TIMER,
		Audio = SDL2.SDL.SDL_INIT_AUDIO,
		Video = SDL2.SDL.SDL_INIT_VIDEO,
		Joystick = SDL2.SDL.SDL_INIT_JOYSTICK,
		Haptic = SDL2.SDL.SDL_INIT_HAPTIC,
		Gamecontroller = SDL2.SDL.SDL_INIT_GAMECONTROLLER,
		NoParachute = SDL2.SDL.SDL_INIT_NOPARACHUTE,
		Everything = SDL2.SDL.SDL_INIT_EVERYTHING,
	}

	public class SDL
	{
		public void Init(InitFlags flags)
		{

		}

		public void InitSubsystem(InitFlags flags)
		{

		}

		public void Quit()
		{

		}

		public void QuitSubsystem(InitFlags flags)
		{

		}

		public void WasInit(InitFlags flags)
		{

		}

		public string GetPlatform()
		{

		}

		public enum HintPriority
		{
			Default,
			Normal,
			Override
		}

		public void ClearHints()
		{

		}

		public string GetHint(string hint)
		{

		}

		public bool SetHint(string name, string value)
		{

		}

		public bool SetHint(string name, string value, HintPriority priority)
		{

		}

		public void ClearError()
		{

		}

		public string GetError()
		{

		}

		public void SetError(string format, params string[] args)
		{

		}

		public enum LogCategory
		{
			Application = SDL2.SDL.SDL_LOG_CATEGORY_APPLICATION,
			Error = SDL2.SDL.SDL_LOG_CATEGORY_ERROR,
			Assert = SDL2.SDL.SDL_LOG_CATEGORY_ASSERT,
			System = SDL2.SDL.SDL_LOG_CATEGORY_SYSTEM,
			Audio = SDL2.SDL.SDL_LOG_CATEGORY_AUDIO,
			Video = SDL2.SDL.SDL_LOG_CATEGORY_VIDEO,
			Render = SDL2.SDL.SDL_LOG_CATEGORY_RENDER,
			Input = SDL2.SDL.SDL_LOG_CATEGORY_INPUT,
			Test = SDL2.SDL.SDL_LOG_CATEGORY_TEST,

			Reserved1 = SDL2.SDL.SDL_LOG_CATEGORY_RESERVED1,
			Reserved2 = SDL2.SDL.SDL_LOG_CATEGORY_RESERVED2,
			Reserved3 = SDL2.SDL.SDL_LOG_CATEGORY_RESERVED3,
			Reserved4 = SDL2.SDL.SDL_LOG_CATEGORY_RESERVED4,
			Reserved5 = SDL2.SDL.SDL_LOG_CATEGORY_RESERVED5,
			Reserved6 = SDL2.SDL.SDL_LOG_CATEGORY_RESERVED6,
			Reserved7 = SDL2.SDL.SDL_LOG_CATEGORY_RESERVED7,
			Reserved8 = SDL2.SDL.SDL_LOG_CATEGORY_RESERVED8,
			Reserved9 = SDL2.SDL.SDL_LOG_CATEGORY_RESERVED9,
			Reserved10 = SDL2.SDL.SDL_LOG_CATEGORY_RESERVED10,

			Custom = SDL2.SDL.SDL_LOG_CATEGORY_CUSTOM,
		}

		public enum LogPriority
		{
			Verbose = 1,
			Debug,
			Info,
			Warn,
			Error,
			Critical,
			NumPriorities
		}

		public delegate void LogOutputFunction(object userdata,LogCategory category,LogPriority priority,string message);
	}
}

