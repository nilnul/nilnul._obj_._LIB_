using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	[Obsolete(nameof(nilnul.IObjs) + " is defined as unstructured objects, allowing us to circumvent the confusion between objs and obj.str. Hence it's not a subtype of "+nameof(IObjs) + "; rather "+nameof(obj.IStr) + " is a subtype of "+ nameof(nilnul.IObjs) + ".")]
	class IObjs
	{
	}
}
