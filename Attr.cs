using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// key, val pair, used in a dictionary to describe an object. <seealso cref="nameof(nilnul.obj.ITag)"/>. a collection of attrs, if keys are distinct, is called dictionary. dictionary allows for no nul key.
	///
	/// note dictionary allows for null values; if val is null, it shall be regarded as having no corresponding issing key.
	/// </summary>
	public interface IAttr:nilnul.obj.tag_.IKeyVal
	{
	}
}
