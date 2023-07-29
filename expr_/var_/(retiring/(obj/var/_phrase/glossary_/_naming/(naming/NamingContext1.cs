using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// can dynamically assign a[0] a[1] to variables.
	/// can assign to dynamical list of vars.
	/// </remarks>
	/// 
	[Obsolete(".set")]

	public partial class NamingContext1
	{

		static public NamingContext1 StaticContext = new NamingContext1();

		static public Var3<T> CreateVar<T>(string name) {

			return StaticContext.create<T>(name);
		
			
		}


		static public void Name(obj.VarI1 var, string name) {
			StaticContext.set(var, name);
		}


		private Dictionary<VarI1, string> _names = new Dictionary<VarI1, string>();

		public Dictionary<VarI1, string> names
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

		public Var3<T> create<T>(string name) {

			var x = new Var3<T>();
			set(x, name);
			return x;
			
		}
		public void set(nilnul.obj.VarI1 var, string name)
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







		public string getName(VarI1 var) {

			return _names.ContainsKey(var)? _names[var]:null;
		
		}
	


	}
}
