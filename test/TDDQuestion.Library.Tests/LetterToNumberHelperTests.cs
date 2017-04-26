using FluentAssertions;
using Xunit;

namespace TDDQuestion.Library.Tests
{
	public class LetterToNumberHelperTests
	{
		[Theory(DisplayName = "GIVEN a letter WHEN calling convert THEN return the correct number")]
		[InlineData(null, 0)]
		[InlineData("", 0)]
		[InlineData(" ", 0)]
		[InlineData("  ", 0)]
		[InlineData("A", 1)]
		[InlineData("B", 2)]
		[InlineData("Z", 26)]
		[InlineData("AA", 27)]
		[InlineData("AB", 28)]
		[InlineData("BA", 53)]
		[InlineData("ZZ", 702)]
		[InlineData("AAA", 703)]
		public void ConvertLetterToNumber(string letter, int expectedValue)
		{
			var converter = new LetterToNumberConverter();
			var answer = converter.Convert(letter);
			answer.Should().Be(expectedValue);
		}
	}
}
