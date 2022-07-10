using System;
using Codec_Techical;
using NUnit;
using NUnit.Framework;

namespace Test
{
    class TestClass
    {

        public class RobotNavigationTest
        {
            [TestCase]

            //Testcase for FFRFLFLF
            public void Test_1()
            {
                CurrentPosition position = new()
                {
                    X = 1,
                    Y = 2,
                    Direction = Directions.North
                };

                var commandList = "LMLMLMLMM";

                position.NavigateRobot(commandList.ToCharArray());

                Assert.AreEqual($"{position.X} {position.Y} {position.Direction}", "1 3 N");
            }
        }
    }
}
