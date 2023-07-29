using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_._vec_
{

/// <summary>
/// 
/// </summary>
/// <remarks>
/// for the retTyp varies with input type, it's not often used. So we omit it; if it were defined, it shall be the super type of this;
/// </remarks>
/// <typeparam name="T"></typeparam>
	public interface OpI<T>
	{
		T op( IEnumerable<T> vec);
	}

}
