namespace WindowsImmutableCodeGenerator
{

    // from http://stackoverflow.com/questions/711753/a-better-way-to-replace-many-strings-obfuscation-in-c-sharp

    public class Token
    {
        public string Text { get; set; }
        public string Replacement { get; set; }
        public int Index { get; set; }

        public Token(string text, string replacement)
        {
            Text = text;
            Replacement = replacement;
        }

    }
}
