using System.Collections.Generic;

namespace AuntieDot.Models._343.MetaData
{
	#region Achievements
	public abstract class AchievementMetadata
	{
		public IList<Achiecement> Achievements { get; set; } 
	}
	public abstract class Achiecement
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LockedDescription { get; set; }
		public string UnlockedDescription { get; set; }
		public int GamerPoints { get; set; }
		public Common.ImageUrl LockedImageUrl { get; set; }
		public Common.ImageUrl UnlockedImageUrl { get; set; }
	}
	#endregion

	#region Armour Group
	public abstract class ArmorGroupMetadata
	{
		public IList<ArmorGroup> ArmourGroups { get; set; } 
	}
	public abstract class ArmorGroup
	{
		public int Id { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
		public IList<ArmorItem> ArmourItems { get; set; } 
	}
	public abstract class ArmorItem
	{
		public int Id { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	#endregion

	#region Challenges
	public abstract class ChallengesMetadata
	{
		public IList<ChallengeCategory> ChallengeCategories { get; set; } 
		public IList<ChallengePeriod> ChallengePeriods { get; set; } 
	}
	public abstract class ChallengeCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	public abstract class ChallengePeriod
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Namely { get; set; }
	}
	#endregion

	#region Commendations
	public abstract class CommendationsMetadata
	{
		public IList<Commendation> Commendations { get; set; }
		public IList<CommendationCategory> CommendationCategories { get; set; }
		public IList<CommendationLevel> CommendationLevels { get; set; }
	}
	public abstract class Commendation
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
	public abstract class CommendationCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
	public abstract class CommendationLevel
	{
		public int CommendationId { get; set; }
		public int Level { get; set; }
		public int Ticks { get; set; }
		public int Xp { get; set; }
		public string Name { get; set; }
	}
	#endregion

	#region Damage
	public abstract class DamageMetadata
	{
		public IList<DamageClass> DamageClasses { get; set; }
		public IList<WeaponType> WeaponTypes { get; set; }
		public IList<DamageType> DamageTypes { get; set; }
	}
	public abstract class DamageClass
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
	public abstract class WeaponType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	public abstract class DamageType
	{
		public int Id { get; set; }
		public int ClassId { get; set; }
		public int WeaponClassId { get; set; }
		public int FactionId { get; set; }
		public int Range { get; set; }
		public int Power { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	#endregion

	#region Difficulty
	public abstract class DifficultiesMetadata
	{
		public IList<Difficulty> Difficulties { get; set; }
	}
	public abstract class Difficulty
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	#endregion

	#region Enemies
	public abstract class EnemiesMetadata
	{
		public IList<EnemyClass> EnemyClasses { get; set; }
		public IList<EnemyType> EnemyTypes { get; set; }
		public IList<Enemy> Enemies { get; set; }
	}
	public abstract class EnemyClass
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
	public abstract class EnemyType
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
	public abstract class Enemy
	{
		public int Id { get; set; }
		public int ClassId { get; set; }
		public int TypeId { get; set; }
		public int FactionId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	#endregion

	#region Emblems
	public abstract class EmblemsMetadata
	{
		public IList<EmblemColor> EmblemColors { get; set; }
		public IList<EmblemForegroundShape> EmblemForegroundShapes { get; set; }
		public IList<EmblemBackgroundShape> EmblemBackgroundShapes { get; set; }
	}
	public abstract class EmblemColor
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string ColorARGB { get; set; }
	}
	public abstract class EmblemForegroundShape
	{
		public string Id { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
	}
	public abstract class EmblemBackgroundShape
	{
		public string Id { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
	}
	#endregion

	#region Factions
	public abstract class FactionsMetadata
	{
		public IList<Faction> Factions { get; set; }
	}
	public abstract class Faction
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	#endregion

	#region GameModes
	public abstract class GameModesMetadata
	{
		public IList<GameMode> GameModes { get; set; }
	}
	public abstract class GameMode
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ArticleId { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	#endregion

	#region Game Base Varients
	public abstract class GameBaseVariantsMetadata
	{
		public IList<GameBaseVariant> GameBaseVariants { get; set; }
	}
	public abstract class GameBaseVariant
	{
		public int Id { get; set; }
		public bool KDRelevant { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string FeaturedStatName { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	#endregion

	#region Maps
	public abstract class MapsMetadata
	{
		public IList<Map> Maps { get; set; }
	}
	public abstract class Map
	{
		public int Id { get; set; }
		public int GameModeId { get; set; }
		public string ArticleId { get; set; }
		public int Order { get; set; }
		public int? Mission { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	#endregion

	#region Medals
	public abstract class MedalsMetadata
	{
		public IList<Medal> Medals { get; set; }
		public IList<MedalClass> MedalClasses { get; set; }
		public IList<MedalTier> MedalTiers { get; set; }
	}
	public abstract class Medal
	{
		public int Id { get; set; }
		public int TierId { get; set; }
		public int ClassId { get; set; }
		public int GameBaseVariantId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}

	public abstract class MedalClass
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public abstract class MedalTier
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
	#endregion

	#region NarrativeFlags
	public abstract class NarrativeFlagsMetadata
	{
		public IList<NarrativeFlag> NarrativeFlags { get; set; }
	}
	public abstract class NarrativeFlag
	{
		public int Id { get; set; }
		public string ArticleId { get; set; }
		public string Name { get; set; }
	}
	#endregion

	#region Player Upgrades
	public abstract class PlayerUpgradesMetadata
	{
		public IList<ArmorAbility> ArmorAbilities { get; set; }
		public IList<SupportUpgrade> SupportUpgrades { get; set; }
		public IList<TacticalPackage> TacticalPackages { get; set; }
	}
	public abstract class ArmorAbility
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	public abstract class SupportUpgrade
	{
		public int Id { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	public abstract class TacticalPackage
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}

	#endregion

	#region Playlists
	public abstract class PlaylistsMetadata
	{
		public IList<Playlist> Playlists { get; set; }
	}
	public abstract class Playlist
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
		public int ModeId { get; set; }
		public string ModeName { get; set; }
		public int MaxPartySize { get; set; }
		public int MaxLocalPlayers { get; set; }
		public bool IsFreeForAll { get; set; }
		public IList<Common.GameVariant> RelatedGameVariants { get; set; }
		public IList<Common.MapVariant> RelatedMapVariants { get; set; }
		public string EffectiveOn { get; set; }
		public string EffectiveUntil { get; set; }
	}
	#endregion

	#region Poses
	public abstract class PosesMetadata
	{
		public IList<Poses> Poses { get; set; }
	}
	public abstract class Poses
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	#endregion

	#region PromotionTypes
	public abstract class PromotionTypesMetadata
	{
		public IList<PromotionType> PromotionTypes { get; set; }
	}
	public abstract class PromotionType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
	#endregion

	#region Ranks
	public abstract class RanksMetadata
	{
		public IList<Rank> Ranks { get; set; }
	}
	public abstract class Rank
	{
		public int Id { get; set; }
		public int Credits { get; set; }
		public int CompletedSpecializations { get; set; }
		public int StartXp { get; set; }
		public int EndXp { get; set; }
		public string Name { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	#endregion

	#region RankAwards
	public abstract class RankAwardsMetadata
	{
		public IList<RankAward> RankAwards { get; set; }
	}
	public abstract class RankAward
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
		public int SpecializationId { get; set; }
		public int SpecializationLevel { get; set; }
	}
	#endregion

	#region Skulls
	public abstract class SkullsMetadata
	{
		public IList<Skull> Skulls { get; set; }
	}
	public abstract class Skull
	{
		public int Id { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	#endregion

	#region SpartanOps
	public abstract class SpartanOpsMetadata
	{
		public int SeasonsReleasedToDate { get; set; }
		public int ChaptersCurrentlyAvailable { get; set; }
		public int BumperType { get; set; }
		public int CurrentSeason { get; set; }
		public int CurrentEpisode { get; set; }
		public IList<Season> Seasons { get; set; }
	}
	public abstract class Episode
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public IList<Video> Videos { get; set; }
		public IList<Chapter> Chapters { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	public abstract class Season
	{
		public int Id { get; set; }
		public IList<Episode> Episodes { get; set; }
		public object Epilogue { get; set; }
	}
	public abstract class Chapter
	{
		public int Id { get; set; }
		public int Number { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}
	public abstract class Video
	{
		public Language Language { get; set; }
		public string Folder { get; set; }
		public string WebFileName { get; set; }
		public string ConsoleFileName { get; set; }
		public string MobileFileName { get; set; }
		public string IosFileName { get; set; }
		public string IosSuffix { get; set; }
		public string Mp4FileName { get; set; }
		public string Mp4Suffix { get; set; }
	}
	public abstract class Language
	{
		public string CultureName { get; set; }
	}
	#endregion

	#region  Specializations
	public abstract class SpecializationsMetadata
	{
		public IList<Specialization> Specializations { get; set; }
		public IList<SpecializationLevel> SpecializationLevels { get; set; }
	}
	public abstract class Specialization
	{
		public int Id { get; set; }
		public int MaxSpecializationXP { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Common.ImageUrl ImageUrl { get; set; }
	}

	public abstract class SpecializationLevel
	{
		public int Id { get; set; }
		public int SpecializationId { get; set; }
		public int Level { get; set; }
		public int StartXp { get; set; }
		public string Name { get; set; }
	}
	#endregion

	#region Team Appearances
	public abstract class TeamAppearancesMetadata
	{
		public IList<TeamAppearanceSetting> TeamAppearanceSettings { get; set; }
	}
	public abstract class TeamAppearanceSetting
	{
		public int Id { get; set; }
		public int PrimaryRGBA { get; set; }
		public string PrimaryRGB { get; set; }
		public int SecondaryRGBA { get; set; }
		public string SecondaryRGB { get; set; }
		public string Name { get; set; }
		public string ForegroundShapeId { get; set; }
		public string ForegroundPrimaryColor { get; set; }
		public string ForegroundSecondaryColor { get; set; }
		public string BackgroundShapeId { get; set; }
		public string BackgroundColorId { get; set; }
		public Common.ImageUrl EmblemUrl { get; set; }
	}
	#endregion
}
