using System.Collections.Generic;

namespace nilnul.obj.matrix_.square.cels_
{
	static public class _DiagonalX
	{
		static IEnumerable<T> _Diagonal_0square<T>(T[,] square) {
			for (int i = 0; i < square.GetLength(0); i++)
			{
				yield return square[i, i];
			}
		}
	}



}
