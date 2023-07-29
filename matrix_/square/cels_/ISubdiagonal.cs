using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix_.square.cels_
{
	internal class ISubdiagonal
	{
	}

	static public class _SubdiagonalX
	{
		static IEnumerable<T> _Subdiagonal_0square<T>(T[,] square) {
			for (int i = 1; i < square.GetLength(0); i++)
			{
				yield return square[i, i - 1];
			}
		}
	}


}
