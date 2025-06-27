using Silk.NET.OpenGL;

namespace PoorEngine;

using Silk.NET.Maths;
using Silk.NET.Windowing;

class Program
{
    private static GL _gl;
    private static IWindow _window;
    private static Random _random = new Random();

    static void Main(string[] args)
    {
        WindowOptions windowOptions = WindowOptions.Default;
        windowOptions.Title = "Poor Engine";
        windowOptions.Size = new Vector2D<int>(1280, 720);
        _window = Window.Create(windowOptions);
        _window.Load += OnWindowLoad;
        _window.Update += Update;
        _window.Render += Render;
        _window.Run();
    }

    static void OnWindowLoad()
    {
        _gl = _window.CreateOpenGL();
        
        // Set up initial OpenGL state
        _gl.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
    }

    static void Update(double deltaTime)
    {
        // Game logic updates go here
    }

    static void Render(double deltaTime)
    {
        // Generate random color values between 0.0 and 1.0
        float red = (float)_random.NextDouble();
        float green = (float)_random.NextDouble();
        float blue = (float)_random.NextDouble();
        
        // Set the clear color to the random color
        _gl.ClearColor(red, green, blue, 1.0f);
        
        // Clear the screen with the random color
        _gl.Clear(ClearBufferMask.ColorBufferBit);
    }
}

//TODO start off with tilemap template for world. then we can move to free form