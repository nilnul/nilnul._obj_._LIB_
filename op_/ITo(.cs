using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{

	[Obsolete("use " + nameof(IOp<TTgt>) + " instead;")]
	public interface ITo< out TTgt> :ITo { }

	[Obsolete("use " + nameof(IOp<TTgt>) + " instead;")]
	public interface ITo< out TTgt, in TSrc> :ITo<TTgt> { }





}
