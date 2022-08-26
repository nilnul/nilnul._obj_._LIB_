using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	[Obsolete()]
	public interface SeqI2<TEle>:
		IEnumerable<TEle>
		,
		obj.StrI2<TEle>
	{
	}

	[Obsolete()]
	public class Seq2<TEle> : nilnul.obj.seq_.GetEnumeratorA<TEle>
		//, nilnul.obj.StrI2<TEle>
		, SeqI2<TEle>
	{
		private IEnumerable<TEle> _boxed;

		public IEnumerable<TEle> boxed
		{
			get { return _boxed; }
			set { _boxed = value; }
		}

		public Seq2(IEnumerable<TEle> boxed)
		{
			_boxed = boxed;
		}
		public override IEnumerator<TEle> GetEnumerator()
		{
			return _boxed.GetEnumerator();
			//throw new NotImplementedException();
		}

		public Sans0StartedI<TEle> toSans0Started()
		{
			if (boxed.Any())
			{
				return new sans0Started_.Started<TEle>(
					boxed.First()
					,
					new Seq2<TEle>(nilnul.obj.seq_.headed._TailX._Tail(boxed)).toSans0Started()
				);
			}
			return sans0Started_.Sans<TEle>.Singleton; ;
		}

		//static public implicit operator IEnumerable<TEle>(Seq1 seq) {
		//	return seq;
		//}

		
	}

	static public class SeqX {

		/// <summary>
		/// to a string of Objects; here the str is not meaning txt. see toTxt() for phrasing.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="x"></param>
		/// <returns></returns>
		static public Seq2<T> ToStr<T>(this IEnumerable<T> x) {
			return new Seq2<T>(x);
		}

		static public void Each<T>(this IEnumerable<T> x, Action<T> action)
		{
			foreach (var item in x)
			{
				action(item);
			}
		}

		static public void Each<T>(this IEnumerable<T> x, Action<T,int> action)
		{
			x.Select((c, i) => (c, i)).Each(
				tuple=> action(tuple.c,tuple.i)
			);
			//int i = 0;
			//var enumerator = x.GetEnumerator();
			//while (enumerator.MoveNext())
			//{
			//	action(enumerator.Current, i++);
			//}

			//foreach (var item in x)
			//{
			//	action(item, i++);
			//}
		}


		/// <summary>
		/// make this greedy rather than lazy
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="x"></param>
		static public void Each<T>(this IEnumerable<T> x)
		{
			foreach (var item in x)
			{
			}
		}



	}

	static public class SeqIX {
		static public SeqI2<TEle> Coerce<TEle>(nilnul.obj.StrI2<TEle> str)
		{
			if (str is nilnul.obj.str_.SeqI2<TEle> seq)
			{
				return seq;
			}
			return new seq_.OfStr<TEle>(str);
		}


	}



}
