using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op
{
	public abstract class NameA
		:NameI
	{
		private string _name;
	

		public NameA(string name)
		{
			_name = name;


		}
		public NameA()
		{
			//_name = "";
		}
		public string name
		{
			get {
				return _name;
				
				throw new NotImplementedException(); }

			set {
				_name = value;
			}
		}

		public override string ToString()
		{
			if (string.IsNullOrWhiteSpace(_name))
			{
				return base.ToString();
				
			}
			return _name;
		}
	}
}
