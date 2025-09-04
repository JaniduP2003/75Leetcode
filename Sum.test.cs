using System;
using System.IO;
using Xunit;

namespace HelloWorldApp.Tests
{
    public class SumProgramTests
    {
        [Theory]
        [InlineData("3\n10\n20\n30\n", new int[] { 10, 20, 30 })]
        [InlineData("2\n5\n15\n", new int[] { 5, 15 })]
        [InlineData("1\n42\n", new int[] { 42 })]
        [InlineData("0\n", new int[] { })]
        [InlineData("4\n1\n2\n3\n4\n", new int[] { 1, 2, 3, 4 })]
        public void TestMainProgram(string input, int[] expectedOutput)
        {
            // Redirect Console input
            Console.SetIn(new StringReader(input));

            // Capture Console output
            var outputWriter = new StringWriter();
            Console.SetOut(outputWriter);

            // Run the original Main method
            Sum.Program.Main(new string[] { });

            // Get the output lines
            var outputLines = outputWriter.ToString()
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            // Assert output matches expected
            Assert.Equal(expectedOutput.Length, outputLines.Length);
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i].ToString(), outputLines[i]);
            }
        }
    }
}
