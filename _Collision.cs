using Raylib_cs;

public class Collision
{
    public static bool isColliding(int x1, int y1, int w1, int h1, float x2, float y2, float w2, float h2)
    {
        if (x1 < x2 + w2 && x1 + w1 > x2 && y1 < y2 + h2 && y1 + h1 > y2)
        {
            return true;
        }
        return false;
    }

    private void checkEdges(int x, int y)
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