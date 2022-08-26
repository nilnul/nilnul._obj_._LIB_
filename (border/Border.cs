using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	[Obsolete(nameof(_border_.OpenCloseI))]
	public interface BorderI:_border_.OpenCloseI
	{
	}

	[Obsolete(nameof(_border_.OpenCloseA))]
	public abstract class BorderA :
		_border_.OpenCloseA
		,
		BorderI
	{
		
		public BorderA(bool openFalseCloseTrue):base(openFalseCloseTrue)
		{

		}


	}

	public class Border<T> : _border_.OpenCloseA, BorderI<T>
	{
		T _mark;
		public T mark
		{
			get
			{
				return _mark;
			}
		}

		public Border(bool openFalseCloseTrue, T mark)
			: base(openFalseCloseTrue)
		{
			_mark = mark;
		}

		

	}

	
}
