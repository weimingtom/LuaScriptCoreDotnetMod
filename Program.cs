using System;
using cn.vimfung.luascriptcore;
using System.Diagnostics;

namespace luascriptcore
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			LuaContext.currentContext.onException((errMessage) => {
				Debug.WriteLine(errMessage);
            });			
			LuaValue retValue = LuaContext.currentContext.evalScript ("print(10);return 'Hello World abc';");
			Debug.WriteLine (string.Format("{0}", retValue.toString()));
            Console.WriteLine("return value: " + retValue.toString());

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}