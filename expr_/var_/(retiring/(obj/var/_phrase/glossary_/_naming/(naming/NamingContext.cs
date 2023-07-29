using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	[Obsolete(".set")]
	public partial class NamingContext
	{

		static public NamingContext StaticContext = new NamingContext();



		private Dictionary<VarI, string> _names = new Dictionary<VarI, string>();

		public Dictionary<VarI, string> names
		{
			get { return _names; }
			set
			{


				_names = value;

			}
		}



		public IEnumerable<string> names2
		{
			get
			{
				return _names.Values;
			}
		}

		
		public void set(nilnul.obj.VarI var, string name)
		{
			nilnul.NotNullX.AssertIsNotNull(var);
			if (string.IsNullOrEmpty(name))
			{
				throw new Exception();
			}

			if (_names.ContainsKey(var))
			{
				_names[var] = name;

			}
			else
			{
				_names.Add(var, name);
			}
			var names = new HashSet<string>(names2);
			if (names.Count()!=_names.Count())
			{

				throw new Exception("there are conflicting names.");
				
			}

		}







		public string get(VarI var) {

			return _names[var];
		
		}
	


	}
}
