using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.enumable
{
	[Obsolete()]
	public class Eq<TEle> :
		nilnul.obj._eq_.HashCodeA<IEnumerable<TEle>>
		,

		IEqualityComparer<IEnumerable<TEle>>
		,
		IEqualityComparer<IEnumerator<TEle>>
	{
		private IEqualityComparer<TEle> _elEq;

		public IEqualityComparer<TEle> elEq
		{
			get { return _elEq; }
			set { _elEq = value; }
		}


		public Eq(IEqualityComparer<TEle> elEq)
		{
			_elEq = elEq;
		}
		public override bool Equals(IEnumerable<TEle> x, IEnumerable<TEle> y)
		{
			return x.SequenceEqual(y, _elEq);
			//return Equals(x.GetEnumerator(), y.GetEnumerator());
			//throw new NotImplementedException();
		}

		/// <summary>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public bool Equals(IEnumerator<TEle> x, IEnumerator<TEle> y)
		{
			
			var xAny = x.MoveNext();
			var yAny = y.MoveNext();


			while (xAny == yAny)
			{
				if (xAny)
				{
					if (!elEq.Equals(x.Current, y.Current))
					{
						return false;
					}
				}
				else
				{
					return true;
				}
				xAny = x.MoveNext();
				yAny = y.MoveNext();

			}
			return false;

			;


		}

		public int GetHashCode(IEnumerator<TEle> obj)
		{
			return 0;
			throw new NotImplementedException();
		}
	}
}
