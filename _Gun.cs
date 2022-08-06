using Raylib_cs;
using static Player;

public class Gun 
{
    public int gunX = 0;
    public int gunY = 0;

    private Texture2D texture = Raylib.LoadTexture("assets/Gun.png");

    public void init() 
    {
        Raylib.DrawTexture(texture, gunX, gunY, Color.WHITE);
        shoot();
    }

    public void changePos(int x, int y) 
    {
        gunX = x;
        gunY = y;
    }

    public void shoot()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
        {
            // Raylib.DrawTexture(texture, gunX, gunY, Color.WHITE);
            Console.Out.WriteLine("Shoot");
        }
    }
}