using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq_

{
	/// <summary>
	/// never output the same element twice.
	/// for finite seq, <see cref="obj.str_.IDistinct"/>
	/// for infinite seq, <see cref="obj.stream_.IDistinct"/>
	/// </summary>
	public interface IDistinct:ISeq
	{
	}
}
