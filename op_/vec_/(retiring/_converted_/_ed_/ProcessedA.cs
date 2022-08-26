using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.obj.op._ed_
{
	public abstract class ProcessedA<T>
		: ProcessedI<T>
	{
		public ProcessedA(T processed)
		{
			_processed = processed;
		}
		private T _processed;
		public   T processed
		{
			get { return _processed; }
		}

		public override string ToString()
		{
			return _processed.ToString();
		}
	}
}
