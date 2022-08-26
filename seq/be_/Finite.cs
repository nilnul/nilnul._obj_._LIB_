using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.be_
{
	public interface FiniteI<T> : nilnul.obj.seq.BeI<T>
	{ }
	public class Finite<T> :
		//nilnul.obj.seq.BeI<T>
		//,
		FiniteI<T>
	{
		public bool be(IEnumerable<T> obj)
		{
			try
			{
				obj.LastOrDefault();
				return true;
			}
			catch (Exception)	//this hall be infinteRun Suspicion (an exception undetecable by computer.)
			{
				throw;
			}
			///run into infinite loop.
			return false;

		}


		static public Finite<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Finite<T>>.Instance;
			}
		}

	}
}
