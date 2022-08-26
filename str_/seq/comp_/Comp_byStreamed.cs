using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq
{
	/// <summary>
	/// if the element is class, nul can be appended; thus, we can use nulable comparer which can either make nul bigger (hence appear last), or nul smaller (hence appear first).
	/// if the element is struct, only default is appended. and the above method won't work. But we can use Nullable{struct}
	/// </summary>
	 interface IComp_byStreamed
		:IComp
		,
		nilnul._obj.typ.calc_.unary_.IAlias<str_.seq.IComp>
	{

	}


	
}
