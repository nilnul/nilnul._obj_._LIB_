﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TElement"></typeparam>
	///
	[Obsolete(
		//nameof(Comp)
		"to avoid collision iwth built in type"
	)] 
	public class Comparer<TElement>
		: ComparerI<TElement>, ComparerOfEnumerableI<TElement>
	{
		private IComparer<TElement> _elementComparer;

		public IComparer<TElement> elementComparer
		{
			get { return _elementComparer; }
			set { _elementComparer = value; }
		}

		public Comparer(IComparer<TElement> elementComparer)
		{
			_elementComparer = elementComparer;

		}

		/// <summary>
		/// the longer, the bigger.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int Compare(IEnumerable<TElement> x, IEnumerable<TElement> y)
		{

			if (x.Any())
			{
				if (y.Any())
				{
					var headCompared = _elementComparer.Compare(
						x.First(), y.First()
					);

					if (headCompared == 0)
					{
						return Compare(x.Skip(1), y.Skip(1));
					}
					return headCompared;

 				}
				return 1;
			}
			
			 if (y.Any())
			{
				return -1;

			}
			return 0;



		 

			//throw new NotImplementedException();
		}

		public int Compare(StrI<TElement> x, StrI<TElement> y)
		{

			if (x is str_.SansI)
			{
				if (y is str_.SansI)
				{
					return 0;
				}
				return -1;
			}
			 if (y is str_.SansI)
			{
				return 1;

			}

			var xAsStarted = x as str_.StartedI<TElement>;
			var yAsStarted = y as str_.StartedI<TElement>;




			var headCompared = _elementComparer.Compare(
				xAsStarted.head, yAsStarted.head	
			);

			if (headCompared ==0)
			{
				return Compare( xAsStarted.tail,yAsStarted.tail);
			}
			return headCompared;
			//throw new NotImplementedException();
		}
	}
}
