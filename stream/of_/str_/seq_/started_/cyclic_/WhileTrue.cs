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

namespace nilnul.obj.stream.of_.str_.seq_.started_.cyclic_
{

	static public class _WhileTrue
	{
		public static IEnumerable<TEl> Seq_assumeStarted<TEl>(
			IEnumerable<TEl> seq
		)
		{
			/// lest the lazy expr is evaluated each time. without this, the expr is evaluated multiple times inside the while, at the "for each"
			/// the seq must be finite here. <see cref="nameof(of_.seq_.started_.cyclic_._WhileTrue)"/> cannot use the "ToList" as the seq might be infinite.
			var list = seq.ToList(); 
			while (true)	///when the seq is done looped, we start over.
			{
				foreach (var item in list)
				{
					yield return item;
				}
			}

		}
	}
}
