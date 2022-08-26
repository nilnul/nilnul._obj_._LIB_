using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.collection_._choice_
{
	public interface ChoiceI<T>
	{
		T choice { get; }
	}
}
