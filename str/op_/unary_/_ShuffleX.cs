using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.op_.unary_
{
	static public class _ShuffleX
	{
		public static void Void<T>(T[] array)
		{
			System.Random random = new System.Random();
			for (int i = 0; i < array.Length; i++)
			{
				int j = random.Next(i, array.Length); // Don't select from the entire array on subsequent loops

				nilnul.obj.co.op_.unary_.SwapX.Swap(array,i,j);
				//T temp = array[i];
				//array[i] = array[j];
				//array[j] = temp;
			}
		}

		public static T[] Op<T>(T[] array) {
			Void(array);
			return array;
		}


		public static StringCollection Op(StringCollection sc)
		{
			var array = sc.Cast<string>().ToArray();
			Void(array);

			var r = new StringCollection();
			r.AddRange(array);
			return r;
		}


		public static IEnumerable<T> Op<T>(IEnumerable<T> sc)
		{
			
			return Op( sc.ToArray());

			
		}

	}
}
