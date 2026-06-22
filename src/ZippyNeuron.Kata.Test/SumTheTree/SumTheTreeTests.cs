using ZippyNeuron.Kata.SumTheTree;

namespace ZippyNeuron.Kata.Test.SumTheTree;

[TestFixture]
public class SumTheTreeTests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(new Node(10, new Node(1), new Node(2))).Returns(13).SetDescription("Simple Test");
            yield return new TestCaseData(new Node(11, new Node(0), new Node(0, null, new Node(1)))).Returns(12).SetDescription("Handles unbalanced trees");
        }
    }

    [Test, TestCaseSource("testCases")]
    public int Test(Node root) =>
      SumTheTreeKata.SumTree(root);
}
