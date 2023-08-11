namespace Ardalis.LeftPad
{
    public static class ArdalisExtensions
    {
        public static string LeftPad(this string input, int totalWidth, char padCharacter = ' ')
        {
            return input.PadLeft(totalWidth, padCharacter);
        }
    }
}