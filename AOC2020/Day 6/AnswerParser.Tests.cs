using Xunit;

namespace Day_6
{
    public class AnswerParser_Tests
    {
        private AnswerParser _sut;

        [Theory]
        [InlineData("")]
        public void GetCountForGroup_ReturnsZero_ForEmptyString(string input)
        {
            Arrange();

            var res = _sut.GetCountForGroup(input);

            Assert.Equal(0, res);

            Annihilate();
        }

        [Theory]
        [InlineData("abc")]
        public void GetCountForGroup_ReturnsCountOfDistinctChars(string input)
        {
            Arrange();

            var res = _sut.GetCountForGroup(input);

            Assert.Equal(3, res);

            Annihilate();
        }

        [Theory]
        [InlineData("aa")]
        public void GetCountForGroup_IgnoresDuplicatesFromSamePerson(string input)
        {
            Arrange();

            var res = _sut.GetCountForGroup(input);

            Assert.Equal(1, res);

            Annihilate();
        }

        [Theory]
        [InlineData("a\r\na")]
        public void GetCountForGroup_IgnoresDuplicatesFromDifferentPeopleInSameGroup(string input)
        {
            Arrange();

            var res = _sut.GetCountForGroup(input);

            Assert.Equal(1, res);

            Annihilate();
        }

        [Theory]
        [InlineData("a\r\n\r\na")]
        public void GetCountForInput_AcceptsDuplicatesFromDifferentGroups(string input)
        {
            Arrange();

            var res = _sut.GetCountForInput(input);

            Assert.Equal(2, res);

            Annihilate();
        }

        [Theory]
        [InlineData("a\r\nb")]
        public void GetCountForInput_ReturnsZero_IfTwoPeopleInSameGroupDoNotAnswerYesToAnySameQuestion(string input)
        {
            Arrange();

            var res = _sut.GetCountForInput(input);

            Assert.Equal(0, res);

            Annihilate();
        }

        [Theory]
        [InlineData("ab\r\nac")]
        public void GetCountForInput_ReturnsOne_IfTwoPeopleInSameGroupAnswerYesToExactlyOneSameQuestion(string input)
        {
            Arrange();

            var res = _sut.GetCountForInput(input);

            Assert.Equal(1, res);

            Annihilate();
        }

        [Theory]
        [InlineData("abc\r\n\r\na\r\nb\r\nc\r\n\r\nab\r\nac\r\n\r\na\r\na\r\na\r\na\r\n\r\nb")]
        public void GetCountForInput_PassesForTestData(string input)
        {
            Arrange();

            var res = _sut.GetCountForInput(input);

            Assert.Equal(6, res);

            Annihilate();
        }

        private void Arrange()
        {
            _sut = new AnswerParser();
        }

        private void Annihilate()
        {
            _sut = null;
        }
    }
}
