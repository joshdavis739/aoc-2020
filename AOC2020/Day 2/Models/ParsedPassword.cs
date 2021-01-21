namespace Day_2.Models
{
    public class ParsedPassword
    {
        public ParsedPassword(string input)
        {
            RangeSeparatorIndex = input.IndexOf("-");
            SpaceIndex = input.IndexOf(" ");
            ColonIndex = input.IndexOf(":");

            LowerBound = int.Parse(input[..RangeSeparatorIndex]);
            UpperBound = int.Parse(input[(RangeSeparatorIndex + 1)..SpaceIndex]);
            Character = char.Parse(input[(SpaceIndex + 1)..ColonIndex]);

            Password = input[(ColonIndex + 2)..];
        }

        public int LowerBound { get; private set; }
        public int UpperBound { get; private set; }
        public char Character { get; private set; }
        public int RangeSeparatorIndex { get; private set; }
        public int SpaceIndex { get; private set; }
        public int ColonIndex { get; private set; }
        public string Password { get; private set; }
    }
}
