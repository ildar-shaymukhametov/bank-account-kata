using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace test
{
    [UseReporter(typeof(DiffReporter))]
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var sut = new Account(new FakeTimeProvider());
            sut.Deposit(1000);
            sut.Deposit(2000);
            sut.Withdraw(500);
            var output = sut.Print();
            Approvals.Verify(output);
        }
    }

    class FakeTimeProvider : ITimeProvider
    {
        private int count;

        public FakeTimeProvider()
        {
            this.count = 1;
        }

        public DateTime Now()
        {
            switch (this.count++)
            {
                case 1: return new DateTime(2012, 1, 10);
                case 2: return new DateTime(2012, 1, 13);
                case 3: return new DateTime(2012, 1, 14);
                default: throw new IndexOutOfRangeException();
            }
        }
    }
}