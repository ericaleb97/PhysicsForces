using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PhysicsPart2
{
    [TestFixture]
    public class TestingForce
    {
        [TestCase]
        public void Forces()
        {
            double mass = 155;
            double acceleration = 9.18;

            var forces = new Forces(acceleration, mass);

            forces.LawofForces();

            double actual = forces.Force;
            double expected = 1422.9;
            Assert.AreEqual(expected‬, actual, 0.000000000001);
        }
    }
}
