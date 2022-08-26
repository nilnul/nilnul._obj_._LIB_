using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.be_.distinct.vow
{
	public class Ee<T, TStr> 
		: 
		nilnul.obj.str_.seq.vow.Ee <T, TStr>

		where TStr : nilnul.obj.str_.SeqI2<T> //, nilnul.obj._str_.ToArrI<T>
	{
		public Ee( IEqualityComparer<T> eq, TStr val)
			:
			base(
				val
				,
				new nilnul.obj.str_.seq.be_.distinct.Vow<T,TStr>(eq)
			)
		{
		}
	}

	public class Ee<T> 
		: 
		nilnul.obj.str_.seq.vow.Ee_seqGeneral <T,  Vow<T>>

	{

		public Ee( IEqualityComparer<T> eq, nilnul.obj.str_.SeqI2<T> val)
			:
			base(
				val,
				new nilnul.obj.str_.seq.be_.distinct.Vow<T>(eq)
				
			)
		{
		}
		public Ee(IEqualityComparer<T> eq, IEnumerable<T> val)
			:
			this(
				eq, new nilnul.obj.str_.Seq2<T>(val)
			)
		{

		}
	}

	










}
