namespace AuntieDot.Models._343.Commendations
{
	public class Commendation
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public int Ticks { get; set; }
		public int LevelId { get; set; }
		public string LevelName { get; set; }
		public string LevelStartTicks { get; set; }
		public NextCommendationLevelData NextLevel { get; set; }
	}
}
