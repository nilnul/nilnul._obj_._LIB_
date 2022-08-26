using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj._typ._ns.seg_
{
	/// <summary>
	///  <see cref="obj._id._nom.term.circa_.IPrefixed"/> and <see cref="obj._id._nom.term.circa_.INone"/> is defined first. <see cref="obj._id._nom.term.circa_.IPre0no"/> is defined later.
	///  there is no need to create ns: pre0no_, and move the first two types there.
	///  In general, if the subtypes are directly under and form a full cover for all cases of the parent type's partition, there is no need to move that to a further subSeg. Instead, we can let the prior types at the same level to inherit each other. That incurs less break changes; and that's clearer as the types might come from different taxonomy and they shall be peer2peer, not hierOnHier.
	///	</summary>
	class ICirca
		:
		nilnul.obj._id._nom.term.ICirca
	{
	}
}
