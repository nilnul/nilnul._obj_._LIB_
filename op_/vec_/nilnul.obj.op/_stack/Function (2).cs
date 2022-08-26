using System;

namespace nilnul.relation
{


    /// <summary>
    /// Input n(n=0,1,2,...) objects
    /// Output 1 objects. Sometimes output no objects;this is a special case and we can regard it as out a special object named void.
    /// Function has a method call, which return the result.
    /// </summary>
	public class Function:Element
	{
        private uint? _parametersCount;
        public Function() {
            this._parametersCount = null;
        }
        public object call(params object[] parameters) {
            return null;
        }
        public uint parametersCount {
            get {
                return _parametersCount;
            }
        }
        
		
			
		
	}
	

}
