using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintManagementSystem_Galkin.classes
{
	public class TypeOpertation
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public TypeOpertation(int _id, string _name, string _description)
		{
			this.id = _id;
			this.name = _name;
			this.description = _description;
		}

		public static List<TypeOpertation> AllTypeOperation()
		{
			List<TypeOpertation> alltypeOpertations = new List<TypeOpertation>();

			alltypeOpertations.Add(new TypeOpertation(1, "Печать", ""));
			alltypeOpertations.Add(new TypeOpertation(2, "Копия", ""));
			alltypeOpertations.Add(new TypeOpertation(3, "Сканирование", ""));
			alltypeOpertations.Add(new TypeOpertation(4, "Ризограф", ""));
			return alltypeOpertations;
		}
	}
}
