using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.op_
{
	public interface BinaryI<T, TE>
		:nilnul.obj.op_._binary_.ClosedI<T>
		,
		_binary_.BlankI
		where T: nilnul.obj.BeI1<TE>
	{
	}

	public interface BinaryI< TE>
		:BinaryI<nilnul.obj.BeI1<TE>, TE>
	{
	}

}
