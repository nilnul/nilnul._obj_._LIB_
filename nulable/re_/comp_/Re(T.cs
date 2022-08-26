using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.comp
{
	
	public  class Re<TNulabe>
		:IEqualityComparer<TNulabe>
	{

		private IComparer<TNulabe> _ordNulable;

		public IComparer<TNulabe> ordNulable
		{
			get { return _ordNulable; }
			set { _ordNulable = value; }
		}

		public Re(IComparer<TNulabe> ordNulable)
		{
			_ordNulable = ordNulable;
			
		}

		public bool le(TNulabe x, TNulabe y) {
			return _ordNulable.Compare(x, y)<=0;
		}

		public bool ge(TNulabe x, TNulabe y) {
			return le(y, x);

		}

		public bool ne(TNulabe x, TNulabe y) {
			return _ordNulable.Compare(x,y) !=0;

		}

		public bool lt(TNulabe x, TNulabe y) {
			return _ordNulable.Compare(x,y)<0;

		}

		public bool gt(TNulabe x, TNulabe y) {
			return _ordNulable.Compare(x,y)>0;

		}
	
		public bool eq(TNulabe x, TNulabe y)
		{
			return _ordNulable.Compare(x, y) == 0;

		}

		public bool Equals(TNulabe x, TNulabe y)
		{
			return eq(x, y);

		}


		public int GetHashCode(TNulabe obj)
		{
			return 0;
			//throw new NotImplementedException();
		}
	}

	
}
