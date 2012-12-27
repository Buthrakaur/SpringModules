using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleModule.Nh.Domain
{
	public class Person
	{
		public virtual long Id { get; private set; }
		public virtual string Name { get; set; }

		private Person()
		{
		}

		public Person(string name)
		{
			Name = name;
		}
	}
}