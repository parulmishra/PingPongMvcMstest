using System;
using System.Collections.Generic;

namespace PingPong.Models
{
	public class PingPongClass
	{
		private int _numberEntered;
		
		public PingPongClass(int number)
		{
			_numberEntered = number;
		}
		public int GetNumber()
		{
			return _numberEntered;
		}
		public List<string> IsPingPong()
		{
			List<string> list = new List<string>();
			for(int i=1; i<= _numberEntered ; i++)
			{
				if((i % 3 == 0) && (i % 5 == 0))
				{
					 list.Add("PingPong");
				}
				else if (i % 5 == 0)
				{
					list.Add("Pong");
				}
				else if (i % 3 == 0)
				{
					list.Add("Ping");
				}
				else 
					list.Add(i.ToString());
			}
			return list;
		}
	}
}