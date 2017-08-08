using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;

namespace PingPong.Tests
{
	[TestClass]
	public class PingPongTest
	{
		[TestMethod]
		public void isPingPong_ForNumber_DivisibleByFifteen_pingpong()
		{
			PingPongClass testPingPong = new PingPongClass(30);
			Assert.AreEqual("1" , testPingPong.IsPingPong()[0]);
		}
		[TestMethod]
		public void isPing_ForNumber_DivisibleByFive_pong()
		{
			PingPongClass testPingPong = new PingPongClass(10);
			Assert.AreEqual("Ping" , testPingPong.IsPingPong()[2]);
		}
		[TestMethod]
		public void isPong_ForNumber_DivisibleByThree_ping()
		{
			PingPongClass testPingPong = new PingPongClass(9);
			Assert.AreEqual("Pong" , testPingPong.IsPingPong()[4]);
		}
		[TestMethod]
		public void isPong_ForNumber_NotDivisibleByThreeFiveFifteen_numberEntered()
		{
			PingPongClass testPingPong = new PingPongClass(17);
			Assert.AreEqual("PingPong" , testPingPong.IsPingPong()[14]);
		}
	}
}