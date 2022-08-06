using Raylib_cs;
using static Player;

Raylib.InitWindow(800, 480, "Hello World");

// Some Vars
int playerx = (Raylib.GetScreenWidth() - 100) / 2;
int playery = (Raylib.GetScreenHeight() - 100) / 2;

Player player = new Player(playerx, playery);
Wall wall = new Wall(460, 140, 70, 240, player);
Wall wall2 = new Wall(100, 150, 240, 70, player);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    player.init();
    wall.init();
    wall2.init();

    Raylib.ClearBackground(Color.WHITE);

    Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);

    Raylib.EndDrawing();
}

Raylib.CloseWindow();