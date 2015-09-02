using System;
using Mono.Math;

namespace SoftUni_Homework__Math_For_Programmers
{
	public class TaskFactorials
	{
		public TaskFactorials()
		{
		}

		public BigInteger FindFactorial(int num)
		{
			if (num == 0) 
			{
				return 1;
			}
			return num * FindFactorial (num - 1);
		}
	}
}
