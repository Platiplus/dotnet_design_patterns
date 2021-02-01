namespace Builder.Models
{
	public class Cellphone
	{
		public Cellphone(string name)
		{
			Name = name;	
		}

		public string Name { get; set; }
		public string Screen { get; set; }
		public string Battery { get; set; }
		public string OperatingSystem { get; set; }
		public string Camera { get; set; }
	}
}
