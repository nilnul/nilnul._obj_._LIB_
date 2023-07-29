using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._border_
{
	public interface OpenCloseI
	{
		bool openFalseCloseTrue { get; }
	}

	public abstract class OpenCloseA : OpenCloseI
	{
		bool _openFalseCloseTrue;
		public bool openFalseCloseTrue
		{
			get
			{
				return _openFalseCloseTrue;
				throw new NotImplementedException();
			}
		}

		public bool beOpen { get { return !openFalseCloseTrue; } }
		public bool beClose { get { return openFalseCloseTrue; } }

		public OpenCloseA(bool openFalseCloseTrue)
		{
			_openFalseCloseTrue = openFalseCloseTrue;

		}




	}

	


	
}
