using Raylib_cs;

public class Wall
{
    public int x;
    public int y;
    public int w;
    public int h;

    public Player player;

    public Wall(int x, int y, int w, int h, Player player)
    {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
        this.player = player;
    }

    public void init()
    {
        Raylib.DrawRectangle(x, y, w, h, Color.BLACK);
        collision(player);
    }

    public void collision(Player plr)
    {
        if (Raylib.CheckCollisionRecs(plr.playerHitbox, new Rectangle(x, y, w, h)))
        {
            if (plr.x >= x - 100 && plr.x + 95 == x)
            {
                plr.x = x - 100;
            }
            if (plr.x <= x + w && plr.x + 5 == x + w)
            {
                plr.x = x + w;
            }
            if (plr.y >= y - 100 && plr.y + 95 == y)
            {
                plr.y = y - 100;
            }
            if (plr.y <= y + h && plr.y + 5 == y + h)
            {
                plr.y = y + h;
            }
        }
    }
}