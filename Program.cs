using System;

namespace ObserverPattern
{
	/// <summary>
	/// The main program class.
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			// instantiate a subject
			var subject = new Subject ();

			// instantiate 3 observers
			var observer1 = new Observer ("Observer 1");
			var observer2 = new Observer ("Observer 2");
			var observer3 = new Observer ("Observer 3");

			// attach observers to subject
			subject.Notify += observer1.Update;
			subject.Notify += observer2.Update;
			subject.Notify += observer3.Update;

			// change the subject state
			subject.ChangeState ("NEW");
		}
	}
}
