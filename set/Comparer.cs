using nilnul.obj._set_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set
{
	public interface ComparerI
	{
	}

	/// <summary>
	/// this is defined on Set, not SetI, ;cuz SetI might be infinite.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ComparerI<T> : ComparerI, IComparer<Set<T>> { }

	/// <summary>
	/// this is in fact to treat the set as a str in unspecified order; the equalityComparer of the set becomes insignificant and removed. And then order the str, and then compare the ordered str.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Comparer<T> : ComparerI<T>
	{

		private IComparer<T> _elementComparer;

		public IComparer<T> elementComparer
		{
			get { return _elementComparer; }
			set
			{

				_elementComparer = value;
				_strComparer = new nilnul.obj.str.Comparer<T>(_elementComparer);

			}
		}

		public Comparer(IComparer<T> elementComparer)
		{
			this.elementComparer = elementComparer;



		}


		private nilnul.obj.str.Comparer<T> _strComparer;

		public nilnul.obj.str.Comparer<T> strComparer
		{
			get { return _strComparer; }
		}

		public int Compare(Set<T> x, Set<T> y)
		{

			return _strComparer.Compare(

				nilnul.obj.set.to_._str._Extensions.SortUnstable(x,_elementComparer)
				,

				nilnul.obj.set.to_._str._Extensions.SortUnstable(y,_elementComparer)
				
			);

			//throw new NotImplementedException();
		}
	}

	public class Comparer<T, TComparer> : Comparer<T>
		where TComparer : IComparer<T>, new()
	{
		public Comparer( ) : base(SingletonByDefault<TComparer>.Instance)
		{
		}


		static public readonly Comparer<T,TComparer> Singleton = SingletonByDefault<Comparer<T,TComparer>>.Instance;

	}
}
