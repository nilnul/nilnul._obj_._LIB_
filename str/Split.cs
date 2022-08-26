using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	/// <summary>
	/// split a str into several; last part might be less.
	/// </summary>
	public interface ISplit
	{
	}
	/// <summary>
	/// last part can be less
	/// </summary>
	static public class _SplitX
	{
		static public IEnumerable<List<T>> _Split_partAssumePositive<T>(this IEnumerator<T> enumerator, int _partLengthAssumePositive)
		{

			var part = new List<T>();

			for (int i = 0; ; i++)
			{
				if (enumerator.MoveNext())
				{
					part.Add(enumerator.Current);

					if (++i == _partLengthAssumePositive)
					{
						yield return part;
						i = 0;
						part = new List<T>();
					}

				}
				else
				{
					break;
				}
			}
			if (part.Any())
			{
				yield return part;
			}

		}

		static public IEnumerable<List<T>> _Split_partAssumePositive<T>(this IEnumerable<T> str, int _partLengthAssumePositive) {
			return _Split_partAssumePositive(str.GetEnumerator(), _partLengthAssumePositive);
		}


	


	}
}
