// See https://aka.ms/new-console-template for more information


struct Coords
{
    int x;
    int y;
}

class Square
{
    bool IsHidden;
    bool IsMarked;
    bool IsBomb;
    byte AdjacentBombs;
}

class Board
{
    Coords Size;
    double Bomb_Percent;
}