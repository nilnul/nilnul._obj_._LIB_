using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started
{
	public interface CascadeI<T>:_cascade_.OfHeadedI<T>
	{
		//T cascade(nilnul.objs_.Started3<T> started);
	}

	static public  class _CascadeX
	{
		static public T _Cascade_0started<T>(this CascadeI<T> cascade,  IEnumerator<T> seq)
		{
			seq.MoveNext();

			return cascade.cascade(seq.Current,seq);
		}
		static public T _Cascade_0started<T>(this CascadeI<T> cascade,  IEnumerable<T> seq)
		{
			return _Cascade_0started(cascade,seq.GetEnumerator());
		}

		static public T _Cascade_0started<T> (this CascadeI<T> cascade, params T[] seq)
		{
			return _Cascade_0started(cascade,(IEnumerable<T>)seq);
		}
	}

	public abstract class CascadeA<T>
		: CascadeI<T>, _cascade_._AssumeStartedI<T>
		,
		_cascade_.assumeStarted_._OfParamsI<T>
		
	{
		public abstract T cascade(T started, IEnumerator<T> seq);
	
	

		public T _cascade_0started(IEnumerable<T> started)
		{
			return _CascadeX._Cascade_0started(this,started);
		}

		public T _cascade_0started(IEnumerator<T> started)
		{
			return _CascadeX._Cascade_0started(this,started);
		}

		public T _cascade_0started(params T[] started)
		{
			return _CascadeX._Cascade_0started(this,started);

		}
	}
}
