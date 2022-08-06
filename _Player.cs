using Raylib_cs;
using System;

public class Player 
{
    public int x;
    public int y;

    public Rectangle playerHitbox = new Rectangle(0, 0, 100, 100);

    private Texture2D texture = Raylib.LoadTexture("assets/player.png");
    private Gun gun = new Gun();

    public Player(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void init() 
    {
        Raylib.DrawTexture(texture, x, y, Color.WHITE);
        gun.init();
        gun.changePos(x + 100, y + 50);
        playerHitbox.x = x;
        playerHitbox.y = y;
        update();
    }

    private void update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            x -= 1;
            checkEdges();
            System.Threading.Thread.Sleep(1);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            x += 1;
            checkEdges();
            System.Threading.Thread.Sleep(1);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            y -= 1;
            checkEdges();
            System.Threading.Thread.Sleep(1);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            y += 1;
            checkEdges();
            System.Threading.Thread.Sleep(1);
        }   
    }

    private void checkEdges() 
    {
        if (x < 0)
        {
            x = 0;
        }
        if (x > Raylib.GetScreenWidth() - 100)
        {
            x = Raylib.GetScreenWidth() - 100;
        }
        if (y < 0)
        {
            y = 0;
        }
        if (y > Raylib.GetScreenHeight() - 100)
        {
            y = Raylib.GetScreenHeight() - 100;
        }
    }
}
