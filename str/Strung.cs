using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{

	public interface IStrung<T>:IStrung, IStr<IStr<T>>
	{
	}

	public interface StrungI<T>:IEnumerable<IEnumerable<T>>,IStrung<T> { }
}
