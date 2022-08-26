using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpI = nilnul.obj.OpI;


namespace nilnul.obj.op
{
	public partial class Priority 
	{

		static public Priority StaticInstance = new Priority();

		private List<Tuple<nilnul.obj.OpI,nilnul.obj.OpI>> _kernel=new List<Tuple<nilnul.obj.OpI, nilnul.obj.OpI>>();

		public List<Tuple<nilnul.obj.OpI,nilnul.obj.OpI>> kernel
		{
			get { return _kernel; }
			set { _kernel = value; }
		}




		public bool Le(nilnul.obj.OpI x, nilnul.obj.OpI y) {
			return _kernel.Contains(new Tuple<nilnul.obj.OpI, nilnul.obj.OpI>(x, y));

		}

		public bool Eq(nilnul.obj.OpI x, nilnul.obj.OpI y) {
			

			return Le(x,y) && Le( y,x);

		}
		public bool Ne(nilnul.obj.OpI x, nilnul.obj.OpI y) {


			return !Eq(x, y);

		}

		public bool Lt(nilnul.obj.OpI x, nilnul.obj.OpI y) {
			return Le(x, y) && Ne(x, y);
		}






	}
}
