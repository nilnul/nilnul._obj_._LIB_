using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Var7 = nilnul.obj.VarI_blank1;

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

	public partial class NamingContext3
	{

		static public NamingContext3 StaticContext = new NamingContext3();




		static public void Name(obj.VarI_blank1 var, string name)
		{
			StaticContext.name(var, name);
		}

		static public string Name(Var7 var)
		{
			return StaticContext.name(var);
		}

		private int _next;

		public int next
		{
			get { return _next; }
			set { _next = value; }
		}

		private string _reservedPrefix="_";

		public string reservedPrefix
		{
			get { return _reservedPrefix; }
			set { _reservedPrefix = value; }
		}


		private Dictionary<Var7, string> _names = new Dictionary<Var7, string>();

		public Dictionary<Var7, string> names
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

		

		public bool containName(string name) {
			return _names.Values.Contains(name);
		}


		public void name(Var7 var, string name)
		{
			//nilnul.NotNullX.AssertIsNotNull(var);
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
			if (names.Count() != _names.Count())
			{
				throw new Exception("there are conflicting names.");

			}

		}


	




		public string name(Var7 var)
		{
			if (!_names.ContainsKey(var))
			{

				name(var, $"{reservedPrefix}{next}");
				next++;
			}
			return _names[var];
		}


		



	}
	static public class NamingContextX3
	{
		static public string ToTxt(this Var7 var) {

			return NamingContext3.StaticContext.name(var);

		}

	}
}
