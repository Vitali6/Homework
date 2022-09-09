
void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}
DrawText("Intensive C# Demo text", 629, 360);