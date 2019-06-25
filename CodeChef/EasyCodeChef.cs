using System;
namespace CodeChef
{
    public static class EasyCodeChef
    {
        public static int DecrementOrIncrement(int value)
		{
			if (value % 4 == 0)
				value++;
			else
				value--;

			return value;
		}
    }
}
