namespace CommandAPI.Dtos
{
	public class CommandReadDto //use this DTO when we perform any read operation
	{
		public int Id { get; set; }

		public string HowTo { get; set; }

		public string Platform { get; set; }

		public string CommandLine { get; set; }
	}
}