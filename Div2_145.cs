using System;

namespace TopCoder
{
	namespace Div2_145
	{
		//easy
		public class ImageDithering
		{
			public int count(string dithered, string[] screen)
			{
				char[] keys = dithered.ToCharArray();
				int count = 0;
				for (int i = 0; i < screen.Length; i++)
				{
					char[] sc2 = screen[i].ToCharArray();
					for (int j = 0; j < sc2.Length; j++)
					{
						for (int k = 0; k < keys.Length; k++)
						{
							if (sc2[j] == keys[k])
								count++;
						}
					}
				}
				return count;
			}
		}
	}
}
