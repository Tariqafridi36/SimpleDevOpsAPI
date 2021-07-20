using System;
using Xunit;
using SimpleDevOpsAPI.Controllers;

namespace SimpleDevOpsAPI.Test
{

    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsByName()
        {
        //Given
        var returnValue = controller.Get(1);
        Assert.Equal("Tariq Iqbal", returnValue);
        //When
        
        //Then
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
