using System.Collections.Generic;

namespace nilnul.obj.matrix_.square.cels_
{
	static public class _SupdiagonalX
	{
		static IEnumerable<T> _Supdiagonal_0square<T>(T[,] square) {
			for (int i = 0; i < square.GetLength(0)-1; i++)
			{
				yield return square[i, i + 1];
			}
		}
	}



}
