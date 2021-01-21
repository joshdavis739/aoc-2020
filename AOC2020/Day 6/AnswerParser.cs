using System.Linq;

namespace Day_6
{
    public class AnswerParser
    {
        public int GetCountForInput(string input)
        {
            return input.Split("\r\n\r\n")
                .Select(x => GetCountForGroup(x))
                .Sum();
        }

        public int GetCountForGroup(string input)
        {
            var responsesForPeopleInGroup = input.Split("\r\n");

            // From inspection, duplicate responses from the same person are ignored.

            var allAnswers = string.Empty;
            foreach (var response in responsesForPeopleInGroup)
            {
                allAnswers += response;
            }

            var count = allAnswers.ToCharArray()
                .GroupBy(x => x)
                .Select(x => x.Count())
                .Where(x => x == responsesForPeopleInGroup.Length)
                .Count();

            return count;
        }
    }
}
