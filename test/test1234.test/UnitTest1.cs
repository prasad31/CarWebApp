using ServiceStack;
using System;
using Xunit;

namespace test1234.test
{
    public class UnitTest1
    {

        
        [Fact]
        public void Test2()
        {
            DummyDataDBInitializer data = new DummyDataDBInitializer();
            data.Seed();

            //DummyDataDBInitializer data2 = new DummyDataDBInitializer();
            //data2.Seed();

        }

       
    }
}
