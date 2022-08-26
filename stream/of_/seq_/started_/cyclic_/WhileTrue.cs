using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.str.to;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.str_.started_;

namespace nilnul.obj.stream.of_.seq_.started_.cyclic_
{

	static public class _WhileTrue
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="TEl"></typeparam>
		/// <param name="seq"></param>
		/// <returns></returns>
		public static IEnumerable<TEl> Seq_assumeStarted<TEl>(
			IEnumerable<TEl> seq
		)
		{
			///var list = seq.ToList(); //this cannot be used, as the seq might be infinite <see cref="nameof(str_.seq_.started_.cyclic_._WhileTrue)"/>
			while (true)	///when the seq is done looped, we start over.
			{
				foreach (var item in seq)
				{
					yield return item;
				}
			}

		}
	}
}
