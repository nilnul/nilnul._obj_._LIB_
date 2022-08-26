using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.comp_
{
	/// <summary>
	/// if the element is struct, only default is appended. and the above method won't work. But we can use Nullable{struct}
	/// </summary>
	public class OvStruct<TEl>
	   :
		nilnul.obj.Box1<
			IComparer<TEl>
		>
		,
		seq.CompI<TEl>
	   where TEl : struct
	{
		public OvStruct(IComparer<TEl> val) : base(val)
		{
		}

		/// <summary>
		/// this is infact equivalent to <seealso cref="nameof(seq.Comparer<typeparamref name="TEl"/>)"/>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int _Compare_assumeStreams(IEnumerator<TEl?> x, IEnumerator<TEl?> y)
		{
			while (! (x.Current is null ))
			{
				if (y.Current is null)
				{
					return 1;
				}
				var compared = boxed.Compare(
					x.Current.Value
					,
					y.Current.Value
				);
				if (compared!=0)
				{
					return compared;
				}
			}
			if (y.Current is null)
			{
				return 0;
			}
			return -1;
			
		}

		public int _Compare_assumeStreams(IEnumerable<TEl?> x, IEnumerable<TEl?> y)
		{

			return _Compare_assumeStreams(x.GetEnumerator(),y.GetEnumerator());
		}

		public int Compare(IEnumerable<TEl> x, IEnumerable<TEl> y)
		{

			return _Compare_assumeStreams(
				stream.of_.seq_._AppendX.Seq_ovStruct(x)
				,
				stream.of_.seq_._AppendX.Seq_ovStruct(y)
			);

			//throw new NotImplementedException();
		}

	}



}
