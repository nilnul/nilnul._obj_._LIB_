using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.str_.seq.phrase_
{

	/// <summary>
	/// extends some methods related to Vector. For one-dimensional array can be regarded as vector, we extend some vector methods to one-dimensional arrays.
	/// Of course we can box one-dimensional array as vector then compute and then unbox.
	/// </summary>
	static public  class _JoinX
	{

		static public string Phrase<T>(this IEnumerable<T> vector, string seperator=",")
		{

			return string.Join(seperator, vector);



		}

	

	







	}



}
