using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict_
{
	/// <summary>
	/// yes or no
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// alias:
	///		Ballot (b  all o t == bit of all)
	/// </remarks>
	public class Poll<T>:Dictionary<T,bool>
	{

		public Poll(IEqualityComparer<T> eq):base(eq)
		{

		}

		public Poll():this(EqualityComparer<T>.Default)
		{
				
		}

		public Poll(IDictionary<T,bool> dict, IEqualityComparer<T> eq) :base(dict,eq)
		{

		}
		public Poll(IDictionary<T,bool> dict ) :this(dict, EqualityComparer < T >.Default)
		{

		}


	}
}
