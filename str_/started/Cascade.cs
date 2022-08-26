using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.started
{
	public interface CascadeI<T>:_cascade_.OfStartedI<T>
	{
		//T cascade(nilnul.objs_.Started3<T> started);
	}

	static public  class _CascadeX
	{
		static public T Cascade<T>(this CascadeI<T> cascade,  IEnumerable<T> seq)
		{
			return cascade.cascade(new Started3<T>(seq));
		}
		static public T Cascade<T> (this CascadeI<T> cascade, params T[] seq)
		{
			return Cascade(cascade,(IEnumerable<T>)seq);
		}
	}

	public abstract class CascadeA<T>
		: CascadeI<T>, _cascade_.OfParamsI<T>
		,
		_cascade_.OfSeqI<T>
	{
		public abstract T cascade(Started3<T> started);
		public T cascade(IEnumerable<T> seq)
		{
			return _CascadeX.Cascade(this,seq);
		}
		public T cascade(params T[] seq)
		{
			return _CascadeX.Cascade(this,seq);
		}
	}
}
