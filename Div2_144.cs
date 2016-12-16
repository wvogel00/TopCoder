using System;
using System.Collections.Generic;

namespace TopCoder
{
	namespace Div2_144
	{
		public class Outage
		{
			public int output(int[] fromJ, int[] toJ, int[] ductL)
			{
				int[] cost = new int[fromJ.Length + 1];
				int maxL = 0, tweiL = 0;

				foreach (int v in ductL)
					tweiL += 2 * v;

				Queue<int> queue = new Queue<int>();
				queue.Enqueue(0);

				while (queue.Count != 0)
				{
					for (int i = 0; i < fromJ.Length; i++)
					{
						if (queue.Contains(fromJ[i]))
						{
							queue.Enqueue(toJ[i]);
							cost[toJ[i]] = cost[fromJ[i]] + ductL[i];
						}
					}
					queue.Dequeue();
				}

				foreach (int v in cost)
					maxL = maxL < v ? v : maxL;

				return tweiL - maxL;
			}
		}
	}
	}
}
