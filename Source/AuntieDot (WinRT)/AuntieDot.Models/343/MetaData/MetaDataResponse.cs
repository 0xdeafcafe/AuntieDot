namespace AuntieDot.Models._343.MetaData
{
	public abstract class MetaDataResponse : XResponse
	{
		public AchievementMetadata AchievementsMetadata { get; set; }
		public ArmorGroupMetadata ArmorGroupMetadata { get; set; }
		public CommendationsMetadata CommendationsMetadata { get; set; }
		public DamageMetadata DamageMetadata { get; set; }
		public DifficultiesMetadata DifficultiesMetadata { get; set; }
		public EnemiesMetadata EnemiesMetadata { get; set; }
		public EmblemsMetadata EmblemsMetadata { get; set; }
		public FactionsMetadata FactionsMetadata { get; set; }
		public GameModesMetadata GameModesMetadata { get; set; }
		public GameBaseVariantsMetadata GameBaseVariantsMetadata { get; set; }
		public MapsMetadata MapsMetadata { get; set; }
		public MedalsMetadata MedalsMetadata { get; set; }
		public NarrativeFlagsMetadata NarrativeFlagsMetadata { get; set; }
		public PlayerUpgradesMetadata PlayerUpgradesMetadata { get; set; }
		public PlaylistsMetadata PlaylistsMetadata { get; set; }
		public PosesMetadata PosesMetadata { get; set; }
		public PromotionTypesMetadata PromotionTypesMetadata { get; set; }
		public RanksMetadata RanksMetadata { get; set; }
		public SkullsMetadata SkullsMetadata { get; set; }
		public SpartanOpsMetadata SpartanOpsMetadata { get; set; }
		public SpecializationsMetadata SpecializationsMetadata { get; set; }
		public TeamAppearancesMetadata TeamAppearancesMetadata { get; set; }
	}
}
